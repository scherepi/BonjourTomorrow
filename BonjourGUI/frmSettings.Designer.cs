namespace BonjourGUI
{
    partial class frmSettings
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
            this.btn_Return = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_DataDebug = new System.Windows.Forms.Button();
            this.lbl_Debug = new System.Windows.Forms.Label();
            this.btn_ProgDebug = new System.Windows.Forms.Button();
            this.btnBakery = new System.Windows.Forms.Button();
            this.btnFood = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Return
            // 
            this.btn_Return.Image = global::BonjourGUI.Properties.Resources.istockphoto_900591912_612x612;
            this.btn_Return.Location = new System.Drawing.Point(-1, 377);
            this.btn_Return.Name = "btn_Return";
            this.btn_Return.Size = new System.Drawing.Size(75, 75);
            this.btn_Return.TabIndex = 0;
            this.btn_Return.UseVisualStyleBackColor = true;
            this.btn_Return.Click += new System.EventHandler(this.btn_Return_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(229, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Settings";
            // 
            // btn_DataDebug
            // 
            this.btn_DataDebug.Location = new System.Drawing.Point(542, 244);
            this.btn_DataDebug.Name = "btn_DataDebug";
            this.btn_DataDebug.Size = new System.Drawing.Size(75, 23);
            this.btn_DataDebug.TabIndex = 2;
            this.btn_DataDebug.Text = "Data";
            this.btn_DataDebug.UseVisualStyleBackColor = true;
            this.btn_DataDebug.Click += new System.EventHandler(this.btn_DataDebug_Click);
            // 
            // lbl_Debug
            // 
            this.lbl_Debug.AutoSize = true;
            this.lbl_Debug.Location = new System.Drawing.Point(614, 218);
            this.lbl_Debug.Name = "lbl_Debug";
            this.lbl_Debug.Size = new System.Drawing.Size(45, 13);
            this.lbl_Debug.TabIndex = 3;
            this.lbl_Debug.Text = "DEBUG";
            // 
            // btn_ProgDebug
            // 
            this.btn_ProgDebug.Location = new System.Drawing.Point(648, 244);
            this.btn_ProgDebug.Name = "btn_ProgDebug";
            this.btn_ProgDebug.Size = new System.Drawing.Size(75, 23);
            this.btn_ProgDebug.TabIndex = 4;
            this.btn_ProgDebug.Text = "Progress";
            this.btn_ProgDebug.UseVisualStyleBackColor = true;
            this.btn_ProgDebug.Click += new System.EventHandler(this.btn_ProgDebug_Click);
            // 
            // btnBakery
            // 
            this.btnBakery.Location = new System.Drawing.Point(542, 285);
            this.btnBakery.Name = "btnBakery";
            this.btnBakery.Size = new System.Drawing.Size(75, 23);
            this.btnBakery.TabIndex = 5;
            this.btnBakery.Text = "Bakery";
            this.btnBakery.UseVisualStyleBackColor = true;
            this.btnBakery.Click += new System.EventHandler(this.btnBakery_Click);
            // 
            // btnFood
            // 
            this.btnFood.Location = new System.Drawing.Point(648, 285);
            this.btnFood.Name = "btnFood";
            this.btnFood.Size = new System.Drawing.Size(75, 23);
            this.btnFood.TabIndex = 6;
            this.btnFood.Text = "Food";
            this.btnFood.UseVisualStyleBackColor = true;
            this.btnFood.Click += new System.EventHandler(this.btnFood_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(648, 325);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnFood);
            this.Controls.Add(this.btnBakery);
            this.Controls.Add(this.btn_ProgDebug);
            this.Controls.Add(this.lbl_Debug);
            this.Controls.Add(this.btn_DataDebug);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Return);
            this.Name = "frmSettings";
            this.Text = "frmSettings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Return;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_DataDebug;
        private System.Windows.Forms.Label lbl_Debug;
        private System.Windows.Forms.Button btn_ProgDebug;
        private System.Windows.Forms.Button btnBakery;
        private System.Windows.Forms.Button btnFood;
        private System.Windows.Forms.Button btnReset;
    }
}