using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BonjourClasses;

namespace BonjourGUI
{
    public partial class frmQuestions : Form
    {
        DataHandler dh;
        ProgressHandler ph;
        Question question;
        public frmQuestions(ProgressHandler ph, DataHandler dh, Question question)
        {
            InitializeComponent();
            this.ph = ph;
            this.dh = dh;
            this.question = question;
            lblQuestionText.Text = question.getText();
            Answer[] answers = question.getAnswers().ToArray();
            btnOptionOne.Text = answers[0].getText();
            btnOptionTwo.Text = answers[1].getText();
            btnOptionThree.Text = answers[2].getText();
            btnOptionFour.Text = answers[3].getText();
        }

        private void btnOptionOne_MouseEnter(object sender, EventArgs e)
        {
            btnOptionOne.BackColor = Color.FromName("Green");
        }

        private void btnOptionOne_MouseLeave(object sender, EventArgs e)
        {
            btnOptionOne.BackColor = Color.FromArgb(77, 175, 72);
        }
        private void btnOptionTwo_MouseEnter(object sender, EventArgs e)
        {
            btnOptionTwo.BackColor = Color.FromName("Green");
        }
        private void btnOptionTwo_MouseLeave(object sender, EventArgs e)
        {
            btnOptionTwo.BackColor = Color.FromArgb(77, 175, 72);
        }

        private void btnOptionThree_MouseEnter(object sender, EventArgs e)
        {
            btnOptionThree.BackColor = Color.FromName("Green");
        }

        private void btnOptionThree_MouseLeave(object sender, EventArgs e)
        {
            btnOptionThree.BackColor = Color.FromArgb(77, 175, 72);
        }

        private void btnOptionFour_MouseEnter(object sender, EventArgs e)
        {
            btnOptionFour.BackColor = Color.FromName("Green");
        }

        private void btnOptionFour_MouseLeave(object sender, EventArgs e)
        {
            btnOptionFour.BackColor = Color.FromArgb(77, 175, 72);
        }
    }
}
