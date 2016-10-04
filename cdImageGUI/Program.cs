﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace cdImageGUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());
        }
    }
}
/*
-l  volume label, no spaces (e.g. -lMYLABEL)
-t  time stamp for all files and directories, no spaces, any delimiter
      (e.g. -t12/31/2000,15:01:00)
-g  encode GMT time for files rather than local time
-h  include hidden files and directories
-n  allow long filenames (longer than DOS 8.3 names)
-nt allow long filenames, restricted to NT 3.51 compatibility
      (-nt and -d cannot be used together)
-d  don't force lowercase filenames to uppercase
-c  use ANSI filenames versus OEM filenames from source
-j1 encode Joliet Unicode filenames AND generate DOS-compatible 8.3
      filenames in the ISO-9660 name space (can be read by either
      Joliet systems or conventional ISO-9660 systems, but some of the
      filenames in the ISO-9660 name space might be changed to comply
      with DOS 8.3 and/or ISO-9660 naming restrictions)
-j2 encode Joliet Unicode filenames without standard ISO-9660 names
      (requires a Joliet operating system to read files from the CD)
    When using the -j1 or -j2 options, the -n, -nt, and -d options
      do not apply and cannot be used.
-js non-Joliet "readme.txt" file for images encoded with -j2 option
      (e.g. -jsc:\location\readme.txt). This file will be visible as
      the only file in the root directory of the disc on systems that
      do not support the Joliet format (Windows 3.1, NT 3.x, etc).
-u1 encode "UDF-Bridge" media
-u2 encode "UDF" file system without a mirror ISO-9660 file system
      (requires a UDF capable operating system to read the files)
-ur non-UDF "readme.txt" file for images encoded with -u2 option
      (e.g. -usc:\location\readme.txt). This file will be visible as
      the only file in the root directory of the disc on systems that
      do not support the UDF format.
-us sparse UDF files
-ue embed file data in UDF extent entry
-uf embed UDF FID entries
-uv UDF Video Zone compatibility enforced
-b  "El Torito" boot sector file, no spaces
      (e.g. -bc:\location\cdboot.bin)
-p  Platform ID for the "El Torito" boot catalog
-e  Do not set floppy emulation mode in El Torito boot catalog
-s  sign image file with digital signature (no spaces, provide RPC
      server and endpoint name like -sServerName:EndPointName)
-x  compute and encode "AutoCRC" values in image
-o  optimize storage by encoding duplicate files only once
-oc slower duplicate file detection using binary comparisons rather
      than MD5 hash values
-oi ignore diamond compression timestamps when comparing files
-os show duplicate files while creating image
    (-o options can be combined like -ocis)
-w  warning level followed by number (e.g. -w4)
    1  report non-ISO or non-Joliet compliant filenames or depth
    2  report non-DOS compliant filenames
    3  report zero-length files
    4  report each file name copied to image
-y  test option followed by number (e.g. -y1), used to generate
      non-standard variations of ISO-9660 for testing purposes:
    1 encode trailing version number ';1' on filenames (7.5.1)
    2 round directory sizes to multiples of 2K (6.8.1.3)
    5 write \i386 directory files first, in reverse sort order
    6 allow directory records to be exactly aligned at ends of sectors
        (ISO-9660 6.8.1.1 conformant but breaks MSCDEX)
    7 warn about generated shortnames for 16-bit apps under NT 4.0
    b blocksize 512 bytes rather than 2048 bytes
    d suppress warning for non-identical files with same initial 64K
    l UDF - long ads used in file entries instead of short ads
    r UDF - number of ad's is random
    w open source files with write sharing
    t load segment in hex for El Torito boot image (e.g. -yt7C0)
    f use a faster way to generate short names
-k  (keep) create image even if fail to open some of the source files
-m  ignore maximum image size of 681,984,000 bytes
-a  allocation summary shows file and directory sizes
-q  scan source files only, don't create an image file
 */