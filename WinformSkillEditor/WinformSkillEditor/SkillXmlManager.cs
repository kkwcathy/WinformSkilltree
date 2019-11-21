using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml;
using System.IO;

struct SkillInfo
{
	public string Name;
	public string Explanation;
	public string Type;
	public int MasterLevel;

	public SkillInfo(string name, string explanation, string type, int level)
	{
		Name = name;
		Explanation = explanation;
		Type = type;
		MasterLevel = level;
	}
}

static class SkillXmlManager
{
	

	public static string _savePath = Application.StartupPath + "\\..\\..\\xml\\";
	static XmlDocument _skillInfoXml = new XmlDocument();

	public static string _FileName;
	public static string _CurJobName;

	static XmlNode _rootNode = null;

	const string _NameNodeStr = "name";
	const string _SkillNodeStr = "skill";
	const string _ExplanNodeStr = "explanation";
	const string _TypeNodeStr = "type";
	const string _LevelNodeStr = "master_level";

	public static void Init()
	{ 
	}

	static void CreateFile()
	{
		XmlNode docNode = _skillInfoXml.CreateXmlDeclaration("1.0", "UTF-8", null);
		_skillInfoXml.AppendChild(docNode);

		_rootNode = _skillInfoXml.CreateElement("job");

		XmlNode nameNode = _skillInfoXml.CreateElement(_NameNodeStr);
		nameNode.InnerText = _CurJobName;

		_rootNode.AppendChild(nameNode);

		_skillInfoXml.AppendChild(_rootNode);

		_skillInfoXml.Save(_savePath + _FileName);
	}

	public static void LoadFile()
	{
		try
		{
			_skillInfoXml.Load(_savePath + _FileName);
		}
		catch(FileNotFoundException e)
		{
			// 해당 직업의 스킬 파일이 존재하지 않을 경우 파일 새로 생성
			CreateFile();
			return;
		}

		_rootNode = _skillInfoXml.SelectNodes("job")[0];

	}

	public static void AddSkill(SkillInfo newSkill)
	{
		XmlNode skillNode = _skillInfoXml.CreateElement(_SkillNodeStr);

		XmlAttribute skillName = _skillInfoXml.CreateAttribute(_NameNodeStr);
		skillName.Value = newSkill.Name;

		XmlNode explanationNode = _skillInfoXml.CreateElement(_ExplanNodeStr);
		explanationNode.InnerText = newSkill.Explanation;

		XmlNode typeNode = _skillInfoXml.CreateElement(_TypeNodeStr);
		typeNode.InnerText = newSkill.Type;

		XmlNode levelNode = _skillInfoXml.CreateElement(_LevelNodeStr);
		levelNode.InnerText = newSkill.MasterLevel.ToString();

		skillNode.Attributes.Append(skillName);
		skillNode.AppendChild(explanationNode);
		skillNode.AppendChild(typeNode);
		skillNode.AppendChild(levelNode);

		_rootNode.AppendChild(skillNode);
		_skillInfoXml.Save(_savePath + _FileName);
	}

	public static bool ModifySkill(string skillName, SkillInfo newSkill)
	{
		XmlNode skillNode = null;

		foreach(XmlNode i in _rootNode.SelectNodes(_SkillNodeStr))
		{
			if (i.Attributes[_NameNodeStr].Value.Equals(skillName))
			{
				skillNode = i;
			}
		}

		if(skillNode == null) { return false; }

		skillNode.Attributes[_NameNodeStr].Value = newSkill.Name;
		skillNode.SelectNodes(_ExplanNodeStr)[0].InnerText = newSkill.Explanation;
		skillNode.SelectNodes(_TypeNodeStr)[0].InnerText = newSkill.Type;
		skillNode.SelectNodes(_LevelNodeStr)[0].InnerText = newSkill.MasterLevel.ToString();

		return true;
	}

	public static List<string> GetSkillList()
	{
		List<string> skillList = new List<string>();

		foreach (XmlNode i in _rootNode.SelectNodes(_SkillNodeStr))
		{
			skillList.Add(i.Attributes[_NameNodeStr].Value);
		}

		return skillList;
	}

	public static bool GetSelectedSkillInfo(string skillName, out SkillInfo skillInfo)
	{
		XmlNode curSkill = null;

		foreach (XmlNode i in _rootNode.SelectNodes(_SkillNodeStr))
		{
			if (i.Attributes[_NameNodeStr].Value.Equals(skillName))
			{
				curSkill = i;
			}
		}

		if (curSkill == null)
		{
			skillInfo = new SkillInfo();
			return false;
		}

		skillInfo = new SkillInfo(
			skillName,
			curSkill.SelectNodes(_ExplanNodeStr)[0].InnerText,
			curSkill.SelectNodes(_TypeNodeStr)[0].InnerText,
			int.Parse(curSkill.SelectNodes(_LevelNodeStr)[0].InnerText));

		return true;
	}
}
