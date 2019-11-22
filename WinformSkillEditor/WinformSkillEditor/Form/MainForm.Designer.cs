namespace WinformSkillEditor
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
			this.JobBox = new System.Windows.Forms.ComboBox();
			this.InputNewJob = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.JobSelectView = new System.Windows.Forms.ListBox();
			this.btnAddJob = new System.Windows.Forms.Button();
			this.StageSelectView = new System.Windows.Forms.ListBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.btnStageModify = new System.Windows.Forms.Button();
			this.StageTextBox = new System.Windows.Forms.TextBox();
			this.CurStageText = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label5 = new System.Windows.Forms.Label();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.panel3 = new System.Windows.Forms.Panel();
			this.label16 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.button1 = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.radioButton3 = new System.Windows.Forms.RadioButton();
			this.label12 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label10 = new System.Windows.Forms.Label();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.StageComboBox1 = new System.Windows.Forms.ComboBox();
			this.JobComboBox1 = new System.Windows.Forms.ComboBox();
			this.TypeComboBox1 = new System.Windows.Forms.ComboBox();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.openLabel = new System.Windows.Forms.LinkLabel();
			this.label11 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.StageComboBox2 = new System.Windows.Forms.ComboBox();
			this.JobComboBox2 = new System.Windows.Forms.ComboBox();
			this.TypeComboBox2 = new System.Windows.Forms.ComboBox();
			this.BtnTransform = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.tabPage3.SuspendLayout();
			this.SuspendLayout();
			// 
			// JobBox
			// 
			this.JobBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.JobBox.FormattingEnabled = true;
			this.JobBox.Items.AddRange(new object[] {
            "전사",
            "마법사",
            "궁수",
            "도적",
            "해적"});
			this.JobBox.Location = new System.Drawing.Point(81, 54);
			this.JobBox.Name = "JobBox";
			this.JobBox.Size = new System.Drawing.Size(109, 20);
			this.JobBox.TabIndex = 0;
			this.JobBox.SelectedIndexChanged += new System.EventHandler(this.JobBox_SelectedIndexChanged);
			// 
			// InputNewJob
			// 
			this.InputNewJob.Enabled = false;
			this.InputNewJob.Location = new System.Drawing.Point(12, 237);
			this.InputNewJob.Name = "InputNewJob";
			this.InputNewJob.Size = new System.Drawing.Size(109, 21);
			this.InputNewJob.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(11, 57);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(53, 12);
			this.label1.TabIndex = 2;
			this.label1.Text = "직업계열";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// JobSelectView
			// 
			this.JobSelectView.Enabled = false;
			this.JobSelectView.FormattingEnabled = true;
			this.JobSelectView.ItemHeight = 12;
			this.JobSelectView.Location = new System.Drawing.Point(12, 178);
			this.JobSelectView.Name = "JobSelectView";
			this.JobSelectView.Size = new System.Drawing.Size(178, 52);
			this.JobSelectView.TabIndex = 3;
			this.JobSelectView.SelectedIndexChanged += new System.EventHandler(this.JobSelectView_SelectedIndexChanged);
			// 
			// btnAddJob
			// 
			this.btnAddJob.Enabled = false;
			this.btnAddJob.Location = new System.Drawing.Point(128, 237);
			this.btnAddJob.Name = "btnAddJob";
			this.btnAddJob.Size = new System.Drawing.Size(62, 21);
			this.btnAddJob.TabIndex = 5;
			this.btnAddJob.Text = "추가";
			this.btnAddJob.UseVisualStyleBackColor = true;
			this.btnAddJob.Click += new System.EventHandler(this.btnAddJob_Click);
			// 
			// StageSelectView
			// 
			this.StageSelectView.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.StageSelectView.Enabled = false;
			this.StageSelectView.FormattingEnabled = true;
			this.StageSelectView.ItemHeight = 12;
			this.StageSelectView.Location = new System.Drawing.Point(270, 178);
			this.StageSelectView.Name = "StageSelectView";
			this.StageSelectView.Size = new System.Drawing.Size(178, 52);
			this.StageSelectView.TabIndex = 8;
			this.StageSelectView.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.StageSelectView_DrawItem);
			this.StageSelectView.SelectedIndexChanged += new System.EventHandler(this.StageSelectView_SelectedIndexChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(10, 153);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(29, 12);
			this.label2.TabIndex = 9;
			this.label2.Text = "직업";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(234, 153);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(53, 12);
			this.label3.TabIndex = 10;
			this.label3.Text = "전직과정";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(237, 182);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(27, 48);
			this.label4.TabIndex = 11;
			this.label4.Text = "1차:\r\n2차:\r\n3차:\r\n4차:";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// btnStageModify
			// 
			this.btnStageModify.Enabled = false;
			this.btnStageModify.Location = new System.Drawing.Point(386, 237);
			this.btnStageModify.Name = "btnStageModify";
			this.btnStageModify.Size = new System.Drawing.Size(62, 21);
			this.btnStageModify.TabIndex = 13;
			this.btnStageModify.Text = "수정";
			this.btnStageModify.UseVisualStyleBackColor = true;
			this.btnStageModify.Click += new System.EventHandler(this.btnStageModify_Click);
			// 
			// StageTextBox
			// 
			this.StageTextBox.Enabled = false;
			this.StageTextBox.Location = new System.Drawing.Point(270, 237);
			this.StageTextBox.Name = "StageTextBox";
			this.StageTextBox.Size = new System.Drawing.Size(109, 21);
			this.StageTextBox.TabIndex = 12;
			// 
			// CurStageText
			// 
			this.CurStageText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.CurStageText.AutoSize = true;
			this.CurStageText.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.CurStageText.Location = new System.Drawing.Point(237, 241);
			this.CurStageText.Name = "CurStageText";
			this.CurStageText.Size = new System.Drawing.Size(10, 12);
			this.CurStageText.TabIndex = 14;
			this.CurStageText.Text = " ";
			this.CurStageText.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.CurStageText);
			this.panel1.Controls.Add(this.btnStageModify);
			this.panel1.Controls.Add(this.StageTextBox);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.StageSelectView);
			this.panel1.Controls.Add(this.btnAddJob);
			this.panel1.Controls.Add(this.JobSelectView);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.InputNewJob);
			this.panel1.Controls.Add(this.JobBox);
			this.panel1.Location = new System.Drawing.Point(5, 5);
			this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(460, 335);
			this.panel1.TabIndex = 15;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label5.Location = new System.Drawing.Point(11, 32);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(153, 12);
			this.label5.TabIndex = 14;
			this.label5.Text = "직업계열을 선택해주세요";
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Controls.Add(this.tabPage3);
			this.tabControl1.Location = new System.Drawing.Point(10, 10);
			this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(478, 370);
			this.tabControl1.TabIndex = 16;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.panel1);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tabPage1.Size = new System.Drawing.Size(470, 344);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "직업목록";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.panel3);
			this.tabPage2.Controls.Add(this.panel2);
			this.tabPage2.Controls.Add(this.label8);
			this.tabPage2.Controls.Add(this.label7);
			this.tabPage2.Controls.Add(this.label6);
			this.tabPage2.Controls.Add(this.StageComboBox1);
			this.tabPage2.Controls.Add(this.JobComboBox1);
			this.tabPage2.Controls.Add(this.TypeComboBox1);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tabPage2.Size = new System.Drawing.Size(470, 344);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "스킬목록";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.PowderBlue;
			this.panel3.Controls.Add(this.label16);
			this.panel3.Controls.Add(this.label13);
			this.panel3.Controls.Add(this.numericUpDown1);
			this.panel3.Controls.Add(this.button1);
			this.panel3.Controls.Add(this.groupBox1);
			this.panel3.Controls.Add(this.label12);
			this.panel3.Controls.Add(this.label9);
			this.panel3.Controls.Add(this.textBox2);
			this.panel3.Controls.Add(this.textBox1);
			this.panel3.Location = new System.Drawing.Point(207, 24);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(257, 295);
			this.panel3.TabIndex = 7;
			this.panel3.Visible = false;
			this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label16.Location = new System.Drawing.Point(70, 4);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(123, 16);
			this.label16.TabIndex = 26;
			this.label16.Text = "스킬 추가/수정";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(123, 208);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(69, 12);
			this.label13.TabIndex = 25;
			this.label13.Text = "마스터 레벨";
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.Location = new System.Drawing.Point(198, 205);
			this.numericUpDown1.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
			this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(42, 21);
			this.numericUpDown1.TabIndex = 24;
			this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.button1.Location = new System.Drawing.Point(75, 253);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(108, 30);
			this.button1.TabIndex = 23;
			this.button1.Text = "등록하기";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.radioButton1);
			this.groupBox1.Controls.Add(this.radioButton2);
			this.groupBox1.Controls.Add(this.radioButton3);
			this.groupBox1.Location = new System.Drawing.Point(15, 152);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(225, 47);
			this.groupBox1.TabIndex = 22;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "스킬 타입";
			// 
			// radioButton1
			// 
			this.radioButton1.AutoSize = true;
			this.radioButton1.Checked = true;
			this.radioButton1.Location = new System.Drawing.Point(20, 20);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(47, 16);
			this.radioButton1.TabIndex = 2;
			this.radioButton1.TabStop = true;
			this.radioButton1.Text = "공격";
			this.radioButton1.UseVisualStyleBackColor = true;
			this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
			// 
			// radioButton2
			// 
			this.radioButton2.AutoSize = true;
			this.radioButton2.Location = new System.Drawing.Point(83, 20);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(47, 16);
			this.radioButton2.TabIndex = 3;
			this.radioButton2.TabStop = true;
			this.radioButton2.Text = "버프";
			this.radioButton2.UseVisualStyleBackColor = true;
			this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
			// 
			// radioButton3
			// 
			this.radioButton3.AutoSize = true;
			this.radioButton3.Location = new System.Drawing.Point(148, 20);
			this.radioButton3.Name = "radioButton3";
			this.radioButton3.Size = new System.Drawing.Size(59, 16);
			this.radioButton3.TabIndex = 17;
			this.radioButton3.TabStop = true;
			this.radioButton3.Text = "패시브";
			this.radioButton3.UseVisualStyleBackColor = true;
			this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(13, 71);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(29, 12);
			this.label12.TabIndex = 21;
			this.label12.Text = "설명";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(12, 42);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(29, 12);
			this.label9.TabIndex = 18;
			this.label9.Text = "이름";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(51, 69);
			this.textBox2.Multiline = true;
			this.textBox2.Name = "textBox2";
			this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textBox2.Size = new System.Drawing.Size(189, 69);
			this.textBox2.TabIndex = 1;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(50, 37);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(190, 21);
			this.textBox1.TabIndex = 0;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.label10);
			this.panel2.Controls.Add(this.listBox1);
			this.panel2.Location = new System.Drawing.Point(15, 116);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(179, 203);
			this.panel2.TabIndex = 6;
			this.panel2.Visible = false;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(22, 11);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(53, 12);
			this.label10.TabIndex = 19;
			this.label10.Text = "스킬목록";
			// 
			// listBox1
			// 
			this.listBox1.FormattingEnabled = true;
			this.listBox1.ItemHeight = 12;
			this.listBox1.Location = new System.Drawing.Point(24, 41);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(141, 148);
			this.listBox1.TabIndex = 0;
			this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(13, 94);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(53, 12);
			this.label8.TabIndex = 5;
			this.label8.Text = "전직과정";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(37, 61);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(29, 12);
			this.label7.TabIndex = 4;
			this.label7.Text = "직업";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(37, 27);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(29, 12);
			this.label6.TabIndex = 3;
			this.label6.Text = "계열";
			// 
			// StageComboBox1
			// 
			this.StageComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.StageComboBox1.Enabled = false;
			this.StageComboBox1.FormattingEnabled = true;
			this.StageComboBox1.Location = new System.Drawing.Point(72, 91);
			this.StageComboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.StageComboBox1.Name = "StageComboBox1";
			this.StageComboBox1.Size = new System.Drawing.Size(122, 20);
			this.StageComboBox1.TabIndex = 2;
			this.StageComboBox1.SelectedIndexChanged += new System.EventHandler(this.StageComboBox1_SelectedIndexChanged);
			// 
			// JobComboBox1
			// 
			this.JobComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.JobComboBox1.Enabled = false;
			this.JobComboBox1.FormattingEnabled = true;
			this.JobComboBox1.Location = new System.Drawing.Point(72, 58);
			this.JobComboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.JobComboBox1.Name = "JobComboBox1";
			this.JobComboBox1.Size = new System.Drawing.Size(122, 20);
			this.JobComboBox1.TabIndex = 1;
			this.JobComboBox1.SelectedIndexChanged += new System.EventHandler(this.JobComboBox1_SelectedIndexChanged);
			// 
			// TypeComboBox1
			// 
			this.TypeComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.TypeComboBox1.FormattingEnabled = true;
			this.TypeComboBox1.Items.AddRange(new object[] {
            "전사",
            "마법사",
            "궁수",
            "도적",
            "해적"});
			this.TypeComboBox1.Location = new System.Drawing.Point(72, 24);
			this.TypeComboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.TypeComboBox1.Name = "TypeComboBox1";
			this.TypeComboBox1.Size = new System.Drawing.Size(122, 20);
			this.TypeComboBox1.TabIndex = 0;
			this.TypeComboBox1.SelectedIndexChanged += new System.EventHandler(this.TypeComboBox1_SelectedIndexChanged);
			// 
			// tabPage3
			// 
			this.tabPage3.Controls.Add(this.openLabel);
			this.tabPage3.Controls.Add(this.label11);
			this.tabPage3.Controls.Add(this.label14);
			this.tabPage3.Controls.Add(this.label15);
			this.tabPage3.Controls.Add(this.StageComboBox2);
			this.tabPage3.Controls.Add(this.JobComboBox2);
			this.tabPage3.Controls.Add(this.TypeComboBox2);
			this.tabPage3.Controls.Add(this.BtnTransform);
			this.tabPage3.Location = new System.Drawing.Point(4, 22);
			this.tabPage3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tabPage3.Size = new System.Drawing.Size(470, 344);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "직업정보 조회";
			this.tabPage3.UseVisualStyleBackColor = true;
			// 
			// openLabel
			// 
			this.openLabel.AutoSize = true;
			this.openLabel.Font = new System.Drawing.Font("나눔바른고딕", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.openLabel.Location = new System.Drawing.Point(165, 253);
			this.openLabel.Name = "openLabel";
			this.openLabel.Size = new System.Drawing.Size(125, 31);
			this.openLabel.TabIndex = 12;
			this.openLabel.TabStop = true;
			this.openLabel.Text = "html 열기";
			this.openLabel.Visible = false;
			this.openLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.openLabel_LinkClicked);
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(11, 101);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(53, 12);
			this.label11.TabIndex = 11;
			this.label11.Text = "전직과정";
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(35, 63);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(29, 12);
			this.label14.TabIndex = 10;
			this.label14.Text = "직업";
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Location = new System.Drawing.Point(35, 27);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(29, 12);
			this.label15.TabIndex = 9;
			this.label15.Text = "계열";
			// 
			// StageComboBox2
			// 
			this.StageComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.StageComboBox2.Enabled = false;
			this.StageComboBox2.FormattingEnabled = true;
			this.StageComboBox2.Location = new System.Drawing.Point(70, 98);
			this.StageComboBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.StageComboBox2.Name = "StageComboBox2";
			this.StageComboBox2.Size = new System.Drawing.Size(122, 20);
			this.StageComboBox2.TabIndex = 8;
			this.StageComboBox2.SelectedIndexChanged += new System.EventHandler(this.StageComboBox2_SelectedIndexChanged);
			// 
			// JobComboBox2
			// 
			this.JobComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.JobComboBox2.Enabled = false;
			this.JobComboBox2.FormattingEnabled = true;
			this.JobComboBox2.Location = new System.Drawing.Point(70, 60);
			this.JobComboBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.JobComboBox2.Name = "JobComboBox2";
			this.JobComboBox2.Size = new System.Drawing.Size(122, 20);
			this.JobComboBox2.TabIndex = 7;
			this.JobComboBox2.SelectedIndexChanged += new System.EventHandler(this.JobComboBox2_SelectedIndexChanged);
			// 
			// TypeComboBox2
			// 
			this.TypeComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.TypeComboBox2.FormattingEnabled = true;
			this.TypeComboBox2.Items.AddRange(new object[] {
            "전사",
            "마법사",
            "궁수",
            "도적",
            "해적"});
			this.TypeComboBox2.Location = new System.Drawing.Point(70, 24);
			this.TypeComboBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.TypeComboBox2.Name = "TypeComboBox2";
			this.TypeComboBox2.Size = new System.Drawing.Size(122, 20);
			this.TypeComboBox2.TabIndex = 6;
			this.TypeComboBox2.SelectedIndexChanged += new System.EventHandler(this.TypeComboBox2_SelectedIndexChanged);
			// 
			// BtnTransform
			// 
			this.BtnTransform.Location = new System.Drawing.Point(96, 200);
			this.BtnTransform.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.BtnTransform.Name = "BtnTransform";
			this.BtnTransform.Size = new System.Drawing.Size(278, 34);
			this.BtnTransform.TabIndex = 0;
			this.BtnTransform.Text = "해당 직업 정보를 html로 내보내기";
			this.BtnTransform.UseVisualStyleBackColor = true;
			this.BtnTransform.Visible = false;
			this.BtnTransform.Click += new System.EventHandler(this.BtnTransform_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(499, 391);
			this.Controls.Add(this.tabControl1);
			this.Name = "MainForm";
			this.Text = "메이플스토리 직업정보 편집기";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.tabPage3.ResumeLayout(false);
			this.tabPage3.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		protected System.Windows.Forms.ComboBox JobBox;
		protected System.Windows.Forms.TextBox InputNewJob;
		protected System.Windows.Forms.Label label1;
		protected System.Windows.Forms.ListBox JobSelectView;
		protected System.Windows.Forms.Button btnAddJob;
		protected System.Windows.Forms.ListBox StageSelectView;
		protected System.Windows.Forms.Label label2;
		protected System.Windows.Forms.Label label3;
		protected System.Windows.Forms.Label label4;
		protected System.Windows.Forms.Button btnStageModify;
		protected System.Windows.Forms.TextBox StageTextBox;
		protected System.Windows.Forms.Label CurStageText;
		protected System.Windows.Forms.Panel panel1;
		protected System.Windows.Forms.TabControl tabControl1;
		protected System.Windows.Forms.TabPage tabPage1;
		protected System.Windows.Forms.TabPage tabPage2;
		protected System.Windows.Forms.Label label5;
		protected System.Windows.Forms.Label label8;
		protected System.Windows.Forms.Label label7;
		protected System.Windows.Forms.Label label6;
		protected System.Windows.Forms.ComboBox StageComboBox1;
		protected System.Windows.Forms.ComboBox JobComboBox1;
		protected System.Windows.Forms.ComboBox TypeComboBox1;
		protected System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.RadioButton radioButton3;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.NumericUpDown numericUpDown1;
		private System.Windows.Forms.Button BtnTransform;
		protected System.Windows.Forms.Label label11;
		protected System.Windows.Forms.Label label14;
		protected System.Windows.Forms.Label label15;
		protected System.Windows.Forms.ComboBox StageComboBox2;
		protected System.Windows.Forms.ComboBox JobComboBox2;
		protected System.Windows.Forms.ComboBox TypeComboBox2;
		private System.Windows.Forms.LinkLabel openLabel;
		private System.Windows.Forms.Label label16;
	}
}