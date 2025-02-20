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
using BonjourClasses;

namespace BonjourGUI
{
    public partial class frmReview : Form
    {
        private DataHandler dh;
        private ProgressHandler ph;
        public frmReview(ProgressHandler ph, DataHandler dh)
        {
            InitializeComponent();
            this.dh = dh;
            this.ph = ph;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread t = new Thread(new ThreadStart(ThreadHomeForm));
            t.Start();
        }
        private void ThreadHomeForm()
        {
            Application.Run(new BonjourTomorrow(this.dh, this.ph));
        }

        private void btnLearn_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread t = new Thread(new ThreadStart(ThreadLearnForm));
            t.Start();
        }
        private void ThreadLearnForm()
        {
            Application.Run(new frmLearn(this.ph, this.dh));
        }

        private void btnMissed_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread t = new Thread(new ThreadStart(ThreadMissedForm));
            t.Start();
        }
        private void ThreadMissedForm()
        {
            Application.Run(new frmMissed(this.ph, this.dh));
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread t = new Thread(new ThreadStart(ThreadReportForm));
            t.Start();
        }
        private void ThreadReportForm()
        {
            Application.Run(new frmReport(this.ph, this.dh));
        }

        private void btnRewards_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread t = new Thread(new ThreadStart(ThreadRewardsForm));
            t.Start();
        }
        private void ThreadRewardsForm()
        {
            Application.Run(new frmRewards(this.ph, this.dh));
        }
    }
}
