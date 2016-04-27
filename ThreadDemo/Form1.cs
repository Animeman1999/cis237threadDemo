using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace ThreadDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            getData();
/*
            BackgroundWorker worker = new BackgroundWorker();
            worker.WorkerReportsProgress = true;

            progressBar1.Maximum = 100;
            progressBar1.Step = 1;
            progressBar1.Value = 0;

            worker.DoWork += (sen, ev) =>
            {
                for (Int64 i = 0; i < 400000000; i++)
                {
                    var backgroundWorker = sen as BackgroundWorker;
                    if (i % 4000000 == 0)
                    {
                        backgroundWorker.ReportProgress((Int32)((i * 100) / 400000000));
                    }
                }
                ev.Result = "David";
            };

            worker.RunWorkerCompleted += (sen, ev) =>
            {
                //e.Result "returned" from thread
                label1.Text = (string)ev.Result;
                label1.Font = new Font("Arial", 22);
            };

            worker.ProgressChanged += (sen, ev) =>
            {
                progressBar1.Value = ev.ProgressPercentage;
            };

            worker.RunWorkerAsync();
*/
        }


        private void getData()
        {
            for (Int64 i=0; i<400000000; i++)
            {
                if (i % 4000000 == 0)
                {
                    progressBar1.Value = ((Int32)((i * 100) / 400000000));
                }
            }

            label1.Text = "David";
            label1.Font = new Font("Arial", 22);
        }

    }
}
