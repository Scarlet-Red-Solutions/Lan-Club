using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lan_Club_Toernooi
{

	// define fields to be shown on form Team Registration
	// form create gaan deur en error nie
	public partial class FormTeamRegistration : Form
	{
		public FormTeamRegistration()
		{
			InitializeComponent();

			if (frmMain.pressedButton == "LoL")
			{
				pnlPosition.Visible = true;
				grbGame.Text = "League of Legends";
			}

			else
				if (frmMain.pressedButton == "DoTa2")
				{
					pnlPosition.Visible = true;
					grbGame.Text = "DOTA2";
				}

				else
				{
					pnlPosition.Visible = false;
					grbGame.Text = "Call Of Duty";
				}
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			this.Close();

		}
	}
}
