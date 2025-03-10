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
            this.lbl_Results = new System.Windows.Forms.Label();
            this.btn_Return = new System.Windows.Forms.Button();
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
            // lbl_Results
            // 
            this.lbl_Results.AutoSize = true;
            this.lbl_Results.Location = new System.Drawing.Point(123, 187);
            this.lbl_Results.Name = "lbl_Results";
            this.lbl_Results.Size = new System.Drawing.Size(35, 13);
            this.lbl_Results.TabIndex = 1;
            this.lbl_Results.Text = "label1";
            // 
            // btn_Return
            // 
            this.btn_Return.Location = new System.Drawing.Point(220, 340);
            this.btn_Return.Name = "btn_Return";
            this.btn_Return.Size = new System.Drawing.Size(75, 23);
            this.btn_Return.TabIndex = 2;
            this.btn_Return.Text = "Go Home!";
            this.btn_Return.UseVisualStyleBackColor = true;
            this.btn_Return.Click += new System.EventHandler(this.btn_Return_Click);
            // 
            // frmAfterview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 450);
            this.Controls.Add(this.btn_Return);
            this.Controls.Add(this.lbl_Results);
            this.Controls.Add(this.lbl_Encouragement);
            this.Name = "frmAfterview";
            this.Text = "Nice job!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Encouragement;
        private System.Windows.Forms.Label lbl_Results;
        private System.Windows.Forms.Button btn_Return;
    }
}