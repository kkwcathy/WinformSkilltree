using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Xsl;
using System.IO;

namespace WinformSkillEditor
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();

		}

		private void BtnTransform_Click(object sender, EventArgs e)
		{
			string targetFileName =
				GetFileName(TypeComboBox2.SelectedItem.ToString(), JobComboBox2.SelectedIndex, StageComboBox2.SelectedIndex);
			XslCompiledTransform myXslTransform;
			myXslTransform = new XslCompiledTransform();
			myXslTransform.Load(Application.StartupPath + "\\..\\..\\Show.xsl");

			try
			{
				myXslTransform.Transform(Application.StartupPath + "\\..\\..\\xml\\" + targetFileName, Application.StartupPath + "\\..\\..\\Result.html");
			}
			catch (FileNotFoundException error)
			{
				MessageBox.Show("해당 직업의 스킬정보가 등록되지 않았습니다. 스킬목록 탭에서 스킬을 추가해주세요.");
				return;
			}
			
			openLabel.Visible = true;
		}

		private string GetFileName(string type, int jobIndex, int stageIndex)
		{
			StringBuilder fileName = new StringBuilder();

			fileName.Append(JobXmlManager.GetFileName(type));

			if (stageIndex > 0)
			{
				fileName.Append("_");
				fileName.Append((jobIndex + 1).ToString());
				fileName.Append("_");
				fileName.Append((stageIndex + 1).ToString());
			}

			fileName.Append(".xml");

			return fileName.ToString();
		}

		private void TypeComboBox2_SelectedIndexChanged(object sender, EventArgs e)
		{
			JobXmlManager.SetCurJobTypeNode(TypeComboBox2.SelectedItem.ToString());

			List<string> itemList = JobXmlManager.GetSubJobData();

			JobComboBox2.Items.Clear();

			foreach (var i in itemList)
			{
				JobComboBox2.Items.Add(i);
			}

			JobComboBox2.Enabled = true;
			StageComboBox2.Items.Clear();
			StageComboBox2.Enabled = false;
			BtnTransform.Visible = false;
			openLabel.Visible = false;
		}

		private void JobComboBox2_SelectedIndexChanged(object sender, EventArgs e)
		{
			JobXmlManager.SetCurSubJobNode(JobComboBox2.SelectedItem.ToString());

			string[] itemArray = JobXmlManager.GetStageData();

			StageComboBox2.Items.Clear();

			foreach (var i in itemArray)
			{
				if (i.Length == 0) { break; }

				StageComboBox2.Items.Add(i);
			}

			StageComboBox2.Enabled = true;
			BtnTransform.Visible = false;
			openLabel.Visible = false;
		}

		private void StageComboBox2_SelectedIndexChanged(object sender, EventArgs e)
		{
			BtnTransform.Visible = true;
			openLabel.Visible = false;
		}

		private void openLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			System.Diagnostics.Process.Start(Application.StartupPath + "\\..\\..\\html\\Result.html");
		}

		private void panel3_Paint(object sender, PaintEventArgs e)
		{

		}

	}
}
