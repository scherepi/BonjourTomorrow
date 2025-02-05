namespace BonjourGUI
{
    partial class BonjourTomorrow
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
            this.btnHome = new System.Windows.Forms.Button();
            this.btnLearn = new System.Windows.Forms.Button();
            this.btnReview = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Greeting = new System.Windows.Forms.Label();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btn_quickStart = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(12, 12);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(82, 28);
            this.btnHome.TabIndex = 1;
            this.btnHome.Text = "HOME";
            this.btnHome.UseVisualStyleBackColor = true;
            // 
            // btnLearn
            // 
            this.btnLearn.Location = new System.Drawing.Point(109, 12);
            this.btnLearn.Name = "btnLearn";
            this.btnLearn.Size = new System.Drawing.Size(82, 28);
            this.btnLearn.TabIndex = 2;
            this.btnLearn.Text = "LEARN";
            this.btnLearn.UseVisualStyleBackColor = true;
            this.btnLearn.Click += new System.EventHandler(this.btnLearn_Click);
            // 
            // btnReview
            // 
            this.btnReview.Location = new System.Drawing.Point(206, 12);
            this.btnReview.Name = "btnReview";
            this.btnReview.Size = new System.Drawing.Size(82, 28);
            this.btnReview.TabIndex = 3;
            this.btnReview.Text = "REVIEW";
            this.btnReview.UseVisualStyleBackColor = true;
            this.btnReview.Click += new System.EventHandler(this.btnReview_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(294, -6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 46);
            this.label1.TabIndex = 4;
            this.label1.Text = "|";
            // 
            // lbl_Greeting
            // 
            this.lbl_Greeting.AutoSize = true;
            this.lbl_Greeting.Font = new System.Drawing.Font("Itim", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Greeting.Location = new System.Drawing.Point(365, 190);
            this.lbl_Greeting.Name = "lbl_Greeting";
            this.lbl_Greeting.Size = new System.Drawing.Size(167, 48);
            this.lbl_Greeting.TabIndex = 5;
            this.lbl_Greeting.Text = "Bonjour!";
            // 
            // btnSettings
            // 
            this.btnSettings.Image = global::BonjourGUI.Properties.Resources._2821378_1;
            this.btnSettings.Location = new System.Drawing.Point(704, 12);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(84, 82);
            this.btnSettings.TabIndex = 6;
            this.btnSettings.UseVisualStyleBackColor = true;
            // 
            // btn_quickStart
            // 
            this.btn_quickStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.btn_quickStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_quickStart.Image = global::BonjourGUI.Properties.Resources.Group_1;
            this.btn_quickStart.Location = new System.Drawing.Point(118, 118);
            this.btn_quickStart.Name = "btn_quickStart";
            this.btn_quickStart.Size = new System.Drawing.Size(208, 208);
            this.btn_quickStart.TabIndex = 0;
            this.btn_quickStart.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "███████";
            // 
            // BonjourTomorrow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.lbl_Greeting);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReview);
            this.Controls.Add(this.btnLearn);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btn_quickStart);
            this.Name = "BonjourTomorrow";
            this.Text = "Let\'s learn French!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_quickStart;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnLearn;
        private System.Windows.Forms.Button btnReview;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Greeting;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Label label2;
    }
}

