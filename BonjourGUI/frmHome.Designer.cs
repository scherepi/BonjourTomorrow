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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btn_quickStart = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(212)))), ((int)(((byte)(75)))));
            this.label4.Location = new System.Drawing.Point(209, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "▀▀▀▀▀▀▀";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(105)))), ((int)(((byte)(216)))));
            this.label3.Location = new System.Drawing.Point(15, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "███████";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(41)))), ((int)(((byte)(96)))));
            this.label2.Location = new System.Drawing.Point(112, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "▀▀▀▀▀▀▀";
            // 
            // btnExit
            // 
            this.btnExit.Image = global::BonjourGUI.Properties.Resources.Adobe_Express___file;
            this.btnExit.Location = new System.Drawing.Point(713, 363);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 75);
            this.btnExit.TabIndex = 25;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Image = global::BonjourGUI.Properties.Resources._2821378_1;
            this.btnSettings.Location = new System.Drawing.Point(704, 12);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(84, 82);
            this.btnSettings.TabIndex = 6;
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btn_quickStart
            // 
            this.btn_quickStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.btn_quickStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_quickStart.Image = global::BonjourGUI.Properties.Resources.Group_1;
            this.btn_quickStart.Location = new System.Drawing.Point(50, 118);
            this.btn_quickStart.Name = "btn_quickStart";
            this.btn_quickStart.Size = new System.Drawing.Size(208, 208);
            this.btn_quickStart.TabIndex = 0;
            this.btn_quickStart.UseVisualStyleBackColor = false;
            this.btn_quickStart.Click += new System.EventHandler(this.btn_quickStart_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Itim", 25F);
            this.label5.Location = new System.Drawing.Point(63, 329);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(187, 40);
            this.label5.TabIndex = 26;
            this.label5.Text = "Quick Start";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BonjourTomorrow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label5;
    }
}

