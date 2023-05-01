using System.Windows.Forms;

namespace UmniyDom
{
	partial class Form
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
			this.Panel = new System.Windows.Forms.Panel();
			this.LTKond = new System.Windows.Forms.CheckBox();
			this.TKond = new System.Windows.Forms.TrackBar();
			this.Room = new System.Windows.Forms.TrackBar();
			this.LKRoom = new System.Windows.Forms.Label();
			this.KBat = new System.Windows.Forms.TrackBar();
			this.LKBat = new System.Windows.Forms.Label();
			this.KAtm = new System.Windows.Forms.TrackBar();
			this.LKAtm = new System.Windows.Forms.Label();
			this.TReg = new System.Windows.Forms.TrackBar();
			this.LReg = new System.Windows.Forms.Label();
			this.TAtm = new System.Windows.Forms.TrackBar();
			this.LAtm = new System.Windows.Forms.Label();
			this.LKot = new System.Windows.Forms.Label();
			this.TKot = new System.Windows.Forms.TrackBar();
			this.RegOn = new System.Windows.Forms.CheckBox();
			this.BTick = new System.Windows.Forms.Button();
			this.LA = new System.Windows.Forms.Label();
			this.LB = new System.Windows.Forms.Label();
			this.LC = new System.Windows.Forms.Label();
			this.LD = new System.Windows.Forms.Label();
			this.LE = new System.Windows.Forms.Label();
			this.LF = new System.Windows.Forms.Label();
			this.WinA = new System.Windows.Forms.Label();
			this.WinB = new System.Windows.Forms.Label();
			this.WinE = new System.Windows.Forms.Label();
			this.WinC = new System.Windows.Forms.Label();
			this.WinD = new System.Windows.Forms.Label();
			this.DoorA = new System.Windows.Forms.Label();
			this.DoorB = new System.Windows.Forms.Label();
			this.DoorE = new System.Windows.Forms.Label();
			this.DoorC = new System.Windows.Forms.Label();
			this.DoorD = new System.Windows.Forms.Label();
			this.Door = new System.Windows.Forms.Label();
			this.LBA = new System.Windows.Forms.Label();
			this.LBB = new System.Windows.Forms.Label();
			this.LBC = new System.Windows.Forms.Label();
			this.LBD = new System.Windows.Forms.Label();
			this.LBE = new System.Windows.Forms.Label();
			this.LT = new System.Windows.Forms.Label();
			this.LKond = new System.Windows.Forms.Label();
			this.Panel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.TKond)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Room)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.KBat)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.KAtm)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.TReg)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.TAtm)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.TKot)).BeginInit();
			this.SuspendLayout();
			// 
			// Panel
			// 
			this.Panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.Panel.BackColor = System.Drawing.Color.LightSlateGray;
			this.Panel.Controls.Add(this.LTKond);
			this.Panel.Controls.Add(this.TKond);
			this.Panel.Controls.Add(this.Room);
			this.Panel.Controls.Add(this.LKRoom);
			this.Panel.Controls.Add(this.KBat);
			this.Panel.Controls.Add(this.LKBat);
			this.Panel.Controls.Add(this.KAtm);
			this.Panel.Controls.Add(this.LKAtm);
			this.Panel.Controls.Add(this.TReg);
			this.Panel.Controls.Add(this.LReg);
			this.Panel.Controls.Add(this.TAtm);
			this.Panel.Controls.Add(this.LAtm);
			this.Panel.Controls.Add(this.LKot);
			this.Panel.Controls.Add(this.TKot);
			this.Panel.Controls.Add(this.RegOn);
			this.Panel.Location = new System.Drawing.Point(1024, 0);
			this.Panel.Name = "Panel";
			this.Panel.Size = new System.Drawing.Size(284, 610);
			this.Panel.TabIndex = 0;
			// 
			// LTKond
			// 
			this.LTKond.AutoSize = true;
			this.LTKond.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.LTKond.Location = new System.Drawing.Point(15, 170);
			this.LTKond.Name = "LTKond";
			this.LTKond.Size = new System.Drawing.Size(126, 22);
			this.LTKond.TabIndex = 22;
			this.LTKond.Text = "Кондиционер:";
			this.LTKond.UseVisualStyleBackColor = true;
			this.LTKond.CheckedChanged += new System.EventHandler(this.LTKond_CheckedChanged);
			// 
			// TKond
			// 
			this.TKond.Location = new System.Drawing.Point(15, 190);
			this.TKond.Maximum = 20;
			this.TKond.Name = "TKond";
			this.TKond.Size = new System.Drawing.Size(160, 45);
			this.TKond.TabIndex = 21;
			this.TKond.Value = 20;
			this.TKond.Scroll += new System.EventHandler(this.TKond_Scroll);
			// 
			// Room
			// 
			this.Room.Location = new System.Drawing.Point(20, 470);
			this.Room.Maximum = 100;
			this.Room.Name = "Room";
			this.Room.Size = new System.Drawing.Size(160, 45);
			this.Room.TabIndex = 20;
			this.Room.Value = 30;
			this.Room.Scroll += new System.EventHandler(this.Room_Scroll);
			// 
			// LKRoom
			// 
			this.LKRoom.AutoSize = true;
			this.LKRoom.BackColor = System.Drawing.Color.LightSlateGray;
			this.LKRoom.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.LKRoom.Location = new System.Drawing.Point(20, 450);
			this.LKRoom.Name = "LKRoom";
			this.LKRoom.Size = new System.Drawing.Size(198, 18);
			this.LKRoom.TabIndex = 19;
			this.LKRoom.Text = "Влияние соседних комнат:";
			// 
			// KBat
			// 
			this.KBat.Location = new System.Drawing.Point(15, 400);
			this.KBat.Maximum = 100;
			this.KBat.Name = "KBat";
			this.KBat.Size = new System.Drawing.Size(160, 45);
			this.KBat.TabIndex = 18;
			this.KBat.Value = 50;
			this.KBat.Scroll += new System.EventHandler(this.KBat_Scroll);
			// 
			// LKBat
			// 
			this.LKBat.AutoSize = true;
			this.LKBat.BackColor = System.Drawing.Color.LightSlateGray;
			this.LKBat.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.LKBat.Location = new System.Drawing.Point(15, 380);
			this.LKBat.Name = "LKBat";
			this.LKBat.Size = new System.Drawing.Size(176, 18);
			this.LKBat.TabIndex = 17;
			this.LKBat.Text = "Влияние нагревателей:";
			// 
			// KAtm
			// 
			this.KAtm.Location = new System.Drawing.Point(15, 330);
			this.KAtm.Maximum = 100;
			this.KAtm.Name = "KAtm";
			this.KAtm.Size = new System.Drawing.Size(160, 45);
			this.KAtm.TabIndex = 16;
			this.KAtm.Value = 40;
			this.KAtm.Scroll += new System.EventHandler(this.KAtm_Scroll);
			// 
			// LKAtm
			// 
			this.LKAtm.AutoSize = true;
			this.LKAtm.BackColor = System.Drawing.Color.LightSlateGray;
			this.LKAtm.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.LKAtm.Location = new System.Drawing.Point(15, 310);
			this.LKAtm.Name = "LKAtm";
			this.LKAtm.Size = new System.Drawing.Size(164, 18);
			this.LKAtm.TabIndex = 15;
			this.LKAtm.Text = "Влияние атмосферы:";
			// 
			// TReg
			// 
			this.TReg.Enabled = false;
			this.TReg.Location = new System.Drawing.Point(15, 50);
			this.TReg.Maximum = 40;
			this.TReg.Name = "TReg";
			this.TReg.Size = new System.Drawing.Size(160, 45);
			this.TReg.TabIndex = 14;
			this.TReg.Value = 25;
			this.TReg.Scroll += new System.EventHandler(this.TReg_Scroll);
			// 
			// LReg
			// 
			this.LReg.AutoSize = true;
			this.LReg.BackColor = System.Drawing.Color.LightSlateGray;
			this.LReg.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.LReg.Location = new System.Drawing.Point(15, 30);
			this.LReg.Name = "LReg";
			this.LReg.Size = new System.Drawing.Size(124, 18);
			this.LReg.TabIndex = 13;
			this.LReg.Text = "Поддерживать: ";
			// 
			// TAtm
			// 
			this.TAtm.Location = new System.Drawing.Point(15, 260);
			this.TAtm.Maximum = 50;
			this.TAtm.Minimum = -50;
			this.TAtm.Name = "TAtm";
			this.TAtm.Size = new System.Drawing.Size(160, 45);
			this.TAtm.TabIndex = 12;
			this.TAtm.Value = 20;
			this.TAtm.Scroll += new System.EventHandler(this.TAtm_Scroll);
			// 
			// LAtm
			// 
			this.LAtm.AutoSize = true;
			this.LAtm.BackColor = System.Drawing.Color.LightSlateGray;
			this.LAtm.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.LAtm.Location = new System.Drawing.Point(10, 240);
			this.LAtm.Name = "LAtm";
			this.LAtm.Size = new System.Drawing.Size(198, 18);
			this.LAtm.TabIndex = 11;
			this.LAtm.Text = "Температура атмосферы:";
			// 
			// LKot
			// 
			this.LKot.AutoSize = true;
			this.LKot.BackColor = System.Drawing.Color.LightSlateGray;
			this.LKot.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.LKot.Location = new System.Drawing.Point(10, 100);
			this.LKot.Name = "LKot";
			this.LKot.Size = new System.Drawing.Size(151, 18);
			this.LKot.TabIndex = 10;
			this.LKot.Text = "Температура котла:";
			// 
			// TKot
			// 
			this.TKot.Location = new System.Drawing.Point(15, 120);
			this.TKot.Maximum = 90;
			this.TKot.Minimum = 10;
			this.TKot.Name = "TKot";
			this.TKot.Size = new System.Drawing.Size(160, 45);
			this.TKot.TabIndex = 9;
			this.TKot.Value = 50;
			this.TKot.Scroll += new System.EventHandler(this.TKot_Scroll);
			// 
			// RegOn
			// 
			this.RegOn.AutoSize = true;
			this.RegOn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.RegOn.Location = new System.Drawing.Point(15, 5);
			this.RegOn.Name = "RegOn";
			this.RegOn.Size = new System.Drawing.Size(174, 22);
			this.RegOn.TabIndex = 8;
			this.RegOn.Text = "Включить регулятор";
			this.RegOn.UseVisualStyleBackColor = true;
			this.RegOn.CheckedChanged += new System.EventHandler(this.RegOn_CheckedChanged);
			// 
			// BTick
			// 
			this.BTick.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.BTick.Location = new System.Drawing.Point(440, 470);
			this.BTick.Name = "BTick";
			this.BTick.Size = new System.Drawing.Size(75, 23);
			this.BTick.TabIndex = 21;
			this.BTick.Text = "Шаг";
			this.BTick.UseVisualStyleBackColor = true;
			this.BTick.Click += new System.EventHandler(this.BTick_Click);
			// 
			// LA
			// 
			this.LA.AutoSize = true;
			this.LA.BackColor = System.Drawing.Color.Silver;
			this.LA.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.LA.Location = new System.Drawing.Point(225, 281);
			this.LA.Name = "LA";
			this.LA.Size = new System.Drawing.Size(34, 27);
			this.LA.TabIndex = 1;
			this.LA.Text = "A:";
			// 
			// LB
			// 
			this.LB.AutoSize = true;
			this.LB.BackColor = System.Drawing.Color.Silver;
			this.LB.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.LB.Location = new System.Drawing.Point(780, 150);
			this.LB.Name = "LB";
			this.LB.Size = new System.Drawing.Size(35, 27);
			this.LB.TabIndex = 2;
			this.LB.Text = "B:";
			// 
			// LC
			// 
			this.LC.AutoSize = true;
			this.LC.BackColor = System.Drawing.Color.Silver;
			this.LC.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.LC.Location = new System.Drawing.Point(560, 200);
			this.LC.Name = "LC";
			this.LC.Size = new System.Drawing.Size(36, 27);
			this.LC.TabIndex = 3;
			this.LC.Text = "C:";
			// 
			// LD
			// 
			this.LD.AutoSize = true;
			this.LD.BackColor = System.Drawing.Color.Silver;
			this.LD.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.LD.Location = new System.Drawing.Point(320, 281);
			this.LD.Name = "LD";
			this.LD.Size = new System.Drawing.Size(36, 27);
			this.LD.TabIndex = 4;
			this.LD.Text = "D:";
			// 
			// LE
			// 
			this.LE.AutoSize = true;
			this.LE.BackColor = System.Drawing.Color.Silver;
			this.LE.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.LE.Location = new System.Drawing.Point(210, 85);
			this.LE.Name = "LE";
			this.LE.Size = new System.Drawing.Size(35, 27);
			this.LE.TabIndex = 5;
			this.LE.Text = "E:";
			// 
			// LF Room F
			// 
			this.LF.AutoSize = true;
			this.LF.BackColor = System.Drawing.Color.Silver;
			this.LF.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.LF.Location = new System.Drawing.Point(200, 220);
			this.LF.Name = "LF";
			this.LF.Size = new System.Drawing.Size(34, 27);
			this.LF.TabIndex = 6;
			this.LF.Text = "F:";
			// 
			// WinA
			// 
			this.WinA.AutoSize = true;
			this.WinA.BackColor = System.Drawing.Color.Silver;
			this.WinA.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.WinA.Location = new System.Drawing.Point(20, 355);
			this.WinA.Name = "WinA";
			this.WinA.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.WinA.Size = new System.Drawing.Size(26, 23);
			this.WinA.TabIndex = 7;
			this.WinA.Text = "О";
			this.WinA.Click += new System.EventHandler(this.WinA_Click);
			// 
			// WinB
			// 
			this.WinB.AutoSize = true;
			this.WinB.BackColor = System.Drawing.Color.Silver;
			this.WinB.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.WinB.Location = new System.Drawing.Point(20, 140);
			this.WinB.Name = "WinB";
			this.WinB.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.WinB.Size = new System.Drawing.Size(26, 23);
			this.WinB.TabIndex = 8;
			this.WinB.Text = "О";
			this.WinB.Click += new System.EventHandler(this.WinB_Click);
			// 
			// WinE
			// 
			this.WinE.AutoSize = true;
			this.WinE.BackColor = System.Drawing.Color.Silver;
			this.WinE.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.WinE.Location = new System.Drawing.Point(235, 10);
			this.WinE.Name = "WinE";
			this.WinE.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.WinE.Size = new System.Drawing.Size(26, 23);
			this.WinE.TabIndex = 9;
			this.WinE.Text = "О";
			this.WinE.Click += new System.EventHandler(this.WinE_Click);
			// 
			// WinC
			// 
			this.WinC.AutoSize = true;
			this.WinC.BackColor = System.Drawing.Color.Silver;
			this.WinC.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.WinC.Location = new System.Drawing.Point(460, 115);
			this.WinC.Name = "WinC";
			this.WinC.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.WinC.Size = new System.Drawing.Size(26, 23);
			this.WinC.TabIndex = 10;
			this.WinC.Text = "О";
			this.WinC.Click += new System.EventHandler(this.WinC_Click);
			// 
			// WinD
			// 
			this.WinD.AutoSize = true;
			this.WinD.BackColor = System.Drawing.Color.Silver;
			this.WinD.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.WinD.Location = new System.Drawing.Point(460, 330);
			this.WinD.Name = "WinD";
			this.WinD.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.WinD.Size = new System.Drawing.Size(26, 23);
			this.WinD.TabIndex = 11;
			this.WinD.Text = "О";
			this.WinD.Click += new System.EventHandler(this.WinD_Click);
			// 
			// DoorA
			// 
			this.DoorA.AutoSize = true;
			this.DoorA.BackColor = System.Drawing.Color.Silver;
			this.DoorA.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.DoorA.Location = new System.Drawing.Point(450, 80);
			this.DoorA.Name = "DoorA";
			this.DoorA.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.DoorA.Size = new System.Drawing.Size(26, 23);
			this.DoorA.TabIndex = 12;
			this.DoorA.Text = "Открыто";
			this.DoorA.Click += new System.EventHandler(this.DoorA_Click);
			// 
			// DoorB
			// 
			this.DoorB.AutoSize = true;
			this.DoorB.BackColor = System.Drawing.Color.Silver;
			this.DoorB.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.DoorB.Location = new System.Drawing.Point(650, 80);
			this.DoorB.Name = "DoorB";
			this.DoorB.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.DoorB.Size = new System.Drawing.Size(26, 23);
			this.DoorB.TabIndex = 13;
			this.DoorB.Text = "Открыто";
			this.DoorB.Click += new System.EventHandler(this.DoorB_Click);
			// 
			// DoorE
			// 
			this.DoorE.AutoSize = true;
			this.DoorE.BackColor = System.Drawing.Color.Silver;
			this.DoorE.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.DoorE.Location = new System.Drawing.Point(225, 115);
			this.DoorE.Name = "DoorE";
			this.DoorE.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.DoorE.Size = new System.Drawing.Size(26, 23);
			this.DoorE.TabIndex = 14;
			this.DoorE.Text = "О";
			this.DoorE.Click += new System.EventHandler(this.DoorE_Click);
			// 
			// DoorC
			// 
			this.DoorC.AutoSize = true;
			this.DoorC.BackColor = System.Drawing.Color.Silver;
			this.DoorC.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.DoorC.Location = new System.Drawing.Point(361, 190);
			this.DoorC.Name = "DoorC";
			this.DoorC.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.DoorC.Size = new System.Drawing.Size(26, 23);
			this.DoorC.TabIndex = 15;
			this.DoorC.Text = "О";
			this.DoorC.Click += new System.EventHandler(this.DoorC_Click);
			// 
			// DoorD
			// 
			this.DoorD.AutoSize = true;
			this.DoorD.BackColor = System.Drawing.Color.Silver;
			this.DoorD.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.DoorD.Location = new System.Drawing.Point(277, 268);
			this.DoorD.Name = "DoorD";
			this.DoorD.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.DoorD.Size = new System.Drawing.Size(26, 23);
			this.DoorD.TabIndex = 16;
			this.DoorD.Text = "О";
			this.DoorD.Click += new System.EventHandler(this.DoorD_Click);
			// 
			// Door
			// 
			this.Door.AutoSize = true;
			this.Door.BackColor = System.Drawing.Color.Silver;
			this.Door.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.Door.Location = new System.Drawing.Point(550, 475);
			this.Door.Name = "Door";
			this.Door.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Door.Size = new System.Drawing.Size(26, 23);
			this.Door.TabIndex = 17;
			this.Door.Text = "Открыто";
			this.Door.Click += new System.EventHandler(this.Door_Click);
			// 
			// LBA
			// 
			this.LBA.AutoSize = true;
			this.LBA.BackColor = System.Drawing.Color.Silver;
			this.LBA.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.LBA.Location = new System.Drawing.Point(400, 330);
			this.LBA.Name = "LBA";
			this.LBA.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.LBA.Size = new System.Drawing.Size(21, 23);
			this.LBA.TabIndex = 18;
			this.LBA.Text = "0";
			// 
			// LBB
			// 
			this.LBB.AutoSize = true;
			this.LBB.BackColor = System.Drawing.Color.Silver;
			this.LBB.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.LBB.Location = new System.Drawing.Point(760, 330);
			this.LBB.Name = "LBB";
			this.LBB.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.LBB.Size = new System.Drawing.Size(21, 23);
			this.LBB.TabIndex = 19;
			this.LBB.Text = "0";
			// 
			// LBC
			// 
			this.LBC.AutoSize = true;
			this.LBC.BackColor = System.Drawing.Color.Silver;
			this.LBC.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.LBC.Location = new System.Drawing.Point(400, 122);
			this.LBC.Name = "LBC";
			this.LBC.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.LBC.Size = new System.Drawing.Size(21, 23);
			this.LBC.TabIndex = 20;
			this.LBC.Text = "0";
			// 
			// LBD
			// 
			this.LBD.AutoSize = true;
			this.LBD.BackColor = System.Drawing.Color.Silver;
			this.LBD.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            //this.LBD.Location = new System.Drawing.Point(400, 330);
            this.LBD.Name = "LBD";
			this.LBD.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.LBD.Size = new System.Drawing.Size(21, 23);
			this.LBD.TabIndex = 21;
			this.LBD.Text = "0";
			// 
			// LBE Batary at E room
			// 
			this.LBE.AutoSize = true;
			this.LBE.BackColor = System.Drawing.Color.Silver;
			this.LBE.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.LBE.Location = new System.Drawing.Point(235, 62);
			this.LBE.Name = "LBE";
			this.LBE.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.LBE.Size = new System.Drawing.Size(21, 23);
			this.LBE.TabIndex = 22;
			this.LBE.Text = "0";
			// 
			// LTime
			// 
			this.LT.AutoSize = true;
			this.LT.BackColor = System.Drawing.Color.Silver;
			this.LT.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.LT.Location = new System.Drawing.Point(10, 470);
			this.LT.Name = "LT";
			this.LT.Size = new System.Drawing.Size(61, 18);
			this.LT.TabIndex = 22;
			this.LT.Text = "Время:";
			// 
			// LKond
			// 
			this.LKond.AutoSize = true;
			this.LKond.BackColor = System.Drawing.Color.Silver;
			this.LKond.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.LKond.Location = new System.Drawing.Point(610, 300);
			this.LKond.Name = "LKond";
			this.LKond.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.LKond.Size = new System.Drawing.Size(21, 23);
			this.LKond.TabIndex = 23;
			this.LKond.Text = "0";
			// 
			// Form
			// 
			//this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("room1")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.ClientSize = new System.Drawing.Size(1324, 640);
			this.Controls.Add(this.LKond);
			this.Controls.Add(this.BTick);
			this.Controls.Add(this.LT);
			//this.Controls.Add(this.LBE);
			//this.Controls.Add(this.LBD);
			//this.Controls.Add(this.LBC);
			this.Controls.Add(this.LBB);
			this.Controls.Add(this.LBA);
			this.Controls.Add(this.Door);
			//this.Controls.Add(this.DoorD);
			//this.Controls.Add(this.DoorC);
			//this.Controls.Add(this.DoorE);
			this.Controls.Add(this.DoorB);
			this.Controls.Add(this.DoorA);
			//this.Controls.Add(this.WinD);
			//this.Controls.Add(this.WinC);
			//this.Controls.Add(this.WinE);
			//this.Controls.Add(this.WinB);
			//this.Controls.Add(this.WinA);
			//this.Controls.Add(this.LF);
			//this.Controls.Add(this.LE);
			//this.Controls.Add(this.LD);
			this.Controls.Add(this.LC);
			this.Controls.Add(this.LB);
			this.Controls.Add(this.LA);
			this.Controls.Add(this.Panel);
			this.DoubleBuffered = true;
			this.MaximumSize = new System.Drawing.Size(1324, 640);
			this.MinimumSize = new System.Drawing.Size(1324, 640);
			this.Name = "Form";
			this.Text = "Умный дом";
			this.Panel.ResumeLayout(false);
			this.Panel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.TKond)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Room)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.KBat)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.KAtm)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.TReg)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.TAtm)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.TKot)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Panel Panel;
		private Label LA;
		private Label LB;
		private Label LC;
		private Label LD;
		private Label LE;
		private Label LKot;
		private TrackBar TKot;
		private CheckBox RegOn;
		private Label LAtm;
		private TrackBar TAtm;
		private TrackBar KBat;
		private Label LKBat;
		private TrackBar KAtm;
		private Label LKAtm;
		private TrackBar TReg;
		private Label LReg;
		private Label LF;
		private Label WinA;
		private Label WinB;
		private Label WinE;
		private Label WinC;
		private Label WinD;
		private Label DoorA;
		private Label DoorB;
		private Label DoorE;
		private Label DoorC;
		private Label DoorD;
		private Label Door;
		private TrackBar Room;
		private Label LKRoom;
		private Button BTick;
		private Label LBA;
		private Label LBB;
		private Label LBC;
		private Label LBD;
		private Label LBE;
		private Label LT;
		private TrackBar TKond;
		private Label LKond;
		private CheckBox LTKond;
	}
}