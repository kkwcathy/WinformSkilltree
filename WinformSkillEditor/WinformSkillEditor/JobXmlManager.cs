using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml;

static class JobXmlManager
{
	static string _path = Application.StartupPath + "\\..\\..\\xml\\Jobs.xml";
	static XmlDocument _jobInfoXml = new XmlDocument();

	static XmlNode _rootNode = null;
	static XmlNode _curJobTypeNode = null;
	static XmlNode _curSubJobNode = null;

	const string _JobTypeNodeStr = "JobType";
	const string _SubNodeStr = "SubJob";
	const string _StageNodeStr = "Stage";

	public static XmlDocument JobsXml { get; }

	public static void Init()
	{
		_jobInfoXml.Load(_path);
		_rootNode = _jobInfoXml.SelectNodes("Jobs")[0];
	}

	// 정보 추가 및 변경
	public static bool AddSubJob(string addStr)
	{
		if(_curJobTypeNode == null) { return false; }

		XmlNode newJobNode = _jobInfoXml.CreateElement(_SubNodeStr);

		XmlAttribute newName = _jobInfoXml.CreateAttribute("name");
		newName.Value = addStr;

		newJobNode.Attributes.Append(newName);
		
		// 초기 전직 과정 정보 추가 
		for (int i = 1; i <= 4; i++)
		{
			XmlNode newStageNode = _jobInfoXml.CreateElement(_StageNodeStr);

			XmlAttribute newStageNum = _jobInfoXml.CreateAttribute("num");
			newStageNum.Value = i.ToString();

			// 1차 전직 직업은 계열이 같으면 다 같아서 미리 추가해주기
			if(i == 1)
			{
				newStageNode.InnerText = _curJobTypeNode.SelectNodes("firstStage")[0].InnerText.Trim();
			}
			else
			{
				newStageNode.InnerText = "";
			}

			newStageNode.Attributes.Append(newStageNum);
			newJobNode.AppendChild(newStageNode);
		}

		_curJobTypeNode.AppendChild(newJobNode);

		_jobInfoXml.Save(_path);

		return true;
	}
	
	public static bool ModifyStage(int index, string modifyStr)
	{
		if (_curSubJobNode == null) { return false; }

		XmlNodeList stageList = _curSubJobNode.SelectNodes(_StageNodeStr);
		
		foreach(XmlNode i in stageList)
		{
			if(int.Parse(i.Attributes["num"].Value) == index)
			{
				i.InnerText = modifyStr;
				_jobInfoXml.Save(_path);
				return true;
			}
		}
		
		return false;
	}


	// 현재 선택된 노드 가져오기

	public static bool SetCurJobTypeNode(string keyStr)
	{
		foreach (XmlNode i in _rootNode.SelectNodes(_JobTypeNodeStr))
		{

			if (keyStr.Equals(i.Attributes["name"].Value))
			{
				_curJobTypeNode = i;
				return true;
			}
		}

		return false;
	}

	public static bool SetCurSubJobNode(string keyStr)
	{
		if(_curJobTypeNode == null) { return false; }

		foreach (XmlNode i in _curJobTypeNode.SelectNodes(_SubNodeStr))
		{

			if (keyStr.Equals(i.Attributes["name"].Value))
			{
				_curSubJobNode = i;
				return true;
			}
		}

		return false;
	}


	// 리스트뷰에 넣을 데이터 가져오기

	public static List<string> GetSubJobData()
	{
		XmlNodeList subJobNodeList = null;
		List<string> subJobData = new List<string>();

		subJobNodeList = _curJobTypeNode.SelectNodes(_SubNodeStr);

		foreach (XmlNode i in subJobNodeList)
		{
			subJobData.Add(i.Attributes["name"].Value);
		}

		return subJobData;
	}

	public static string[] GetStageData()
	{
		XmlNodeList stageNodeList = null;
		string[] stageData = new string[4];

		stageNodeList = _curSubJobNode.SelectNodes(_StageNodeStr);

		foreach (XmlNode i in stageNodeList)
		{
			stageData[int.Parse(i.Attributes["num"].Value) - 1] = i.InnerText.Trim();
		}

		return stageData;
	}

	public static string GetFileName(string type)
	{
		XmlNode jobTypeNode = null;

		foreach(XmlNode i in _rootNode.SelectNodes(_JobTypeNodeStr))
		{
			if (i.Attributes["name"].Value.Equals(type))
			{
				jobTypeNode = i;
			}
		}

		if(jobTypeNode == null) { return null; }

		return jobTypeNode.SelectNodes("fileName")[0].InnerText;
	}
}

