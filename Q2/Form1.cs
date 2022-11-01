using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q2
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			resultlbl.Text = string.Empty;
			answerlbl.Text = string.Empty;
		}

		private void guessbtn_Click(object sender, EventArgs e)
		{
			Random numbers = new Random();
			int[] number = new int[4] { numbers.Next(1, 7), numbers.Next(1, 7), numbers.Next(1, 7), numbers.Next(1, 7) };
			Array.Sort(number);
			foreach (int num in number)
				resultlbl.Text += num + ",";
			resultlbl.Text += "\r\n";
			var answer = new game().DiceGame(number);
			answerlbl.Text = answer.ToString();
		}
	}
	class game
	{
		public int DiceGame(int[] number)
		{
			int result = 0;

			var dict = new Dictionary<int, int>();
			foreach (var value in number)
			{
				dict.TryGetValue(value, out int count);
				dict[value] = count + 1;
			}
			var total = dict.Values.ToArray();
			var max = total.Max();
			var repeatnumber = dict.FirstOrDefault(a => a.Value == max).Key;
			if (max == 2)
			{
				var numbersList = number.ToList();
				while (numbersList.Contains(repeatnumber))
					numbersList.Remove(repeatnumber);
				foreach (var num2 in numbersList)
				{
					result += num2;
				}
			}
			else if (max == 3)
			{
				var numbersList = number.ToList();
				while (numbersList.Contains(repeatnumber))
					numbersList.Remove(repeatnumber);
				result = repeatnumber + numbersList[0];
			}
			else if (max == 4)
			{
				result = repeatnumber * 2;
			}
			return result;
		}
	}
}
