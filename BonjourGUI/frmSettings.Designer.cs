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
            this.SuspendLayout();
            // 
            // btn_Return
            // 
            this.btn_Return.Image = global::BonjourGUI.Properties.Resources.back_icon;
            this.btn_Return.Location = new System.Drawing.Point(-2, 580);
            this.btn_Return.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Return.Name = "btn_Return";
            this.btn_Return.Size = new System.Drawing.Size(112, 115);
            this.btn_Return.TabIndex = 0;
            this.btn_Return.UseVisualStyleBackColor = true;
            this.btn_Return.Click += new System.EventHandler(this.btn_Return_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(344, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Settings";
            // 
            // btn_DataDebug
            // 
            this.btn_DataDebug.Location = new System.Drawing.Point(813, 375);
            this.btn_DataDebug.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_DataDebug.Name = "btn_DataDebug";
            this.btn_DataDebug.Size = new System.Drawing.Size(112, 35);
            this.btn_DataDebug.TabIndex = 2;
            this.btn_DataDebug.Text = "Data";
            this.btn_DataDebug.UseVisualStyleBackColor = true;
            this.btn_DataDebug.Click += new System.EventHandler(this.btn_DataDebug_Click);
            // 
            // lbl_Debug
            // 
            this.lbl_Debug.AutoSize = true;
            this.lbl_Debug.Location = new System.Drawing.Point(921, 335);
            this.lbl_Debug.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Debug.Name = "lbl_Debug";
            this.lbl_Debug.Size = new System.Drawing.Size(68, 20);
            this.lbl_Debug.TabIndex = 3;
            this.lbl_Debug.Text = "DEBUG";
            // 
            // btn_ProgDebug
            // 
            this.btn_ProgDebug.Location = new System.Drawing.Point(972, 375);
            this.btn_ProgDebug.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_ProgDebug.Name = "btn_ProgDebug";
            this.btn_ProgDebug.Size = new System.Drawing.Size(112, 35);
            this.btn_ProgDebug.TabIndex = 4;
            this.btn_ProgDebug.Text = "Progress";
            this.btn_ProgDebug.UseVisualStyleBackColor = true;
            this.btn_ProgDebug.Click += new System.EventHandler(this.btn_ProgDebug_Click);
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.btn_ProgDebug);
            this.Controls.Add(this.lbl_Debug);
            this.Controls.Add(this.btn_DataDebug);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Return);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
    }
}