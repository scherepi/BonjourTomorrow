using BonjourClasses;
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

namespace BonjourGUI
{
    public partial class frmSettings : Form
    {
        public ProgressHandler ph;
        public DataHandler dh;
        public frmSettings(ProgressHandler ph, DataHandler dh)
        {
            InitializeComponent();
            this.ph = ph;
            this.dh = dh;
        }

        private void btn_Return_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread t = new Thread(new ThreadStart(ThreadHomeForm));
            t.Start();
        }
        private void ThreadHomeForm()
        {
            Application.Run(new BonjourTomorrow(this.dh, this.ph));
        }

        private void btn_DataDebug_Click(object sender, EventArgs e)
        {
            this.dh.printDebug();
        }

        private void btn_ProgDebug_Click(object sender, EventArgs e)
        {
            this.ph.printDebug();
        }

        private void btnBakery_Click(object sender, EventArgs e)
        {
            this.ph.unlock("Bakery");
        }

        private void btnFood_Click(object sender, EventArgs e)
        {
            this.ph.progressTopic("Food");
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.ph.resetProgress();
        }
    }
}
