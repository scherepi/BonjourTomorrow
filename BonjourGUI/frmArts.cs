using BonjourClasses;
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

namespace BonjourGUI
{
    public partial class frmArts : Form
    {
        ProgressHandler ph;
        DataHandler dh;
        bool louvre = false;
        bool bakery = false;
        public frmArts(ProgressHandler ph, DataHandler dh)
        {
            InitializeComponent();
            this.ph = ph;
            this.dh = dh;
            this.checkUnlocked();
        }
        public void checkUnlocked()
        {
            (bool, bool) data = this.ph.getACUnlocks();
            this.bakery = data.Item1;
            this.louvre = data.Item2;
            if (this.bakery)
            {
                this.btn_BakeryLock.Enabled = false;
                this.btn_BakeryLock.Visible = false;
                this.btn_BakeryLock.Dispose();
                this.lbl_Bakery.BringToFront();
                this.lbl_Bakery.Click += new EventHandler(this.openBakery);
            }
            if (this.louvre)
            {
                this.btn_LouvreLock.Enabled = false;
                this.btn_LouvreLock.Visible = false;
                this.btn_LouvreLock.Dispose();
                this.lbl_Louvre.BringToFront();
                this.lbl_Louvre.Click += new EventHandler(this.openLouvre);
            }
        }
        public void openLouvre(object sender, EventArgs e)
        {
            Thread t = new Thread(new ThreadStart(ThreadLouvre));
            t.Start();
        }
        public void openBakery(object sender, EventArgs e)
        {
            Thread t = new Thread(new ThreadStart(ThreadBakery));
            t.Start();
        }
        public void ThreadLouvre()
        {
            Application.Run(new frmLouvre());
        }
        public void ThreadBakery()
        {
            Application.Run(new frmBakery());
        }

        private void btn_Return_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread t = new Thread(new ThreadStart(ThreadGoBack));
            t.Start();
        }
        private void ThreadGoBack()
        {
            Application.Run(new frmLearn(this.ph, this.dh));
        }
    }
}
