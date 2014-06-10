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
	public partial class frmMain : Form
  {
      public frmMain()
      {
          InitializeComponent();
      }

      public static string pressedButton = "";

      // Display Team registration Form depending on button press
      private void btnLOLreg_Click_1(object sender, EventArgs e)
      {
          pressedButton = "LoL";

          FormTeamRegistration frm = new FormTeamRegistration();
          frm.Show();
      }

      private void btnDOTAreg_Click_1(object sender, EventArgs e)
      {
          pressedButton = "DoTa2";
          FormTeamRegistration frm = new FormTeamRegistration();
          frm.Show();
      }

      private void btnCODreg_Click(object sender, EventArgs e)
      {
          pressedButton = "CoD";
          FormTeamRegistration frm = new FormTeamRegistration();
          frm.Show();
      }

      private void btnRegPlayer_Click(object sender, EventArgs e)
      {
          FormPlayerRegistration frm = new FormPlayerRegistration();
          frm.Show();
      }
  }
}

       
    

