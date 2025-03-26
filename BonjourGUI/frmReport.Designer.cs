namespace BonjourGUI
{
    partial class frmReport
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btn_Return = new System.Windows.Forms.Button();
            this.cht_Report = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.progressHandlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.cht_Report)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressHandlerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Return
            // 
            this.btn_Return.Image = global::BonjourGUI.Properties.Resources.istockphoto_900591912_612x612;
            this.btn_Return.Location = new System.Drawing.Point(-1, 377);
            this.btn_Return.Name = "btn_Return";
            this.btn_Return.Size = new System.Drawing.Size(75, 75);
            this.btn_Return.TabIndex = 2;
            this.btn_Return.UseVisualStyleBackColor = true;
            this.btn_Return.Click += new System.EventHandler(this.btn_Return_Click);
            // 
            // cht_Report
            // 
            chartArea1.Name = "ChartArea1";
            this.cht_Report.ChartAreas.Add(chartArea1);
            this.cht_Report.DataSource = this.progressHandlerBindingSource;
            legend1.Name = "Legend1";
            this.cht_Report.Legends.Add(legend1);
            this.cht_Report.Location = new System.Drawing.Point(414, 49);
            this.cht_Report.Name = "cht_Report";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.cht_Report.Series.Add(series1);
            this.cht_Report.Size = new System.Drawing.Size(300, 300);
            this.cht_Report.TabIndex = 3;
            this.cht_Report.Text = "chart1";
            // 
            // progressHandlerBindingSource
            // 
            this.progressHandlerBindingSource.DataSource = typeof(BonjourClasses.ProgressHandler);
            // 
            // frmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cht_Report);
            this.Controls.Add(this.btn_Return);
            this.Name = "frmReport";
            this.Text = "Check the Stats!";
            ((System.ComponentModel.ISupportInitialize)(this.cht_Report)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressHandlerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Return;
        private System.Windows.Forms.DataVisualization.Charting.Chart cht_Report;
        private System.Windows.Forms.BindingSource progressHandlerBindingSource;
    }
}