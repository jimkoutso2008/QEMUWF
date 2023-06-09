﻿using System;
using System.IO;
using System.Windows.Forms;

namespace QEMUWF
{
	public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 j = new Form3();
            j.ShowDialog();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About j = new About();
            j.ShowDialog();
        }

		private void toolBar1_ButtonClick(object sender, ToolBarButtonClickEventArgs e)
		{
            if (e.Button.Name == "newButton")
			{
                Form3 j = new Form3();
                j.ShowDialog();
            }
		}

		private void qemuPath_Click(object sender, EventArgs e)
		{
            bool found = false;
            while (!found)
            {
                FolderPicker dialog = new FolderPicker
                {
                    Title = "Select the folder where QEMU is installed"
                };
                if (dialog.ShowDialog(IntPtr.Zero) == true)
                {
                    if (File.Exists(Path.Combine(dialog.ResultPath, "qemu-system-i386.exe")))
                    {
                        Properties.Settings.Default.qemuPath = dialog.ResultPath;
                        Properties.Settings.Default.Save();
                        break;
                    }
                    else
                    {
                        MessageBox.Show("QEMU not found");
                    }
                }
				else
				{
                    break;
				}
            }
        }

		private void exitMenu_Click(object sender, EventArgs e)
		{
            Application.Exit();
		}
	}
}
