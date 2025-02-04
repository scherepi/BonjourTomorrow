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
            this.btn_quickStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_quickStart
            // 
            this.btn_quickStart.BackColor = System.Drawing.SystemColors.Control;
            this.btn_quickStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_quickStart.Image = global::BonjourGUI.Properties.Resources.Group_1;
            this.btn_quickStart.Location = new System.Drawing.Point(118, 118);
            this.btn_quickStart.Name = "btn_quickStart";
            this.btn_quickStart.Size = new System.Drawing.Size(208, 208);
            this.btn_quickStart.TabIndex = 0;
            this.btn_quickStart.UseVisualStyleBackColor = false;
            // 
            // BonjourTomorrow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_quickStart);
            this.Name = "BonjourTomorrow";
            this.Text = "Let\'s learn French!";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_quickStart;
    }
}

