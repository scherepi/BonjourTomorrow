﻿using System;
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
    public partial class frmQuestions : Form
    {
        DataHandler dh;
        ProgressHandler ph;
        Question question;
        Answer[] answers;
        public frmQuestions(ProgressHandler ph, DataHandler dh, Question question)
        {
            // We need access to the handlers, and we need to populate the form according to the question.
            InitializeComponent();
            this.ph = ph;
            this.dh = dh;
            this.question = question;
            lblQuestionText.Text = question.getText();
            lblFeedback.Text = "";
            lblProgress.Text = SessionHandler.getSessionProgress();
            btnNext.Visible = false;
            btnNext.Enabled = false;
            answers = question.getAnswers().ToArray();
            btnOptionOne.Text = answers[0].getText();
            btnOptionTwo.Text = answers[1].getText();
            btnOptionThree.Text = answers[2].getText();
            btnOptionFour.Text = answers[3].getText();
        }
        // The functions below are just to make the buttons react to the user's mouse hovering.
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

        private void btn_Return_Click(object sender, EventArgs e)
        {
            SessionHandler.exitSession();
            this.Close();
            Thread t = new Thread(new ThreadStart(openResults));
            t.Start();
        }
        private void openResults()
        {
            Application.Run(new frmAfterview(this.ph, this.dh));
        }
        // Answer button functionality:
        private void btnOptionOne_Click(object sender, EventArgs e)
        {
            reactToInput(answers[0].isCorrect());
        }
        private void btnOptionTwo_Click(object sender, EventArgs e)
        {
            reactToInput(answers[1].isCorrect());
        }

        private void btnOptionThree_Click(object sender, EventArgs e)
        {
            reactToInput(answers[2].isCorrect());
        }

        private void btnOptionFour_Click(object sender, EventArgs e)
        {
            reactToInput(answers[3].isCorrect());
        }
        private void reactToInput(bool correct)
        {
            if (correct)
            {
                lblFeedback.Text = "Correct!";
                lblFeedback.ForeColor = Color.FromName("Green");
                SessionHandler.reportCorrect(question);
            }
            else
            {
                lblFeedback.Text = "Incorrect!";
                lblFeedback.ForeColor = Color.FromName("Red");
                SessionHandler.reportIncorrect(question);
            }
            // Turn off all the answer buttons:
            btnOptionOne.Enabled = false;
            btnOptionTwo.Enabled = false;
            btnOptionThree.Enabled = false;
            btnOptionFour.Enabled = false;
            // Make the "next question" button visible and clickable:
            btnNext.Visible = true;
            btnNext.Enabled = true;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread t = new Thread(new ThreadStart(ThreadNextQuestion));
            t.Start();
        }
        private void ThreadNextQuestion()
        {
            Question q = SessionHandler.getNextQuestion();
            if (q == null)
            {
                // If there are no more questions, we should close the session and open the results.
                this.Close();
                Thread t = new Thread(new ThreadStart(openResults));
                t.Start();
                return;
            }
            Application.Run(new frmQuestions(this.ph, this.dh, q));
        }
    }
}
