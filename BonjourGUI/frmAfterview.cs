using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using BonjourClasses;
using System.Runtime.InteropServices;

namespace BonjourGUI
{
    public partial class frmAfterview : Form
    {
        public ProgressHandler ph;
        public DataHandler dh;
        public frmAfterview(ProgressHandler ph, DataHandler dh)
        {
            InitializeComponent();
            this.ph = ph;
            this.dh = dh;
            Random rnd = new Random();
            String[] encouragements = {
                "French genius?",
                "You crushed that!",
                "Are you sure you're not French?",
                "Keep it up!",
                "Woohoo!",
                "You're doing great!",
                "Fantastic!",
                "Keep learning!"
            };
            int randomNumber = rnd.Next(0, encouragements.Length);
            lbl_Encouragement.Text = encouragements[randomNumber];
            String[] results = SessionHandler.getLastSessionResults().Split('/');
            lbl_Results.Text = "You got " + results[0] + " questions correct out of "  + results[1] + " questions answered!";
        }

        private void btn_Return_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread t = new Thread(new ThreadStart(returnHomeThread));
            t.Start();
        }
        
        private void returnHomeThread()
        {
            Application.Run(new BonjourTomorrow(this.dh, this.ph));
        }
    }
}
