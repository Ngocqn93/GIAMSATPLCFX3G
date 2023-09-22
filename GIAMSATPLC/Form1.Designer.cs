namespace GIAMSATPLCFX3G
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Code = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btt_Connect = new System.Windows.Forms.Button();
            this.btt_Disconnect = new System.Windows.Forms.Button();
            this.btt_Check = new System.Windows.Forms.Button();
            this.Timer_Watchdog = new System.Windows.Forms.Timer(this.components);
            this.sym_Lamp_PLC = new SymbolFactoryDotNet.StandardControl();
            this.label4 = new System.Windows.Forms.Label();
            this.sym_Lamp_Error = new SymbolFactoryDotNet.StandardControl();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_VT = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.tbx_settingspeed = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.tbx_settingtoado = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.tbx_speedjog = new System.Windows.Forms.TextBox();
            this.sym_Lamp_servorun = new SymbolFactoryDotNet.StandardControl();
            this.label25 = new System.Windows.Forms.Label();
            this.btt_Edit = new System.Windows.Forms.Button();
            this.btt_Save = new System.Windows.Forms.Button();
            this.sym_btt_JOG2 = new System.Windows.Forms.Button();
            this.sym_btt_JOG3 = new System.Windows.Forms.Button();
            this.sym_btt_home = new System.Windows.Forms.Button();
            this.sym_btt_goabs = new System.Windows.Forms.Button();
            this.sym_btt_goinc = new System.Windows.Forms.Button();
            this.sym_btt_sethome = new System.Windows.Forms.Button();
            this.sym_btt_AM = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btt_Logout = new System.Windows.Forms.Button();
            this.btt_Login = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btt_SQLSave = new System.Windows.Forms.Button();
            this.btt_SQLEdit = new System.Windows.Forms.Button();
            this.tbx_DBName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btt_Showdata = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txt_ND = new System.Windows.Forms.TextBox();
            this.grb_SortbyTime = new System.Windows.Forms.GroupBox();
            this.dtpk_TimeEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpk_TimeStart = new System.Windows.Forms.DateTimePicker();
            this.dtpk_DateEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpk_DateStart = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btt_Search = new System.Windows.Forms.Button();
            this.btt_report1 = new System.Windows.Forms.Button();
            this.btt_excel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sym_Lamp_PLC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sym_Lamp_Error)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sym_Lamp_servorun)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grb_SortbyTime.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(301, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(508, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "GIÁM SÁT VÀ ĐIỀU KHIỂN  SERVO";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(96, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "MÃ LỖI PLC";
            // 
            // txt_Code
            // 
            this.txt_Code.Location = new System.Drawing.Point(69, 101);
            this.txt_Code.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Code.Name = "txt_Code";
            this.txt_Code.ReadOnly = true;
            this.txt_Code.Size = new System.Drawing.Size(181, 22);
            this.txt_Code.TabIndex = 2;
            this.txt_Code.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(58, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "HIỂN THỊ NỘI DUNG";
            // 
            // btt_Connect
            // 
            this.btt_Connect.Location = new System.Drawing.Point(22, 98);
            this.btt_Connect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btt_Connect.Name = "btt_Connect";
            this.btt_Connect.Size = new System.Drawing.Size(106, 38);
            this.btt_Connect.TabIndex = 3;
            this.btt_Connect.Text = "CONNECT";
            this.btt_Connect.UseVisualStyleBackColor = true;
            this.btt_Connect.Click += new System.EventHandler(this.btt_Connect_Click);
            // 
            // btt_Disconnect
            // 
            this.btt_Disconnect.Location = new System.Drawing.Point(147, 98);
            this.btt_Disconnect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btt_Disconnect.Name = "btt_Disconnect";
            this.btt_Disconnect.Size = new System.Drawing.Size(115, 38);
            this.btt_Disconnect.TabIndex = 3;
            this.btt_Disconnect.Text = "DISCONNECT";
            this.btt_Disconnect.UseVisualStyleBackColor = true;
            this.btt_Disconnect.Click += new System.EventHandler(this.btt_Disconnect_Click);
            // 
            // btt_Check
            // 
            this.btt_Check.Location = new System.Drawing.Point(22, 157);
            this.btt_Check.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btt_Check.Name = "btt_Check";
            this.btt_Check.Size = new System.Drawing.Size(106, 47);
            this.btt_Check.TabIndex = 4;
            this.btt_Check.Text = "CHECK ERROR";
            this.btt_Check.UseVisualStyleBackColor = true;
            this.btt_Check.Click += new System.EventHandler(this.btt_Check_Click);
            // 
            // Timer_Watchdog
            // 
            this.Timer_Watchdog.Enabled = true;
            this.Timer_Watchdog.Interval = 3000;
            this.Timer_Watchdog.Tick += new System.EventHandler(this.Timer_Watchdog_Tick_1);
            // 
            // sym_Lamp_PLC
            // 
            this.sym_Lamp_PLC.AnalogIntValue1 = ((short)(0));
            this.sym_Lamp_PLC.AnalogValue1 = 0D;
            this.sym_Lamp_PLC.AnimationMode = SymbolFactoryNetEngine.AnimationModeOptions.DiscreteColorFill;
            this.sym_Lamp_PLC.BackColor = System.Drawing.Color.Transparent;
            this.sym_Lamp_PLC.BackStyle = SymbolFactoryNetEngine.BackStyleOptions.Transparent;
            this.sym_Lamp_PLC.BandsCollection.Add(new SymbolFactoryNetEngine.Band(0D, 0, false, SymbolFactoryNetEngine.BandStyleOptions.Shaded, System.Drawing.Color.Lime, "Band1"));
            this.sym_Lamp_PLC.BlinkColor = System.Drawing.Color.Red;
            this.sym_Lamp_PLC.Category = "1Btn.cat2";
            this.sym_Lamp_PLC.DebugData = new SymbolFactoryDotNet.DebugClass(resources.GetString("sym_Lamp_PLC.DebugData"));
            this.sym_Lamp_PLC.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.sym_Lamp_PLC.FillColorMode = SymbolFactoryNetEngine.FillColorModeOptions.Shaded;
            this.sym_Lamp_PLC.Location = new System.Drawing.Point(415, 121);
            this.sym_Lamp_PLC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sym_Lamp_PLC.Name = "sym_Lamp_PLC";
            this.sym_Lamp_PLC.Size = new System.Drawing.Size(57, 57);
            this.sym_Lamp_PLC.SymbolHandle = ((long)(842488176));
            this.sym_Lamp_PLC.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(399, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "PLC STATUS";
            // 
            // sym_Lamp_Error
            // 
            this.sym_Lamp_Error.AnalogIntValue1 = ((short)(0));
            this.sym_Lamp_Error.AnalogValue1 = 0D;
            this.sym_Lamp_Error.AnimationMode = SymbolFactoryNetEngine.AnimationModeOptions.DiscreteColorFill;
            this.sym_Lamp_Error.BackColor = System.Drawing.Color.Transparent;
            this.sym_Lamp_Error.BackStyle = SymbolFactoryNetEngine.BackStyleOptions.Transparent;
            this.sym_Lamp_Error.BandsCollection.Add(new SymbolFactoryNetEngine.Band(0D, 0, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkShaded, System.Drawing.Color.Red, "Band1"));
            this.sym_Lamp_Error.BlinkColor = System.Drawing.Color.Red;
            this.sym_Lamp_Error.Category = "1Btn.cat2";
            this.sym_Lamp_Error.DebugData = new SymbolFactoryDotNet.DebugClass(resources.GetString("sym_Lamp_Error.DebugData"));
            this.sym_Lamp_Error.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.sym_Lamp_Error.FillColorMode = SymbolFactoryNetEngine.FillColorModeOptions.Shaded;
            this.sym_Lamp_Error.Location = new System.Drawing.Point(529, 121);
            this.sym_Lamp_Error.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sym_Lamp_Error.Name = "sym_Lamp_Error";
            this.sym_Lamp_Error.Size = new System.Drawing.Size(57, 57);
            this.sym_Lamp_Error.SymbolHandle = ((long)(842488176));
            this.sym_Lamp_Error.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(513, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "PLC ERROR";
            // 
            // txt_VT
            // 
            this.txt_VT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_VT.Location = new System.Drawing.Point(467, 237);
            this.txt_VT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_VT.Name = "txt_VT";
            this.txt_VT.ReadOnly = true;
            this.txt_VT.Size = new System.Drawing.Size(181, 30);
            this.txt_VT.TabIndex = 9;
            this.txt_VT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label13.Location = new System.Drawing.Point(483, 194);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(155, 25);
            this.label13.TabIndex = 1;
            this.label13.Text = "VỊ TRÍ HIỆN TẠI";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label14.Location = new System.Drawing.Point(654, 240);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(25, 25);
            this.label14.TabIndex = 1;
            this.label14.Text = " °";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label15.Location = new System.Drawing.Point(78, 234);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(151, 25);
            this.label15.TabIndex = 1;
            this.label15.Text = "NHẬP TỐC ĐỘ";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label16.Location = new System.Drawing.Point(253, 274);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(81, 25);
            this.label16.TabIndex = 1;
            this.label16.Text = "mm/min";
            // 
            // tbx_settingspeed
            // 
            this.tbx_settingspeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbx_settingspeed.Location = new System.Drawing.Point(72, 269);
            this.tbx_settingspeed.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbx_settingspeed.Name = "tbx_settingspeed";
            this.tbx_settingspeed.Size = new System.Drawing.Size(175, 30);
            this.tbx_settingspeed.TabIndex = 9;
            this.tbx_settingspeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbx_settingspeed.WordWrap = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label17.Location = new System.Drawing.Point(80, 331);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(155, 25);
            this.label17.TabIndex = 1;
            this.label17.Text = "NHẬP TỌA ĐỘ ";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label18.Location = new System.Drawing.Point(253, 368);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(25, 25);
            this.label18.TabIndex = 1;
            this.label18.Text = " °";
            // 
            // tbx_settingtoado
            // 
            this.tbx_settingtoado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbx_settingtoado.Location = new System.Drawing.Point(72, 365);
            this.tbx_settingtoado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbx_settingtoado.Name = "tbx_settingtoado";
            this.tbx_settingtoado.Size = new System.Drawing.Size(175, 30);
            this.tbx_settingtoado.TabIndex = 9;
            this.tbx_settingtoado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label19.Location = new System.Drawing.Point(54, 426);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(198, 25);
            this.label19.TabIndex = 1;
            this.label19.Text = "NHẬP TỐC ĐỘ JOG";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label20.Location = new System.Drawing.Point(253, 468);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(81, 25);
            this.label20.TabIndex = 1;
            this.label20.Text = "mm/min";
            // 
            // tbx_speedjog
            // 
            this.tbx_speedjog.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbx_speedjog.Location = new System.Drawing.Point(72, 465);
            this.tbx_speedjog.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbx_speedjog.Name = "tbx_speedjog";
            this.tbx_speedjog.Size = new System.Drawing.Size(175, 30);
            this.tbx_speedjog.TabIndex = 9;
            this.tbx_speedjog.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // sym_Lamp_servorun
            // 
            this.sym_Lamp_servorun.AnalogIntValue1 = ((short)(0));
            this.sym_Lamp_servorun.AnalogValue1 = 0D;
            this.sym_Lamp_servorun.AnimationMode = SymbolFactoryNetEngine.AnimationModeOptions.DiscreteColorFill;
            this.sym_Lamp_servorun.BackColor = System.Drawing.Color.Transparent;
            this.sym_Lamp_servorun.BackStyle = SymbolFactoryNetEngine.BackStyleOptions.Transparent;
            this.sym_Lamp_servorun.BandsCollection.Add(new SymbolFactoryNetEngine.Band(0D, 0, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkShaded, System.Drawing.Color.Lime, "Band1"));
            this.sym_Lamp_servorun.BlinkColor = System.Drawing.Color.Red;
            this.sym_Lamp_servorun.Category = "1Btn.cat2";
            this.sym_Lamp_servorun.DebugData = new SymbolFactoryDotNet.DebugClass(resources.GetString("sym_Lamp_servorun.DebugData"));
            this.sym_Lamp_servorun.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.sym_Lamp_servorun.FillColorMode = SymbolFactoryNetEngine.FillColorModeOptions.Shaded;
            this.sym_Lamp_servorun.Location = new System.Drawing.Point(643, 121);
            this.sym_Lamp_servorun.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sym_Lamp_servorun.Name = "sym_Lamp_servorun";
            this.sym_Lamp_servorun.Size = new System.Drawing.Size(57, 57);
            this.sym_Lamp_servorun.SymbolHandle = ((long)(842488176));
            this.sym_Lamp_servorun.TabIndex = 5;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(627, 91);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(90, 17);
            this.label25.TabIndex = 6;
            this.label25.Text = "SERVO RUN";
            // 
            // btt_Edit
            // 
            this.btt_Edit.Location = new System.Drawing.Point(408, 443);
            this.btt_Edit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btt_Edit.Name = "btt_Edit";
            this.btt_Edit.Size = new System.Drawing.Size(79, 38);
            this.btt_Edit.TabIndex = 10;
            this.btt_Edit.Text = "EDIT";
            this.btt_Edit.UseVisualStyleBackColor = true;
            this.btt_Edit.Click += new System.EventHandler(this.btt_Edit_Click);
            // 
            // btt_Save
            // 
            this.btt_Save.Location = new System.Drawing.Point(517, 443);
            this.btt_Save.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btt_Save.Name = "btt_Save";
            this.btt_Save.Size = new System.Drawing.Size(88, 39);
            this.btt_Save.TabIndex = 11;
            this.btt_Save.Text = "SAVE";
            this.btt_Save.UseVisualStyleBackColor = true;
            this.btt_Save.Click += new System.EventHandler(this.btt_Save_Click);
            // 
            // sym_btt_JOG2
            // 
            this.sym_btt_JOG2.Location = new System.Drawing.Point(408, 296);
            this.sym_btt_JOG2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sym_btt_JOG2.Name = "sym_btt_JOG2";
            this.sym_btt_JOG2.Size = new System.Drawing.Size(81, 44);
            this.sym_btt_JOG2.TabIndex = 12;
            this.sym_btt_JOG2.Text = "JOG+";
            this.sym_btt_JOG2.UseVisualStyleBackColor = true;
            this.sym_btt_JOG2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.sym_btt_JOG2_MouseDown);
            this.sym_btt_JOG2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.sym_btt_JOG2_MouseUp);
            // 
            // sym_btt_JOG3
            // 
            this.sym_btt_JOG3.Location = new System.Drawing.Point(517, 296);
            this.sym_btt_JOG3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sym_btt_JOG3.Name = "sym_btt_JOG3";
            this.sym_btt_JOG3.Size = new System.Drawing.Size(81, 44);
            this.sym_btt_JOG3.TabIndex = 12;
            this.sym_btt_JOG3.Text = "JOG-";
            this.sym_btt_JOG3.UseVisualStyleBackColor = true;
            this.sym_btt_JOG3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.sym_btt_JOG3_MouseDown);
            this.sym_btt_JOG3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.sym_btt_JOG3_MouseUp);
            // 
            // sym_btt_home
            // 
            this.sym_btt_home.Location = new System.Drawing.Point(620, 296);
            this.sym_btt_home.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sym_btt_home.Name = "sym_btt_home";
            this.sym_btt_home.Size = new System.Drawing.Size(95, 44);
            this.sym_btt_home.TabIndex = 12;
            this.sym_btt_home.Text = "HOME";
            this.sym_btt_home.UseVisualStyleBackColor = true;
            this.sym_btt_home.MouseDown += new System.Windows.Forms.MouseEventHandler(this.sym_btt_Home_MouseDown);
            this.sym_btt_home.MouseUp += new System.Windows.Forms.MouseEventHandler(this.sym_btt_Home_MouseUp);
            // 
            // sym_btt_goabs
            // 
            this.sym_btt_goabs.Location = new System.Drawing.Point(408, 368);
            this.sym_btt_goabs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sym_btt_goabs.Name = "sym_btt_goabs";
            this.sym_btt_goabs.Size = new System.Drawing.Size(81, 44);
            this.sym_btt_goabs.TabIndex = 12;
            this.sym_btt_goabs.Text = "GO ABS";
            this.sym_btt_goabs.UseVisualStyleBackColor = true;
            this.sym_btt_goabs.MouseDown += new System.Windows.Forms.MouseEventHandler(this.sym_btt_goabs_MouseDown);
            this.sym_btt_goabs.MouseUp += new System.Windows.Forms.MouseEventHandler(this.sym_btt_goabs_MouseUp);
            // 
            // sym_btt_goinc
            // 
            this.sym_btt_goinc.Location = new System.Drawing.Point(517, 368);
            this.sym_btt_goinc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sym_btt_goinc.Name = "sym_btt_goinc";
            this.sym_btt_goinc.Size = new System.Drawing.Size(81, 44);
            this.sym_btt_goinc.TabIndex = 12;
            this.sym_btt_goinc.Text = "GO INC";
            this.sym_btt_goinc.UseVisualStyleBackColor = true;
            this.sym_btt_goinc.MouseDown += new System.Windows.Forms.MouseEventHandler(this.sym_btt_goinc_MouseDown);
            this.sym_btt_goinc.MouseUp += new System.Windows.Forms.MouseEventHandler(this.sym_btt_goinc_MouseUp);
            // 
            // sym_btt_sethome
            // 
            this.sym_btt_sethome.Location = new System.Drawing.Point(620, 368);
            this.sym_btt_sethome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sym_btt_sethome.Name = "sym_btt_sethome";
            this.sym_btt_sethome.Size = new System.Drawing.Size(95, 44);
            this.sym_btt_sethome.TabIndex = 12;
            this.sym_btt_sethome.Text = "SET HOME";
            this.sym_btt_sethome.UseVisualStyleBackColor = true;
            this.sym_btt_sethome.MouseDown += new System.Windows.Forms.MouseEventHandler(this.sym_btt_sethome_MouseDown);
            this.sym_btt_sethome.MouseUp += new System.Windows.Forms.MouseEventHandler(this.sym_btt_sethome_MouseUp);
            // 
            // sym_btt_AM
            // 
            this.sym_btt_AM.Location = new System.Drawing.Point(625, 443);
            this.sym_btt_AM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sym_btt_AM.Name = "sym_btt_AM";
            this.sym_btt_AM.Size = new System.Drawing.Size(90, 39);
            this.sym_btt_AM.TabIndex = 12;
            this.sym_btt_AM.Text = "AU/MAN";
            this.sym_btt_AM.UseVisualStyleBackColor = true;
            this.sym_btt_AM.MouseDown += new System.Windows.Forms.MouseEventHandler(this.sym_btt_Automan_MouseDown);
            this.sym_btt_AM.MouseUp += new System.Windows.Forms.MouseEventHandler(this.sym_btt_Automan_MouseUp);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btt_Logout);
            this.groupBox1.Controls.Add(this.btt_Login);
            this.groupBox1.Controls.Add(this.btt_Connect);
            this.groupBox1.Controls.Add(this.btt_Disconnect);
            this.groupBox1.Controls.Add(this.btt_Check);
            this.groupBox1.Location = new System.Drawing.Point(1000, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(273, 229);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quản trị viên";
            // 
            // btt_Logout
            // 
            this.btt_Logout.Location = new System.Drawing.Point(147, 32);
            this.btt_Logout.Name = "btt_Logout";
            this.btt_Logout.Size = new System.Drawing.Size(115, 35);
            this.btt_Logout.TabIndex = 1;
            this.btt_Logout.Text = "Logout";
            this.btt_Logout.UseVisualStyleBackColor = true;
            this.btt_Logout.Click += new System.EventHandler(this.btt_Logout_Click);
            // 
            // btt_Login
            // 
            this.btt_Login.Location = new System.Drawing.Point(22, 32);
            this.btt_Login.Name = "btt_Login";
            this.btt_Login.Size = new System.Drawing.Size(106, 35);
            this.btt_Login.TabIndex = 1;
            this.btt_Login.Text = "Login";
            this.btt_Login.UseVisualStyleBackColor = true;
            this.btt_Login.Click += new System.EventHandler(this.btt_Login_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btt_SQLSave);
            this.groupBox2.Controls.Add(this.btt_SQLEdit);
            this.groupBox2.Controls.Add(this.tbx_DBName);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(794, 58);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 161);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "SQL_Serve";
            // 
            // btt_SQLSave
            // 
            this.btt_SQLSave.Location = new System.Drawing.Point(96, 108);
            this.btt_SQLSave.Name = "btt_SQLSave";
            this.btt_SQLSave.Size = new System.Drawing.Size(75, 23);
            this.btt_SQLSave.TabIndex = 2;
            this.btt_SQLSave.Text = "Save";
            this.btt_SQLSave.UseVisualStyleBackColor = true;
            this.btt_SQLSave.Click += new System.EventHandler(this.btt_SQLSave_Click);
            // 
            // btt_SQLEdit
            // 
            this.btt_SQLEdit.Location = new System.Drawing.Point(15, 108);
            this.btt_SQLEdit.Name = "btt_SQLEdit";
            this.btt_SQLEdit.Size = new System.Drawing.Size(75, 23);
            this.btt_SQLEdit.TabIndex = 2;
            this.btt_SQLEdit.Text = "Edit";
            this.btt_SQLEdit.UseVisualStyleBackColor = true;
            this.btt_SQLEdit.Click += new System.EventHandler(this.btt_SQLEdit_Click);
            // 
            // tbx_DBName
            // 
            this.tbx_DBName.Enabled = false;
            this.tbx_DBName.Location = new System.Drawing.Point(15, 74);
            this.tbx_DBName.Name = "tbx_DBName";
            this.tbx_DBName.Size = new System.Drawing.Size(153, 22);
            this.tbx_DBName.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Database name";
            // 
            // btt_Showdata
            // 
            this.btt_Showdata.Location = new System.Drawing.Point(57, 534);
            this.btt_Showdata.Name = "btt_Showdata";
            this.btt_Showdata.Size = new System.Drawing.Size(132, 33);
            this.btt_Showdata.TabIndex = 15;
            this.btt_Showdata.Text = "Show data";
            this.btt_Showdata.UseVisualStyleBackColor = true;
            this.btt_Showdata.Click += new System.EventHandler(this.btt_Showdata_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(54, 594);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1188, 248);
            this.dataGridView1.TabIndex = 16;
            // 
            // txt_ND
            // 
            this.txt_ND.Location = new System.Drawing.Point(69, 194);
            this.txt_ND.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_ND.Name = "txt_ND";
            this.txt_ND.Size = new System.Drawing.Size(181, 22);
            this.txt_ND.TabIndex = 2;
            this.txt_ND.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // grb_SortbyTime
            // 
            this.grb_SortbyTime.Controls.Add(this.dtpk_TimeEnd);
            this.grb_SortbyTime.Controls.Add(this.dtpk_TimeStart);
            this.grb_SortbyTime.Controls.Add(this.dtpk_DateEnd);
            this.grb_SortbyTime.Controls.Add(this.dtpk_DateStart);
            this.grb_SortbyTime.Controls.Add(this.label10);
            this.grb_SortbyTime.Controls.Add(this.label9);
            this.grb_SortbyTime.Location = new System.Drawing.Point(943, 319);
            this.grb_SortbyTime.Name = "grb_SortbyTime";
            this.grb_SortbyTime.Size = new System.Drawing.Size(330, 116);
            this.grb_SortbyTime.TabIndex = 17;
            this.grb_SortbyTime.TabStop = false;
            this.grb_SortbyTime.Text = "Lựa chọn theo thời gian";
            // 
            // dtpk_TimeEnd
            // 
            this.dtpk_TimeEnd.CustomFormat = "HH:mm:ss";
            this.dtpk_TimeEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpk_TimeEnd.Location = new System.Drawing.Point(211, 67);
            this.dtpk_TimeEnd.Name = "dtpk_TimeEnd";
            this.dtpk_TimeEnd.Size = new System.Drawing.Size(107, 22);
            this.dtpk_TimeEnd.TabIndex = 11;
            // 
            // dtpk_TimeStart
            // 
            this.dtpk_TimeStart.CustomFormat = "HH:mm:ss";
            this.dtpk_TimeStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpk_TimeStart.Location = new System.Drawing.Point(211, 34);
            this.dtpk_TimeStart.Name = "dtpk_TimeStart";
            this.dtpk_TimeStart.Size = new System.Drawing.Size(107, 22);
            this.dtpk_TimeStart.TabIndex = 11;
            // 
            // dtpk_DateEnd
            // 
            this.dtpk_DateEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpk_DateEnd.Location = new System.Drawing.Point(78, 68);
            this.dtpk_DateEnd.Name = "dtpk_DateEnd";
            this.dtpk_DateEnd.Size = new System.Drawing.Size(107, 22);
            this.dtpk_DateEnd.TabIndex = 11;
            // 
            // dtpk_DateStart
            // 
            this.dtpk_DateStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpk_DateStart.Location = new System.Drawing.Point(78, 35);
            this.dtpk_DateStart.Name = "dtpk_DateStart";
            this.dtpk_DateStart.Size = new System.Drawing.Size(107, 22);
            this.dtpk_DateStart.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 68);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 17);
            this.label10.TabIndex = 10;
            this.label10.Text = "Kết thúc";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 17);
            this.label9.TabIndex = 10;
            this.label9.Text = "Bắt đầu";
            // 
            // btt_Search
            // 
            this.btt_Search.Location = new System.Drawing.Point(943, 465);
            this.btt_Search.Name = "btt_Search";
            this.btt_Search.Size = new System.Drawing.Size(86, 28);
            this.btt_Search.TabIndex = 18;
            this.btt_Search.Text = "Tìm kiếm";
            this.btt_Search.UseVisualStyleBackColor = true;
            this.btt_Search.Click += new System.EventHandler(this.btt_Search_Click);
            // 
            // btt_report1
            // 
            this.btt_report1.Location = new System.Drawing.Point(1053, 464);
            this.btt_report1.Name = "btt_report1";
            this.btt_report1.Size = new System.Drawing.Size(75, 29);
            this.btt_report1.TabIndex = 19;
            this.btt_report1.Text = "Báo cáo";
            this.btt_report1.UseVisualStyleBackColor = true;
            this.btt_report1.Click += new System.EventHandler(this.btt_report1_Click);
            // 
            // btt_excel
            // 
            this.btt_excel.Location = new System.Drawing.Point(1147, 464);
            this.btt_excel.Name = "btt_excel";
            this.btt_excel.Size = new System.Drawing.Size(107, 28);
            this.btt_excel.TabIndex = 20;
            this.btt_excel.Text = "Xuất Excel";
            this.btt_excel.UseVisualStyleBackColor = true;
            this.btt_excel.Click += new System.EventHandler(this.btt_excel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1302, 880);
            this.Controls.Add(this.btt_excel);
            this.Controls.Add(this.btt_report1);
            this.Controls.Add(this.btt_Search);
            this.Controls.Add(this.grb_SortbyTime);
            this.Controls.Add(this.btt_Showdata);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.sym_btt_sethome);
            this.Controls.Add(this.sym_btt_home);
            this.Controls.Add(this.sym_btt_AM);
            this.Controls.Add(this.sym_btt_goinc);
            this.Controls.Add(this.sym_btt_JOG3);
            this.Controls.Add(this.sym_btt_goabs);
            this.Controls.Add(this.sym_btt_JOG2);
            this.Controls.Add(this.btt_Save);
            this.Controls.Add(this.btt_Edit);
            this.Controls.Add(this.tbx_settingtoado);
            this.Controls.Add(this.tbx_speedjog);
            this.Controls.Add(this.tbx_settingspeed);
            this.Controls.Add(this.txt_VT);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.sym_Lamp_servorun);
            this.Controls.Add(this.sym_Lamp_Error);
            this.Controls.Add(this.sym_Lamp_PLC);
            this.Controls.Add(this.txt_ND);
            this.Controls.Add(this.txt_Code);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sym_Lamp_PLC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sym_Lamp_Error)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sym_Lamp_servorun)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grb_SortbyTime.ResumeLayout(false);
            this.grb_SortbyTime.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Code;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btt_Connect;
        private System.Windows.Forms.Button btt_Disconnect;
        private System.Windows.Forms.Button btt_Check;
        private System.Windows.Forms.Timer Timer_Watchdog;
        private SymbolFactoryDotNet.StandardControl sym_Lamp_PLC;
        private System.Windows.Forms.Label label4;
        private SymbolFactoryDotNet.StandardControl sym_Lamp_Error;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_VT;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tbx_settingspeed;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox tbx_settingtoado;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox tbx_speedjog;
        private SymbolFactoryDotNet.StandardControl sym_Lamp_servorun;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Button btt_Edit;
        private System.Windows.Forms.Button btt_Save;
        private System.Windows.Forms.Button sym_btt_JOG2;
        private System.Windows.Forms.Button sym_btt_JOG3;
        private System.Windows.Forms.Button sym_btt_home;
        private System.Windows.Forms.Button sym_btt_goabs;
        private System.Windows.Forms.Button sym_btt_goinc;
        private System.Windows.Forms.Button sym_btt_sethome;
        private System.Windows.Forms.Button sym_btt_AM;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btt_Logout;
        private System.Windows.Forms.Button btt_Login;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.Button btt_SQLSave;
        public System.Windows.Forms.Button btt_SQLEdit;
        private System.Windows.Forms.TextBox tbx_DBName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btt_Showdata;
        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.TextBox txt_ND;
        public System.Windows.Forms.GroupBox grb_SortbyTime;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.Button btt_Search;
        private System.Windows.Forms.Button btt_report1;
        private System.Windows.Forms.Button btt_excel;
        public System.Windows.Forms.DateTimePicker dtpk_TimeEnd;
        public System.Windows.Forms.DateTimePicker dtpk_TimeStart;
        public System.Windows.Forms.DateTimePicker dtpk_DateEnd;
        public System.Windows.Forms.DateTimePicker dtpk_DateStart;
    }
}

