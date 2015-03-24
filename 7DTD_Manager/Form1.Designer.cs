namespace _7DTD_Manager
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.strHost = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.comboHost = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.strStatus = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.strPort = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.strPass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.strConsole = new System.Windows.Forms.RichTextBox();
            this.strCmd = new System.Windows.Forms.TextBox();
            this.panelPlayers = new System.Windows.Forms.GroupBox();
            this.btnKickall = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.panelBanTime = new System.Windows.Forms.GroupBox();
            this.comboPeriod = new System.Windows.Forms.ComboBox();
            this.trackBanTime = new System.Windows.Forms.TrackBar();
            this.strReason = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnKick = new System.Windows.Forms.Button();
            this.btnBan = new System.Windows.Forms.Button();
            this.listPlayers = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSetTime = new System.Windows.Forms.Button();
            this.strHour = new System.Windows.Forms.Label();
            this.strDay = new System.Windows.Forms.Label();
            this.trackHour = new System.Windows.Forms.TrackBar();
            this.trackDay = new System.Windows.Forms.TrackBar();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.comboItems = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboPlayers = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnRefresh2 = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnShutdown = new System.Windows.Forms.Button();
            this.btnFreeRam = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.btnDebugOFF = new System.Windows.Forms.Button();
            this.btnDebugON = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnScopeOFF = new System.Windows.Forms.Button();
            this.btnScopeON = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panelPlayers.SuspendLayout();
            this.panelBanTime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBanTime)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackDay)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.strHost);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.comboHost);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.strStatus);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.strPort);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.strPass);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(481, 76);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Telnet Login";
            // 
            // strHost
            // 
            this.strHost.Location = new System.Drawing.Point(44, 23);
            this.strHost.Name = "strHost";
            this.strHost.Size = new System.Drawing.Size(100, 20);
            this.strHost.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(150, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Load:";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(321, 47);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);
            // 
            // comboHost
            // 
            this.comboHost.FormattingEnabled = true;
            this.comboHost.Location = new System.Drawing.Point(190, 49);
            this.comboHost.Name = "comboHost";
            this.comboHost.Size = new System.Drawing.Size(122, 21);
            this.comboHost.TabIndex = 1;
            this.comboHost.SelectedIndexChanged += new System.EventHandler(this.strHost_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(402, 47);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(69, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Disconnect";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // strStatus
            // 
            this.strStatus.AutoSize = true;
            this.strStatus.ForeColor = System.Drawing.Color.Red;
            this.strStatus.Location = new System.Drawing.Point(52, 54);
            this.strStatus.Name = "strStatus";
            this.strStatus.Size = new System.Drawing.Size(73, 13);
            this.strStatus.TabIndex = 9;
            this.strStatus.Text = "Disconnected";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Status:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(318, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Port";
            // 
            // strPort
            // 
            this.strPort.Location = new System.Drawing.Point(350, 22);
            this.strPort.Name = "strPort";
            this.strPort.Size = new System.Drawing.Size(46, 20);
            this.strPort.TabIndex = 5;
            this.strPort.Text = "8081";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(402, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(150, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password:";
            // 
            // strPass
            // 
            this.strPass.Location = new System.Drawing.Point(212, 22);
            this.strPass.Name = "strPass";
            this.strPass.Size = new System.Drawing.Size(100, 20);
            this.strPass.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Host:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.strConsole);
            this.groupBox2.Controls.Add(this.strCmd);
            this.groupBox2.Location = new System.Drawing.Point(12, 94);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(481, 495);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Console";
            // 
            // strConsole
            // 
            this.strConsole.BackColor = System.Drawing.SystemColors.ControlText;
            this.strConsole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.strConsole.HideSelection = false;
            this.strConsole.Location = new System.Drawing.Point(6, 19);
            this.strConsole.Name = "strConsole";
            this.strConsole.Size = new System.Drawing.Size(465, 444);
            this.strConsole.TabIndex = 2;
            this.strConsole.Text = "";
            // 
            // strCmd
            // 
            this.strCmd.Location = new System.Drawing.Point(6, 469);
            this.strCmd.Name = "strCmd";
            this.strCmd.Size = new System.Drawing.Size(465, 20);
            this.strCmd.TabIndex = 1;
            this.strCmd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // panelPlayers
            // 
            this.panelPlayers.Controls.Add(this.btnKickall);
            this.panelPlayers.Controls.Add(this.btnRefresh);
            this.panelPlayers.Controls.Add(this.panelBanTime);
            this.panelPlayers.Controls.Add(this.strReason);
            this.panelPlayers.Controls.Add(this.label5);
            this.panelPlayers.Controls.Add(this.btnKick);
            this.panelPlayers.Controls.Add(this.btnBan);
            this.panelPlayers.Controls.Add(this.listPlayers);
            this.panelPlayers.Location = new System.Drawing.Point(499, 12);
            this.panelPlayers.Name = "panelPlayers";
            this.panelPlayers.Size = new System.Drawing.Size(333, 215);
            this.panelPlayers.TabIndex = 2;
            this.panelPlayers.TabStop = false;
            this.panelPlayers.Text = "Players";
            // 
            // btnKickall
            // 
            this.btnKickall.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnKickall.Location = new System.Drawing.Point(240, 61);
            this.btnKickall.Name = "btnKickall";
            this.btnKickall.Size = new System.Drawing.Size(87, 23);
            this.btnKickall.TabIndex = 7;
            this.btnKickall.Text = "KICKALL";
            this.btnKickall.UseVisualStyleBackColor = false;
            this.btnKickall.Click += new System.EventHandler(this.btnKickall_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(6, 184);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(120, 23);
            this.btnRefresh.TabIndex = 6;
            this.btnRefresh.Text = "Refresh Player List";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // panelBanTime
            // 
            this.panelBanTime.Controls.Add(this.comboPeriod);
            this.panelBanTime.Controls.Add(this.trackBanTime);
            this.panelBanTime.Location = new System.Drawing.Point(135, 120);
            this.panelBanTime.Name = "panelBanTime";
            this.panelBanTime.Size = new System.Drawing.Size(192, 87);
            this.panelBanTime.TabIndex = 5;
            this.panelBanTime.TabStop = false;
            this.panelBanTime.Text = "Ban Time";
            // 
            // comboPeriod
            // 
            this.comboPeriod.DisplayMember = "1";
            this.comboPeriod.FormattingEnabled = true;
            this.comboPeriod.Items.AddRange(new object[] {
            "minutes",
            "hours",
            "days",
            "weeks",
            "months",
            "years"});
            this.comboPeriod.Location = new System.Drawing.Point(6, 54);
            this.comboPeriod.Name = "comboPeriod";
            this.comboPeriod.Size = new System.Drawing.Size(180, 21);
            this.comboPeriod.TabIndex = 1;
            this.comboPeriod.Text = "Period Time";
            // 
            // trackBanTime
            // 
            this.trackBanTime.Location = new System.Drawing.Point(6, 19);
            this.trackBanTime.Maximum = 60;
            this.trackBanTime.Minimum = 1;
            this.trackBanTime.Name = "trackBanTime";
            this.trackBanTime.Size = new System.Drawing.Size(180, 45);
            this.trackBanTime.TabIndex = 0;
            this.trackBanTime.TickFrequency = 3;
            this.trackBanTime.Value = 1;
            this.trackBanTime.ValueChanged += new System.EventHandler(this.trackBanTime_ValueChanged);
            // 
            // strReason
            // 
            this.strReason.Location = new System.Drawing.Point(135, 35);
            this.strReason.Name = "strReason";
            this.strReason.Size = new System.Drawing.Size(192, 20);
            this.strReason.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(132, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Reason:";
            // 
            // btnKick
            // 
            this.btnKick.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnKick.Location = new System.Drawing.Point(135, 61);
            this.btnKick.Name = "btnKick";
            this.btnKick.Size = new System.Drawing.Size(90, 23);
            this.btnKick.TabIndex = 2;
            this.btnKick.Text = "KICK";
            this.btnKick.UseVisualStyleBackColor = false;
            this.btnKick.Click += new System.EventHandler(this.btnKick_Click);
            // 
            // btnBan
            // 
            this.btnBan.BackColor = System.Drawing.Color.Tomato;
            this.btnBan.Location = new System.Drawing.Point(135, 90);
            this.btnBan.Name = "btnBan";
            this.btnBan.Size = new System.Drawing.Size(192, 23);
            this.btnBan.TabIndex = 1;
            this.btnBan.Text = "BAN";
            this.btnBan.UseVisualStyleBackColor = false;
            this.btnBan.Click += new System.EventHandler(this.btnBan_Click);
            // 
            // listPlayers
            // 
            this.listPlayers.FormattingEnabled = true;
            this.listPlayers.Location = new System.Drawing.Point(6, 19);
            this.listPlayers.Name = "listPlayers";
            this.listPlayers.Size = new System.Drawing.Size(120, 160);
            this.listPlayers.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnSetTime);
            this.groupBox3.Controls.Add(this.strHour);
            this.groupBox3.Controls.Add(this.strDay);
            this.groupBox3.Controls.Add(this.trackHour);
            this.groupBox3.Controls.Add(this.trackDay);
            this.groupBox3.Location = new System.Drawing.Point(499, 233);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(327, 147);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Game Time";
            // 
            // btnSetTime
            // 
            this.btnSetTime.Location = new System.Drawing.Point(240, 118);
            this.btnSetTime.Name = "btnSetTime";
            this.btnSetTime.Size = new System.Drawing.Size(75, 23);
            this.btnSetTime.TabIndex = 4;
            this.btnSetTime.Text = "Set";
            this.btnSetTime.UseVisualStyleBackColor = true;
            this.btnSetTime.Click += new System.EventHandler(this.btnSetTime_Click);
            // 
            // strHour
            // 
            this.strHour.AutoSize = true;
            this.strHour.Location = new System.Drawing.Point(6, 64);
            this.strHour.Name = "strHour";
            this.strHour.Size = new System.Drawing.Size(30, 13);
            this.strHour.TabIndex = 3;
            this.strHour.Text = "Hour";
            // 
            // strDay
            // 
            this.strDay.AutoSize = true;
            this.strDay.Location = new System.Drawing.Point(6, 16);
            this.strDay.Name = "strDay";
            this.strDay.Size = new System.Drawing.Size(26, 13);
            this.strDay.TabIndex = 2;
            this.strDay.Text = "Day";
            // 
            // trackHour
            // 
            this.trackHour.Location = new System.Drawing.Point(6, 83);
            this.trackHour.Maximum = 23;
            this.trackHour.Name = "trackHour";
            this.trackHour.Size = new System.Drawing.Size(309, 45);
            this.trackHour.TabIndex = 1;
            this.trackHour.ValueChanged += new System.EventHandler(this.trackHour_ValueChanged);
            // 
            // trackDay
            // 
            this.trackDay.Location = new System.Drawing.Point(6, 32);
            this.trackDay.Maximum = 11;
            this.trackDay.Minimum = 1;
            this.trackDay.Name = "trackDay";
            this.trackDay.Size = new System.Drawing.Size(309, 45);
            this.trackDay.TabIndex = 0;
            this.trackDay.Value = 1;
            this.trackDay.ValueChanged += new System.EventHandler(this.trackDay_ValueChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button5);
            this.groupBox4.Controls.Add(this.button4);
            this.groupBox4.Controls.Add(this.comboItems);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.comboPlayers);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.btnRefresh2);
            this.groupBox4.Location = new System.Drawing.Point(499, 386);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(327, 128);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Spawning";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(6, 99);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(150, 23);
            this.button5.TabIndex = 13;
            this.button5.Text = "Horde!";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(165, 99);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(150, 23);
            this.button4.TabIndex = 12;
            this.button4.Text = "Spawn";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // comboItems
            // 
            this.comboItems.FormattingEnabled = true;
            this.comboItems.Location = new System.Drawing.Point(77, 72);
            this.comboItems.Name = "comboItems";
            this.comboItems.Size = new System.Drawing.Size(238, 21);
            this.comboItems.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Item / Mob:";
            // 
            // comboPlayers
            // 
            this.comboPlayers.FormattingEnabled = true;
            this.comboPlayers.Location = new System.Drawing.Point(77, 45);
            this.comboPlayers.Name = "comboPlayers";
            this.comboPlayers.Size = new System.Drawing.Size(238, 21);
            this.comboPlayers.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Near Player:";
            // 
            // btnRefresh2
            // 
            this.btnRefresh2.Location = new System.Drawing.Point(6, 19);
            this.btnRefresh2.Name = "btnRefresh2";
            this.btnRefresh2.Size = new System.Drawing.Size(309, 23);
            this.btnRefresh2.TabIndex = 7;
            this.btnRefresh2.Text = "Refresh Player List";
            this.btnRefresh2.UseVisualStyleBackColor = true;
            this.btnRefresh2.Click += new System.EventHandler(this.button3_Click);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnShutdown);
            this.groupBox5.Controls.Add(this.btnFreeRam);
            this.groupBox5.Controls.Add(this.groupBox7);
            this.groupBox5.Controls.Add(this.groupBox6);
            this.groupBox5.Location = new System.Drawing.Point(499, 520);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(327, 69);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Server Control";
            // 
            // btnShutdown
            // 
            this.btnShutdown.Location = new System.Drawing.Point(203, 40);
            this.btnShutdown.Name = "btnShutdown";
            this.btnShutdown.Size = new System.Drawing.Size(118, 23);
            this.btnShutdown.TabIndex = 3;
            this.btnShutdown.Text = "Shutdown";
            this.btnShutdown.UseVisualStyleBackColor = true;
            this.btnShutdown.Click += new System.EventHandler(this.btnShutdown_Click);
            // 
            // btnFreeRam
            // 
            this.btnFreeRam.Location = new System.Drawing.Point(203, 14);
            this.btnFreeRam.Name = "btnFreeRam";
            this.btnFreeRam.Size = new System.Drawing.Size(118, 23);
            this.btnFreeRam.TabIndex = 2;
            this.btnFreeRam.Text = "Free Ram";
            this.btnFreeRam.UseVisualStyleBackColor = true;
            this.btnFreeRam.Click += new System.EventHandler(this.btnFreeRam_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.btnDebugOFF);
            this.groupBox7.Controls.Add(this.btnDebugON);
            this.groupBox7.Location = new System.Drawing.Point(107, 19);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(90, 44);
            this.groupBox7.TabIndex = 1;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Debug Menu";
            // 
            // btnDebugOFF
            // 
            this.btnDebugOFF.BackColor = System.Drawing.Color.IndianRed;
            this.btnDebugOFF.Location = new System.Drawing.Point(46, 15);
            this.btnDebugOFF.Name = "btnDebugOFF";
            this.btnDebugOFF.Size = new System.Drawing.Size(34, 23);
            this.btnDebugOFF.TabIndex = 2;
            this.btnDebugOFF.Text = "Off";
            this.btnDebugOFF.UseVisualStyleBackColor = false;
            this.btnDebugOFF.Click += new System.EventHandler(this.btnDebugOFF_Click);
            // 
            // btnDebugON
            // 
            this.btnDebugON.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnDebugON.Location = new System.Drawing.Point(6, 15);
            this.btnDebugON.Name = "btnDebugON";
            this.btnDebugON.Size = new System.Drawing.Size(34, 23);
            this.btnDebugON.TabIndex = 2;
            this.btnDebugON.Text = "On";
            this.btnDebugON.UseVisualStyleBackColor = false;
            this.btnDebugON.Click += new System.EventHandler(this.btnDebugON_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnScopeOFF);
            this.groupBox6.Controls.Add(this.btnScopeON);
            this.groupBox6.Location = new System.Drawing.Point(12, 19);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(90, 44);
            this.groupBox6.TabIndex = 0;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Scope";
            // 
            // btnScopeOFF
            // 
            this.btnScopeOFF.BackColor = System.Drawing.Color.IndianRed;
            this.btnScopeOFF.Location = new System.Drawing.Point(46, 15);
            this.btnScopeOFF.Name = "btnScopeOFF";
            this.btnScopeOFF.Size = new System.Drawing.Size(34, 23);
            this.btnScopeOFF.TabIndex = 1;
            this.btnScopeOFF.Text = "Off";
            this.btnScopeOFF.UseVisualStyleBackColor = false;
            this.btnScopeOFF.Click += new System.EventHandler(this.btnScopeOFF_Click);
            // 
            // btnScopeON
            // 
            this.btnScopeON.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnScopeON.Location = new System.Drawing.Point(6, 15);
            this.btnScopeON.Name = "btnScopeON";
            this.btnScopeON.Size = new System.Drawing.Size(34, 23);
            this.btnScopeON.TabIndex = 0;
            this.btnScopeON.Text = "On";
            this.btnScopeON.UseVisualStyleBackColor = false;
            this.btnScopeON.Click += new System.EventHandler(this.btnScopeON_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 601);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.panelPlayers);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "7DTD Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panelPlayers.ResumeLayout(false);
            this.panelPlayers.PerformLayout();
            this.panelBanTime.ResumeLayout(false);
            this.panelBanTime.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBanTime)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackDay)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox strPass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox strPort;
        private System.Windows.Forms.Label strStatus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox strCmd;
        private System.Windows.Forms.RichTextBox strConsole;
        private System.Windows.Forms.GroupBox panelPlayers;
        private System.Windows.Forms.ListBox listPlayers;
        private System.Windows.Forms.GroupBox panelBanTime;
        private System.Windows.Forms.TrackBar trackBanTime;
        private System.Windows.Forms.TextBox strReason;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnKick;
        private System.Windows.Forms.Button btnBan;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnSetTime;
        private System.Windows.Forms.Label strHour;
        private System.Windows.Forms.Label strDay;
        private System.Windows.Forms.TrackBar trackHour;
        private System.Windows.Forms.TrackBar trackDay;
        private System.Windows.Forms.ComboBox comboPeriod;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox comboItems;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboPlayers;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnRefresh2;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnScopeOFF;
        private System.Windows.Forms.Button btnScopeON;
        private System.Windows.Forms.Button btnShutdown;
        private System.Windows.Forms.Button btnFreeRam;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button btnDebugOFF;
        private System.Windows.Forms.Button btnDebugON;
        private System.Windows.Forms.Button btnKickall;
        private System.Windows.Forms.ComboBox comboHost;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox strHost;


    }
}

