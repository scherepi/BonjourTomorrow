using BonjourClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BonjourGUI
{
    public partial class frmRewards : Form
    {
        ProgressHandler ph;
        DataHandler dh;
        public frmRewards(ProgressHandler ph, DataHandler dh)
        {
            InitializeComponent();
            this.ph = ph;
            this.dh = dh;
            updateValues();
        }

        private void updateValues()
        {
            this.lbl_BusinessValue.Text = this.ph.getTopicProgress("Business").ToString();
            this.lbl_FoodValue.Text = this.ph.getTopicProgress("Food").ToString();
            this.lbl_GreetingsValue.Text = this.ph.getTopicProgress("Greetings").ToString();
            this.lbl_NumValue.Text = this.ph.getTopicProgress("Numbers").ToString();
        }
        private void btn_Return_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread t = new Thread(new ThreadStart(ThreadGoBack));
            t.Start();
        }
        private void ThreadGoBack()
        {
            Application.Run(new frmReview(this.ph, this.dh));
        }
    }
}
