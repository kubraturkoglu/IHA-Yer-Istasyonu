namespace MavLinkReader
{
    partial class MavLinkReader
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MavLinkReader));
            this.LCom = new System.Windows.Forms.Label();
            this.LBaud = new System.Windows.Forms.Label();
            this.Comm = new System.Windows.Forms.TextBox();
            this.Baud = new System.Windows.Forms.ComboBox();
            this.Start = new System.Windows.Forms.Button();
            this.Serial = new System.IO.Ports.SerialPort(this.components);
            this.LStatus = new System.Windows.Forms.Label();
            this.Status = new System.Windows.Forms.Label();
            this.LMode = new System.Windows.Forms.Label();
            this.Mode = new System.Windows.Forms.Label();
            this.LBattery = new System.Windows.Forms.Label();
            this.BVolts = new System.Windows.Forms.Label();
            this.LBPercent = new System.Windows.Forms.Label();
            this.BPercent = new System.Windows.Forms.Label();
            this.LCurrent = new System.Windows.Forms.Label();
            this.Current = new System.Windows.Forms.Label();
            this.LRoll = new System.Windows.Forms.Label();
            this.Roll = new System.Windows.Forms.Label();
            this.LPitch = new System.Windows.Forms.Label();
            this.Pitch = new System.Windows.Forms.Label();
            this.LYaw = new System.Windows.Forms.Label();
            this.Yaw = new System.Windows.Forms.Label();
            this.LGpsf = new System.Windows.Forms.Label();
            this.GpsFix = new System.Windows.Forms.Label();
            this.LLatitude = new System.Windows.Forms.Label();
            this.Latitude = new System.Windows.Forms.Label();
            this.LLongitude = new System.Windows.Forms.Label();
            this.Longitude = new System.Windows.Forms.Label();
            this.LSatellites = new System.Windows.Forms.Label();
            this.Satellites = new System.Windows.Forms.Label();
            this.LAltitude = new System.Windows.Forms.Label();
            this.Altitude = new System.Windows.Forms.Label();
            this.LHeading = new System.Windows.Forms.Label();
            this.Heading = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Seq = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Results = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Message = new System.Windows.Forms.Label();
            this.Request = new System.Windows.Forms.Button();
            this.HeartBeat = new System.ComponentModel.BackgroundWorker();
            this.button1 = new System.Windows.Forms.Button();
            this.FlightModes = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.MissionItems = new System.Windows.Forms.Label();
            this.GetMissionValues = new System.ComponentModel.BackgroundWorker();
            this.map = new GMap.NET.WindowsForms.GMapControl();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LCom
            // 
            this.LCom.AutoSize = true;
            this.LCom.ForeColor = System.Drawing.Color.Lime;
            this.LCom.Location = new System.Drawing.Point(1108, 7);
            this.LCom.Name = "LCom";
            this.LCom.Size = new System.Drawing.Size(63, 23);
            this.LCom.TabIndex = 0;
            this.LCom.Text = "COM:";
            // 
            // LBaud
            // 
            this.LBaud.AutoSize = true;
            this.LBaud.ForeColor = System.Drawing.Color.Lime;
            this.LBaud.Location = new System.Drawing.Point(1108, 36);
            this.LBaud.Name = "LBaud";
            this.LBaud.Size = new System.Drawing.Size(69, 23);
            this.LBaud.TabIndex = 0;
            this.LBaud.Text = "BAUD:";
            // 
            // Comm
            // 
            this.Comm.Location = new System.Drawing.Point(1173, 7);
            this.Comm.Name = "Comm";
            this.Comm.Size = new System.Drawing.Size(86, 30);
            this.Comm.TabIndex = 1;
            // 
            // Baud
            // 
            this.Baud.FormattingEnabled = true;
            this.Baud.Items.AddRange(new object[] {
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.Baud.Location = new System.Drawing.Point(1173, 36);
            this.Baud.Name = "Baud";
            this.Baud.Size = new System.Drawing.Size(86, 31);
            this.Baud.TabIndex = 2;
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(1112, 73);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(147, 35);
            this.Start.TabIndex = 3;
            this.Start.Text = "Connect";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.ReadData);
            // 
            // Serial
            // 
            this.Serial.BaudRate = 57600;
            this.Serial.PortName = "COM16";
            this.Serial.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.Data);
            // 
            // LStatus
            // 
            this.LStatus.AutoSize = true;
            this.LStatus.ForeColor = System.Drawing.Color.Lime;
            this.LStatus.Location = new System.Drawing.Point(1130, 185);
            this.LStatus.Name = "LStatus";
            this.LStatus.Size = new System.Drawing.Size(73, 23);
            this.LStatus.TabIndex = 0;
            this.LStatus.Text = "Durum:";
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Status.Location = new System.Drawing.Point(1198, 185);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(42, 23);
            this.Status.TabIndex = 4;
            this.Status.Text = "N/A";
            this.Status.Click += new System.EventHandler(this.Status_Click);
            // 
            // LMode
            // 
            this.LMode.AutoSize = true;
            this.LMode.ForeColor = System.Drawing.Color.Lime;
            this.LMode.Location = new System.Drawing.Point(1135, 306);
            this.LMode.Name = "LMode";
            this.LMode.Size = new System.Drawing.Size(66, 23);
            this.LMode.TabIndex = 0;
            this.LMode.Text = "Mode:";
            this.LMode.Visible = false;
            // 
            // Mode
            // 
            this.Mode.AutoSize = true;
            this.Mode.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Mode.Location = new System.Drawing.Point(1198, 306);
            this.Mode.Name = "Mode";
            this.Mode.Size = new System.Drawing.Size(42, 23);
            this.Mode.TabIndex = 4;
            this.Mode.Text = "N/A";
            this.Mode.Visible = false;
            // 
            // LBattery
            // 
            this.LBattery.AutoSize = true;
            this.LBattery.ForeColor = System.Drawing.Color.Lime;
            this.LBattery.Location = new System.Drawing.Point(1130, 201);
            this.LBattery.Name = "LBattery";
            this.LBattery.Size = new System.Drawing.Size(80, 23);
            this.LBattery.TabIndex = 0;
            this.LBattery.Text = "Battery:";
            // 
            // BVolts
            // 
            this.BVolts.AutoSize = true;
            this.BVolts.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BVolts.Location = new System.Drawing.Point(1198, 201);
            this.BVolts.Name = "BVolts";
            this.BVolts.Size = new System.Drawing.Size(42, 23);
            this.BVolts.TabIndex = 4;
            this.BVolts.Text = "N/A";
            // 
            // LBPercent
            // 
            this.LBPercent.AutoSize = true;
            this.LBPercent.ForeColor = System.Drawing.Color.Lime;
            this.LBPercent.Location = new System.Drawing.Point(1131, 327);
            this.LBPercent.Name = "LBPercent";
            this.LBPercent.Size = new System.Drawing.Size(84, 23);
            this.LBPercent.TabIndex = 0;
            this.LBPercent.Text = "Percent:";
            this.LBPercent.Visible = false;
            // 
            // BPercent
            // 
            this.BPercent.AutoSize = true;
            this.BPercent.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BPercent.Location = new System.Drawing.Point(1198, 322);
            this.BPercent.Name = "BPercent";
            this.BPercent.Size = new System.Drawing.Size(42, 23);
            this.BPercent.TabIndex = 4;
            this.BPercent.Text = "N/A";
            this.BPercent.Visible = false;
            // 
            // LCurrent
            // 
            this.LCurrent.AutoSize = true;
            this.LCurrent.ForeColor = System.Drawing.Color.Lime;
            this.LCurrent.Location = new System.Drawing.Point(1131, 450);
            this.LCurrent.Name = "LCurrent";
            this.LCurrent.Size = new System.Drawing.Size(81, 23);
            this.LCurrent.TabIndex = 0;
            this.LCurrent.Text = "Current:";
            this.LCurrent.Visible = false;
            // 
            // Current
            // 
            this.Current.AutoSize = true;
            this.Current.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Current.Location = new System.Drawing.Point(1205, 450);
            this.Current.Name = "Current";
            this.Current.Size = new System.Drawing.Size(42, 23);
            this.Current.TabIndex = 4;
            this.Current.Text = "N/A";
            this.Current.Visible = false;
            // 
            // LRoll
            // 
            this.LRoll.AutoSize = true;
            this.LRoll.ForeColor = System.Drawing.Color.Lime;
            this.LRoll.Location = new System.Drawing.Point(1130, 217);
            this.LRoll.Name = "LRoll";
            this.LRoll.Size = new System.Drawing.Size(49, 23);
            this.LRoll.TabIndex = 0;
            this.LRoll.Text = "Roll:";
            this.LRoll.Click += new System.EventHandler(this.LRoll_Click);
            // 
            // Roll
            // 
            this.Roll.AutoSize = true;
            this.Roll.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Roll.Location = new System.Drawing.Point(1198, 217);
            this.Roll.Name = "Roll";
            this.Roll.Size = new System.Drawing.Size(42, 23);
            this.Roll.TabIndex = 4;
            this.Roll.Text = "N/A";
            this.Roll.Click += new System.EventHandler(this.Roll_Click);
            // 
            // LPitch
            // 
            this.LPitch.AutoSize = true;
            this.LPitch.ForeColor = System.Drawing.Color.Lime;
            this.LPitch.Location = new System.Drawing.Point(1130, 338);
            this.LPitch.Name = "LPitch";
            this.LPitch.Size = new System.Drawing.Size(59, 23);
            this.LPitch.TabIndex = 0;
            this.LPitch.Text = "Pitch:";
            // 
            // Pitch
            // 
            this.Pitch.AutoSize = true;
            this.Pitch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Pitch.Location = new System.Drawing.Point(1198, 338);
            this.Pitch.Name = "Pitch";
            this.Pitch.Size = new System.Drawing.Size(42, 23);
            this.Pitch.TabIndex = 4;
            this.Pitch.Text = "N/A";
            // 
            // LYaw
            // 
            this.LYaw.AutoSize = true;
            this.LYaw.ForeColor = System.Drawing.Color.Lime;
            this.LYaw.Location = new System.Drawing.Point(1131, 361);
            this.LYaw.Name = "LYaw";
            this.LYaw.Size = new System.Drawing.Size(55, 23);
            this.LYaw.TabIndex = 0;
            this.LYaw.Text = "Yaw:";
            // 
            // Yaw
            // 
            this.Yaw.AutoSize = true;
            this.Yaw.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Yaw.Location = new System.Drawing.Point(1201, 361);
            this.Yaw.Name = "Yaw";
            this.Yaw.Size = new System.Drawing.Size(42, 23);
            this.Yaw.TabIndex = 4;
            this.Yaw.Text = "N/A";
            // 
            // LGpsf
            // 
            this.LGpsf.AutoSize = true;
            this.LGpsf.ForeColor = System.Drawing.Color.Lime;
            this.LGpsf.Location = new System.Drawing.Point(1130, 233);
            this.LGpsf.Name = "LGpsf";
            this.LGpsf.Size = new System.Drawing.Size(89, 23);
            this.LGpsf.TabIndex = 0;
            this.LGpsf.Text = "GPS Fix:";
            this.LGpsf.Visible = false;
            // 
            // GpsFix
            // 
            this.GpsFix.AutoSize = true;
            this.GpsFix.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GpsFix.Location = new System.Drawing.Point(1198, 233);
            this.GpsFix.Name = "GpsFix";
            this.GpsFix.Size = new System.Drawing.Size(42, 23);
            this.GpsFix.TabIndex = 4;
            this.GpsFix.Text = "N/A";
            this.GpsFix.Visible = false;
            this.GpsFix.Click += new System.EventHandler(this.GpsFix_Click);
            // 
            // LLatitude
            // 
            this.LLatitude.AutoSize = true;
            this.LLatitude.ForeColor = System.Drawing.Color.Lime;
            this.LLatitude.Location = new System.Drawing.Point(1131, 286);
            this.LLatitude.Name = "LLatitude";
            this.LLatitude.Size = new System.Drawing.Size(70, 23);
            this.LLatitude.TabIndex = 0;
            this.LLatitude.Text = "Enlem:";
            // 
            // Latitude
            // 
            this.Latitude.AutoSize = true;
            this.Latitude.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Latitude.Location = new System.Drawing.Point(1195, 286);
            this.Latitude.Name = "Latitude";
            this.Latitude.Size = new System.Drawing.Size(42, 23);
            this.Latitude.TabIndex = 4;
            this.Latitude.Text = "N/A";
            // 
            // LLongitude
            // 
            this.LLongitude.AutoSize = true;
            this.LLongitude.ForeColor = System.Drawing.Color.Lime;
            this.LLongitude.Location = new System.Drawing.Point(1127, 377);
            this.LLongitude.Name = "LLongitude";
            this.LLongitude.Size = new System.Drawing.Size(81, 23);
            this.LLongitude.TabIndex = 0;
            this.LLongitude.Text = "Boylam:";
            // 
            // Longitude
            // 
            this.Longitude.AutoSize = true;
            this.Longitude.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Longitude.Location = new System.Drawing.Point(1201, 377);
            this.Longitude.Name = "Longitude";
            this.Longitude.Size = new System.Drawing.Size(42, 23);
            this.Longitude.TabIndex = 4;
            this.Longitude.Text = "N/A";
            // 
            // LSatellites
            // 
            this.LSatellites.AutoSize = true;
            this.LSatellites.ForeColor = System.Drawing.Color.Lime;
            this.LSatellites.Location = new System.Drawing.Point(1130, 249);
            this.LSatellites.Name = "LSatellites";
            this.LSatellites.Size = new System.Drawing.Size(96, 23);
            this.LSatellites.TabIndex = 0;
            this.LSatellites.Text = "Satellites:";
            this.LSatellites.Visible = false;
            // 
            // Satellites
            // 
            this.Satellites.AutoSize = true;
            this.Satellites.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Satellites.Location = new System.Drawing.Point(1198, 249);
            this.Satellites.Name = "Satellites";
            this.Satellites.Size = new System.Drawing.Size(42, 23);
            this.Satellites.TabIndex = 4;
            this.Satellites.Text = "N/A";
            this.Satellites.Visible = false;
            // 
            // LAltitude
            // 
            this.LAltitude.AutoSize = true;
            this.LAltitude.ForeColor = System.Drawing.Color.Lime;
            this.LAltitude.Location = new System.Drawing.Point(1130, 265);
            this.LAltitude.Name = "LAltitude";
            this.LAltitude.Size = new System.Drawing.Size(81, 23);
            this.LAltitude.TabIndex = 0;
            this.LAltitude.Text = "Altitude:";
            // 
            // Altitude
            // 
            this.Altitude.AutoSize = true;
            this.Altitude.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Altitude.Location = new System.Drawing.Point(1198, 265);
            this.Altitude.Name = "Altitude";
            this.Altitude.Size = new System.Drawing.Size(42, 23);
            this.Altitude.TabIndex = 4;
            this.Altitude.Text = "N/A";
            this.Altitude.Click += new System.EventHandler(this.Altitude_Click);
            // 
            // LHeading
            // 
            this.LHeading.AutoSize = true;
            this.LHeading.ForeColor = System.Drawing.Color.Lime;
            this.LHeading.Location = new System.Drawing.Point(1130, 304);
            this.LHeading.Name = "LHeading";
            this.LHeading.Size = new System.Drawing.Size(87, 23);
            this.LHeading.TabIndex = 0;
            this.LHeading.Text = "Heading:";
            // 
            // Heading
            // 
            this.Heading.AutoSize = true;
            this.Heading.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Heading.Location = new System.Drawing.Point(1194, 309);
            this.Heading.Name = "Heading";
            this.Heading.Size = new System.Drawing.Size(42, 23);
            this.Heading.TabIndex = 4;
            this.Heading.Text = "N/A";
            this.Heading.Click += new System.EventHandler(this.Heading_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(1131, 434);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Sequence:";
            this.label1.Visible = false;
            // 
            // Seq
            // 
            this.Seq.AutoSize = true;
            this.Seq.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Seq.Location = new System.Drawing.Point(1205, 434);
            this.Seq.Name = "Seq";
            this.Seq.Size = new System.Drawing.Size(42, 23);
            this.Seq.TabIndex = 6;
            this.Seq.Text = "N/A";
            this.Seq.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(1061, 384);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "Command Results:";
            this.label2.Visible = false;
            // 
            // Results
            // 
            this.Results.AutoSize = true;
            this.Results.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Results.Location = new System.Drawing.Point(1206, 384);
            this.Results.Name = "Results";
            this.Results.Size = new System.Drawing.Size(42, 23);
            this.Results.TabIndex = 8;
            this.Results.Text = "N/A";
            this.Results.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Lime;
            this.label3.Location = new System.Drawing.Point(1060, 413);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 23);
            this.label3.TabIndex = 9;
            this.label3.Text = "Status Message:";
            this.label3.Visible = false;
            // 
            // Message
            // 
            this.Message.AutoSize = true;
            this.Message.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Message.Location = new System.Drawing.Point(1205, 413);
            this.Message.Name = "Message";
            this.Message.Size = new System.Drawing.Size(42, 23);
            this.Message.TabIndex = 10;
            this.Message.Text = "N/A";
            this.Message.Visible = false;
            // 
            // Request
            // 
            this.Request.Location = new System.Drawing.Point(1123, 482);
            this.Request.Name = "Request";
            this.Request.Size = new System.Drawing.Size(95, 33);
            this.Request.TabIndex = 11;
            this.Request.Text = "Request";
            this.Request.UseVisualStyleBackColor = true;
            this.Request.Visible = false;
            this.Request.Click += new System.EventHandler(this.DoCmd);
            // 
            // HeartBeat
            // 
            this.HeartBeat.DoWork += new System.ComponentModel.DoWorkEventHandler(this.HeartB);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1165, 584);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 32);
            this.button1.TabIndex = 12;
            this.button1.Text = "Stop Heartbeat";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.StopHeartBeat);
            // 
            // FlightModes
            // 
            this.FlightModes.FormattingEnabled = true;
            this.FlightModes.Location = new System.Drawing.Point(1115, 137);
            this.FlightModes.Name = "FlightModes";
            this.FlightModes.Size = new System.Drawing.Size(144, 31);
            this.FlightModes.TabIndex = 13;
            this.FlightModes.SelectedIndexChanged += new System.EventHandler(this.ChgFlight);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Lime;
            this.label4.Location = new System.Drawing.Point(1108, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 23);
            this.label4.TabIndex = 14;
            this.label4.Text = "Uçuş Modu:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1108, 476);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(66, 30);
            this.button2.TabIndex = 15;
            this.button2.Text = "Send Mission";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.SendMission);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1178, 476);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(57, 30);
            this.button3.TabIndex = 16;
            this.button3.Text = "Get Mission";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.GetMission);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Lime;
            this.label5.Location = new System.Drawing.Point(1130, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 23);
            this.label5.TabIndex = 17;
            this.label5.Text = "Mission:";
            this.label5.Visible = false;
            // 
            // MissionItems
            // 
            this.MissionItems.AutoSize = true;
            this.MissionItems.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MissionItems.Location = new System.Drawing.Point(1198, 281);
            this.MissionItems.Name = "MissionItems";
            this.MissionItems.Size = new System.Drawing.Size(42, 23);
            this.MissionItems.TabIndex = 18;
            this.MissionItems.Text = "N/A";
            this.MissionItems.Visible = false;
            // 
            // GetMissionValues
            // 
            this.GetMissionValues.DoWork += new System.ComponentModel.DoWorkEventHandler(this.RecvMission);
            // 
            // map
            // 
            this.map.Bearing = 0F;
            this.map.CanDragMap = true;
            this.map.EmptyTileColor = System.Drawing.Color.Navy;
            this.map.GrayScaleMode = false;
            this.map.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.map.LevelsKeepInMemmory = 5;
            this.map.Location = new System.Drawing.Point(0, -3);
            this.map.MarkersEnabled = true;
            this.map.MaxZoom = 2;
            this.map.MinZoom = 2;
            this.map.MouseWheelZoomEnabled = true;
            this.map.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.map.Name = "map";
            this.map.NegativeMode = false;
            this.map.PolygonsEnabled = true;
            this.map.RetryLoadTile = 0;
            this.map.RoutesEnabled = true;
            this.map.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.map.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.map.ShowTileGridLines = false;
            this.map.Size = new System.Drawing.Size(1094, 335);
            this.map.TabIndex = 20;
            this.map.Zoom = 0D;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::MavLinkReader.Properties.Resources.yukseklikimleci;
            this.pictureBox4.Location = new System.Drawing.Point(290, 466);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(71, 5);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 24;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::MavLinkReader.Properties.Resources.usttengorunum_removebg_preview;
            this.pictureBox3.Location = new System.Drawing.Point(75, 469);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(50, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 23;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::MavLinkReader.Properties.Resources.yukseklikimleci;
            this.pictureBox2.Location = new System.Drawing.Point(480, 575);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(71, 5);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MavLinkReader.Properties.Resources.yukseklik;
            this.pictureBox1.Location = new System.Drawing.Point(449, 338);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(129, 285);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1134, 521);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(105, 37);
            this.button4.TabIndex = 25;
            this.button4.Text = "Özellikler";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(1092, 476);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(84, 30);
            this.button5.TabIndex = 26;
            this.button5.Text = "Başla";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(1178, 476);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(81, 30);
            this.button6.TabIndex = 27;
            this.button6.Text = "Durdur";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(1126, 450);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 23);
            this.label6.TabIndex = 28;
            this.label6.Text = "00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(1174, 450);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 23);
            this.label7.TabIndex = 29;
            this.label7.Text = "00";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(1204, 450);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 23);
            this.label8.TabIndex = 30;
            this.label8.Text = "00";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Lime;
            this.label9.Location = new System.Drawing.Point(1088, 436);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 23);
            this.label9.TabIndex = 31;
            this.label9.Text = "Kronometre";
            // 
            // MavLinkReader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1271, 639);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.map);
            this.Controls.Add(this.MissionItems);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.FlightModes);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Request);
            this.Controls.Add(this.Message);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Results);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Seq);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Longitude);
            this.Controls.Add(this.Yaw);
            this.Controls.Add(this.Current);
            this.Controls.Add(this.Heading);
            this.Controls.Add(this.Latitude);
            this.Controls.Add(this.Pitch);
            this.Controls.Add(this.BPercent);
            this.Controls.Add(this.Mode);
            this.Controls.Add(this.Altitude);
            this.Controls.Add(this.Satellites);
            this.Controls.Add(this.GpsFix);
            this.Controls.Add(this.Roll);
            this.Controls.Add(this.BVolts);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.Baud);
            this.Controls.Add(this.Comm);
            this.Controls.Add(this.LLongitude);
            this.Controls.Add(this.LYaw);
            this.Controls.Add(this.LCurrent);
            this.Controls.Add(this.LHeading);
            this.Controls.Add(this.LLatitude);
            this.Controls.Add(this.LPitch);
            this.Controls.Add(this.LBPercent);
            this.Controls.Add(this.LMode);
            this.Controls.Add(this.LAltitude);
            this.Controls.Add(this.LSatellites);
            this.Controls.Add(this.LGpsf);
            this.Controls.Add(this.LRoll);
            this.Controls.Add(this.LBattery);
            this.Controls.Add(this.LStatus);
            this.Controls.Add(this.LBaud);
            this.Controls.Add(this.LCom);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MavLinkReader";
            this.Text = "Yer İstasyonu Poyraz";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Dismiss);
            this.Load += new System.EventHandler(this.MavLinkReader_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Update);
            this.Leave += new System.EventHandler(this.MavLinkReader_Leave);
            this.Resize += new System.EventHandler(this.MavLinkReader_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LCom;
        private System.Windows.Forms.Label LBaud;
        private System.Windows.Forms.TextBox Comm;
        private System.Windows.Forms.ComboBox Baud;
        private System.Windows.Forms.Button Start;
        private System.IO.Ports.SerialPort Serial;
        private System.Windows.Forms.Label LStatus;
        private System.Windows.Forms.Label Status;
        private System.Windows.Forms.Label LMode;
        private System.Windows.Forms.Label Mode;
        private System.Windows.Forms.Label LBattery;
        private System.Windows.Forms.Label BVolts;
        private System.Windows.Forms.Label LBPercent;
        private System.Windows.Forms.Label BPercent;
        private System.Windows.Forms.Label LCurrent;
        private System.Windows.Forms.Label Current;
        private System.Windows.Forms.Label LRoll;
        private System.Windows.Forms.Label Roll;
        private System.Windows.Forms.Label LPitch;
        private System.Windows.Forms.Label Pitch;
        private System.Windows.Forms.Label LYaw;
        private System.Windows.Forms.Label Yaw;
        private System.Windows.Forms.Label LGpsf;
        private System.Windows.Forms.Label GpsFix;
        private System.Windows.Forms.Label LLatitude;
        private System.Windows.Forms.Label Latitude;
        private System.Windows.Forms.Label LLongitude;
        private System.Windows.Forms.Label Longitude;
        private System.Windows.Forms.Label LSatellites;
        private System.Windows.Forms.Label Satellites;
        private System.Windows.Forms.Label LAltitude;
        private System.Windows.Forms.Label Altitude;
        private System.Windows.Forms.Label LHeading;
        private System.Windows.Forms.Label Heading;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Seq;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Results;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Message;
        private System.Windows.Forms.Button Request;
        private System.ComponentModel.BackgroundWorker HeartBeat;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox FlightModes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label MissionItems;
        private System.ComponentModel.BackgroundWorker GetMissionValues;
        private GMap.NET.WindowsForms.GMapControl map;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label9;
    }
}

