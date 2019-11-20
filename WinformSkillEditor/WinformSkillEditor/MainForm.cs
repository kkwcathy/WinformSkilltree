using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace WinformSkillEditor
{

	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();	
		}

		private void JobBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			ComboBox comboBox = (ComboBox)sender;

			label5.Text = " ";

			JobSelectView.Enabled = true;
			btnAddJob.Enabled = true;
			InputNewJob.Enabled = true;

			if (!JobXmlManager.SetCurJobTypeNode(comboBox.SelectedItem.ToString()))
			{
				return;
			}

			StagePanelClear();
			UpdateJobSelectView();
		}

		private void UpdateJobSelectView()
		{
			List<string> jobitemList = JobXmlManager.GetSubJobData();

			JobSelectView.Items.Clear();

			foreach (var i in jobitemList)
			{
				JobSelectView.Items.Add(i);
			}
		}
		
		private void UpdateStageView()
		{
			string[] stageArr = JobXmlManager.GetStageData();

			StageSelectView.Items.Clear();

			for(int i = 0; i < stageArr.Length; i++)
			{
				StageSelectView.Items.Add(new MyListBoxItem(stageArr[i]));

				if(stageArr[i].Length == 0)
				{
					break;
				}
			}
		}

		private void JobSelectView_SelectedIndexChanged(object sender, EventArgs e)
		{
		
			ListBox listBox = (ListBox)sender;

			if (!JobXmlManager.SetCurSubJobNode(listBox.Text)) { return; }

			StageSelectView.Enabled = true;

			StageTextBox.Enabled = false;
			btnStageModify.Enabled = false;
			StageTextBox.Text = "";
			CurStageText.Text = "";

			UpdateStageView();
		}
		
		private void btnAddJob_Click(object sender, EventArgs e)
		{
			string addJobText = InputNewJob.Text.ToString();

			if (addJobText.Length == 0)
			{
				MessageBox.Show("추가할 직업을 입력해주세요.");
				return;
			}

			if (!JobXmlManager.AddSubJob(InputNewJob.Text))
			{
				MessageBox.Show("add error");
				return;
			}

			UpdateJobSelectView();
		}

		private void StageSelectView_DrawItem(object sender, DrawItemEventArgs e)
		{

			if (e.Index == -1) return;
			MyListBoxItem item = StageSelectView.Items[e.Index] as MyListBoxItem;

			string msg;


			if (item.Message.Length > 0)
			{
			
				item.ItemColor = Color.Black;
				msg = item.Message;

			}
			else
			{
				item.ItemColor = Color.Green;
				msg = "클릭해서 추가해주세요";
			}

			e.Graphics.DrawString(
				msg,
				StageSelectView.Font,
				new SolidBrush(item.ItemColor),
				0,
				e.Index * StageSelectView.ItemHeight
			);
		}

		private void StageSelectView_SelectedIndexChanged(object sender, EventArgs e)
		{
			ListBox listBox = (ListBox)sender;
			MyListBoxItem curItem = (MyListBoxItem)listBox.SelectedItem;

			if(curItem == null) { return; }

			string buttonText = curItem.Message.Length > 0 ? "수정" : "추가";
			
			StageTextBox.Enabled = true;
			btnStageModify.Enabled = true;
			btnStageModify.Text = buttonText;
			StageTextBox.Text = curItem.Message;
			CurStageText.Text = (listBox.SelectedIndex + 1) + "차";

		}

		private void btnStageModify_Click(object sender, EventArgs e)
		{
			
			if(StageTextBox.TextLength == 0)
			{
				MessageBox.Show("수정할 직업이름을 입력해주세요");
				return;
			}

			if(!JobXmlManager.ModifyStage(StageSelectView.SelectedIndex + 1, StageTextBox.Text))
			{
				MessageBox.Show("modify error");
				return;
			}

			UpdateStageView();
		}

		private void StagePanelClear()
		{
			StageSelectView.Items.Clear();
			StageSelectView.Enabled = false;
			CurStageText.Text = " ";
			btnStageModify.Enabled = false;
			StageTextBox.Enabled = false;
		}


		/////////////////////////////분리예정: 스킬편집 페이지


		//빼야함
		private void tabPage2_Click(object sender, EventArgs e)
		{
			JobComboBox1.Enabled = false;
			StageComboBox1.Enabled = false;
		}

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
	}
}
