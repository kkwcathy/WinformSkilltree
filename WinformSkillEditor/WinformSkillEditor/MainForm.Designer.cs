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
			this.JobBox.Location = new System.Drawing.Point(115, 72);
			this.JobBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.JobBox.Name = "JobBox";
			this.JobBox.Size = new System.Drawing.Size(124, 23);
			this.JobBox.TabIndex = 0;
			this.JobBox.SelectedIndexChanged += new System.EventHandler(this.JobBox_SelectedIndexChanged);
			// 
			// InputNewJob
			// 
			this.InputNewJob.Enabled = false;
			this.InputNewJob.Location = new System.Drawing.Point(37, 239);
			this.InputNewJob.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.InputNewJob.Name = "InputNewJob";
			this.InputNewJob.Size = new System.Drawing.Size(124, 25);
			this.InputNewJob.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(34, 76);
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
			this.JobSelectView.Location = new System.Drawing.Point(37, 166);
			this.JobSelectView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.JobSelectView.Name = "JobSelectView";
			this.JobSelectView.Size = new System.Drawing.Size(203, 64);
			this.JobSelectView.TabIndex = 3;
			this.JobSelectView.SelectedIndexChanged += new System.EventHandler(this.JobSelectView_SelectedIndexChanged);
			// 
			// btnAddJob
			// 
			this.btnAddJob.Enabled = false;
			this.btnAddJob.Location = new System.Drawing.Point(169, 239);
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
			this.StageSelectView.Enabled = false;
			this.StageSelectView.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.StageSelectView.FormattingEnabled = true;
			this.StageSelectView.ItemHeight = 12;
			this.StageSelectView.Location = new System.Drawing.Point(327, 166);
			this.StageSelectView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.StageSelectView.Name = "StageSelectView";
			this.StageSelectView.Size = new System.Drawing.Size(203, 64);
			this.StageSelectView.TabIndex = 8;
			this.StageSelectView.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.StageSelectView_DrawItem);
			this.StageSelectView.SelectedIndexChanged += new System.EventHandler(this.StageSelectView_SelectedIndexChanged);
			this.StageSelectView.Leave += new System.EventHandler(this.StageSelectView_NotSelected);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(34, 135);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(37, 15);
			this.label2.TabIndex = 9;
			this.label2.Text = "직업";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(285, 135);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(67, 15);
			this.label3.TabIndex = 10;
			this.label3.Text = "전직과정";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(289, 171);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(35, 60);
			this.label4.TabIndex = 11;
			this.label4.Text = "1차:\r\n2차:\r\n3차:\r\n4차:";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// btnStageModify
			// 
			this.btnStageModify.Enabled = false;
			this.btnStageModify.Location = new System.Drawing.Point(459, 240);
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
			this.StageTextBox.Location = new System.Drawing.Point(327, 240);
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
			this.CurStageText.Location = new System.Drawing.Point(289, 245);
			this.CurStageText.Name = "CurStageText";
			this.CurStageText.Size = new System.Drawing.Size(13, 15);
			this.CurStageText.TabIndex = 14;
			this.CurStageText.Text = " ";
			this.CurStageText.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(571, 750);
			this.Controls.Add(this.CurStageText);
			this.Controls.Add(this.btnStageModify);
			this.Controls.Add(this.StageTextBox);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.StageSelectView);
			this.Controls.Add(this.btnAddJob);
			this.Controls.Add(this.JobSelectView);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.InputNewJob);
			this.Controls.Add(this.JobBox);
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "MainForm";
			this.Text = "메이플 직업정보 편집기";
			this.ResumeLayout(false);
			this.PerformLayout();

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
	}
}