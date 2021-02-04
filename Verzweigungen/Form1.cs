using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Verzweigungen
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnAusgabe_Click(object sender, EventArgs e)
		{

			if (nUpDownEingabe.Value > 5 && nUpDownEingabe.Value > 7)
			{
				lblAusgabe.Text = "Die Bedingung war wahr.";
			}
			else
			{
				lblAusgabe.Text = "Die Bedingung war falsch.";
			}

			// Kurzversion ist auch möglich:
			// if (nUpDownEingabe.Value > 5) lblAusgabe.Text = "Die Bedingung war wahr.";

		}

		private void btnTernärerOperator_Click(object sender, EventArgs e)
		{
			// Ternärer Operator ? :
			// enspricht if () .. else ...

			int x = (int)nUpDownEingabe.Value;

			lblAusgabe.Text = x > 0 ? "x > 0" : "x <= 0";
		}

		private void btnSwitch_Click(object sender, EventArgs e)
		{
			int x = (int)nUpDownEingabe.Value;

			switch (x)
			{
				case 1:
				case 3:
				case 5:
				case 7:
				case 9:
					lblAusgabe.Text = "Einstellig, ungerade";
					break;
				case 2:
				case 4:
				case 6:
				case 8:
					lblAusgabe.Text = "Einstellig, gerade";
					break;
				default:
					lblAusgabe.Text = "Andere Zahl";
					break;
			}
		}
	}
}
