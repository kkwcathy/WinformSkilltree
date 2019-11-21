using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace WinformSkillEditor
{
	// 직업정보 편집 tab 부분만 분리한 partial class

	public partial class MainForm : Form
	{
		public void JobBox_SelectedIndexChanged(object sender, EventArgs e)
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

		public void UpdateJobSelectView()
		{
			List<string> jobitemList = JobXmlManager.GetSubJobData();

			JobSelectView.Items.Clear();

			foreach (var i in jobitemList)
			{
				JobSelectView.Items.Add(i);
			}
		}

		public void UpdateStageView()
		{
			string[] stageArr = JobXmlManager.GetStageData();

			StageSelectView.Items.Clear();

			for (int i = 0; i < stageArr.Length; i++)
			{
				StageSelectView.Items.Add(new MyListBoxItem(stageArr[i]));

				if (stageArr[i].Length == 0)
				{
					break;
				}
			}
		}

		public void JobSelectView_SelectedIndexChanged(object sender, EventArgs e)
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

		public void btnAddJob_Click(object sender, EventArgs e)
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

		public void StageSelectView_DrawItem(object sender, DrawItemEventArgs e)
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

		public void StageSelectView_SelectedIndexChanged(object sender, EventArgs e)
		{
			ListBox listBox = (ListBox)sender;
			MyListBoxItem curItem = (MyListBoxItem)listBox.SelectedItem;

			if (curItem == null) { return; }

			string buttonText = curItem.Message.Length > 0 ? "수정" : "추가";

			StageTextBox.Enabled = true;
			btnStageModify.Enabled = true;
			btnStageModify.Text = buttonText;
			StageTextBox.Text = curItem.Message;
			CurStageText.Text = (listBox.SelectedIndex + 1) + "차";

		}

		public void btnStageModify_Click(object sender, EventArgs e)
		{

			if (StageTextBox.TextLength == 0)
			{
				MessageBox.Show("수정할 직업이름을 입력해주세요");
				return;
			}

			if (!JobXmlManager.ModifyStage(StageSelectView.SelectedIndex + 1, StageTextBox.Text))
			{
				MessageBox.Show("modify error");
				return;
			}

			UpdateStageView();
		}

		public void StagePanelClear()
		{
			StageSelectView.Items.Clear();
			StageSelectView.Enabled = false;
			CurStageText.Text = " ";
			btnStageModify.Enabled = false;
			StageTextBox.Enabled = false;
		}
	}
}


