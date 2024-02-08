using System;
using System.ComponentModel;
using System.Threading;
using System.Windows.Forms;

namespace Assingment1MCQGame_AnyaScheinman
{
    public partial class Form16 : Form
    {
        private Form3 nf;

        public Form16()
        {
            InitializeComponent();
            nf = new Form3();
            nf.Activated += Form3_Activated;
        }

        private void Form3_Activated(object sender, EventArgs e)
        {
            // Close Form16 when Form3 is activated (shown)
        }
        private void progressBar1_Click(object sender, EventArgs e)
        {
            this.Close();

            // Your code for the progressBar1_Click event
        }
        private void label1_Click(object sender, EventArgs e)
        {
            // Your code for the label1_Click event
        }


        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            int sum = 0;
            for (int i = 1; i <= 100; i++)
            {
                Thread.Sleep(100);
                sum = sum + i;
                backgroundWorker1.ReportProgress(i);

                if (i == 100)
                {
                    e.Cancel = true;
                    backgroundWorker1.ReportProgress(100);
                    return;
                }

                if (backgroundWorker1.CancellationPending)
                {
                    e.Cancel = true;
                    backgroundWorker1.ReportProgress(0);
                    return;
                }
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
            label1.Text = e.ProgressPercentage.ToString() + "%";
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                label1.Text = "";
                // Show and activate Form3
                nf.Show();
                nf.Activate();
            }
            else if (e.Error != null)
            {
                label1.Text = e.Error.Message;
            }
            else
            {
                label1.Text = e.Result.ToString();
            }
        }

        private void Form16_Load(object sender, EventArgs e)
        {
            if (!backgroundWorker1.IsBusy)
            {
                backgroundWorker1.RunWorkerAsync();
            }
        }
    }
}
