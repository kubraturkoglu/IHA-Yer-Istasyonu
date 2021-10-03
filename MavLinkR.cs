using System;
using System.ComponentModel;
using System.Windows.Forms;
using MavLink;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace MavLinkReader
{
    public partial class MavLinkReader : Form
    {
        String[] SMode = { "Stabilize", "Acrobatic", "Alt Hold ", "Auto     ", "Guided   ", "Loiter   ", "RTL      ",
"Circle   ", "Position ", "Land     ", "OF_Loiter", "Drift    ", "None     ", "Sport    ", "Flip     ",
"Auto Tune", "Pos Hold" };

        Mavlink Mv = new Mavlink();
        Msg_heartbeat Hb = new Msg_heartbeat();
        Msg_sys_status Ss = new Msg_sys_status();
        Msg_power_status Ps = new Msg_power_status();
        Msg_attitude At = new Msg_attitude();
        Msg_gps_raw_int Gps = new Msg_gps_raw_int();
        Msg_vfr_hud Vfr = new Msg_vfr_hud();
        Msg_data_stream Ds = new Msg_data_stream();
        Msg_raw_pressure Rp = new Msg_raw_pressure();
        Msg_scaled_pressure Sp = new Msg_scaled_pressure();
        Msg_command_ack Ca = new Msg_command_ack();
        Msg_statustext St = new Msg_statustext();
        Msg_mission_count Mc = new Msg_mission_count();
        Msg_mission_item[] Mi = new Msg_mission_item[32];
        int Prs;
        int Tep;
        int Dif;
        int Systemid;
        int Componentid;
        int Sequence;
        Boolean HB = true;
        volatile int MI = -1;
        Util ut;
        float gps_lat, gps_longth;
        float head, gspead, aispeed;
        float pitch_value, roll_value, yaw_value,alti;
        public MavLinkReader()
        {
            InitializeComponent();
            Baud.SelectedIndex = 3;
            Ca.result = (byte)255;
            Mv.PacketReceived += Mv_PacketReceived;
            String[] P = System.IO.Ports.SerialPort.GetPortNames();
            if (P.Length > 0)
                Comm.Text = P[0];
            FlightModes.Items.AddRange(SMode);
            Mi[0] = new Msg_mission_item();
            ut = new Util();
            yukseklikDegistir();
        }

        void Mv_PacketReceived(object sender, MavLink.MavlinkPacket e)
        {
            uint x = Mv.PacketsReceived;
            Systemid = e.SystemId;
            Componentid = e.ComponentId;
            Sequence = e.SequenceNumber;
            MavlinkMessage m = e.Message;
            if (m.GetType() == Hb.GetType())
                Hb = (Msg_heartbeat)e.Message;
            if (m.GetType() == Ss.GetType())
                Ss = (Msg_sys_status)e.Message;
            if (m.GetType() == Ps.GetType())
                Ps = (Msg_power_status)e.Message;
            if (m.GetType() == At.GetType())
                At = (Msg_attitude)e.Message;
            pitch_value = At.pitch;
            yaw_value = At.yaw;
            roll_value = At.roll;
            if (m.GetType() == Gps.GetType())
            Gps = (Msg_gps_raw_int)e.Message;
            gps_lat = (float)Gps.lat / 10000000.0f;
            gps_longth = (float)Gps.lon / 10000000.0f;
            if (m.GetType() == Vfr.GetType())
                Vfr = (Msg_vfr_hud)e.Message;
            alti = Vfr.alt;
            head = Vfr.heading;
            gspead = Vfr.groundspeed;
            aispeed = Vfr.airspeed;
            if (m.GetType() == Rp.GetType())
            {
                Rp = (Msg_raw_pressure)e.Message;

            }
            if (m.GetType() == Sp.GetType())
            {
                Sp = (Msg_scaled_pressure)e.Message;
                Prs = (int)(Sp.press_abs * 1000f);
                Tep = Sp.temperature;
                Dif = (int)(Sp.press_diff * 1000f);
               
                ut.LogPressure(Sp);
            }
            if (m.GetType() == Ca.GetType())
            {
                Ca = (Msg_command_ack)e.Message;
            }
            if (m.GetType() == St.GetType())
            {
                St = (Msg_statustext)e.Message;
            }
            if (m.GetType() == Mc.GetType())
            {
                Mc = (Msg_mission_count)e.Message;
                MI = 0;
                GetMissionValues.RunWorkerAsync();
            }
            if (m.GetType() == Mi[0].GetType())
            {
                Mi[MI++] = (Msg_mission_item)e.Message;
                if (MI >= Mc.count)
                    MI = -1;
            }
            if (x > 0)
            {
                if (MavLinkReader.ActiveForm != null)
                    MavLinkReader.ActiveForm.Invalidate();
            }
        }

        private void Data(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            int x = Serial.BytesToRead;
            byte[] b = new byte[x];
            for (int i=0;i<x;i++)
                b[i] = (byte)Serial.ReadByte();
            Mv.ParseBytes(b);
        }

        private void ReadData(object sender, EventArgs e)
        {
            Serial.BaudRate = int.Parse(Baud.Text);
            Serial.PortName = Comm.Text;
            Serial.Open();
            Start.Enabled = false;
            HeartBeat.RunWorkerAsync();
        }

        private void Dismiss(object sender, FormClosingEventArgs e)
        {
            if (Serial.IsOpen)
                Serial.Close();
        }
        private int changevalue_a(int value, int fromLow, int fromHigh, int toLow, int toHigh)
        {
            // kendi değerlerimizle göstergedeki değerleri eşitlemek için kullandıgımız bır fonksiyon 
            return (value - fromLow) * (toHigh - toLow) / (fromHigh - fromLow) + toLow;
        }
        private async void yukseklikDegistir()

        {
            Console.WriteLine(alti);

            while (alti != 0)
            {

                //altitude yukseklık 

                int hyuksek = changevalue_a((int)alti , 0, 50, 377, 570);
                int x = pictureBox2.Location.X;
                pictureBox2.Location = new Point(x, hyuksek);

            }


        }

        int minute = 0, second = 0, splitsecond = 0;


        //c ler konum , r ler boyutu
        int cx = 330, cy = 500, rx = 170, ry = 170; //381; 600
        int angle12;
        // =Convert.ToInt32(Vfr.airspeed);
        Bitmap image12 = Properties.Resources.airground;


        //pusula degerler
        int cxpusula = 100, cypusula = 500, rxpusula = 200, rypusula = 200; 
        //int  angle13 = Convert.ToInt32(head);
        Bitmap image13 = Properties.Resources.pusula;

        // hız needle degerleri
        int cxhız = 700, cyhız = 508, rxhız = 200, ryhız = 200; 
        Bitmap image14 = Properties.Resources.acilineedlepreview;

        //hava hız needle degerlerı
        int cxhava = 900, cyhava = 508, rxhava = 200, ryhava = 200; 

        Bitmap image15 = Properties.Resources.acilineedlepreview;
        //speed cizim deger
        int cxdenem = 598, cydenem = 388; 
        Bitmap image16 = Properties.Resources.speed;

        //arkaplan degerler 1
        int cxcerceve = 10, cycerceve =405; 
       
        Bitmap cercceve1 = Properties.Resources.cerceve;

        //arkaplan degerler 2
        int cxcerceve2 = 235, cycerceve2 = 405; 
        
        Bitmap cercceve2 = Properties.Resources.cerceve;

        //arkaplan degerler 3
        int cxcerceve3 = 604, cycerceve3 = 405; 

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult cevap;

            cevap = MessageBox.Show("Motor: 1400 kv Sunny Sky X2212 \n \n Batarya: 850 Mah Tattu Lipo Pil \n \n ESC: 30A Flycolor 3-6S Esc ", "Özellikler", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (cevap == DialogResult.Yes)
            {


            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            timer1.Start();
            button6.Text = "Stop";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            splitsecond++;
            if (splitsecond == 60)
            {
                splitsecond = 0;

                second++;
                if (second == 60)
                {
                    second = 0;
                    minute++;

                }
            }
            label6.Text = string.Format("{0:D2}", minute);   //label1 ->minute 
            label7.Text = string.Format("{0:D2}", second);  //label2 -> second
            label8.Text = string.Format("{0:D2}", splitsecond);  //label3 ->splitsecond

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (button6.Text == "Stop" && splitsecond != 0)
            {
                button6.Text = "Reset";
                timer1.Stop();
            }
            else
            {
                button6.Text = "Stop";
                minute = 0;
                second = 0;
                splitsecond = 0;

                label6.Text = string.Format("{0:D2}", minute);   //label1 ->minute 
                label7.Text = string.Format("{0:D2}", second);  //label2 -> second
                label8.Text = string.Format("{0:D2}", splitsecond);  //label3 ->splitsecond

            }
        }

        private void MavLinkReader_Resize(object sender, EventArgs e)
        {
            Invalidate();
        }

        //int  angle13 = Convert.ToInt32(head);
        Bitmap cercceve3 = Properties.Resources.cerceve;

        //arkaplan degerler 4
        int cxcerceve4 = 805, cycerceve4 = 400; //381; 600
        //int  angle13 = Convert.ToInt32(head);
        Bitmap cercceve4 = Properties.Resources.cerceve;


        //250 Air speed bilgileri 
        int cxairspeed = 795, cyairspeed = 388;
        Bitmap image17 = Properties.Resources.airspeed;

        private void Update(object sender, PaintEventArgs e)
        {
            Mode.Text = SMode[Hb.custom_mode];
            if (Ss != null)
            {
                BVolts.Text = String.Format("{0:f}", (float)Ss.voltage_battery / 1000.0f);
                BPercent.Text = String.Format("{0:d}%", Ss.battery_remaining);
                Current.Text = String.Format("{0:f}", (float)Ss.current_battery / 100.0f);
            }
            if ((Hb.base_mode & (byte)MAV_MODE_FLAG.MAV_MODE_FLAG_SAFETY_ARMED) != 0)
                Status.Text = "Armed";
            else
                Status.Text = "Not Armed";

            Seq.Text = String.Format("{0}", Sequence);

            if (At != null)
            {
                Roll.Text = String.Format("{0:f}", At.roll * 180 / 3.1415926);
                Pitch.Text = String.Format("{0:f}", At.pitch * 180 / 3.1415926);
                Yaw.Text = String.Format("{0:f}", At.yaw * 180 / 3.1415926);
            }
            if (Gps != null)
            {
                GpsFix.Text = String.Format("{0:d}", Gps.fix_type);
                Latitude.Text = String.Format("{0:00.000000}", (float)Gps.lat / 10000000.0f);
                Longitude.Text = String.Format("{0:00.000000}", (float)Gps.lon / 10000000.0f);
                Satellites.Text = String.Format("{0:d}", Gps.satellites_visible);
            }
            if (Vfr != null)
            {
                Altitude.Text = String.Format("{0:f}", Vfr.alt);
                Heading.Text = String.Format("{0:d}", Vfr.heading);
            }
            if (Ca != null)
            {
                if ((MAV_RESULT)Ca.result == MAV_RESULT.MAV_RESULT_ACCEPTED)
                    Results.Text = "Accepted";
                if ((MAV_RESULT)Ca.result == MAV_RESULT.MAV_RESULT_FAILED)
                    Results.Text = "Failed";
                if ((MAV_RESULT)Ca.result == MAV_RESULT.MAV_RESULT_TEMPORARILY_REJECTED)
                    Results.Text = "Rejected";
                if ((MAV_RESULT)Ca.result == MAV_RESULT.MAV_RESULT_UNSUPPORTED)
                    Results.Text = "Unsupported";
            }
            if (St.text != null)
            {
                char[] c = new char[St.text.Length];
                for (int i = 0; i < St.text.Length; i++)
                    c[i] = (char)St.text[i];
                Message.Text = new string(c);
            }
            if (Mc != null)
            {
                MissionItems.Text = String.Format("{0:d}", Mc.count);
            }
            double lat = Convert.ToDouble(gps_lat);
            double longt = Convert.ToDouble(gps_longth);

            Console.WriteLine(lat);

            map.Position = new GMap.NET.PointLatLng(gps_lat, gps_longth);
            map.MinZoom = 0;   // Haritanın gösterim boyutunu ayarlıyoruz.
            map.MaxZoom = 50;
            map.Zoom = 18;

            PointLatLng point = new PointLatLng(lat, longt);

            Bitmap bmMarker = (Bitmap)Image.FromFile("C:/Users/kubra/Desktop/MR/imagesNew/wp.png");
            GMapMarker marker = new GMarkerGoogle(point, bmMarker); //markerın seklını belırleyebılıyoruz.

            //üstüne bir marker  oluşturmak ıcın olusturuyoruz.
            GMapOverlay markers = new GMapOverlay("markers");
            // marker ekletıyoruz
            markers.Markers.Add(marker);
            // harıtada gostertıyoruz.
            map.Overlays.Add(markers);



            int pitch_int = Convert.ToInt32(pitch_value * 180 / 3.1415926);
            int pitch_deger = changevalue_a((int)pitch_int, -154, 154, 600, 390);
            int an = pictureBox4.Location.X;
            pictureBox4.Location = new Point(an, pitch_deger);
         
              

            Graphics g = e.Graphics;
            Graphics g1 = e.Graphics;

            g.DrawImage(cercceve1, cxcerceve, cycerceve); //cerceve cizdir
            g.DrawImage(cercceve2, cxcerceve2, cycerceve2); //cerceve cizdir
            g.DrawImage(cercceve3, cxcerceve3, cycerceve3); //cerceve cizdir
            g.DrawImage(cercceve4, cxcerceve4, cycerceve4); //cerceve cizdir
            g.DrawImage(image16, cxdenem, cydenem); //speed cizdir
            g1.DrawImage(image17, cxairspeed, cyairspeed); //airspeed cizdir
            // roll eksenı angle gosterdıgımız
            int roll_int = Convert.ToInt32(At.roll * -180 / 3.1415926);
            int angle_deger = changevalue_a((int)roll_int, 168, -154, 185, -175);
            Console.WriteLine((int)roll_int);
            Console.WriteLine("angle:");

            Console.WriteLine(angle_deger);
            g.RotateTransform(angle_deger, MatrixOrder.Append);
            g.TranslateTransform(cx, cy, MatrixOrder.Append);
            g.DrawImage(image12, -rx / 2, -ry / 2, rx, ry);
            e.Graphics.ResetTransform(); // döndürme eksenini 0 lamak için onemlisi


            //pusula için dondurme islemi
            int pusula_deger = changevalue_a((int)head *-1, -180, 180, 0, 360);
            Console.WriteLine(Vfr.heading);
            g1.RotateTransform(pusula_deger, MatrixOrder.Append);
            g1.TranslateTransform(cxpusula, cypusula, MatrixOrder.Append);
            g1.DrawImage(image13, -rxpusula / 2, -rypusula / 2, rxpusula, rypusula);

            e.Graphics.ResetTransform();

            //yer hızı için dondurme islemi
            int yerhız_deger = changevalue_a((int)gspead, 0, 50, 10, 300);
            Graphics g2 = e.Graphics;
            g2.RotateTransform(yerhız_deger, MatrixOrder.Append);
            g2.TranslateTransform(cxhız, cyhız, MatrixOrder.Append);
            g2.DrawImage(image14, -rxhız / 2, -ryhız / 2, rxhız, ryhız);
            e.Graphics.ResetTransform();

            //hava hız için dondurme islemi
            Graphics g3 = e.Graphics;
            int havahız_deger = changevalue_a((int)aispeed, 0, 50, 10, 300);
            g3.RotateTransform(havahız_deger, MatrixOrder.Append);
            g3.TranslateTransform(cxhava, cyhava, MatrixOrder.Append);
            g3.DrawImage(image15, -rxhava / 2, -ryhava / 2, rxhava, ryhava);
            e.Graphics.ResetTransform();
        }

       
        private void RequestMav()
        {

            Msg_request_data_stream ds = new Msg_request_data_stream();
            ds.req_message_rate = 2;
            ds.req_stream_id = (byte)MAV_DATA_STREAM.MAV_DATA_STREAM_ALL;
            ds.start_stop = 1;
            ds.target_component = (byte)MAV_COMPONENT.MAV_COMP_ID_ALL;
            ds.target_system = (byte)Systemid;

            SendPacket(ds);
        }

        private void DoCmd(object sender, EventArgs e)
        {
            RequestMav();
        }

         private void HeartB(object sender, DoWorkEventArgs e)
        {
            int sec;

            sec = 0;

            while (HB)
            {
                Msg_heartbeat hb = new Msg_heartbeat();
                if (sec != DateTime.Now.Second)
                {
                    hb.type = 6;
                    hb.system_status = 0;
                    hb.custom_mode = 0;
                    hb.base_mode = 0;
                    hb.autopilot = 0;

                    SendPacket(hb);
                    sec = DateTime.Now.Second;
                }
            }
        }

        private void SendPacket(MavlinkMessage m)
        {
            MavlinkPacket p = new MavlinkPacket();
            p.Message = m;
            p.SequenceNumber = (byte)Sequence;
            p.SystemId = 255;
            p.ComponentId = (byte)MAV_COMPONENT.MAV_COMP_ID_MISSIONPLANNER;
            byte[] b = Mv.Send(p);
            Serial.Write(b, 0, b.Length);
        }

        private void StopHeartBeat(object sender, EventArgs e)
        {
            HB = false;
        }

        private void ChgFlight(object sender, EventArgs e)
        {
            if (!Serial.IsOpen)
                return;
            int i = FlightModes.SelectedIndex;
            Msg_set_mode m = new Msg_set_mode();
            m.base_mode = (byte)MAV_MODE_FLAG.MAV_MODE_FLAG_CUSTOM_MODE_ENABLED;
            m.custom_mode = (byte)i;
            m.target_system = (byte)MAV_AUTOPILOT.MAV_AUTOPILOT_RESERVED;

            SendPacket(m);
        }

        private void SendMission(object sender, EventArgs e)
        {
            Msg_mission_clear_all cl = new Msg_mission_clear_all();
            cl.target_component = (byte)MAV_COMPONENT.MAV_COMP_ID_ALL;
            cl.target_system = (byte)Systemid;
            SendPacket(cl);
            Msg_mission_item it = new Msg_mission_item();
            it.autocontinue = 1;
            it.command = (byte)MAV_CMD.MAV_CMD_NAV_TAKEOFF;
            it.current = 0;
            it.frame = (byte)MAV_FRAME.MAV_FRAME_GLOBAL_RELATIVE_ALT;
            it.seq = 1;
            SendPacket(it);
        }

        private void GetMission(object sender, EventArgs e)
        {
            Msg_mission_request_list rl = new Msg_mission_request_list();
            rl.target_component = (byte)MAV_COMPONENT.MAV_COMP_ID_ALL;
            rl.target_system = (byte)Systemid;
            SendPacket(rl);
        }

        /* Lacks retry logic in case mission recieved is missed */
        private void RecvMission(object sender, DoWorkEventArgs e)
        {
            int Pr = -1;

            while (MI >= 0)
            {
                if ((Pr != MI) && (MI >= 0))
                {
                    Msg_mission_request Mr = new Msg_mission_request();
                    Mr.seq = (byte)MI;
                    Mr.target_component = (byte)MAV_COMPONENT.MAV_COMP_ID_ALL;
                    Mr.target_system = (byte)Systemid;
                    SendPacket(Mr);
                    Pr = MI;
                }
            }
        }

        private void Status_Click(object sender, EventArgs e)
        {

        }

        private void Altitude_Click(object sender, EventArgs e)
        {

        }

        private void Heading_Click(object sender, EventArgs e)
        {

        }

        private void GpsFix_Click(object sender, EventArgs e)
        {

        }

        private void LRoll_Click(object sender, EventArgs e)
        {

        }

        private void Roll_Click(object sender, EventArgs e)
        {

        }

        private void MavLinkReader_Load(object sender, EventArgs e)
        {
            map.DragButton = MouseButtons.Left; // farenin soluyla hareket ettirmeyi ayarlıyoruz.
            map.MapProvider = GMapProviders.GoogleMap; // Google Map ekliyoruz. (Farklı haritalaari da buradan deneyebiliriz.)

        }

        private void MavLinkReader_Leave(object sender, EventArgs e)
        {

        }
    }

    public enum FLIGHT_MODES : ushort
    {
        MODE_STABILIZE = 0,
        MODE_ACRO = 1,
        MODE_ALT_HOLD = 2,
        MODE_AUTO = 3,
        MODE_GUIDED = 4,
        MODE_LOITER = 5,
        MODE_RTL = 6,
        MODE_CIRCLE = 7,
        MODE_LAND = 9,
        MODE_DRIFT = 11,
        MODE_SPORT = 13,
        MODE_FLIP = 14,
        MODE_AUTOTUNE = 15,
        MODE_POSHOLD = 16,
        MODE_BRAKE = 17,
        MODE_THROW = 18,
    }

}
