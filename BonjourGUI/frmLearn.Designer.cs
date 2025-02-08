namespace BonjourGUI
{
    partial class frmLearn
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReview = new System.Windows.Forms.Button();
            this.btnLearn = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(41)))), ((int)(((byte)(96)))));
            this.label2.Location = new System.Drawing.Point(112, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "███████";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(294, -6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 46);
            this.label1.TabIndex = 11;
            this.label1.Text = "|";
            // 
            // btnReview
            // 
            this.btnReview.Location = new System.Drawing.Point(206, 12);
            this.btnReview.Name = "btnReview";
            this.btnReview.Size = new System.Drawing.Size(82, 28);
            this.btnReview.TabIndex = 10;
            this.btnReview.Text = "REVIEW";
            this.btnReview.UseVisualStyleBackColor = true;
            this.btnReview.Click += new System.EventHandler(this.btnReview_Click);
            // 
            // btnLearn
            // 
            this.btnLearn.Location = new System.Drawing.Point(109, 12);
            this.btnLearn.Name = "btnLearn";
            this.btnLearn.Size = new System.Drawing.Size(82, 28);
            this.btnLearn.TabIndex = 9;
            this.btnLearn.Text = "LEARN";
            this.btnLearn.UseVisualStyleBackColor = true;
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(12, 12);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(82, 28);
            this.btnHome.TabIndex = 8;
            this.btnHome.Text = "HOME";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(105)))), ((int)(((byte)(216)))));
            this.label3.Location = new System.Drawing.Point(15, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "▀▀▀▀▀▀▀";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(212)))), ((int)(((byte)(75)))));
            this.label4.Location = new System.Drawing.Point(209, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "▀▀▀▀▀▀▀";
            // 
            // frmLearn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReview);
            this.Controls.Add(this.btnLearn);
            this.Controls.Add(this.btnHome);
            this.Name = "frmLearn";
            this.Text = "Learn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReview;
        private System.Windows.Forms.Button btnLearn;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}