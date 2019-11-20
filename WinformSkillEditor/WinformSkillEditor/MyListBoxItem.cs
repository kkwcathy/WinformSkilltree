using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class MyListBoxItem
{
	public MyListBoxItem(string m)
	{ 
		Message = m;
	}
	public Color ItemColor { get; set; }
	public string Message { get; set; }
}

