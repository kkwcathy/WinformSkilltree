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
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.StageComboBox1 = new System.Windows.Forms.ComboBox();
			this.JobComboBox1 = new System.Windows.Forms.ComboBox();
			this.TypeComboBox1 = new System.Windows.Forms.ComboBox();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.panel1.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
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
			this.JobBox.Location = new System.Drawing.Point(92, 45);
			this.JobBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.JobBox.Name = "JobBox";
			this.JobBox.Size = new System.Drawing.Size(124, 23);
			this.JobBox.TabIndex = 0;
			this.JobBox.SelectedIndexChanged += new System.EventHandler(this.JobBox_SelectedIndexChanged);
			// 
			// InputNewJob
			// 
			this.InputNewJob.Enabled = false;
			this.InputNewJob.Location = new System.Drawing.Point(14, 212);
			this.InputNewJob.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.InputNewJob.Name = "InputNewJob";
			this.InputNewJob.Size = new System.Drawing.Size(124, 25);
			this.InputNewJob.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(11, 49);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(67, 15);
			this.label1.TabIndex = 2;
			this.label1.Text = "직업계열";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// JobSelectView
			// 
			this.JobSelectView.Enabled = false;
			this.JobSelectView.FormattingEnabled = true;
			this.JobSelectView.ItemHeight = 15;
			this.JobSelectView.Location = new System.Drawing.Point(14, 139);
			this.JobSelectView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.JobSelectView.Name = "JobSelectView";
			this.JobSelectView.Size = new System.Drawing.Size(203, 64);
			this.JobSelectView.TabIndex = 3;
			this.JobSelectView.SelectedIndexChanged += new System.EventHandler(this.JobSelectView_SelectedIndexChanged);
			// 
			// btnAddJob
			// 
			this.btnAddJob.Enabled = false;
			this.btnAddJob.Location = new System.Drawing.Point(146, 212);
			this.btnAddJob.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.btnAddJob.Name = "btnAddJob";
			this.btnAddJob.Size = new System.Drawing.Size(71, 26);
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
			this.StageSelectView.Location = new System.Drawing.Point(309, 139);
			this.StageSelectView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.StageSelectView.Name = "StageSelectView";
			this.StageSelectView.Size = new System.Drawing.Size(203, 64);
			this.StageSelectView.TabIndex = 8;
			this.StageSelectView.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.StageSelectView_DrawItem);
			this.StageSelectView.SelectedIndexChanged += new System.EventHandler(this.StageSelectView_SelectedIndexChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(11, 108);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(37, 15);
			this.label2.TabIndex = 9;
			this.label2.Text = "직업";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(267, 108);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(67, 15);
			this.label3.TabIndex = 10;
			this.label3.Text = "전직과정";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(271, 144);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(35, 60);
			this.label4.TabIndex = 11;
			this.label4.Text = "1차:\r\n2차:\r\n3차:\r\n4차:";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// btnStageModify
			// 
			this.btnStageModify.Enabled = false;
			this.btnStageModify.Location = new System.Drawing.Point(441, 213);
			this.btnStageModify.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.btnStageModify.Name = "btnStageModify";
			this.btnStageModify.Size = new System.Drawing.Size(71, 26);
			this.btnStageModify.TabIndex = 13;
			this.btnStageModify.Text = "수정";
			this.btnStageModify.UseVisualStyleBackColor = true;
			this.btnStageModify.Click += new System.EventHandler(this.btnStageModify_Click);
			// 
			// StageTextBox
			// 
			this.StageTextBox.Enabled = false;
			this.StageTextBox.Location = new System.Drawing.Point(309, 213);
			this.StageTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.StageTextBox.Name = "StageTextBox";
			this.StageTextBox.Size = new System.Drawing.Size(124, 25);
			this.StageTextBox.TabIndex = 12;
			// 
			// CurStageText
			// 
			this.CurStageText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.CurStageText.AutoSize = true;
			this.CurStageText.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.CurStageText.Location = new System.Drawing.Point(271, 219);
			this.CurStageText.Name = "CurStageText";
			this.CurStageText.Size = new System.Drawing.Size(13, 15);
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
			this.panel1.Location = new System.Drawing.Point(6, 6);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(526, 268);
			this.panel1.TabIndex = 15;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label5.Location = new System.Drawing.Point(11, 17);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(189, 15);
			this.label5.TabIndex = 14;
			this.label5.Text = "직업계열을 선택해주세요";
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Controls.Add(this.tabPage3);
			this.tabControl1.Location = new System.Drawing.Point(12, 12);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(546, 311);
			this.tabControl1.TabIndex = 16;
			
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.panel1);
			this.tabPage1.Location = new System.Drawing.Point(4, 25);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(538, 282);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "직업목록";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.label8);
			this.tabPage2.Controls.Add(this.label7);
			this.tabPage2.Controls.Add(this.label6);
			this.tabPage2.Controls.Add(this.StageComboBox1);
			this.tabPage2.Controls.Add(this.JobComboBox1);
			this.tabPage2.Controls.Add(this.TypeComboBox1);
			this.tabPage2.Location = new System.Drawing.Point(4, 25);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(538, 282);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "스킬목록";
			this.tabPage2.UseVisualStyleBackColor = true;
			this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(23, 210);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(67, 15);
			this.label8.TabIndex = 5;
			this.label8.Text = "전직과정";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(23, 127);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(37, 15);
			this.label7.TabIndex = 4;
			this.label7.Text = "직업";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(23, 44);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(37, 15);
			this.label6.TabIndex = 3;
			this.label6.Text = "계열";
			// 
			// StageComboBox1
			// 
			this.StageComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.StageComboBox1.Enabled = false;
			this.StageComboBox1.FormattingEnabled = true;
			this.StageComboBox1.Location = new System.Drawing.Point(26, 228);
			this.StageComboBox1.Name = "StageComboBox1";
			this.StageComboBox1.Size = new System.Drawing.Size(158, 23);
			this.StageComboBox1.TabIndex = 2;
			// 
			// JobComboBox1
			// 
			this.JobComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.JobComboBox1.Enabled = false;
			this.JobComboBox1.FormattingEnabled = true;
			this.JobComboBox1.Location = new System.Drawing.Point(26, 145);
			this.JobComboBox1.Name = "JobComboBox1";
			this.JobComboBox1.Size = new System.Drawing.Size(158, 23);
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
			this.TypeComboBox1.Location = new System.Drawing.Point(26, 62);
			this.TypeComboBox1.Name = "TypeComboBox1";
			this.TypeComboBox1.Size = new System.Drawing.Size(158, 23);
			this.TypeComboBox1.TabIndex = 0;
			this.TypeComboBox1.SelectedIndexChanged += new System.EventHandler(this.TypeComboBox1_SelectedIndexChanged);
			// 
			// tabPage3
			// 
			this.tabPage3.Location = new System.Drawing.Point(4, 25);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage3.Size = new System.Drawing.Size(538, 282);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "직업정보 조회";
			this.tabPage3.UseVisualStyleBackColor = true;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(570, 337);
			this.Controls.Add(this.tabControl1);
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "MainForm";
			this.Text = "메이플스토리 직업정보 편집기";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ComboBox JobBox;
		private System.Windows.Forms.TextBox InputNewJob;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ListBox JobSelectView;
		private System.Windows.Forms.Button btnAddJob;
		private System.Windows.Forms.ListBox StageSelectView;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnStageModify;
		private System.Windows.Forms.TextBox StageTextBox;
		private System.Windows.Forms.Label CurStageText;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ComboBox StageComboBox1;
		private System.Windows.Forms.ComboBox JobComboBox1;
		private System.Windows.Forms.ComboBox TypeComboBox1;
		private System.Windows.Forms.TabPage tabPage3;
	}
}