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
