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
		string path = Application.StartupPath + "\\..\\..\\xml\\Jobs.xml";
		XmlDocument jobInfoXml = new XmlDocument();
		XmlNode root;

		Dictionary<int, string> firstJobDic = new Dictionary<int, string>();

		const string SubNodeStr = "SubJob";
		const string StageNodeStr = "Stage";

		public MainForm()
		{
			InitJobListXml();
			InitializeComponent();	
		}

		public void InitJobListXml()
		{
			jobInfoXml.Load(path);
			root = jobInfoXml.SelectNodes("Jobs")[0];
		}

		private XmlNodeList GetSubJobList(string jobType)
		{
			XmlNodeList resultList = null;

			foreach (XmlNode i in root.SelectNodes("JobType"))
			{
				if (jobType.Equals(i.Attributes["name"].Value))
				{
					resultList = i.SelectNodes(SubNodeStr);
				}
			}

			return resultList;
		}

		private XmlNodeList GetStageList(XmlNode jobType, string job)
		{
			XmlNodeList resultList = null;

			foreach (XmlNode i in jobType.SelectNodes(SubNodeStr))
			{
				if (job.Equals(i.Attributes["name"].Value))
				{
					resultList = i.SelectNodes(StageNodeStr);
				}
			}

			return resultList;
		}

		private void JobBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			ComboBox comboBox = (ComboBox)sender;

			XmlNodeList subJobData = GetSubJobList(comboBox.SelectedItem.ToString());

			if(subJobData == null) { return; } // 불러오기 실패한 예외처리

			List<string> jobitemList = new List<string>();

			foreach (XmlNode i in subJobData)
			{
				jobitemList.Add(i.Attributes["name"].Value);
			}

			UpdateJobSelectView(jobitemList);
		}

		private void UpdateJobSelectView(List<string> itemList)
		{
			JobSelectView.Items.Clear();

			foreach (var i in itemList)
			{
				JobSelectView.Items.Add(i);
			}
		}

		private void UpdateJobSelectView(string item)
		{
			JobSelectView.Items.Add(item);
		}

		private void UpdateStageView(string[] stageArr)
		{
			StageSelectView.Items.Clear();

			for(int i = 0; i< stageArr.Length; i++)
			{
				StageSelectView.Items.Add((i + 1) + " 차 : " + stageArr[i]);
			}
		}

		private void JobSelectView_SelectedIndexChanged(object sender, EventArgs e)
		{
		
			ListBox listBox = (ListBox)sender;

			XmlNode currentJobTypeNode = null;

			foreach (XmlNode i in root.SelectNodes("JobType"))
			{
				if (JobBox.SelectedItem.ToString().Equals(i.Attributes["name"].Value))
				{
					currentJobTypeNode = i;
				}
			}

			if (currentJobTypeNode == null) { return; } // 불러오기 실패한 예외처리

			XmlNodeList stageData = GetStageList(currentJobTypeNode, listBox.SelectedItem.ToString());

			if (stageData == null) { return; } // 불러오기 실패한 예외처리

			string[] stageItemArr = new string[4];

			foreach (XmlNode i in stageData)
			{
				stageItemArr[int.Parse(i.Attributes["num"].Value)-1] = i.InnerText.Trim();
			}

			UpdateStageView(stageItemArr);
		}

		private void AddSubJob()
		{
			string addJobText = InputNewJob.Text.ToString();

			if (addJobText.Length == 0)
			{
				MessageBox.Show("추가할 직업을 입력해주세요.");
				return;
			}

			if (JobBox.SelectedItem == null)
			{
				MessageBox.Show("직업계열을 선택해주세요.");
				return;
			}

			XmlNode resultNode = null;
			string jobType = JobBox.SelectedItem.ToString();

			foreach (XmlNode i in root.SelectNodes("JobType"))
			{
				if (jobType.Equals(i.Attributes["name"].Value))
				{
					resultNode = i;
				}
			}

			XmlNode newJobNode = jobInfoXml.CreateElement(SubNodeStr);

			XmlAttribute newName = jobInfoXml.CreateAttribute("name");
			newName.Value = addJobText;

			// 1차 전직 직업은 계열이 같으면 다 같아서 미리 추가해주기
			XmlNode newStageNode = jobInfoXml.CreateElement(StageNodeStr);

			XmlAttribute newStageNum = jobInfoXml.CreateAttribute("num");
			newStageNum.Value = "1";

			newStageNode.InnerText = resultNode.InnerText.Trim();

			newStageNode.Attributes.Append(newStageNum);
		
			newJobNode.Attributes.Append(newName);
			newJobNode.AppendChild(newStageNode);

			resultNode.AppendChild(newJobNode);

			UpdateJobSelectView(addJobText);

			jobInfoXml.Save(path);
		}

		private void btnAddJob_Click(object sender, EventArgs e)
		{
			AddSubJob();
		}
	}

}
