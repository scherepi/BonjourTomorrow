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
            this.btnFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFood.Location = new System.Drawing.Point(668, 80);
            this.btnFood.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnFood.Name = "btnFood";
            this.btnFood.Size = new System.Drawing.Size(306, 149);
            this.btnFood.TabIndex = 2;
            this.btnFood.Text = "Food";
            this.btnFood.UseVisualStyleBackColor = false;
            this.btnFood.Click += new System.EventHandler(this.btnFood_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Image = global::BonjourGUI.Properties.Resources.Ellipse_1__1_;
            this.label1.Location = new System.Drawing.Point(568, 294);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.MinimumSize = new System.Drawing.Size(88, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 91);
            this.label1.TabIndex = 3;
            // 
            // btn_Return
            // 
            this.btn_Return.Image = global::BonjourGUI.Properties.Resources.istockphoto_900591912_612x612;
            this.btn_Return.Location = new System.Drawing.Point(2, 578);
            this.btn_Return.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Return.Name = "btn_Return";
            this.btn_Return.Size = new System.Drawing.Size(112, 115);
            this.btn_Return.TabIndex = 1;
            this.btn_Return.UseVisualStyleBackColor = true;
            this.btn_Return.Click += new System.EventHandler(this.btn_Return_Click);
            // 
            // btnNumbers
            // 
            this.btnNumbers.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNumbers.Location = new System.Drawing.Point(668, 448);
            this.btnNumbers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNumbers.Name = "btnNumbers";
            this.btnNumbers.Size = new System.Drawing.Size(306, 149);
            this.btnNumbers.TabIndex = 4;
            this.btnNumbers.Text = "Numbers";
            this.btnNumbers.UseVisualStyleBackColor = false;
            this.btnNumbers.Click += new System.EventHandler(this.btnNumbers_Click);
            // 
            // btnBusiness
            // 
            this.btnBusiness.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBusiness.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBusiness.Location = new System.Drawing.Point(234, 448);
            this.btnBusiness.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBusiness.Name = "btnBusiness";
            this.btnBusiness.Size = new System.Drawing.Size(306, 149);
            this.btnBusiness.TabIndex = 5;
            this.btnBusiness.Text = "Business";
            this.btnBusiness.UseVisualStyleBackColor = false;
            this.btnBusiness.Click += new System.EventHandler(this.btnBusiness_Click);
            // 
            // btnGreetings
            // 
            this.btnGreetings.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGreetings.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGreetings.Location = new System.Drawing.Point(234, 80);
            this.btnGreetings.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGreetings.Name = "btnGreetings";
            this.btnGreetings.Size = new System.Drawing.Size(306, 149);
            this.btnGreetings.TabIndex = 6;
            this.btnGreetings.Text = "Greetings";
            this.btnGreetings.UseVisualStyleBackColor = false;
            this.btnGreetings.Click += new System.EventHandler(this.btnGreetings_Click);
            // 
            // frmTopics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.btnGreetings);
            this.Controls.Add(this.btnBusiness);
            this.Controls.Add(this.btnNumbers);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFood);
            this.Controls.Add(this.btn_Return);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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