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
			this.btnModifyJob = new System.Windows.Forms.Button();
			this.InputNewSubJob = new System.Windows.Forms.TextBox();
			this.StageSelectView = new System.Windows.Forms.ListBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
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
			this.JobBox.Location = new System.Drawing.Point(93, 46);
			this.JobBox.Name = "JobBox";
			this.JobBox.Size = new System.Drawing.Size(109, 20);
			this.JobBox.TabIndex = 0;
			this.JobBox.SelectedIndexChanged += new System.EventHandler(this.JobBox_SelectedIndexChanged);
			// 
			// InputNewJob
			// 
			this.InputNewJob.Location = new System.Drawing.Point(93, 231);
			this.InputNewJob.Name = "InputNewJob";
			this.InputNewJob.Size = new System.Drawing.Size(109, 21);
			this.InputNewJob.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(22, 49);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(53, 12);
			this.label1.TabIndex = 2;
			this.label1.Text = "직업계열";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// JobSelectView
			// 
			this.JobSelectView.FormattingEnabled = true;
			this.JobSelectView.ItemHeight = 12;
			this.JobSelectView.Location = new System.Drawing.Point(93, 112);
			this.JobSelectView.Name = "JobSelectView";
			this.JobSelectView.Size = new System.Drawing.Size(178, 100);
			this.JobSelectView.TabIndex = 3;
			this.JobSelectView.SelectedIndexChanged += new System.EventHandler(this.JobSelectView_SelectedIndexChanged);
			// 
			// btnAddJob
			// 
			this.btnAddJob.Location = new System.Drawing.Point(209, 231);
			this.btnAddJob.Name = "btnAddJob";
			this.btnAddJob.Size = new System.Drawing.Size(62, 21);
			this.btnAddJob.TabIndex = 5;
			this.btnAddJob.Text = "추가";
			this.btnAddJob.UseVisualStyleBackColor = true;
			this.btnAddJob.Click += new System.EventHandler(this.btnAddJob_Click);
			// 
			// btnModifyJob
			// 
			this.btnModifyJob.Location = new System.Drawing.Point(408, 232);
			this.btnModifyJob.Name = "btnModifyJob";
			this.btnModifyJob.Size = new System.Drawing.Size(62, 21);
			this.btnModifyJob.TabIndex = 7;
			this.btnModifyJob.Text = "수정";
			this.btnModifyJob.UseVisualStyleBackColor = true;
			// 
			// InputNewSubJob
			// 
			this.InputNewSubJob.Location = new System.Drawing.Point(292, 231);
			this.InputNewSubJob.Name = "InputNewSubJob";
			this.InputNewSubJob.Size = new System.Drawing.Size(109, 21);
			this.InputNewSubJob.TabIndex = 6;
			// 
			// StageSelectView
			// 
			this.StageSelectView.FormattingEnabled = true;
			this.StageSelectView.ItemHeight = 12;
			this.StageSelectView.Location = new System.Drawing.Point(292, 112);
			this.StageSelectView.Name = "StageSelectView";
			this.StageSelectView.Size = new System.Drawing.Size(178, 100);
			this.StageSelectView.TabIndex = 8;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(91, 87);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(29, 12);
			this.label2.TabIndex = 9;
			this.label2.Text = "직업";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(290, 87);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(53, 12);
			this.label3.TabIndex = 10;
			this.label3.Text = "전직과정";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(500, 600);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.StageSelectView);
			this.Controls.Add(this.btnModifyJob);
			this.Controls.Add(this.InputNewSubJob);
			this.Controls.Add(this.btnAddJob);
			this.Controls.Add(this.JobSelectView);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.InputNewJob);
			this.Controls.Add(this.JobBox);
			this.Name = "MainForm";
			this.Text = "직업정보 편집기";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox JobBox;
		private System.Windows.Forms.TextBox InputNewJob;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ListBox JobSelectView;
		private System.Windows.Forms.Button btnAddJob;
		private System.Windows.Forms.Button btnModifyJob;
		private System.Windows.Forms.TextBox InputNewSubJob;
		private System.Windows.Forms.ListBox StageSelectView;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
	}
}