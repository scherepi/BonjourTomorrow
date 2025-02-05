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
using BonjourGUI;

namespace BonjourGUI
{
    public partial class frmLearn : Form
    {
        public frmLearn()
        {
            InitializeComponent();
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
    }
}
