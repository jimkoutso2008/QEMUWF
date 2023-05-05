using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;
namespace QEMUWF
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
            string s = Properties.Settings.Default.qemuPath;
            if (string.IsNullOrEmpty(s) || !Directory.Exists(s) || (Directory.Exists(s) && !File.Exists(Path.Combine(s, "qemu-system-i386.exe"))))
            {
                FolderPicker dialog = new FolderPicker();
                dialog.Title = "Select the folder where Qemu is installed.";
                if (dialog.ShowDialog(IntPtr.Zero) == true)
                {
                    Properties.Settings.Default.qemuPath = dialog.ResultPath;
                    Properties.Settings.Default.Save();
                }
            }
            Application.Run(new Form1());
        }
    }
}
