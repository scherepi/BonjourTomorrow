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
    public partial class frmTopics : Form
    {
        private ProgressHandler ph;
        private DataHandler dh;
        public frmTopics(ProgressHandler ph, DataHandler dh)
        {
            InitializeComponent();
            this.ph = ph;
            this.dh = dh; 
        }

        private void btn_Return_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread t = new Thread(new ThreadStart(returnToLearn));
            t.Start();
        }
        private void returnToLearn() {
            Application.Run(new frmLearn());
        }
    }
}
