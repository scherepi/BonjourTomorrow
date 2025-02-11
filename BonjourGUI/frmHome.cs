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
    public partial class BonjourTomorrow : Form
    {
        public bool initialized = false;
        public BonjourTomorrow()
        {
            InitializeComponent();
            initialized = true;
            if (!initialized)
            {
                DataHandler dataHandler = new DataHandler();
                ProgressHandler progressHandler = dataHandler.loadProgress();
            }
        }

        private void btnLearn_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread t = new Thread(new ThreadStart(ThreadLearnForm));
            t.Start();
        }
        private void ThreadLearnForm()
        {
            Application.Run(new frmLearn());
        }

        private void btnReview_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread t = new Thread(new ThreadStart(ThreadReviewForm));
            t.Start();
        }
        private void ThreadReviewForm()
        {
            Application.Run(new frmReview());
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread t = new Thread(new ThreadStart(ThreadSettingsForm));
            t.Start();
        }
        private void ThreadSettingsForm()
        {
            Application.Run(new frmSettings());
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
