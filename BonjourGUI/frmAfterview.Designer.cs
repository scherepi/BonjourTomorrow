namespace BonjourGUI
{
    partial class frmAfterview
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
            this.lbl_Encouragement = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Encouragement
            // 
            this.lbl_Encouragement.AutoSize = true;
            this.lbl_Encouragement.Font = new System.Drawing.Font("Ingrid Darling", 47.99999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Encouragement.Location = new System.Drawing.Point(-1, 0);
            this.lbl_Encouragement.MinimumSize = new System.Drawing.Size(534, 0);
            this.lbl_Encouragement.Name = "lbl_Encouragement";
            this.lbl_Encouragement.Size = new System.Drawing.Size(534, 100);
            this.lbl_Encouragement.TabIndex = 0;
            this.lbl_Encouragement.Text = "lbl_Encouragement";
            this.lbl_Encouragement.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmAfterview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 450);
            this.Controls.Add(this.lbl_Encouragement);
            this.Name = "frmAfterview";
            this.Text = "Nice job!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Encouragement;
    }
}