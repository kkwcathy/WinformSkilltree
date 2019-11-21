using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace WinformSkillEditor
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		/////////////////////////////분리예정: 스킬편집 페이wl
		private void TypeComboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			JobXmlManager.SetCurJobTypeNode(TypeComboBox1.SelectedItem.ToString());

			List<string> itemList = JobXmlManager.GetSubJobData();

			JobComboBox1.Items.Clear();

			foreach(var i in itemList)
			{
				JobComboBox1.Items.Add(i);
			}

			JobComboBox1.Enabled = true;
			StageComboBox1.Enabled = false;
		}

		private void JobComboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			JobXmlManager.SetCurSubJobNode(JobComboBox1.SelectedItem.ToString());

			string[] itemArray = JobXmlManager.GetStageData();

			StageComboBox1.Items.Clear();

			foreach (var i in itemArray)
			{
				if (i.Length == 0) { break; }

				StageComboBox1.Items.Add(i);
			}

			StageComboBox1.Enabled = true;
		}

		private void StageComboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			panel2.Visible = true;

			StringBuilder fileName = new StringBuilder();

			fileName.Append(JobXmlManager.GetFileName(TypeComboBox1.SelectedItem.ToString()));
			fileName.Append("_");
			fileName.Append((JobComboBox1.SelectedIndex + 1).ToString());
			fileName.Append("_");
			fileName.Append((StageComboBox1.SelectedIndex + 1).ToString());

			fileName.Append(".xml");

			SkillXmlManager._CurJobName = StageComboBox1.SelectedItem.ToString();
			SkillXmlManager._FileName = fileName.ToString();
			SkillXmlManager.LoadFile();

			UpdateSkillList();			
		}

		private void UpdateSkillList()
		{
			List<string> items = SkillXmlManager.GetSkillList();

			listBox1.Items.Clear();
			
			if(items.Count == 0)
			{
				listBox1.Items.Add("클릭해서 추가해주세요.");
				return;
			}

			foreach(var i in items)
			{
				listBox1.Items.Add(i);
			}
		}

		private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			panel3.Visible = true;
		}

		private void panel2_Paint(object sender, PaintEventArgs e)
		{

		}
	}
}
