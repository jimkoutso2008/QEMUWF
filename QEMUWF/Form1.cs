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

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 j = new Form3();
            j.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About j = new About();
            j.Show();
        }
    }
}
