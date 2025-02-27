namespace BonjourGUI
{
    partial class frmTopics
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
            this.btnFood = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Return = new System.Windows.Forms.Button();
            this.btnNumbers = new System.Windows.Forms.Button();
            this.btnBusiness = new System.Windows.Forms.Button();
            this.btnGreetings = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFood
            // 
            this.btnFood.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnFood.Font = new System.Drawing.Font("Itim", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFood.Location = new System.Drawing.Point(445, 52);
            this.btnFood.Name = "btnFood";
            this.btnFood.Size = new System.Drawing.Size(204, 97);
            this.btnFood.TabIndex = 2;
            this.btnFood.Text = "Food";
            this.btnFood.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Image = global::BonjourGUI.Properties.Resources.Ellipse_1__1_;
            this.label1.Location = new System.Drawing.Point(379, 191);
            this.label1.MinimumSize = new System.Drawing.Size(59, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 59);
            this.label1.TabIndex = 3;
            // 
            // btn_Return
            // 
            this.btn_Return.Image = global::BonjourGUI.Properties.Resources.istockphoto_900591912_612x612;
            this.btn_Return.Location = new System.Drawing.Point(1, 376);
            this.btn_Return.Name = "btn_Return";
            this.btn_Return.Size = new System.Drawing.Size(75, 75);
            this.btn_Return.TabIndex = 1;
            this.btn_Return.UseVisualStyleBackColor = true;
            this.btn_Return.Click += new System.EventHandler(this.btn_Return_Click);
            // 
            // btnNumbers
            // 
            this.btnNumbers.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnNumbers.Font = new System.Drawing.Font("Itim", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNumbers.Location = new System.Drawing.Point(445, 291);
            this.btnNumbers.Name = "btnNumbers";
            this.btnNumbers.Size = new System.Drawing.Size(204, 97);
            this.btnNumbers.TabIndex = 4;
            this.btnNumbers.Text = "Numbers";
            this.btnNumbers.UseVisualStyleBackColor = false;
            // 
            // btnBusiness
            // 
            this.btnBusiness.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBusiness.Font = new System.Drawing.Font("Itim", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBusiness.Location = new System.Drawing.Point(156, 291);
            this.btnBusiness.Name = "btnBusiness";
            this.btnBusiness.Size = new System.Drawing.Size(204, 97);
            this.btnBusiness.TabIndex = 5;
            this.btnBusiness.Text = "Business";
            this.btnBusiness.UseVisualStyleBackColor = false;
            // 
            // btnGreetings
            // 
            this.btnGreetings.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGreetings.Font = new System.Drawing.Font("Itim", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGreetings.Location = new System.Drawing.Point(156, 52);
            this.btnGreetings.Name = "btnGreetings";
            this.btnGreetings.Size = new System.Drawing.Size(204, 97);
            this.btnGreetings.TabIndex = 6;
            this.btnGreetings.Text = "Greetings";
            this.btnGreetings.UseVisualStyleBackColor = false;
            // 
            // frmTopics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGreetings);
            this.Controls.Add(this.btnBusiness);
            this.Controls.Add(this.btnNumbers);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFood);
            this.Controls.Add(this.btn_Return);
            this.Name = "frmTopics";
            this.Text = "frmTopics";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Return;
        private System.Windows.Forms.Button btnFood;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNumbers;
        private System.Windows.Forms.Button btnBusiness;
        private System.Windows.Forms.Button btnGreetings;
    }
}