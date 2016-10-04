namespace cdImageGUI
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnBrowseIn = new System.Windows.Forms.Button();
            this.tbInFolder = new System.Windows.Forms.TextBox();
            this.btnBrowseOut = new System.Windows.Forms.Button();
            this.tbOutfile = new System.Windows.Forms.TextBox();
            this.gbFile = new System.Windows.Forms.GroupBox();
            this.cbIncludeHidden = new System.Windows.Forms.CheckBox();
            this.gbDisc = new System.Windows.Forms.GroupBox();
            this.tbReadme = new System.Windows.Forms.TextBox();
            this.cbDosCompatible = new System.Windows.Forms.CheckBox();
            this.cbANSI = new System.Windows.Forms.CheckBox();
            this.cbNoEnforceUppercase = new System.Windows.Forms.CheckBox();
            this.btnReadme = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbDiscType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbNamelength = new System.Windows.Forms.ComboBox();
            this.cbUTC = new System.Windows.Forms.CheckBox();
            this.cbDate = new System.Windows.Forms.CheckBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.cbVolumelabel = new System.Windows.Forms.CheckBox();
            this.tbVolumelabel = new System.Windows.Forms.TextBox();
            this.gbUDF = new System.Windows.Forms.GroupBox();
            this.cbUDFVideo = new System.Windows.Forms.CheckBox();
            this.cbUDFFID = new System.Windows.Forms.CheckBox();
            this.cbUDFextent = new System.Windows.Forms.CheckBox();
            this.cbUDFSparse = new System.Windows.Forms.CheckBox();
            this.gbBoot = new System.Windows.Forms.GroupBox();
            this.tbPlatform = new System.Windows.Forms.TextBox();
            this.cbNoFloppy = new System.Windows.Forms.CheckBox();
            this.cbPlatform = new System.Windows.Forms.CheckBox();
            this.tbBoot = new System.Windows.Forms.TextBox();
            this.cbBoot = new System.Windows.Forms.CheckBox();
            this.btnBoot = new System.Windows.Forms.Button();
            this.ttMain = new System.Windows.Forms.ToolTip(this.components);
            this.cbAutoCRC = new System.Windows.Forms.CheckBox();
            this.cbOptimize = new System.Windows.Forms.CheckBox();
            this.cbCompareBin = new System.Windows.Forms.CheckBox();
            this.cbIgnoreDiamond = new System.Windows.Forms.CheckBox();
            this.cbShowDuplicates = new System.Windows.Forms.CheckBox();
            this.cbWarningLevel = new System.Windows.Forms.ComboBox();
            this.tbFlags = new System.Windows.Forms.TextBox();
            this.cbTest = new System.Windows.Forms.CheckBox();
            this.cbScanOnly = new System.Windows.Forms.CheckBox();
            this.cbIgnoreMaxSize = new System.Windows.Forms.CheckBox();
            this.cbKeepImage = new System.Windows.Forms.CheckBox();
            this.cbShowAlloc = new System.Windows.Forms.CheckBox();
            this.gbOutput = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gbMisc = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.FBD = new System.Windows.Forms.FolderBrowserDialog();
            this.SFD = new System.Windows.Forms.SaveFileDialog();
            this.tbCommand = new System.Windows.Forms.TextBox();
            this.OFD = new System.Windows.Forms.OpenFileDialog();
            this.gbFile.SuspendLayout();
            this.gbDisc.SuspendLayout();
            this.gbUDF.SuspendLayout();
            this.gbBoot.SuspendLayout();
            this.gbOutput.SuspendLayout();
            this.gbMisc.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBrowseIn
            // 
            this.btnBrowseIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseIn.Location = new System.Drawing.Point(318, 17);
            this.btnBrowseIn.Name = "btnBrowseIn";
            this.btnBrowseIn.Size = new System.Drawing.Size(39, 23);
            this.btnBrowseIn.TabIndex = 1;
            this.btnBrowseIn.Text = "...";
            this.btnBrowseIn.UseVisualStyleBackColor = true;
            this.btnBrowseIn.Click += new System.EventHandler(this.btnBrowseIn_Click);
            // 
            // tbInFolder
            // 
            this.tbInFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbInFolder.Location = new System.Drawing.Point(6, 19);
            this.tbInFolder.Name = "tbInFolder";
            this.tbInFolder.Size = new System.Drawing.Size(306, 20);
            this.tbInFolder.TabIndex = 0;
            this.ttMain.SetToolTip(this.tbInFolder, "The contents of this folder are put in an iso image");
            // 
            // btnBrowseOut
            // 
            this.btnBrowseOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseOut.Location = new System.Drawing.Point(318, 46);
            this.btnBrowseOut.Name = "btnBrowseOut";
            this.btnBrowseOut.Size = new System.Drawing.Size(39, 23);
            this.btnBrowseOut.TabIndex = 3;
            this.btnBrowseOut.Text = "...";
            this.btnBrowseOut.UseVisualStyleBackColor = true;
            this.btnBrowseOut.Click += new System.EventHandler(this.btnBrowseOut_Click);
            // 
            // tbOutfile
            // 
            this.tbOutfile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbOutfile.Location = new System.Drawing.Point(6, 48);
            this.tbOutfile.Name = "tbOutfile";
            this.tbOutfile.Size = new System.Drawing.Size(306, 20);
            this.tbOutfile.TabIndex = 2;
            this.ttMain.SetToolTip(this.tbOutfile, "File name and path of iso image to create");
            // 
            // gbFile
            // 
            this.gbFile.Controls.Add(this.cbIncludeHidden);
            this.gbFile.Controls.Add(this.tbInFolder);
            this.gbFile.Controls.Add(this.tbOutfile);
            this.gbFile.Controls.Add(this.btnBrowseIn);
            this.gbFile.Controls.Add(this.btnBrowseOut);
            this.gbFile.Location = new System.Drawing.Point(12, 12);
            this.gbFile.Name = "gbFile";
            this.gbFile.Size = new System.Drawing.Size(363, 98);
            this.gbFile.TabIndex = 0;
            this.gbFile.TabStop = false;
            this.gbFile.Text = "Source and Destination";
            // 
            // cbIncludeHidden
            // 
            this.cbIncludeHidden.AutoSize = true;
            this.cbIncludeHidden.Location = new System.Drawing.Point(6, 74);
            this.cbIncludeHidden.Name = "cbIncludeHidden";
            this.cbIncludeHidden.Size = new System.Drawing.Size(117, 17);
            this.cbIncludeHidden.TabIndex = 4;
            this.cbIncludeHidden.Text = "Include hidden files";
            this.ttMain.SetToolTip(this.cbIncludeHidden, "Includes hidden files in the image");
            this.cbIncludeHidden.UseVisualStyleBackColor = true;
            // 
            // gbDisc
            // 
            this.gbDisc.Controls.Add(this.tbReadme);
            this.gbDisc.Controls.Add(this.cbDosCompatible);
            this.gbDisc.Controls.Add(this.cbANSI);
            this.gbDisc.Controls.Add(this.cbNoEnforceUppercase);
            this.gbDisc.Controls.Add(this.btnReadme);
            this.gbDisc.Controls.Add(this.label3);
            this.gbDisc.Controls.Add(this.label2);
            this.gbDisc.Controls.Add(this.cbDiscType);
            this.gbDisc.Controls.Add(this.label1);
            this.gbDisc.Controls.Add(this.cbNamelength);
            this.gbDisc.Controls.Add(this.cbUTC);
            this.gbDisc.Controls.Add(this.cbDate);
            this.gbDisc.Controls.Add(this.dtpDate);
            this.gbDisc.Controls.Add(this.cbVolumelabel);
            this.gbDisc.Controls.Add(this.tbVolumelabel);
            this.gbDisc.Location = new System.Drawing.Point(12, 116);
            this.gbDisc.Name = "gbDisc";
            this.gbDisc.Size = new System.Drawing.Size(363, 232);
            this.gbDisc.TabIndex = 1;
            this.gbDisc.TabStop = false;
            this.gbDisc.Text = "Disc Properties";
            // 
            // tbReadme
            // 
            this.tbReadme.Location = new System.Drawing.Point(130, 197);
            this.tbReadme.Name = "tbReadme";
            this.tbReadme.Size = new System.Drawing.Size(180, 20);
            this.tbReadme.TabIndex = 13;
            this.ttMain.SetToolTip(this.tbReadme, resources.GetString("tbReadme.ToolTip"));
            // 
            // cbDosCompatible
            // 
            this.cbDosCompatible.AutoSize = true;
            this.cbDosCompatible.Location = new System.Drawing.Point(6, 174);
            this.cbDosCompatible.Name = "cbDosCompatible";
            this.cbDosCompatible.Size = new System.Drawing.Size(235, 17);
            this.cbDosCompatible.TabIndex = 11;
            this.cbDosCompatible.Text = "Automatically create DOS compatible names";
            this.ttMain.SetToolTip(this.cbDosCompatible, "UDF and Joliet are not DOS compatible.\r\nWith this option enabled, a DOS compatibl" +
                    "e section\r\nof file names is created.\r\nThis will change file names on disc if the" +
                    "y do not match 8.3 conformity.");
            this.cbDosCompatible.UseVisualStyleBackColor = true;
            this.cbDosCompatible.CheckedChanged += new System.EventHandler(this.cbDosCompatible_CheckedChanged);
            // 
            // cbANSI
            // 
            this.cbANSI.AutoSize = true;
            this.cbANSI.Location = new System.Drawing.Point(6, 122);
            this.cbANSI.Name = "cbANSI";
            this.cbANSI.Size = new System.Drawing.Size(331, 17);
            this.cbANSI.TabIndex = 8;
            this.cbANSI.Text = "Use ANSI names instead of OEM Names (breaks names in DOS)";
            this.ttMain.SetToolTip(this.cbANSI, "Uses ANSI instead of OEM.\r\nSpecial chars (äöü, etc.) may look horribly wrong in D" +
                    "OS if enabled.");
            this.cbANSI.UseVisualStyleBackColor = true;
            // 
            // cbNoEnforceUppercase
            // 
            this.cbNoEnforceUppercase.AutoSize = true;
            this.cbNoEnforceUppercase.Enabled = false;
            this.cbNoEnforceUppercase.Location = new System.Drawing.Point(6, 99);
            this.cbNoEnforceUppercase.Name = "cbNoEnforceUppercase";
            this.cbNoEnforceUppercase.Size = new System.Drawing.Size(304, 17);
            this.cbNoEnforceUppercase.TabIndex = 7;
            this.cbNoEnforceUppercase.Text = "Don\'t force uppercase names on ISO-9660 compatible disc";
            this.ttMain.SetToolTip(this.cbNoEnforceUppercase, "ISO-9660 specifies all file names to be uppercase.\r\nDue to ASCII being used, it i" +
                    "s however not a technical\r\nlimitation. Disc could become incompatible with some\r" +
                    "\nsystems if enabled.");
            this.cbNoEnforceUppercase.UseVisualStyleBackColor = true;
            // 
            // btnReadme
            // 
            this.btnReadme.Location = new System.Drawing.Point(318, 195);
            this.btnReadme.Name = "btnReadme";
            this.btnReadme.Size = new System.Drawing.Size(39, 23);
            this.btnReadme.TabIndex = 14;
            this.btnReadme.Text = "...";
            this.ttMain.SetToolTip(this.btnReadme, "Browse for readme.txt");
            this.btnReadme.UseVisualStyleBackColor = true;
            this.btnReadme.Click += new System.EventHandler(this.btnReadme_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Readme for old systems";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Disc type";
            // 
            // cbDiscType
            // 
            this.cbDiscType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDiscType.FormattingEnabled = true;
            this.cbDiscType.Items.AddRange(new object[] {
            "ISO-9660 (all systems, default)",
            "Joliet (almost all systems)",
            "UDF (Windows XP and newer)"});
            this.cbDiscType.Location = new System.Drawing.Point(130, 145);
            this.cbDiscType.Name = "cbDiscType";
            this.cbDiscType.Size = new System.Drawing.Size(227, 21);
            this.cbDiscType.TabIndex = 10;
            this.ttMain.SetToolTip(this.cbDiscType, resources.GetString("cbDiscType.ToolTip"));
            this.cbDiscType.SelectedIndexChanged += new System.EventHandler(this.cbDiscType_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "File name length (ISO)";
            // 
            // cbNamelength
            // 
            this.cbNamelength.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNamelength.Items.AddRange(new object[] {
            "Default (8.3 on ISO, long names on other)",
            "Long names",
            "Long names (NT 3.51 compatible)"});
            this.cbNamelength.Location = new System.Drawing.Point(132, 68);
            this.cbNamelength.Name = "cbNamelength";
            this.cbNamelength.Size = new System.Drawing.Size(225, 21);
            this.cbNamelength.TabIndex = 6;
            this.ttMain.SetToolTip(this.cbNamelength, "Converts file names to match a specific operating system\r\nDo not change this when" +
                    " using UDF Discs");
            // 
            // cbUTC
            // 
            this.cbUTC.AutoSize = true;
            this.cbUTC.Enabled = false;
            this.cbUTC.Location = new System.Drawing.Point(291, 45);
            this.cbUTC.Name = "cbUTC";
            this.cbUTC.Size = new System.Drawing.Size(48, 17);
            this.cbUTC.TabIndex = 4;
            this.cbUTC.Text = "UTC";
            this.ttMain.SetToolTip(this.cbUTC, "Converts the specified time to UTC (GMT) rather than\r\nassuming it is UTC already." +
                    "");
            this.cbUTC.UseVisualStyleBackColor = true;
            // 
            // cbDate
            // 
            this.cbDate.AutoSize = true;
            this.cbDate.Location = new System.Drawing.Point(6, 45);
            this.cbDate.Name = "cbDate";
            this.cbDate.Size = new System.Drawing.Size(120, 17);
            this.cbDate.TabIndex = 2;
            this.cbDate.Text = "Set Custom file date";
            this.ttMain.SetToolTip(this.cbDate, "Sets the creation time of all files/folders to the specified date/time");
            this.cbDate.UseVisualStyleBackColor = true;
            this.cbDate.CheckedChanged += new System.EventHandler(this.cbDate_CheckedChanged);
            // 
            // dtpDate
            // 
            this.dtpDate.CustomFormat = "dd.MM.yyyy HH.mm.ss";
            this.dtpDate.Enabled = false;
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate.Location = new System.Drawing.Point(132, 42);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(153, 20);
            this.dtpDate.TabIndex = 3;
            this.dtpDate.ValueChanged += new System.EventHandler(this.checkChange);
            // 
            // cbVolumelabel
            // 
            this.cbVolumelabel.AutoSize = true;
            this.cbVolumelabel.Location = new System.Drawing.Point(6, 19);
            this.cbVolumelabel.Name = "cbVolumelabel";
            this.cbVolumelabel.Size = new System.Drawing.Size(108, 17);
            this.cbVolumelabel.TabIndex = 0;
            this.cbVolumelabel.Text = "Set volume Label";
            this.ttMain.SetToolTip(this.cbVolumelabel, "If disabled, the volume label is empty");
            this.cbVolumelabel.UseVisualStyleBackColor = true;
            this.cbVolumelabel.CheckedChanged += new System.EventHandler(this.cbVolumelabel_CheckedChanged);
            // 
            // tbVolumelabel
            // 
            this.tbVolumelabel.Enabled = false;
            this.tbVolumelabel.Location = new System.Drawing.Point(132, 16);
            this.tbVolumelabel.MaxLength = 64;
            this.tbVolumelabel.Name = "tbVolumelabel";
            this.tbVolumelabel.Size = new System.Drawing.Size(225, 20);
            this.tbVolumelabel.TabIndex = 1;
            this.ttMain.SetToolTip(this.tbVolumelabel, "Enter the volume label.\r\nShould be 11 chars or less");
            this.tbVolumelabel.TextChanged += new System.EventHandler(this.tbVolumelabel_TextChanged);
            // 
            // gbUDF
            // 
            this.gbUDF.Controls.Add(this.cbUDFVideo);
            this.gbUDF.Controls.Add(this.cbUDFFID);
            this.gbUDF.Controls.Add(this.cbUDFextent);
            this.gbUDF.Controls.Add(this.cbUDFSparse);
            this.gbUDF.Location = new System.Drawing.Point(387, 12);
            this.gbUDF.Name = "gbUDF";
            this.gbUDF.Size = new System.Drawing.Size(369, 116);
            this.gbUDF.TabIndex = 4;
            this.gbUDF.TabStop = false;
            this.gbUDF.Text = "UDF Options";
            // 
            // cbUDFVideo
            // 
            this.cbUDFVideo.AutoSize = true;
            this.cbUDFVideo.Enabled = false;
            this.cbUDFVideo.Location = new System.Drawing.Point(6, 93);
            this.cbUDFVideo.Name = "cbUDFVideo";
            this.cbUDFVideo.Size = new System.Drawing.Size(200, 17);
            this.cbUDFVideo.TabIndex = 3;
            this.cbUDFVideo.Text = "Enforce UDF Video Zone cmpatibility";
            this.ttMain.SetToolTip(this.cbUDFVideo, "You can check this if you create a video/audio DVD to\r\nenforce some compatibility" +
                    " settings.");
            this.cbUDFVideo.UseVisualStyleBackColor = true;
            // 
            // cbUDFFID
            // 
            this.cbUDFFID.AutoSize = true;
            this.cbUDFFID.Enabled = false;
            this.cbUDFFID.Location = new System.Drawing.Point(6, 70);
            this.cbUDFFID.Name = "cbUDFFID";
            this.cbUDFFID.Size = new System.Drawing.Size(137, 17);
            this.cbUDFFID.TabIndex = 2;
            this.cbUDFFID.Text = "embed UDF FID entries";
            this.ttMain.SetToolTip(this.cbUDFFID, "Just leave this unchecked, will you?");
            this.cbUDFFID.UseVisualStyleBackColor = true;
            // 
            // cbUDFextent
            // 
            this.cbUDFextent.AutoSize = true;
            this.cbUDFextent.Enabled = false;
            this.cbUDFextent.Location = new System.Drawing.Point(6, 45);
            this.cbUDFextent.Name = "cbUDFextent";
            this.cbUDFextent.Size = new System.Drawing.Size(168, 17);
            this.cbUDFextent.TabIndex = 1;
            this.cbUDFextent.Text = "Embed file data in extent entry";
            this.ttMain.SetToolTip(this.cbUDFextent, "Embed additional file attributes in the extent entry.\r\nUsually not required. May " +
                    "increase disk size.");
            this.cbUDFextent.UseVisualStyleBackColor = true;
            // 
            // cbUDFSparse
            // 
            this.cbUDFSparse.AutoSize = true;
            this.cbUDFSparse.Enabled = false;
            this.cbUDFSparse.Location = new System.Drawing.Point(6, 19);
            this.cbUDFSparse.Name = "cbUDFSparse";
            this.cbUDFSparse.Size = new System.Drawing.Size(105, 17);
            this.cbUDFSparse.TabIndex = 0;
            this.cbUDFSparse.Text = "Sparse UDF files";
            this.ttMain.SetToolTip(this.cbUDFSparse, "Changes the layout how files are placed on disc.\r\nUsually not needed but may shri" +
                    "nk space requirements.\r\n\r\nWARNING: Incompatible with Windows 9x");
            this.cbUDFSparse.UseVisualStyleBackColor = true;
            // 
            // gbBoot
            // 
            this.gbBoot.Controls.Add(this.tbPlatform);
            this.gbBoot.Controls.Add(this.cbNoFloppy);
            this.gbBoot.Controls.Add(this.cbPlatform);
            this.gbBoot.Controls.Add(this.tbBoot);
            this.gbBoot.Controls.Add(this.cbBoot);
            this.gbBoot.Controls.Add(this.btnBoot);
            this.gbBoot.Location = new System.Drawing.Point(387, 135);
            this.gbBoot.Name = "gbBoot";
            this.gbBoot.Size = new System.Drawing.Size(369, 110);
            this.gbBoot.TabIndex = 5;
            this.gbBoot.TabStop = false;
            this.gbBoot.Text = "Boot options (El Torito)";
            // 
            // tbPlatform
            // 
            this.tbPlatform.Enabled = false;
            this.tbPlatform.Location = new System.Drawing.Point(136, 49);
            this.tbPlatform.Name = "tbPlatform";
            this.tbPlatform.Size = new System.Drawing.Size(180, 20);
            this.tbPlatform.TabIndex = 4;
            this.ttMain.SetToolTip(this.tbPlatform, "Enter the platform ID");
            // 
            // cbNoFloppy
            // 
            this.cbNoFloppy.AutoSize = true;
            this.cbNoFloppy.Enabled = false;
            this.cbNoFloppy.Location = new System.Drawing.Point(6, 77);
            this.cbNoFloppy.Name = "cbNoFloppy";
            this.cbNoFloppy.Size = new System.Drawing.Size(176, 17);
            this.cbNoFloppy.TabIndex = 5;
            this.cbNoFloppy.Text = "Do not enforce floppy emulation";
            this.ttMain.SetToolTip(this.cbNoFloppy, "Does not sets the floppy emulation bit.\r\nEnable this, if the boot image is a hard" +
                    " drive image instead of a floppy image.\r\nSometimes called \"no emulation\" mode.");
            this.cbNoFloppy.UseVisualStyleBackColor = true;
            // 
            // cbPlatform
            // 
            this.cbPlatform.AutoSize = true;
            this.cbPlatform.Enabled = false;
            this.cbPlatform.Location = new System.Drawing.Point(6, 51);
            this.cbPlatform.Name = "cbPlatform";
            this.cbPlatform.Size = new System.Drawing.Size(115, 17);
            this.cbPlatform.TabIndex = 3;
            this.cbPlatform.Text = "Specify platform ID";
            this.ttMain.SetToolTip(this.cbPlatform, "allows a special platform ID to be specified for some\r\nmore \'exclusive\' boot sect" +
                    "ors.");
            this.cbPlatform.UseVisualStyleBackColor = true;
            // 
            // tbBoot
            // 
            this.tbBoot.Enabled = false;
            this.tbBoot.Location = new System.Drawing.Point(136, 23);
            this.tbBoot.Name = "tbBoot";
            this.tbBoot.Size = new System.Drawing.Size(180, 20);
            this.tbBoot.TabIndex = 1;
            this.ttMain.SetToolTip(this.tbBoot, "Specify the path of the 1.4 MB floppy image");
            // 
            // cbBoot
            // 
            this.cbBoot.AutoSize = true;
            this.cbBoot.Location = new System.Drawing.Point(6, 25);
            this.cbBoot.Name = "cbBoot";
            this.cbBoot.Size = new System.Drawing.Size(124, 17);
            this.cbBoot.TabIndex = 0;
            this.cbBoot.Text = "Bootable image. File:";
            this.ttMain.SetToolTip(this.cbBoot, "Adds a bootable (floppy) image to the boot sector of the disc.");
            this.cbBoot.UseVisualStyleBackColor = true;
            this.cbBoot.CheckedChanged += new System.EventHandler(this.cbBoot_CheckedChanged);
            // 
            // btnBoot
            // 
            this.btnBoot.Enabled = false;
            this.btnBoot.Location = new System.Drawing.Point(322, 21);
            this.btnBoot.Name = "btnBoot";
            this.btnBoot.Size = new System.Drawing.Size(39, 23);
            this.btnBoot.TabIndex = 2;
            this.btnBoot.Text = "...";
            this.btnBoot.UseVisualStyleBackColor = true;
            this.btnBoot.Click += new System.EventHandler(this.btnBoot_Click);
            // 
            // ttMain
            // 
            this.ttMain.AutoPopDelay = 32676;
            this.ttMain.InitialDelay = 1;
            this.ttMain.ReshowDelay = 100;
            this.ttMain.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ttMain.ToolTipTitle = "Quick Help";
            this.ttMain.UseAnimation = false;
            this.ttMain.UseFading = false;
            // 
            // cbAutoCRC
            // 
            this.cbAutoCRC.AutoSize = true;
            this.cbAutoCRC.Location = new System.Drawing.Point(6, 94);
            this.cbAutoCRC.Name = "cbAutoCRC";
            this.cbAutoCRC.Size = new System.Drawing.Size(215, 17);
            this.cbAutoCRC.TabIndex = 0;
            this.cbAutoCRC.Text = "Compute and include AutoCRC in image";
            this.ttMain.SetToolTip(this.cbAutoCRC, "Adds a few bytes to the iso in a way, that the CRC will be 0xFFFFFFFF\r\n\r\nMost old" +
                    "er Microsoft iso images had this too.");
            this.cbAutoCRC.UseVisualStyleBackColor = true;
            // 
            // cbOptimize
            // 
            this.cbOptimize.AutoSize = true;
            this.cbOptimize.Location = new System.Drawing.Point(6, 119);
            this.cbOptimize.Name = "cbOptimize";
            this.cbOptimize.Size = new System.Drawing.Size(104, 17);
            this.cbOptimize.TabIndex = 1;
            this.cbOptimize.Text = "Optimize storage";
            this.ttMain.SetToolTip(this.cbOptimize, "Encodes identical files only once in the image.\r\n\r\nAttention:\r\nBurning this iso i" +
                    "mage still burns identical files each time they occur to the disc.");
            this.cbOptimize.UseVisualStyleBackColor = true;
            this.cbOptimize.CheckedChanged += new System.EventHandler(this.cbOptimize_CheckedChanged);
            // 
            // cbCompareBin
            // 
            this.cbCompareBin.AutoSize = true;
            this.cbCompareBin.Enabled = false;
            this.cbCompareBin.Location = new System.Drawing.Point(6, 165);
            this.cbCompareBin.Name = "cbCompareBin";
            this.cbCompareBin.Size = new System.Drawing.Size(174, 17);
            this.cbCompareBin.TabIndex = 2;
            this.cbCompareBin.Text = "Compare binary instead of MD5";
            this.ttMain.SetToolTip(this.cbCompareBin, "Enable this if you burn files, which are different, but have the same MD5 hash.\r\n" +
                    "\r\nYes, such files exist.");
            this.cbCompareBin.UseVisualStyleBackColor = true;
            // 
            // cbIgnoreDiamond
            // 
            this.cbIgnoreDiamond.AutoSize = true;
            this.cbIgnoreDiamond.Enabled = false;
            this.cbIgnoreDiamond.Location = new System.Drawing.Point(6, 142);
            this.cbIgnoreDiamond.Name = "cbIgnoreDiamond";
            this.cbIgnoreDiamond.Size = new System.Drawing.Size(216, 17);
            this.cbIgnoreDiamond.TabIndex = 3;
            this.cbIgnoreDiamond.Text = "Ignore diamond compression timestamps";
            this.ttMain.SetToolTip(this.cbIgnoreDiamond, "This option disregards time difference in CAB files, if the packed files are iden" +
                    "tical.");
            this.cbIgnoreDiamond.UseVisualStyleBackColor = true;
            // 
            // cbShowDuplicates
            // 
            this.cbShowDuplicates.AutoSize = true;
            this.cbShowDuplicates.Enabled = false;
            this.cbShowDuplicates.Location = new System.Drawing.Point(9, 19);
            this.cbShowDuplicates.Name = "cbShowDuplicates";
            this.cbShowDuplicates.Size = new System.Drawing.Size(221, 17);
            this.cbShowDuplicates.TabIndex = 0;
            this.cbShowDuplicates.Text = "Show duplicate files when creating image";
            this.ttMain.SetToolTip(this.cbShowDuplicates, "Shows all files, which are duplicates in the console");
            this.cbShowDuplicates.UseVisualStyleBackColor = true;
            // 
            // cbWarningLevel
            // 
            this.cbWarningLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbWarningLevel.FormattingEnabled = true;
            this.cbWarningLevel.Items.AddRange(new object[] {
            "0 (off)",
            "1 (report non-ISO or non-Joliet names)",
            "2 (report non-DOS compliant names)",
            "3 (report zero length files)",
            "4 (report all files)"});
            this.cbWarningLevel.Location = new System.Drawing.Point(130, 42);
            this.cbWarningLevel.Name = "cbWarningLevel";
            this.cbWarningLevel.Size = new System.Drawing.Size(227, 21);
            this.cbWarningLevel.TabIndex = 2;
            this.ttMain.SetToolTip(this.cbWarningLevel, "Various warning levels to ensure disc compatibility");
            // 
            // tbFlags
            // 
            this.tbFlags.Enabled = false;
            this.tbFlags.Location = new System.Drawing.Point(130, 69);
            this.tbFlags.Name = "tbFlags";
            this.tbFlags.Size = new System.Drawing.Size(227, 20);
            this.tbFlags.TabIndex = 4;
            this.ttMain.SetToolTip(this.tbFlags, resources.GetString("tbFlags.ToolTip"));
            // 
            // cbTest
            // 
            this.cbTest.AutoSize = true;
            this.cbTest.Location = new System.Drawing.Point(6, 72);
            this.cbTest.Name = "cbTest";
            this.cbTest.Size = new System.Drawing.Size(108, 17);
            this.cbTest.TabIndex = 3;
            this.cbTest.Text = "Enable Test flags";
            this.ttMain.SetToolTip(this.cbTest, "Allows some options for non-standard discs to be specified");
            this.cbTest.UseVisualStyleBackColor = true;
            this.cbTest.CheckedChanged += new System.EventHandler(this.cbTest_CheckedChanged);
            // 
            // cbScanOnly
            // 
            this.cbScanOnly.AutoSize = true;
            this.cbScanOnly.Location = new System.Drawing.Point(6, 71);
            this.cbScanOnly.Name = "cbScanOnly";
            this.cbScanOnly.Size = new System.Drawing.Size(94, 17);
            this.cbScanOnly.TabIndex = 2;
            this.cbScanOnly.Text = "Scan files only";
            this.ttMain.SetToolTip(this.cbScanOnly, "Disables iso file creation but still prints everything to console.\r\nThis makes te" +
                    "sting for configuration errors much faster.");
            this.cbScanOnly.UseVisualStyleBackColor = true;
            // 
            // cbIgnoreMaxSize
            // 
            this.cbIgnoreMaxSize.AutoSize = true;
            this.cbIgnoreMaxSize.Location = new System.Drawing.Point(6, 44);
            this.cbIgnoreMaxSize.Name = "cbIgnoreMaxSize";
            this.cbIgnoreMaxSize.Size = new System.Drawing.Size(247, 17);
            this.cbIgnoreMaxSize.TabIndex = 1;
            this.cbIgnoreMaxSize.Text = "Ignore Maximum disc size of 700 MB (CD-Rom)";
            this.ttMain.SetToolTip(this.cbIgnoreMaxSize, resources.GetString("cbIgnoreMaxSize.ToolTip"));
            this.cbIgnoreMaxSize.UseVisualStyleBackColor = true;
            // 
            // cbKeepImage
            // 
            this.cbKeepImage.AutoSize = true;
            this.cbKeepImage.Location = new System.Drawing.Point(6, 19);
            this.cbKeepImage.Name = "cbKeepImage";
            this.cbKeepImage.Size = new System.Drawing.Size(174, 17);
            this.cbKeepImage.TabIndex = 0;
            this.cbKeepImage.Text = "Keep image regardless of errors";
            this.ttMain.SetToolTip(this.cbKeepImage, "This will not delete the image if something fails");
            this.cbKeepImage.UseVisualStyleBackColor = true;
            // 
            // cbShowAlloc
            // 
            this.cbShowAlloc.AutoSize = true;
            this.cbShowAlloc.Location = new System.Drawing.Point(6, 95);
            this.cbShowAlloc.Name = "cbShowAlloc";
            this.cbShowAlloc.Size = new System.Drawing.Size(262, 17);
            this.cbShowAlloc.TabIndex = 5;
            this.cbShowAlloc.Text = "Show file and directory sizes in allocation summary";
            this.ttMain.SetToolTip(this.cbShowAlloc, "Shows summary of file scan");
            this.cbShowAlloc.UseVisualStyleBackColor = true;
            // 
            // gbOutput
            // 
            this.gbOutput.Controls.Add(this.cbShowAlloc);
            this.gbOutput.Controls.Add(this.tbFlags);
            this.gbOutput.Controls.Add(this.cbShowDuplicates);
            this.gbOutput.Controls.Add(this.cbWarningLevel);
            this.gbOutput.Controls.Add(this.label4);
            this.gbOutput.Controls.Add(this.cbTest);
            this.gbOutput.Location = new System.Drawing.Point(12, 354);
            this.gbOutput.Name = "gbOutput";
            this.gbOutput.Size = new System.Drawing.Size(363, 120);
            this.gbOutput.TabIndex = 2;
            this.gbOutput.TabStop = false;
            this.gbOutput.Text = "Output and debug Options";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Warning level";
            // 
            // gbMisc
            // 
            this.gbMisc.Controls.Add(this.cbCompareBin);
            this.gbMisc.Controls.Add(this.cbScanOnly);
            this.gbMisc.Controls.Add(this.cbIgnoreDiamond);
            this.gbMisc.Controls.Add(this.cbIgnoreMaxSize);
            this.gbMisc.Controls.Add(this.cbOptimize);
            this.gbMisc.Controls.Add(this.cbKeepImage);
            this.gbMisc.Controls.Add(this.cbAutoCRC);
            this.gbMisc.Location = new System.Drawing.Point(381, 253);
            this.gbMisc.Name = "gbMisc";
            this.gbMisc.Size = new System.Drawing.Size(375, 221);
            this.gbMisc.TabIndex = 6;
            this.gbMisc.TabStop = false;
            this.gbMisc.Text = "Misc";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(681, 480);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(600, 480);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 7;
            this.btnStart.Text = "&Create ISO";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // FBD
            // 
            this.FBD.Description = "Select source directory";
            this.FBD.ShowNewFolderButton = false;
            // 
            // SFD
            // 
            this.SFD.DefaultExt = "iso";
            this.SFD.Filter = "ISO Files|*.iso|All Files|*.*";
            this.SFD.Title = "Create ISO File";
            // 
            // tbCommand
            // 
            this.tbCommand.Location = new System.Drawing.Point(12, 509);
            this.tbCommand.Name = "tbCommand";
            this.tbCommand.ReadOnly = true;
            this.tbCommand.Size = new System.Drawing.Size(744, 20);
            this.tbCommand.TabIndex = 8;
            // 
            // OFD
            // 
            this.OFD.Title = "Select File";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 541);
            this.Controls.Add(this.tbCommand);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.gbMisc);
            this.Controls.Add(this.gbBoot);
            this.Controls.Add(this.gbUDF);
            this.Controls.Add(this.gbDisc);
            this.Controls.Add(this.gbOutput);
            this.Controls.Add(this.gbFile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "CD Image GUI";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.gbFile.ResumeLayout(false);
            this.gbFile.PerformLayout();
            this.gbDisc.ResumeLayout(false);
            this.gbDisc.PerformLayout();
            this.gbUDF.ResumeLayout(false);
            this.gbUDF.PerformLayout();
            this.gbBoot.ResumeLayout(false);
            this.gbBoot.PerformLayout();
            this.gbOutput.ResumeLayout(false);
            this.gbOutput.PerformLayout();
            this.gbMisc.ResumeLayout(false);
            this.gbMisc.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBrowseIn;
        private System.Windows.Forms.TextBox tbInFolder;
        private System.Windows.Forms.Button btnBrowseOut;
        private System.Windows.Forms.TextBox tbOutfile;
        private System.Windows.Forms.GroupBox gbFile;
        private System.Windows.Forms.GroupBox gbDisc;
        private System.Windows.Forms.CheckBox cbVolumelabel;
        private System.Windows.Forms.TextBox tbVolumelabel;
        private System.Windows.Forms.CheckBox cbDate;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.CheckBox cbUTC;
        private System.Windows.Forms.CheckBox cbIncludeHidden;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbNamelength;
        private System.Windows.Forms.CheckBox cbANSI;
        private System.Windows.Forms.CheckBox cbNoEnforceUppercase;
        private System.Windows.Forms.CheckBox cbDosCompatible;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbDiscType;
        private System.Windows.Forms.TextBox tbReadme;
        private System.Windows.Forms.Button btnReadme;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbUDF;
        private System.Windows.Forms.CheckBox cbUDFVideo;
        private System.Windows.Forms.CheckBox cbUDFFID;
        private System.Windows.Forms.CheckBox cbUDFextent;
        private System.Windows.Forms.CheckBox cbUDFSparse;
        private System.Windows.Forms.GroupBox gbBoot;
        private System.Windows.Forms.TextBox tbBoot;
        private System.Windows.Forms.Button btnBoot;
        private System.Windows.Forms.CheckBox cbBoot;
        private System.Windows.Forms.TextBox tbPlatform;
        private System.Windows.Forms.CheckBox cbPlatform;
        private System.Windows.Forms.ToolTip ttMain;
        private System.Windows.Forms.CheckBox cbNoFloppy;
        private System.Windows.Forms.CheckBox cbOptimize;
        private System.Windows.Forms.CheckBox cbAutoCRC;
        private System.Windows.Forms.CheckBox cbCompareBin;
        private System.Windows.Forms.CheckBox cbIgnoreDiamond;
        private System.Windows.Forms.GroupBox gbOutput;
        private System.Windows.Forms.CheckBox cbShowDuplicates;
        private System.Windows.Forms.ComboBox cbWarningLevel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbFlags;
        private System.Windows.Forms.CheckBox cbTest;
        private System.Windows.Forms.CheckBox cbShowAlloc;
        private System.Windows.Forms.GroupBox gbMisc;
        private System.Windows.Forms.CheckBox cbScanOnly;
        private System.Windows.Forms.CheckBox cbIgnoreMaxSize;
        private System.Windows.Forms.CheckBox cbKeepImage;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.FolderBrowserDialog FBD;
        private System.Windows.Forms.SaveFileDialog SFD;
        private System.Windows.Forms.TextBox tbCommand;
        private System.Windows.Forms.OpenFileDialog OFD;
    }
}

