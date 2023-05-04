using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
	}
}
