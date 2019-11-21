using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Xsl;

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
			XslTransform myXslTransform;
			myXslTransform = new XslTransform();
			myXslTransform.Load(Application.StartupPath+"\\..\\..\\Show.xsl");
			myXslTransform.Transform(Application.StartupPath + "\\..\\..\\xml\\Magician_1_2.xml", Application.StartupPath + "\\..\\..\\html\\result2.html");
		}
	}
}
