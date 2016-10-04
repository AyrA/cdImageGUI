using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace cdImageGUI
{
    public partial class frmRun : Form
    {
        private Process P;

        public frmRun(string args)
        {
            InitializeComponent();
            tbOutput.Clear();
            //this rather complex setup allows us to read from a console process without showing it.
            P = new Process();
            P.StartInfo.FileName = "cdimage.exe";
            P.StartInfo.Arguments = args;
            P.OutputDataReceived += new DataReceivedEventHandler(P_OutputDataReceived);
            P.ErrorDataReceived += new DataReceivedEventHandler(P_ErrorDataReceived);
            P.Exited += new EventHandler(P_Exited);
            P.StartInfo.UseShellExecute = false;
            P.EnableRaisingEvents = true;
            P.StartInfo.CreateNoWindow = true;
            P.StartInfo.RedirectStandardOutput = true;
            P.StartInfo.RedirectStandardError = true;
            P.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            P.Start();
            P.BeginOutputReadLine();
            P.BeginErrorReadLine();
        }

        void P_Exited(object sender, EventArgs e)
        {
            try
            {
                this.Invoke((MethodInvoker)delegate
                {
                    addLog("== Process finished ==");
                    MessageBox.Show("Operation finished");
                    pbMain.Value = 0;
                    btnCancel.Text = "Close";
                });
            }
            catch
            {
                //NOOP
            }
        }

        /// <summary>
        /// Reads a line from the error stream. This stream contains the progress value.
        /// </summary>
        void P_ErrorDataReceived(object sender, DataReceivedEventArgs e)
        {
            int i = 0;
            if (!string.IsNullOrEmpty(e.Data))
            {
                if (e.Data.Contains("%") && e.Data.IndexOf('%') > 0 && int.TryParse(e.Data.Split('%')[0], out i) && i >= 0 && i <= 100)
                {
                    try
                    {
                        this.Invoke((MethodInvoker)delegate
                        {
                            if (!string.IsNullOrEmpty(e.Data))
                            {
                                pbMain.Value = i;
                            }
                        });
                    }
                    catch
                    {
                        //NOOP
                    }
                }
                else
                {
                    //Log error
                    P_OutputDataReceived(sender, e);
                }
            }
        }

        /// <summary>
        /// Reads a line from the output stream. This stream contains log messages.
        /// </summary>
        void P_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            try
            {
                this.Invoke((MethodInvoker)delegate
                {
                    if (!string.IsNullOrEmpty(e.Data))
                    {
                        addLog(e.Data);
                    }
                });
            }
            catch
            {
                //NOOP
            }
        }

        /// <summary>
        /// adds a line to the text log
        /// </summary>
        private void addLog(string p)
        {
            tbOutput.Text += p + "\r\n";
            //We might want to check the number of lines in the future and erase some of the older ones.
            tbOutput.SelectionStart = tbOutput.Text.Length;
            tbOutput.ScrollToCaret();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (P.HasExited || MessageBox.Show("This will abort the current process.\r\nAre you sure?", "Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (!P.HasExited)
                {
                    P.Kill();
                    addLog("== Process Terminated ==");
                }
                Close();
            }
        }
    }
}
