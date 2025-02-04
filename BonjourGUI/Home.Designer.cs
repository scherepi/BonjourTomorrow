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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_quickStart = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(578, -34);
            this.label1.MinimumSize = new System.Drawing.Size(400, 600);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(400, 600);
            this.label1.TabIndex = 1;
            // 
            // btn_quickStart
            // 
            this.btn_quickStart.BackColor = System.Drawing.SystemColors.Control;
            this.btn_quickStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_quickStart.Image = global::BonjourGUI.Properties.Resources.Group_1__1_;
            this.btn_quickStart.Location = new System.Drawing.Point(131, 148);
            this.btn_quickStart.Name = "btn_quickStart";
            this.btn_quickStart.Size = new System.Drawing.Size(208, 208);
            this.btn_quickStart.TabIndex = 0;
            this.btn_quickStart.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(842, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 89);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // BonjourTomorrow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 536);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_quickStart);
            this.Name = "BonjourTomorrow";
            this.Text = "Let\'s learn French!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_quickStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}

