namespace BonjourGUI
{
    partial class frmArts
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
            this.lbl_Bakery = new System.Windows.Forms.Label();
            this.btn_Return = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Image = global::BonjourGUI.Properties.Resources.louvre_cropped;
            this.label1.Location = new System.Drawing.Point(531, 182);
            this.label1.MinimumSize = new System.Drawing.Size(450, 381);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(450, 381);
            this.label1.TabIndex = 3;
            // 
            // lbl_Bakery
            // 
            this.lbl_Bakery.Image = global::BonjourGUI.Properties.Resources.bakery;
            this.lbl_Bakery.Location = new System.Drawing.Point(12, 230);
            this.lbl_Bakery.MinimumSize = new System.Drawing.Size(500, 333);
            this.lbl_Bakery.Name = "lbl_Bakery";
            this.lbl_Bakery.Size = new System.Drawing.Size(500, 333);
            this.lbl_Bakery.TabIndex = 2;
            // 
            // btn_Return
            // 
            this.btn_Return.Image = global::BonjourGUI.Properties.Resources.istockphoto_900591912_612x612;
            this.btn_Return.Location = new System.Drawing.Point(-1, 0);
            this.btn_Return.Name = "btn_Return";
            this.btn_Return.Size = new System.Drawing.Size(75, 75);
            this.btn_Return.TabIndex = 1;
            this.btn_Return.UseVisualStyleBackColor = true;
            this.btn_Return.Click += new System.EventHandler(this.btn_Return_Click);
            // 
            // frmArts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_Bakery);
            this.Controls.Add(this.btn_Return);
            this.Name = "frmArts";
            this.Text = "Explore the Arts!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Return;
        private System.Windows.Forms.Label lbl_Bakery;
        private System.Windows.Forms.Label label1;
    }
}