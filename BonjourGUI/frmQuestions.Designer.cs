namespace BonjourGUI
{
    partial class frmQuestions
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
            this.lblQuestionText = new System.Windows.Forms.Label();
            this.btn_Return = new System.Windows.Forms.Button();
            this.btnOptionOne = new System.Windows.Forms.Button();
            this.btnOptionTwo = new System.Windows.Forms.Button();
            this.btnOptionThree = new System.Windows.Forms.Button();
            this.btnOptionFour = new System.Windows.Forms.Button();
            this.lblProgress = new System.Windows.Forms.Label();
            this.lblFeedback = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblQuestionText
            // 
            this.lblQuestionText.AutoSize = true;
            this.lblQuestionText.Font = new System.Drawing.Font("Itim", 25F);
            this.lblQuestionText.Location = new System.Drawing.Point(2, 9);
            this.lblQuestionText.MinimumSize = new System.Drawing.Size(800, 0);
            this.lblQuestionText.Name = "lblQuestionText";
            this.lblQuestionText.Size = new System.Drawing.Size(800, 40);
            this.lblQuestionText.TabIndex = 0;
            this.lblQuestionText.Text = "Question Text";
            this.lblQuestionText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Return
            // 
            this.btn_Return.Image = global::BonjourGUI.Properties.Resources.istockphoto_900591912_612x612;
            this.btn_Return.Location = new System.Drawing.Point(-1, 377);
            this.btn_Return.Name = "btn_Return";
            this.btn_Return.Size = new System.Drawing.Size(75, 75);
            this.btn_Return.TabIndex = 1;
            this.btn_Return.UseVisualStyleBackColor = true;
            this.btn_Return.Click += new System.EventHandler(this.btn_Return_Click);
            // 
            // btnOptionOne
            // 
            this.btnOptionOne.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(175)))), ((int)(((byte)(72)))));
            this.btnOptionOne.Font = new System.Drawing.Font("Itim", 25F);
            this.btnOptionOne.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnOptionOne.Location = new System.Drawing.Point(155, 84);
            this.btnOptionOne.Name = "btnOptionOne";
            this.btnOptionOne.Size = new System.Drawing.Size(500, 61);
            this.btnOptionOne.TabIndex = 2;
            this.btnOptionOne.Text = "Answer 1";
            this.btnOptionOne.UseVisualStyleBackColor = false;
            this.btnOptionOne.Click += new System.EventHandler(this.btnOptionOne_Click);
            this.btnOptionOne.MouseEnter += new System.EventHandler(this.btnOptionOne_MouseEnter);
            this.btnOptionOne.MouseLeave += new System.EventHandler(this.btnOptionOne_MouseLeave);
            // 
            // btnOptionTwo
            // 
            this.btnOptionTwo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(175)))), ((int)(((byte)(72)))));
            this.btnOptionTwo.Font = new System.Drawing.Font("Itim", 25F);
            this.btnOptionTwo.Location = new System.Drawing.Point(155, 164);
            this.btnOptionTwo.Name = "btnOptionTwo";
            this.btnOptionTwo.Size = new System.Drawing.Size(500, 61);
            this.btnOptionTwo.TabIndex = 3;
            this.btnOptionTwo.Text = "Answer 2";
            this.btnOptionTwo.UseVisualStyleBackColor = false;
            this.btnOptionTwo.Click += new System.EventHandler(this.btnOptionTwo_Click);
            this.btnOptionTwo.MouseEnter += new System.EventHandler(this.btnOptionTwo_MouseEnter);
            this.btnOptionTwo.MouseLeave += new System.EventHandler(this.btnOptionTwo_MouseLeave);
            // 
            // btnOptionThree
            // 
            this.btnOptionThree.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(175)))), ((int)(((byte)(72)))));
            this.btnOptionThree.Font = new System.Drawing.Font("Itim", 25F);
            this.btnOptionThree.Location = new System.Drawing.Point(155, 243);
            this.btnOptionThree.Name = "btnOptionThree";
            this.btnOptionThree.Size = new System.Drawing.Size(500, 61);
            this.btnOptionThree.TabIndex = 4;
            this.btnOptionThree.Text = "Answer 3";
            this.btnOptionThree.UseVisualStyleBackColor = false;
            this.btnOptionThree.Click += new System.EventHandler(this.btnOptionThree_Click);
            this.btnOptionThree.MouseEnter += new System.EventHandler(this.btnOptionThree_MouseEnter);
            this.btnOptionThree.MouseLeave += new System.EventHandler(this.btnOptionThree_MouseLeave);
            // 
            // btnOptionFour
            // 
            this.btnOptionFour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(175)))), ((int)(((byte)(72)))));
            this.btnOptionFour.Font = new System.Drawing.Font("Itim", 25F);
            this.btnOptionFour.Location = new System.Drawing.Point(155, 320);
            this.btnOptionFour.Name = "btnOptionFour";
            this.btnOptionFour.Size = new System.Drawing.Size(500, 61);
            this.btnOptionFour.TabIndex = 5;
            this.btnOptionFour.Text = "Answer 4";
            this.btnOptionFour.UseVisualStyleBackColor = false;
            this.btnOptionFour.Click += new System.EventHandler(this.btnOptionFour_Click);
            this.btnOptionFour.MouseEnter += new System.EventHandler(this.btnOptionFour_MouseEnter);
            this.btnOptionFour.MouseLeave += new System.EventHandler(this.btnOptionFour_MouseLeave);
            // 
            // lblProgress
            // 
            this.lblProgress.AutoSize = true;
            this.lblProgress.Font = new System.Drawing.Font("Itim", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgress.Location = new System.Drawing.Point(680, 393);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(108, 48);
            this.lblProgress.TabIndex = 6;
            this.lblProgress.Text = "0/20";
            // 
            // lblFeedback
            // 
            this.lblFeedback.AutoSize = true;
            this.lblFeedback.Font = new System.Drawing.Font("Itim", 15F);
            this.lblFeedback.ForeColor = System.Drawing.Color.Red;
            this.lblFeedback.Location = new System.Drawing.Point(343, 400);
            this.lblFeedback.Name = "lblFeedback";
            this.lblFeedback.Size = new System.Drawing.Size(131, 24);
            this.lblFeedback.TabIndex = 7;
            this.lblFeedback.Text = "Question Text";
            this.lblFeedback.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Lucida Sans", 40F);
            this.btnNext.Location = new System.Drawing.Point(688, 194);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 75);
            this.btnNext.TabIndex = 8;
            this.btnNext.Text = "→";
            this.btnNext.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnNext.UseVisualStyleBackColor = true;
            // 
            // frmQuestions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.lblFeedback);
            this.Controls.Add(this.lblProgress);
            this.Controls.Add(this.btnOptionFour);
            this.Controls.Add(this.btnOptionThree);
            this.Controls.Add(this.btnOptionTwo);
            this.Controls.Add(this.btnOptionOne);
            this.Controls.Add(this.btn_Return);
            this.Controls.Add(this.lblQuestionText);
            this.Name = "frmQuestions";
            this.Text = "You\'ve got this!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuestionText;
        private System.Windows.Forms.Button btn_Return;
        private System.Windows.Forms.Button btnOptionOne;
        private System.Windows.Forms.Button btnOptionTwo;
        private System.Windows.Forms.Button btnOptionThree;
        private System.Windows.Forms.Button btnOptionFour;
        private System.Windows.Forms.Label lblProgress;
        private System.Windows.Forms.Label lblFeedback;
        private System.Windows.Forms.Button btnNext;
    }
}