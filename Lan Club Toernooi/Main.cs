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

            frmTRegister frm = new frmTRegister();
            frm.Show();
        }

        private void btnDOTAreg_Click_1(object sender, EventArgs e)
        {
            pressedButton = "DoTa2";
            frmTRegister frm = new frmTRegister();
            frm.Show();
        }

        private void btnCODreg_Click(object sender, EventArgs e)
        {
            pressedButton = "CoD";
            frmTRegister frm = new frmTRegister();
            frm.Show();
        }

        private void btnRegPlayer_Click(object sender, EventArgs e)
        {
            frmPRegister frm = new frmPRegister();
            frm.Show();
        }

    }

    // define fields to be shown on form Team Registration
    public partial class frmTRegister : Form
    {
        public frmTRegister()
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }

    public partial class frmPRegister : Form
    {
        public frmPRegister()
        {
            InitializeComponent();
        }
        
    }



}

       
    

