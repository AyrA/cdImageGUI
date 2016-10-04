# cdImageGUI
Front-End for the Microsoft cdimage.exe utility

# Features

- Easy to use, single window UI
- Shows command line arguments that will be used for the user to copy
- Hides the console window of `cdimage.exe`
- Shows proper percentage and progress output
- Enables and disables form elements to prevent invalid option combinations

# cdimage.exe

This tool is provided here for your convenience. You cannot obtain this officially.
If this troubles you see the entry about `oscdimg.exe`,
which you could consider the successor of `cdimage.exe`.

## hidden text

Please be aware, that it inserts this hidden texts into the ISO images it creates:

	Microsoft Corporation, One Microsoft Way, Redmond WA 98052
	CDIMAGE 2.47 (10/12/2000 TM)

The text can appear multiple times and is not visible unless you view the raw iso data.
it appears close to a seperate line that just reads `Microsoft Corporation`.
In the ISO-9660 section, both lines are all uppercase.

The number of times the text appears depends on the format of the disc you chose to create.

# oscdimg.exe

This is the successor of `cdimage.exe` and can be officially obtained in the [Windows Automated Installation Kit (WAIK) for Windows 7](https://www.microsoft.com/en-us/download/details.aspx?id=5753).
**This tool has not been tested with this application and might not work properly**.
Most Arguments however are the same ([see here](https://msdn.microsoft.com/en-us/windows/hardware/commercialize/manufacture/desktop/oscdimg-command-line-options)).
