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
            checkUnlocks();
        }

        private void updateValues()
        {
            this.lbl_BusinessValue.Text = this.ph.getTopicProgress("Business").ToString();
            this.lbl_FoodValue.Text = this.ph.getTopicProgress("Food").ToString();
            this.lbl_GreetingsValue.Text = this.ph.getTopicProgress("Greetings").ToString();
            this.lbl_NumValue.Text = this.ph.getTopicProgress("Numbers").ToString();
        }
        private void checkUnlocks()
        {
            if (this.ph.isUnlocked("Bakery"))
            {
                this.lbl_BKey.Visible = false;
                this.btn_Bakery.ForeColor = Color.FromName("ButtonHighlight");
                this.btn_Bakery.BackColor = Color.FromName("HotTrack");
                this.btn_Bakery.Click -= new EventHandler(this.purchaseBakeryKey);
            } else
            {
                this.btn_Bakery.Click += new EventHandler(this.purchaseBakeryKey);
            }
            if (this.ph.isUnlocked("Louvre"))
            {
                this.lbl_LKey.Visible = false;
                this.btn_Louvre.ForeColor = Color.FromName("ButtonHighlight");
                this.btn_Louvre.BackColor = Color.FromName("HotTrack");
                this.btn_Louvre.Click -= new EventHandler(this.purchaseLouvreKey);
            } else
            {
                this.btn_Louvre.Click += new EventHandler(this.purchaseLouvreKey);
            }
            if (this.ph.isUnlocked("Eraser"))
            {
                this.lbl_Eraser.Visible = false;
                this.btn_Eraser.ForeColor = Color.FromName("ButtonHighlight");
                this.btn_Eraser.BackColor = Color.FromName("HotTrack");
                this.btn_Eraser.Click -= new EventHandler(this.purchaseEraser);
            } else
            {
                this.btn_Eraser.Click += new EventHandler(this.purchaseEraser);
            }
        }
        private void purchaseBakeryKey(object sender, EventArgs e)
        {
            if (this.ph.getTopicProgress("Food") >= 15)
            {
                this.ph.unlock("Bakery");
                this.checkUnlocks();
            }
        }
        private void purchaseLouvreKey(object sender, EventArgs e)
        {
            if (this.ph.getTopicProgress("Food") >= 12 && this.ph.getTopicProgress("Greetings") >= 7)
            {
                this.ph.unlock("Louvre");
                this.checkUnlocks();
            }
        }
        private void purchaseEraser(object sender, EventArgs e)
        {
            if (this.ph.getTopicProgress("Business") >= 8)
            {
                this.ph.unlock("Eraser");
                this.checkUnlocks();
            }
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
