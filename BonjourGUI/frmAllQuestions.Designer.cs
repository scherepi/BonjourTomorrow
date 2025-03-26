namespace BonjourGUI
{
    partial class frmAllQuestions
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lst_questions = new System.Windows.Forms.ListView();
            this.btn_Return = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lst_questions
            // 
            this.lst_questions.HideSelection = false;
            this.lst_questions.Location = new System.Drawing.Point(174, 7);
            this.lst_questions.Name = "lst_questions";
            this.lst_questions.Size = new System.Drawing.Size(450, 438);
            this.lst_questions.TabIndex = 0;
            this.lst_questions.UseCompatibleStateImageBehavior = false;
            this.lst_questions.View = System.Windows.Forms.View.List;
            this.lst_questions.ItemActivate += new System.EventHandler(this.lst_questions_ItemActivate);
            // 
            // btn_Return
            // 
            this.btn_Return.Image = global::BonjourGUI.Properties.Resources.istockphoto_900591912_612x612;
            this.btn_Return.Location = new System.Drawing.Point(12, 363);
            this.btn_Return.Name = "btn_Return";
            this.btn_Return.Size = new System.Drawing.Size(75, 75);
            this.btn_Return.TabIndex = 2;
            this.btn_Return.UseVisualStyleBackColor = true;
            this.btn_Return.Click += new System.EventHandler(this.btn_Return_Click);
            // 
            // frmAllQuestions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Return);
            this.Controls.Add(this.lst_questions);
            this.Name = "frmAllQuestions";
            this.Text = "Everything at your fingertips!";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lst_questions;
        private System.Windows.Forms.Button btn_Return;
    }
}