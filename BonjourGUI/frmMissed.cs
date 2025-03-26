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
    public partial class frmMissed : Form
    {
        ProgressHandler ph;
        DataHandler dh;
        public frmMissed(ProgressHandler ph, DataHandler dh)
        {
            InitializeComponent();
            this.ph = ph;
            this.dh = dh;
            this.lst_questions.LabelEdit = false;
            this.lst_questions.View = View.Details;
            this.lst_questions.Columns.Add("Question", this.lst_questions.Width);
            foreach (Question q in ph.getMissed().Keys)
            {
                ListViewItem lvi = new ListViewItem(q.getText());
                this.lst_questions.Items.Add(lvi);
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
