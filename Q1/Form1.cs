using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace Q1
{
	public partial class Form1 : Form
	{
		private int[] answer = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
		private string[] numbers = new string[10];
		private int num, num1;
		private Random ran = new Random();
		public Form1()
		{
			InitializeComponent();
			answerlbl.Text = string.Empty;
			try
			{
				for (int i = 0; i < 10; i++)
				{
					answer[i] = i;
				}
				for (int i = 0; i < 10; i++)
				{
					num1 = ran.Next(0, 10);
					num = answer[num1];
					answer[num1] = answer[9 - i];
					answer[9 - i] = num;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void answerbtn_Click(object sender, EventArgs e)
		{
			answerlbl.Text = string.Empty;
			for (int i = 1; i <= 4; i++)
			{
				answerlbl.Text += answer[i];
			}
		}

		private void guessbtn_Click(object sender, EventArgs e)
		{
			string num = string.Empty;
			int a = 0, b = 0;
			if (inputtxt.TextLength != 4)
			{
				MessageBox.Show("請輸入4個不一樣的數字");
			}
			else
			{
				for (int j = 1; j <= 4; j++)
				{
					numbers[j] = inputtxt.Text.Substring(j - 1, 1);
					num += numbers[j];
				}
				if ((numbers[1] == numbers[2] || numbers[1] == numbers[3] ||
				numbers[1] == numbers[4] || numbers[2] == numbers[3] ||
				numbers[2] == numbers[4] || numbers[3] == numbers[4]))
				{
					MessageBox.Show("不能輸入重複的數字");
				}
				else
				{
					for (int k = 1; k <= 4; k++)
					{
						for (int l = 1; l <= 4; l++)
						{
							if (numbers[k] == answer[l].ToString())
							{
								if (k == l)
								{
									a++;
								}
								else if (k != l)
								{
									b++;
								}
							}
						}
					}
					resultlbl.Text += num + "-----" + a.ToString() + "A" + b.ToString() + "B" + "\r\n";
					inputtxt.Focus();
					inputtxt.SelectAll();
				}
				if (a == 4 && b == 0)
				{
					MessageBox.Show("恭喜你猜對了");
					guessbtn.Enabled = false;
				}
				else
				{
					MessageBox.Show("你要再加油了");
					guessbtn.Enabled = true;
				}
			}
		}

		private void newgamebtn_Click(object sender, EventArgs e)
		{
			answerlbl.Text = string.Empty;
			inputtxt.Text = string.Empty;
			resultlbl.Text = string.Empty;
			guessbtn.Enabled = true;
			for (int i = 0; i < 10; i++)
			{
				num1 = ran.Next(0, 10 - i);
				num = answer[num1];
				answer[num1] = answer[9 - i];
				answer[9 - i] = num;
			}
			for (int j = 1; j <= 4; j++)
			{
				numbers[j] = string.Empty;
			}
		}
	}
}

