using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using BonjourClasses;
using BonjourGUI;

namespace BonjourGUI
{
    public partial class frmLearn : Form
    {
        private ProgressHandler ph;
        private DataHandler dh;
        public frmLearn(ProgressHandler ph, DataHandler dh)
        {
            InitializeComponent();
            this.ph = ph;
            this.dh = dh;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread t = new Thread(new ThreadStart(ThreadHomeForm));
            t.Start();
        }
        private void ThreadHomeForm()
        {
            Application.Run(new BonjourTomorrow());
        }

        private void btnReview_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread t = new Thread(new ThreadStart(ThreadReviewForm));
            t.Start();
        }
        private void ThreadReviewForm()
        {
            Application.Run(new frmReview(this.ph, this.dh));
        }

        private void btnTopics_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread t = new Thread(new ThreadStart(ThreadTopicsForm));
            t.Start();
        }
        private void ThreadTopicsForm()
        {
            Application.Run(new frmTopics(this.ph, this.dh));
        }

        private void btnAC_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread t = new Thread(new ThreadStart(ThreadACForm));
            t.Start();
        }
        private void ThreadACForm()
        {
            Application.Run(new frmArts(this.ph, this.dh));
        }
    }
}
