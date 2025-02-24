using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using BonjourClasses;

// 2/23/2025 - WOOOOO DATA BACKEND ACTUALLY WORKS 

// TODOs:
// - Increase verbosity

namespace BonjourGUI
{
    public partial class BonjourTomorrow : Form
    {
        public DataHandler dataHandler;
        public ProgressHandler progressHandler;
        public BonjourTomorrow()
        {
            InitializeComponent();
            // Initialize data, because it hasn't been initialized yet if we're using this constructor.
            this.dataHandler = new DataHandler(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\..\\..\\..\\Data");
            this.progressHandler = dataHandler.loadProgress();
            AppDomain.CurrentDomain.ProcessExit += new EventHandler(OnProcessExit);
        }

        void OnProcessExit(object sender, EventArgs e)
        {
            this.dataHandler.saveProgress(this.progressHandler);
        }   

        public BonjourTomorrow(DataHandler dataHandler, ProgressHandler progressHandler)
        {
            Console.WriteLine("Home received handlers");
            InitializeComponent();
            // Use the handlers we've previously initialized for the program, passed back to us!
            this.dataHandler = dataHandler;
            this.progressHandler = progressHandler;
        }

        // BUTTONS TO NAVIGATE APPLICATION

        private void btnLearn_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread t = new Thread(new ThreadStart(ThreadLearnForm));
            t.Start();
        }
        private void ThreadLearnForm()
        {
            Application.Run(new frmLearn(this.progressHandler, this.dataHandler));
        }

        private void btnReview_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread t = new Thread(new ThreadStart(ThreadReviewForm));
            t.Start();
        }
        private void ThreadReviewForm()
        {
            Application.Run(new frmReview(this.progressHandler, this.dataHandler));
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread t = new Thread(new ThreadStart(ThreadSettingsForm));
            t.Start();
        }
        private void ThreadSettingsForm()
        {
            Application.Run(new frmSettings(this.progressHandler, this.dataHandler));
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_quickStart_Click(object sender, EventArgs e)
        {
            SessionHandler.startSession();
            
        }
    }
}
