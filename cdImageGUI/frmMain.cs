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
    public partial class frmMain : Form
    {
        private const string README = "Text Files|*.txt|All Files|*.*";
        private const string BOOT = "Boot Sectors|*.bin;*.ima;*.img;*.vfd|All Files|*.*";

        public frmMain()
        {
            InitializeComponent();
            //select the first option of each combobox
            foreach (Control GB in this.Controls)
            {
                if (GB is GroupBox)
                {
                    foreach (Control C in GB.Controls)
                    {
                        if (C is ComboBox)
                        {
                            ((ComboBox)C).SelectedIndex = 0;
                        }
                    }
                }
            }
        }

        private void cbVolumelabel_CheckedChanged(object sender, EventArgs e)
        {
            tbVolumelabel.Enabled = ((CheckBox)sender).Checked;
        }

        private void cbDate_CheckedChanged(object sender, EventArgs e)
        {
            dtpDate.Enabled = cbUTC.Enabled = ((CheckBox)sender).Checked;
        }

        private void cbTest_CheckedChanged(object sender, EventArgs e)
        {
            tbFlags.Enabled = ((CheckBox)sender).Checked;
        }

        private void cbBoot_CheckedChanged(object sender, EventArgs e)
        {
            tbBoot.Enabled = btnBoot.Enabled = tbPlatform.Enabled = cbPlatform.Enabled = cbNoFloppy.Enabled = ((CheckBox)sender).Checked;
        }

        /// <summary>
        /// Enables and disabled certain options depending on the disc type.
        /// </summary>
        private void cbDiscType_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbNoEnforceUppercase.Enabled = cbDosCompatible.Checked || cbDiscType.SelectedIndex == 0;
            switch (cbDiscType.SelectedIndex)
            {
                case 0:
                    cbNamelength.Enabled = true;
                    cbUDFextent.Enabled = cbUDFFID.Enabled = cbUDFSparse.Enabled = cbUDFVideo.Enabled = false;
                    break;
                case 1:
                    cbNamelength.SelectedIndex = 0;
                    cbNoEnforceUppercase.Enabled = cbNamelength.Enabled = false;
                    cbUDFextent.Enabled = cbUDFFID.Enabled = cbUDFSparse.Enabled = cbUDFVideo.Enabled = false;
                    break;
                case 2:
                    cbNamelength.SelectedIndex = 0;
                    cbShowAlloc.Enabled = cbNamelength.Enabled = false;
                    cbUDFextent.Enabled = cbUDFFID.Enabled = cbUDFSparse.Enabled = cbUDFVideo.Enabled = true;
                    break;
                default:
                    break;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            //doing this at the start will disable options so we do not have to hard-code that.
            checkCTRL(this.Controls);
        }

        /// <summary>
        /// Hooks up dynamic events to controls.
        /// </summary>
        private void checkCTRL(Control.ControlCollection controlCollection)
        {
            foreach (Control c in controlCollection)
            {
                if (c is CheckBox)
                {
                    ((CheckBox)c).CheckedChanged += new EventHandler(checkChange);
                }
                else if (c is GroupBox)
                {
                    checkCTRL(((GroupBox)c).Controls);
                }
                else if (c is TextBox)
                {
                    ((TextBox)c).TextChanged+=new EventHandler(checkChange);
                }
                else if (c is ComboBox)
                {
                    ((ComboBox)c).SelectedIndexChanged+=new EventHandler(checkChange);
                }
            }
        }

        private void checkChange(object sender, EventArgs e)
        {
            tbCommand.Text = genCommand();
        }

        /// <summary>
        /// Generates a cdimage.exe command for the options the user has chosen.
        /// </summary>
        private string genCommand()
        {
            List<string> Command = new List<string>();

            if (cbVolumelabel.Checked && !string.IsNullOrEmpty(tbVolumelabel.Text))
            {
                Command.Add(tbVolumelabel.Text.Contains(" ") ? "\"-l" + tbVolumelabel.Text + "\"": "-l" + tbVolumelabel.Text);
            }

            if (cbDate.Checked)
            {
                Command.Add("-t" + dtpDate.Value.ToString("dd/MM/yyyy,HH:mm:ss"));
                if (cbUTC.Checked)
                {
                    Command.Add("-g");
                }
            }

            if (cbIncludeHidden.Checked)
            {
                Command.Add("-h");
            }

            if (cbANSI.Checked)
            {
                Command.Add("-c");
            }

            switch (cbNamelength.SelectedIndex)
            {
                default:
                    break;
                case 1:
                    Command.Add("-n");
                    break;
                case 2:
                    Command.Add("-nt");
                    break;
            }

            if (cbNoEnforceUppercase.Checked && (cbNamelength.SelectedIndex == 0 || cbDosCompatible.Checked))
            {
                Command.Add("-d");
            }

            switch (cbDiscType.SelectedIndex)
            {
                case 1:
                    if (cbDosCompatible.Checked)
                    {
                        Command.Add("-j1");
                    }
                    else
                    {
                        Command.Add("-j2");
                        if (!string.IsNullOrEmpty(tbReadme.Text))
                        {
                            Command.Add("-js" + tbReadme.Text);
                        }
                    }
                    break;
                case 2:
                    if (cbDosCompatible.Checked)
                    {
                        Command.Add("-u1");
                    }
                    else
                    {
                        Command.Add("-u2");
                        if (!string.IsNullOrEmpty(tbReadme.Text))
                        {
                            Command.Add("-ur" + tbReadme.Text);
                        }
                    }
                    if (cbUDFSparse.Checked)
                    {
                        Command.Add("-us");
                    }
                    if (cbUDFextent.Checked)
                    {
                        Command.Add("-ue");
                    }
                    if (cbUDFFID.Checked)
                    {
                        Command.Add("-uf");
                    }
                    if (cbUDFVideo.Checked)
                    {
                        Command.Add("-uv");
                    }
                    break;
                default:
                    break;
            }

            if (cbBoot.Checked && !string.IsNullOrEmpty(tbBoot.Text))
            {
                Command.Add("-b" + tbBoot.Text);
                if (cbPlatform.Checked && !string.IsNullOrEmpty(tbPlatform.Text))
                {
                    Command.Add(tbPlatform.Text.Contains(" ") ? "\"-b" + tbPlatform.Text + "\"" : "-b" + tbPlatform.Text);
                }
                if (cbNoFloppy.Checked)
                {
                    Command.Add("-e");
                }
            }
            if (cbAutoCRC.Checked && cbDiscType.SelectedIndex != 2)
            {
                Command.Add("-x");
            }

            if (cbOptimize.Checked)
            {
                string temp = "-o";
                if (cbCompareBin.Checked)
                {
                    temp+="c";
                }
                if (cbIgnoreDiamond.Checked)
                {
                    temp += "i";
                }
                if (cbShowDuplicates.Checked)
                {
                    temp += "s";
                }
                Command.Add(temp);
            }
            if(cbWarningLevel.SelectedIndex>0)
            {
                Command.Add("-w" + cbWarningLevel.SelectedIndex.ToString());
            }

            if (cbTest.Checked && !string.IsNullOrEmpty(tbFlags.Text))
            {
                Command.Add("-y"+tbFlags.Text);
            }

            if (cbKeepImage.Checked)
            {
                Command.Add("-k");
            }

            if (cbIgnoreMaxSize.Checked)
            {
                Command.Add("-m");
            }

            if (cbScanOnly.Checked)
            {
                Command.Add("-q");
            }

            if (cbShowAlloc.Checked && cbDiscType.SelectedIndex != 2)
            {
                Command.Add("-a");
            }

            Command.Add(tbInFolder.Text.Contains(" ") ? "\"" + tbInFolder.Text + "\"" : tbInFolder.Text);
            Command.Add(tbOutfile.Text.Contains(" ") ? "\"" + tbOutfile.Text + "\"" : tbOutfile.Text);

            return string.Join(" ", Command.ToArray());
        }

        private void cbOptimize_CheckedChanged(object sender, EventArgs e)
        {
            cbShowDuplicates.Enabled = cbIgnoreDiamond.Enabled = cbCompareBin.Enabled = cbOptimize.Checked;
        }

        private void cbDosCompatible_CheckedChanged(object sender, EventArgs e)
        {
            tbReadme.Enabled = btnReadme.Enabled = !cbDosCompatible.Checked;
            cbNoEnforceUppercase.Enabled = cbDosCompatible.Checked && cbDiscType.SelectedIndex != 1;
        }

        private void btnBrowseIn_Click(object sender, EventArgs e)
        {
            if (FBD.ShowDialog() == DialogResult.OK)
            {
                tbInFolder.Text = FBD.SelectedPath;
            }
        }

        private void btnBrowseOut_Click(object sender, EventArgs e)
        {
            if (SFD.ShowDialog() == DialogResult.OK)
            {
                tbOutfile.Text = SFD.FileName;
            }
        }

        private void btnReadme_Click(object sender, EventArgs e)
        {
            OFD.Filter = README;
            if (OFD.ShowDialog() == DialogResult.OK)
            {
                tbReadme.Text = OFD.FileName;
            }
        }

        private void btnBoot_Click(object sender, EventArgs e)
        {
            OFD.Filter = BOOT;
            if (OFD.ShowDialog() == DialogResult.OK)
            {
                tbBoot.Text = OFD.FileName;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            new frmRun(genCommand()).Show();
        }

        private void tbVolumelabel_TextChanged(object sender, EventArgs e)
        {
            if (tbVolumelabel.Text.Contains(" "))
            {
                int selStart = tbVolumelabel.SelectionStart;
                tbVolumelabel.Text = tbVolumelabel.Text.Replace(' ', '_');
                tbVolumelabel.SelectionStart = selStart;
            }
        }
    }
}
