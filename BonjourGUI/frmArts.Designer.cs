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
            this.lbl_Welcome = new System.Windows.Forms.Label();
            this.btn_LouvreLock = new System.Windows.Forms.Button();
            this.btn_BakeryLock = new System.Windows.Forms.Button();
            this.lbl_Louvre = new System.Windows.Forms.Label();
            this.lbl_Bakery = new System.Windows.Forms.Label();
            this.btn_Return = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Welcome
            // 
            this.lbl_Welcome.AutoSize = true;
            this.lbl_Welcome.Font = new System.Drawing.Font("Ingrid Darling", 70F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Welcome.Location = new System.Drawing.Point(248, 36);
            this.lbl_Welcome.Name = "lbl_Welcome";
            this.lbl_Welcome.Size = new System.Drawing.Size(512, 146);
            this.lbl_Welcome.TabIndex = 4;
            this.lbl_Welcome.Text = "Welcome to Paris!";
            // 
            // btn_LouvreLock
            // 
            this.btn_LouvreLock.Image = global::BonjourGUI.Properties.Resources._lock;
            this.btn_LouvreLock.Location = new System.Drawing.Point(716, 333);
            this.btn_LouvreLock.Name = "btn_LouvreLock";
            this.btn_LouvreLock.Size = new System.Drawing.Size(102, 117);
            this.btn_LouvreLock.TabIndex = 6;
            this.btn_LouvreLock.UseVisualStyleBackColor = true;
            // 
            // btn_BakeryLock
            // 
            this.btn_BakeryLock.Image = global::BonjourGUI.Properties.Resources.small_lock;
            this.btn_BakeryLock.Location = new System.Drawing.Point(273, 463);
            this.btn_BakeryLock.Name = "btn_BakeryLock";
            this.btn_BakeryLock.Size = new System.Drawing.Size(44, 59);
            this.btn_BakeryLock.TabIndex = 5;
            this.btn_BakeryLock.UseVisualStyleBackColor = true;
            // 
            // lbl_Louvre
            // 
            this.lbl_Louvre.AutoSize = true;
            this.lbl_Louvre.Image = global::BonjourGUI.Properties.Resources.louvre_cropped;
            this.lbl_Louvre.Location = new System.Drawing.Point(531, 182);
            this.lbl_Louvre.MinimumSize = new System.Drawing.Size(450, 381);
            this.lbl_Louvre.Name = "lbl_Louvre";
            this.lbl_Louvre.Size = new System.Drawing.Size(450, 381);
            this.lbl_Louvre.TabIndex = 3;
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
            this.Controls.Add(this.btn_LouvreLock);
            this.Controls.Add(this.btn_BakeryLock);
            this.Controls.Add(this.lbl_Welcome);
            this.Controls.Add(this.lbl_Louvre);
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
        private System.Windows.Forms.Label lbl_Louvre;
        private System.Windows.Forms.Label lbl_Welcome;
        private System.Windows.Forms.Button btn_BakeryLock;
        private System.Windows.Forms.Button btn_LouvreLock;
    }
}