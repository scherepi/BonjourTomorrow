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
    public partial class frmAllQuestions: Form
    {
        private ProgressHandler ph;
        private DataHandler dh;
        public frmAllQuestions(ProgressHandler ph, DataHandler dh)
        {
            InitializeComponent();
            this.ph = ph;
            this.dh = dh;
            this.lst_questions.LabelEdit = false;
            this.lst_questions.View = View.Details;
            this.lst_questions.Columns.Add(Text = "Question", Width = this.lst_questions.Width);
            foreach (Question q in dh.getAllQuestions())
            {
                ListViewItem lvi = new ListViewItem(q.getText());
                this.lst_questions.Items.Add(lvi);
            }
        }

        private void btn_Return_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread t = new Thread(new ThreadStart(returnToLearn));
            t.Start();
        }
        private void returnToLearn()
        {
            Application.Run(new frmLearn(this.ph, this.dh));
        }
        private void ThreadQuestionsForm()
        {
            Application.Run(new frmQuestions(this.ph, this.dh, SessionHandler.getNextQuestion()));
        }

        private void lst_questions_ItemActivate(object sender, EventArgs e)
        {
            if (this.lst_questions.SelectedItems.Count == 1)
            {
                ListViewItem selectedItem = lst_questions.SelectedItems[0];
                SessionHandler.startQuestion(dh.getQuestionFromText(selectedItem.Text));
                this.Close();
                Thread t = new Thread(new ThreadStart(ThreadQuestionsForm));
                t.Start();
            }
        }
    }
}
