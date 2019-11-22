using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace WinformSkillEditor
{
	// 스킬 편집 tab 부분만 분리한 partial class

	public partial class MainForm : Form 
	{
		string _curSkillName = null;
		string _curSkillType;

		private void TypeComboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			JobXmlManager.SetCurJobTypeNode(TypeComboBox1.SelectedItem.ToString());

			List<string> itemList = JobXmlManager.GetSubJobData();

			JobComboBox1.Items.Clear();

			foreach (var i in itemList)
			{
				JobComboBox1.Items.Add(i);
			}

			JobComboBox1.Enabled = true;
			StageComboBox1.Items.Clear();
			StageComboBox1.Enabled = false;

			panel2.Visible = false;
			panel3.Visible = false;
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

			panel2.Visible = false;
			panel3.Visible = false;
		}

		private void StageComboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			panel2.Visible = true;

			SkillXmlManager._CurJobName = StageComboBox1.SelectedItem.ToString();
			SkillXmlManager._FileName = 
				GetFileName(TypeComboBox1.SelectedItem.ToString(), JobComboBox1.SelectedIndex, StageComboBox1.SelectedIndex);
			SkillXmlManager.LoadFile();

			UpdateSkillList();
		}

		private void UpdateSkillList()
		{
			List<string> items = SkillXmlManager.GetSkillList();

			listBox1.Items.Clear();

			foreach (var i in items)
			{
				listBox1.Items.Add(i);
			}

			listBox1.Items.Add("(추가하기)");

			panel3.Visible = false;
		}

		private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			ListBox selected = sender as ListBox;

			if (selected.Text.Length == 0) { return; }

			//pictureBox1.Load(Application.StartupPath + "\\..\\..\\img\\default.png");
			//pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			panel3.Visible = true;

			SkillInfo curInfo;

			if (SkillXmlManager.GetSelectedSkillInfo(selected.Text, out curInfo))
			{
				textBox1.Text = curInfo.Name;
				textBox2.Text = curInfo.Explanation;
				numericUpDown1.Value = curInfo.MasterLevel;

				_curSkillName = curInfo.Name;
				_curSkillType = curInfo.Type;

				CheckRadioButton();
			}
			else
			{
				ClearSkillInfo();
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (textBox1.Text.Length == 0 || textBox2.Text.Length == 0)
			{
				MessageBox.Show("스킬 이름과 설명을 적어주세요");
				return;
			}

			SkillInfo newSkillInfo = new SkillInfo(
					textBox1.Text,
					textBox2.Text,
					_curSkillType,
					(int)numericUpDown1.Value
				);

			if (_curSkillName == null)
			{
				SkillXmlManager.AddSkill(newSkillInfo);
				MessageBox.Show("스킬이 새로 등록되었습니다.");
			}
			else
			{
				if (SkillXmlManager.ModifySkill(_curSkillName, newSkillInfo))
				{
					MessageBox.Show("스킬이 수정되었습니다.");
				}
				else
				{
					MessageBox.Show("수정 실패");
				}
			}

			UpdateSkillList();
		}

		private void ClearSkillInfo()
		{
			textBox1.Clear();
			textBox2.Clear();
			numericUpDown1.Value = numericUpDown1.Minimum;

			_curSkillName = null;
			_curSkillType = radioButton1.Text;
			CheckRadioButton();
		}

		private void radioButton_CheckedChanged(object sender, EventArgs e)
		{
			if (sender is RadioButton)
			{
				RadioButton radioButton = sender as RadioButton;

				_curSkillType = radioButton.Text;
			}
		}

		private void CheckRadioButton()
		{
			Dictionary<string, RadioButton> radioBtnDic = new Dictionary<string, RadioButton>();

			radioBtnDic.Add(radioButton1.Text, radioButton1);
			radioBtnDic.Add(radioButton2.Text, radioButton2);
			radioBtnDic.Add(radioButton3.Text, radioButton3);

			radioBtnDic[_curSkillType].Checked = true;
		}
	}
}
