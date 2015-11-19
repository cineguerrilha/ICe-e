namespace USB_Scope
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.tmrDraw = new System.Windows.Forms.Timer(this.components);
            this.sbrMyStatusStrip = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.chkChannel1 = new System.Windows.Forms.CheckBox();
            this.chkChannel2 = new System.Windows.Forms.CheckBox();
            this.chkChannel3 = new System.Windows.Forms.CheckBox();
            this.chkChannel4 = new System.Windows.Forms.CheckBox();
            this.chkChannel5 = new System.Windows.Forms.CheckBox();
            this.chkChannel6 = new System.Windows.Forms.CheckBox();
            this.chkChannel7 = new System.Windows.Forms.CheckBox();
            this.chkChannel8 = new System.Windows.Forms.CheckBox();
            this.chkChannel9 = new System.Windows.Forms.CheckBox();
            this.chkChannel10 = new System.Windows.Forms.CheckBox();
            this.chkChannel11 = new System.Windows.Forms.CheckBox();
            this.chkChannel12 = new System.Windows.Forms.CheckBox();
            this.chkChannel13 = new System.Windows.Forms.CheckBox();
            this.chkChannel14 = new System.Windows.Forms.CheckBox();
            this.chkChannel15 = new System.Windows.Forms.CheckBox();
            this.chkChannel16 = new System.Windows.Forms.CheckBox();
            this.btnAllChannelsOff = new System.Windows.Forms.Button();
            this.btnAllChannelsOn = new System.Windows.Forms.Button();
            this.lblAmpChannel = new System.Windows.Forms.Label();
            this.lblYScale = new System.Windows.Forms.Label();
            this.btnZoomOut = new System.Windows.Forms.Button();
            this.btnZoomIn = new System.Windows.Forms.Button();
            this.lblXScale = new System.Windows.Forms.Label();
            this.btnXZoomIn = new System.Windows.Forms.Button();
            this.btnXZoomOut = new System.Windows.Forms.Button();
            this.chkSettle = new System.Windows.Forms.CheckBox();
            this.btnZCheck = new System.Windows.Forms.Button();
            this.txtHPF = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.txtSaveFilename = new System.Windows.Forms.TextBox();
            this.btnSelectFilename = new System.Windows.Forms.Button();
            this.btnRecord = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkEnableHPF = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnNotchFilter60Hz = new System.Windows.Forms.RadioButton();
            this.btnNotchFilter50Hz = new System.Windows.Forms.RadioButton();
            this.btnNotchFilterDisable = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numMaxMinutes = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnSpikeWindow = new System.Windows.Forms.Button();
            this.tmrSynthData = new System.Windows.Forms.Timer(this.components);
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SaveCheckBox = new System.Windows.Forms.CheckBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.sbrMyStatusStrip.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxMinutes)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(843, 148);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 24);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(939, 148);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 24);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(933, 698);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(75, 23);
            this.btnQuit.TabIndex = 2;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // tmrDraw
            // 
            this.tmrDraw.Enabled = true;
            this.tmrDraw.Interval = 5;
            this.tmrDraw.Tick += new System.EventHandler(this.tmrDraw_Tick);
            // 
            // sbrMyStatusStrip
            // 
            this.sbrMyStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.sbrMyStatusStrip.Location = new System.Drawing.Point(0, 721);
            this.sbrMyStatusStrip.Name = "sbrMyStatusStrip";
            this.sbrMyStatusStrip.Padding = new System.Windows.Forms.Padding(2, 0, 14, 0);
            this.sbrMyStatusStrip.Size = new System.Drawing.Size(1014, 22);
            this.sbrMyStatusStrip.SizingGrip = false;
            this.sbrMyStatusStrip.TabIndex = 3;
            this.sbrMyStatusStrip.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(82, 17);
            this.lblStatus.Text = "Ready to start.";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1014, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem1});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.aboutToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(172, 22);
            this.aboutToolStripMenuItem1.Text = "&About Intan Demo";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem1_Click);
            // 
            // chkChannel1
            // 
            this.chkChannel1.AutoSize = true;
            this.chkChannel1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkChannel1.Checked = true;
            this.chkChannel1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkChannel1.Location = new System.Drawing.Point(18, 50);
            this.chkChannel1.Name = "chkChannel1";
            this.chkChannel1.Size = new System.Drawing.Size(32, 17);
            this.chkChannel1.TabIndex = 4;
            this.chkChannel1.Text = "1";
            this.chkChannel1.UseVisualStyleBackColor = true;
            // 
            // chkChannel2
            // 
            this.chkChannel2.AutoSize = true;
            this.chkChannel2.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkChannel2.Checked = true;
            this.chkChannel2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkChannel2.Location = new System.Drawing.Point(18, 91);
            this.chkChannel2.Name = "chkChannel2";
            this.chkChannel2.Size = new System.Drawing.Size(32, 17);
            this.chkChannel2.TabIndex = 5;
            this.chkChannel2.Text = "2";
            this.chkChannel2.UseVisualStyleBackColor = true;
            // 
            // chkChannel3
            // 
            this.chkChannel3.AutoSize = true;
            this.chkChannel3.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkChannel3.Checked = true;
            this.chkChannel3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkChannel3.Location = new System.Drawing.Point(18, 132);
            this.chkChannel3.Name = "chkChannel3";
            this.chkChannel3.Size = new System.Drawing.Size(32, 17);
            this.chkChannel3.TabIndex = 6;
            this.chkChannel3.Text = "3";
            this.chkChannel3.UseVisualStyleBackColor = true;
            // 
            // chkChannel4
            // 
            this.chkChannel4.AutoSize = true;
            this.chkChannel4.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkChannel4.Checked = true;
            this.chkChannel4.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkChannel4.Location = new System.Drawing.Point(18, 171);
            this.chkChannel4.Name = "chkChannel4";
            this.chkChannel4.Size = new System.Drawing.Size(32, 17);
            this.chkChannel4.TabIndex = 7;
            this.chkChannel4.Text = "4";
            this.chkChannel4.UseVisualStyleBackColor = true;
            // 
            // chkChannel5
            // 
            this.chkChannel5.AutoSize = true;
            this.chkChannel5.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkChannel5.Checked = true;
            this.chkChannel5.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkChannel5.Location = new System.Drawing.Point(18, 211);
            this.chkChannel5.Name = "chkChannel5";
            this.chkChannel5.Size = new System.Drawing.Size(32, 17);
            this.chkChannel5.TabIndex = 8;
            this.chkChannel5.Text = "5";
            this.chkChannel5.UseVisualStyleBackColor = true;
            // 
            // chkChannel6
            // 
            this.chkChannel6.AutoSize = true;
            this.chkChannel6.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkChannel6.Checked = true;
            this.chkChannel6.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkChannel6.Location = new System.Drawing.Point(18, 251);
            this.chkChannel6.Name = "chkChannel6";
            this.chkChannel6.Size = new System.Drawing.Size(32, 17);
            this.chkChannel6.TabIndex = 9;
            this.chkChannel6.Text = "6";
            this.chkChannel6.UseVisualStyleBackColor = true;
            // 
            // chkChannel7
            // 
            this.chkChannel7.AutoSize = true;
            this.chkChannel7.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkChannel7.Checked = true;
            this.chkChannel7.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkChannel7.Location = new System.Drawing.Point(18, 291);
            this.chkChannel7.Name = "chkChannel7";
            this.chkChannel7.Size = new System.Drawing.Size(32, 17);
            this.chkChannel7.TabIndex = 10;
            this.chkChannel7.Text = "7";
            this.chkChannel7.UseVisualStyleBackColor = true;
            // 
            // chkChannel8
            // 
            this.chkChannel8.AutoSize = true;
            this.chkChannel8.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkChannel8.Checked = true;
            this.chkChannel8.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkChannel8.Location = new System.Drawing.Point(18, 331);
            this.chkChannel8.Name = "chkChannel8";
            this.chkChannel8.Size = new System.Drawing.Size(32, 17);
            this.chkChannel8.TabIndex = 11;
            this.chkChannel8.Text = "8";
            this.chkChannel8.UseVisualStyleBackColor = true;
            // 
            // chkChannel9
            // 
            this.chkChannel9.AutoSize = true;
            this.chkChannel9.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkChannel9.Checked = true;
            this.chkChannel9.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkChannel9.Location = new System.Drawing.Point(18, 371);
            this.chkChannel9.Name = "chkChannel9";
            this.chkChannel9.Size = new System.Drawing.Size(32, 17);
            this.chkChannel9.TabIndex = 12;
            this.chkChannel9.Text = "9";
            this.chkChannel9.UseVisualStyleBackColor = true;
            // 
            // chkChannel10
            // 
            this.chkChannel10.AutoSize = true;
            this.chkChannel10.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkChannel10.Checked = true;
            this.chkChannel10.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkChannel10.Location = new System.Drawing.Point(12, 411);
            this.chkChannel10.Name = "chkChannel10";
            this.chkChannel10.Size = new System.Drawing.Size(38, 17);
            this.chkChannel10.TabIndex = 13;
            this.chkChannel10.Text = "10";
            this.chkChannel10.UseVisualStyleBackColor = true;
            // 
            // chkChannel11
            // 
            this.chkChannel11.AutoSize = true;
            this.chkChannel11.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkChannel11.Checked = true;
            this.chkChannel11.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkChannel11.Location = new System.Drawing.Point(12, 451);
            this.chkChannel11.Name = "chkChannel11";
            this.chkChannel11.Size = new System.Drawing.Size(38, 17);
            this.chkChannel11.TabIndex = 14;
            this.chkChannel11.Text = "11";
            this.chkChannel11.UseVisualStyleBackColor = true;
            // 
            // chkChannel12
            // 
            this.chkChannel12.AutoSize = true;
            this.chkChannel12.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkChannel12.Checked = true;
            this.chkChannel12.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkChannel12.Location = new System.Drawing.Point(12, 491);
            this.chkChannel12.Name = "chkChannel12";
            this.chkChannel12.Size = new System.Drawing.Size(38, 17);
            this.chkChannel12.TabIndex = 15;
            this.chkChannel12.Text = "12";
            this.chkChannel12.UseVisualStyleBackColor = true;
            // 
            // chkChannel13
            // 
            this.chkChannel13.AutoSize = true;
            this.chkChannel13.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkChannel13.Checked = true;
            this.chkChannel13.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkChannel13.Location = new System.Drawing.Point(12, 531);
            this.chkChannel13.Name = "chkChannel13";
            this.chkChannel13.Size = new System.Drawing.Size(38, 17);
            this.chkChannel13.TabIndex = 16;
            this.chkChannel13.Text = "13";
            this.chkChannel13.UseVisualStyleBackColor = true;
            // 
            // chkChannel14
            // 
            this.chkChannel14.AutoSize = true;
            this.chkChannel14.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkChannel14.Checked = true;
            this.chkChannel14.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkChannel14.Location = new System.Drawing.Point(12, 570);
            this.chkChannel14.Name = "chkChannel14";
            this.chkChannel14.Size = new System.Drawing.Size(38, 17);
            this.chkChannel14.TabIndex = 17;
            this.chkChannel14.Text = "14";
            this.chkChannel14.UseVisualStyleBackColor = true;
            // 
            // chkChannel15
            // 
            this.chkChannel15.AutoSize = true;
            this.chkChannel15.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkChannel15.Checked = true;
            this.chkChannel15.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkChannel15.Location = new System.Drawing.Point(12, 611);
            this.chkChannel15.Name = "chkChannel15";
            this.chkChannel15.Size = new System.Drawing.Size(38, 17);
            this.chkChannel15.TabIndex = 18;
            this.chkChannel15.Text = "15";
            this.chkChannel15.UseVisualStyleBackColor = true;
            // 
            // chkChannel16
            // 
            this.chkChannel16.AutoSize = true;
            this.chkChannel16.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkChannel16.Checked = true;
            this.chkChannel16.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkChannel16.Location = new System.Drawing.Point(12, 652);
            this.chkChannel16.Name = "chkChannel16";
            this.chkChannel16.Size = new System.Drawing.Size(38, 17);
            this.chkChannel16.TabIndex = 19;
            this.chkChannel16.Text = "16";
            this.chkChannel16.UseVisualStyleBackColor = true;
            // 
            // btnAllChannelsOff
            // 
            this.btnAllChannelsOff.Location = new System.Drawing.Point(5, 669);
            this.btnAllChannelsOff.Name = "btnAllChannelsOff";
            this.btnAllChannelsOff.Size = new System.Drawing.Size(57, 23);
            this.btnAllChannelsOff.TabIndex = 20;
            this.btnAllChannelsOff.Text = "Hide All";
            this.btnAllChannelsOff.UseVisualStyleBackColor = true;
            this.btnAllChannelsOff.Click += new System.EventHandler(this.btnAllChannelsOff_Click);
            // 
            // btnAllChannelsOn
            // 
            this.btnAllChannelsOn.Location = new System.Drawing.Point(5, 698);
            this.btnAllChannelsOn.Name = "btnAllChannelsOn";
            this.btnAllChannelsOn.Size = new System.Drawing.Size(57, 23);
            this.btnAllChannelsOn.TabIndex = 21;
            this.btnAllChannelsOn.Text = "Show All";
            this.btnAllChannelsOn.UseVisualStyleBackColor = true;
            this.btnAllChannelsOn.Click += new System.EventHandler(this.btnAllChannelsOn_Click);
            // 
            // lblAmpChannel
            // 
            this.lblAmpChannel.AutoSize = true;
            this.lblAmpChannel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmpChannel.Location = new System.Drawing.Point(44, 24);
            this.lblAmpChannel.Name = "lblAmpChannel";
            this.lblAmpChannel.Size = new System.Drawing.Size(70, 13);
            this.lblAmpChannel.TabIndex = 33;
            this.lblAmpChannel.Text = "Amp Channel";
            // 
            // lblYScale
            // 
            this.lblYScale.AutoSize = true;
            this.lblYScale.Location = new System.Drawing.Point(834, 48);
            this.lblYScale.Name = "lblYScale";
            this.lblYScale.Size = new System.Drawing.Size(41, 13);
            this.lblYScale.TabIndex = 34;
            this.lblYScale.Text = "100 uV";
            // 
            // btnZoomOut
            // 
            this.btnZoomOut.Location = new System.Drawing.Point(939, 27);
            this.btnZoomOut.Name = "btnZoomOut";
            this.btnZoomOut.Size = new System.Drawing.Size(63, 23);
            this.btnZoomOut.TabIndex = 23;
            this.btnZoomOut.Text = "Zoom Out";
            this.btnZoomOut.UseVisualStyleBackColor = true;
            this.btnZoomOut.Click += new System.EventHandler(this.btnZoomOut_Click);
            // 
            // btnZoomIn
            // 
            this.btnZoomIn.Location = new System.Drawing.Point(870, 27);
            this.btnZoomIn.Name = "btnZoomIn";
            this.btnZoomIn.Size = new System.Drawing.Size(63, 23);
            this.btnZoomIn.TabIndex = 22;
            this.btnZoomIn.Text = "Zoom In";
            this.btnZoomIn.UseVisualStyleBackColor = true;
            this.btnZoomIn.Click += new System.EventHandler(this.btnZoomIn_Click);
            // 
            // lblXScale
            // 
            this.lblXScale.AutoSize = true;
            this.lblXScale.Location = new System.Drawing.Point(809, 669);
            this.lblXScale.Name = "lblXScale";
            this.lblXScale.Size = new System.Drawing.Size(47, 13);
            this.lblXScale.TabIndex = 37;
            this.lblXScale.Text = "10 msec";
            // 
            // btnXZoomIn
            // 
            this.btnXZoomIn.Location = new System.Drawing.Point(795, 692);
            this.btnXZoomIn.Name = "btnXZoomIn";
            this.btnXZoomIn.Size = new System.Drawing.Size(63, 23);
            this.btnXZoomIn.TabIndex = 29;
            this.btnXZoomIn.Text = "Zoom In";
            this.btnXZoomIn.UseVisualStyleBackColor = true;
            this.btnXZoomIn.Click += new System.EventHandler(this.btnXZoomIn_Click);
            // 
            // btnXZoomOut
            // 
            this.btnXZoomOut.Location = new System.Drawing.Point(864, 692);
            this.btnXZoomOut.Name = "btnXZoomOut";
            this.btnXZoomOut.Size = new System.Drawing.Size(63, 23);
            this.btnXZoomOut.TabIndex = 30;
            this.btnXZoomOut.Text = "Zoom Out";
            this.btnXZoomOut.UseVisualStyleBackColor = true;
            this.btnXZoomOut.Click += new System.EventHandler(this.btnXZoomOut_Click);
            // 
            // chkSettle
            // 
            this.chkSettle.AutoSize = true;
            this.chkSettle.Location = new System.Drawing.Point(14, 19);
            this.chkSettle.Name = "chkSettle";
            this.chkSettle.Size = new System.Drawing.Size(112, 17);
            this.chkSettle.TabIndex = 40;
            this.chkSettle.Text = "Amplifier Settle On";
            this.chkSettle.UseVisualStyleBackColor = true;
            this.chkSettle.CheckedChanged += new System.EventHandler(this.chkSettle_CheckedChanged);
            // 
            // btnZCheck
            // 
            this.btnZCheck.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnZCheck.Location = new System.Drawing.Point(12, 48);
            this.btnZCheck.Name = "btnZCheck";
            this.btnZCheck.Size = new System.Drawing.Size(150, 23);
            this.btnZCheck.TabIndex = 41;
            this.btnZCheck.Text = "Electrode Impedance Test";
            this.btnZCheck.UseVisualStyleBackColor = true;
            this.btnZCheck.Click += new System.EventHandler(this.btnZCheck_Click);
            // 
            // txtHPF
            // 
            this.txtHPF.AcceptsReturn = true;
            this.txtHPF.Location = new System.Drawing.Point(40, 69);
            this.txtHPF.Name = "txtHPF";
            this.txtHPF.Size = new System.Drawing.Size(50, 20);
            this.txtHPF.TabIndex = 1;
            this.txtHPF.Text = "1.0";
            this.txtHPF.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtHPF.TextChanged += new System.EventHandler(this.txtHPF_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 43;
            this.label1.Text = "Hz";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 13);
            this.label2.TabIndex = 44;
            this.label2.Text = "Software High-Pass Filter Cutoff:";
            // 
            // txtSaveFilename
            // 
            this.txtSaveFilename.Location = new System.Drawing.Point(16, 48);
            this.txtSaveFilename.Name = "txtSaveFilename";
            this.txtSaveFilename.ReadOnly = true;
            this.txtSaveFilename.Size = new System.Drawing.Size(180, 20);
            this.txtSaveFilename.TabIndex = 1;
            this.txtSaveFilename.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnSelectFilename
            // 
            this.btnSelectFilename.Location = new System.Drawing.Point(76, 19);
            this.btnSelectFilename.Name = "btnSelectFilename";
            this.btnSelectFilename.Size = new System.Drawing.Size(120, 23);
            this.btnSelectFilename.TabIndex = 0;
            this.btnSelectFilename.Text = "Select Base Filename";
            this.btnSelectFilename.UseVisualStyleBackColor = true;
            this.btnSelectFilename.Click += new System.EventHandler(this.btnSelectFilename_Click);
            // 
            // btnRecord
            // 
            this.btnRecord.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btnRecord.Location = new System.Drawing.Point(122, 128);
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.Size = new System.Drawing.Size(75, 23);
            this.btnRecord.TabIndex = 3;
            this.btnRecord.Text = "Record";
            this.btnRecord.UseVisualStyleBackColor = true;
            this.btnRecord.Click += new System.EventHandler(this.btnRecord_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkEnableHPF);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtHPF);
            this.groupBox1.Location = new System.Drawing.Point(843, 264);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(171, 97);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Software Offset Removal";
            // 
            // chkEnableHPF
            // 
            this.chkEnableHPF.AutoSize = true;
            this.chkEnableHPF.Checked = true;
            this.chkEnableHPF.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkEnableHPF.Location = new System.Drawing.Point(14, 22);
            this.chkEnableHPF.Name = "chkEnableHPF";
            this.chkEnableHPF.Size = new System.Drawing.Size(59, 17);
            this.chkEnableHPF.TabIndex = 0;
            this.chkEnableHPF.Text = "Enable";
            this.chkEnableHPF.UseVisualStyleBackColor = true;
            this.chkEnableHPF.CheckedChanged += new System.EventHandler(this.chkEnableHPF_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.comboBox2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.btnNotchFilter60Hz);
            this.groupBox2.Controls.Add(this.btnNotchFilter50Hz);
            this.groupBox2.Controls.Add(this.btnNotchFilterDisable);
            this.groupBox2.Location = new System.Drawing.Point(843, 371);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(171, 97);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Software Notch Filter";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(94, 18);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(67, 22);
            this.button2.TabIndex = 57;
            this.button2.Text = "Laser On";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6",
            "COM7",
            "COM8",
            "COM9",
            "COM10",
            "COM11",
            "COM12",
            "COM13",
            "COM14"});
            this.comboBox2.Location = new System.Drawing.Point(93, 46);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(69, 21);
            this.comboBox2.TabIndex = 56;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(91, 67);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 55;
            this.button1.Text = "ARDUINO";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnNotchFilter60Hz
            // 
            this.btnNotchFilter60Hz.AutoSize = true;
            this.btnNotchFilter60Hz.Location = new System.Drawing.Point(6, 67);
            this.btnNotchFilter60Hz.Name = "btnNotchFilter60Hz";
            this.btnNotchFilter60Hz.Size = new System.Drawing.Size(53, 17);
            this.btnNotchFilter60Hz.TabIndex = 2;
            this.btnNotchFilter60Hz.Text = "60 Hz";
            this.btnNotchFilter60Hz.UseVisualStyleBackColor = true;
            this.btnNotchFilter60Hz.CheckedChanged += new System.EventHandler(this.btnNotchFilter60Hz_CheckedChanged);
            // 
            // btnNotchFilter50Hz
            // 
            this.btnNotchFilter50Hz.AutoSize = true;
            this.btnNotchFilter50Hz.Location = new System.Drawing.Point(6, 43);
            this.btnNotchFilter50Hz.Name = "btnNotchFilter50Hz";
            this.btnNotchFilter50Hz.Size = new System.Drawing.Size(53, 17);
            this.btnNotchFilter50Hz.TabIndex = 1;
            this.btnNotchFilter50Hz.Text = "50 Hz";
            this.btnNotchFilter50Hz.UseVisualStyleBackColor = true;
            this.btnNotchFilter50Hz.CheckedChanged += new System.EventHandler(this.btnNotchFilter50Hz_CheckedChanged);
            // 
            // btnNotchFilterDisable
            // 
            this.btnNotchFilterDisable.AutoSize = true;
            this.btnNotchFilterDisable.Checked = true;
            this.btnNotchFilterDisable.Location = new System.Drawing.Point(6, 19);
            this.btnNotchFilterDisable.Name = "btnNotchFilterDisable";
            this.btnNotchFilterDisable.Size = new System.Drawing.Size(58, 17);
            this.btnNotchFilterDisable.TabIndex = 0;
            this.btnNotchFilterDisable.TabStop = true;
            this.btnNotchFilterDisable.Text = "disable";
            this.btnNotchFilterDisable.UseVisualStyleBackColor = true;
            this.btnNotchFilterDisable.CheckedChanged += new System.EventHandler(this.btnNotchFilterDisable_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chkSettle);
            this.groupBox3.Controls.Add(this.btnZCheck);
            this.groupBox3.Location = new System.Drawing.Point(843, 179);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(171, 80);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Hardware Functions";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 13);
            this.label3.TabIndex = 51;
            this.label3.Text = "(Date and time stamp will be added)";
            // 
            // numMaxMinutes
            // 
            this.numMaxMinutes.DecimalPlaces = 1;
            this.numMaxMinutes.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numMaxMinutes.Location = new System.Drawing.Point(106, 95);
            this.numMaxMinutes.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numMaxMinutes.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numMaxMinutes.Name = "numMaxMinutes";
            this.numMaxMinutes.Size = new System.Drawing.Size(43, 20);
            this.numMaxMinutes.TabIndex = 2;
            this.numMaxMinutes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numMaxMinutes.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numMaxMinutes.ValueChanged += new System.EventHandler(this.numMaxMinutes_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 53;
            this.label4.Text = "Start new file every";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(153, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 54;
            this.label5.Text = "Seconds";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.comboBox1);
            this.groupBox4.Controls.Add(this.btnSelectFilename);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.numMaxMinutes);
            this.groupBox4.Controls.Add(this.txtSaveFilename);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.btnRecord);
            this.groupBox4.Location = new System.Drawing.Point(812, 474);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(202, 158);
            this.groupBox4.TabIndex = 27;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Save to Disk";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 116);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 43;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "2",
            "4",
            "8",
            "16",
            "33"});
            this.comboBox1.Location = new System.Drawing.Point(14, 132);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(96, 21);
            this.comboBox1.TabIndex = 55;
            this.comboBox1.Text = "0";
            // 
            // btnSpikeWindow
            // 
            this.btnSpikeWindow.Location = new System.Drawing.Point(898, 119);
            this.btnSpikeWindow.Name = "btnSpikeWindow";
            this.btnSpikeWindow.Size = new System.Drawing.Size(115, 23);
            this.btnSpikeWindow.TabIndex = 28;
            this.btnSpikeWindow.Text = "Open Spike Scope";
            this.btnSpikeWindow.UseVisualStyleBackColor = true;
            this.btnSpikeWindow.Click += new System.EventHandler(this.btnSpikeWindow_Click);
            // 
            // tmrSynthData
            // 
            this.tmrSynthData.Interval = 30;
            this.tmrSynthData.Tick += new System.EventHandler(this.tmrSynthData_Tick);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(836, 93);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(46, 17);
            this.checkBox1.TabIndex = 38;
            this.checkBox1.Text = "pipe";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // SaveCheckBox
            // 
            this.SaveCheckBox.AutoSize = true;
            this.SaveCheckBox.Location = new System.Drawing.Point(837, 72);
            this.SaveCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.SaveCheckBox.Name = "SaveCheckBox";
            this.SaveCheckBox.Size = new System.Drawing.Size(113, 17);
            this.SaveCheckBox.TabIndex = 39;
            this.SaveCheckBox.Text = "Save continuously";
            this.SaveCheckBox.UseVisualStyleBackColor = true;
            this.SaveCheckBox.CheckedChanged += new System.EventHandler(this.SaveCheckBox_CheckedChanged);
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBox3.Location = new System.Drawing.Point(895, 647);
            this.comboBox3.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(50, 21);
            this.comboBox3.TabIndex = 40;
            this.comboBox3.Text = "2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(826, 649);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 41;
            this.label6.Text = "Laser power";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(951, 648);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(56, 19);
            this.button3.TabIndex = 42;
            this.button3.Text = "Update";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(837, 114);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(57, 17);
            this.checkBox2.TabIndex = 43;
            this.checkBox2.Text = "matlab";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1028, 614);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.SaveCheckBox);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btnSpikeWindow);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnXZoomOut);
            this.Controls.Add(this.btnXZoomIn);
            this.Controls.Add(this.lblXScale);
            this.Controls.Add(this.btnZoomIn);
            this.Controls.Add(this.btnZoomOut);
            this.Controls.Add(this.lblYScale);
            this.Controls.Add(this.lblAmpChannel);
            this.Controls.Add(this.btnAllChannelsOn);
            this.Controls.Add(this.btnAllChannelsOff);
            this.Controls.Add(this.chkChannel16);
            this.Controls.Add(this.chkChannel15);
            this.Controls.Add(this.chkChannel14);
            this.Controls.Add(this.chkChannel13);
            this.Controls.Add(this.chkChannel12);
            this.Controls.Add(this.chkChannel11);
            this.Controls.Add(this.chkChannel10);
            this.Controls.Add(this.chkChannel9);
            this.Controls.Add(this.chkChannel8);
            this.Controls.Add(this.chkChannel7);
            this.Controls.Add(this.chkChannel6);
            this.Controls.Add(this.chkChannel5);
            this.Controls.Add(this.chkChannel4);
            this.Controls.Add(this.chkChannel3);
            this.Controls.Add(this.chkChannel2);
            this.Controls.Add(this.chkChannel1);
            this.Controls.Add(this.sbrMyStatusStrip);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Intan Arduino V1.0";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MainForm_Paint);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseClick);
            this.sbrMyStatusStrip.ResumeLayout(false);
            this.sbrMyStatusStrip.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxMinutes)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Timer tmrDraw;
        private System.Windows.Forms.StatusStrip sbrMyStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.CheckBox chkChannel1;
        private System.Windows.Forms.CheckBox chkChannel2;
        private System.Windows.Forms.CheckBox chkChannel3;
        private System.Windows.Forms.CheckBox chkChannel4;
        private System.Windows.Forms.CheckBox chkChannel5;
        private System.Windows.Forms.CheckBox chkChannel6;
        private System.Windows.Forms.CheckBox chkChannel7;
        private System.Windows.Forms.CheckBox chkChannel8;
        private System.Windows.Forms.CheckBox chkChannel9;
        private System.Windows.Forms.CheckBox chkChannel10;
        private System.Windows.Forms.CheckBox chkChannel11;
        private System.Windows.Forms.CheckBox chkChannel12;
        private System.Windows.Forms.CheckBox chkChannel13;
        private System.Windows.Forms.CheckBox chkChannel14;
        private System.Windows.Forms.CheckBox chkChannel15;
        private System.Windows.Forms.CheckBox chkChannel16;
        private System.Windows.Forms.Button btnAllChannelsOff;
        private System.Windows.Forms.Button btnAllChannelsOn;
        private System.Windows.Forms.Label lblAmpChannel;
        private System.Windows.Forms.Label lblYScale;
        private System.Windows.Forms.Button btnZoomOut;
        private System.Windows.Forms.Button btnZoomIn;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.Label lblXScale;
        private System.Windows.Forms.Button btnXZoomIn;
        private System.Windows.Forms.Button btnXZoomOut;
        private System.Windows.Forms.CheckBox chkSettle;
        private System.Windows.Forms.Button btnZCheck;
        private System.Windows.Forms.TextBox txtHPF;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TextBox txtSaveFilename;
        private System.Windows.Forms.Button btnSelectFilename;
        private System.Windows.Forms.Button btnRecord;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkEnableHPF;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton btnNotchFilter60Hz;
        private System.Windows.Forms.RadioButton btnNotchFilter50Hz;
        private System.Windows.Forms.RadioButton btnNotchFilterDisable;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numMaxMinutes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnSpikeWindow;
        private System.Windows.Forms.Timer tmrSynthData;
        private System.Windows.Forms.Button button1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox SaveCheckBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.CheckBox checkBox2;
    }
}

