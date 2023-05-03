using System;
using System.Windows.Forms;

namespace QEMUWF
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            Core.SetStaticControls(trackBar1, trackBar2, comboBox1, comboBox2, tabControl1, numericUpDown1);
        }

        private void Form3_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Core.Navigate(1, tabControl1);
        }

        private void bacc_Click(object sender, EventArgs e)
        {
            Core.Navigate(0, tabControl1);
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Core.SetDynamicControls(true, false, false, comboBox2, comboBox3, radioButton1, radioButton2, radioButton3, trackBar1, trackBar2, label10, label16);
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            Core.SetDynamicControls(false, true, false, comboBox2, comboBox3, radioButton1, radioButton2, radioButton3, trackBar1, trackBar2, label10, label16);
        }

        private void cretNew_CheckedChanged(object sender, EventArgs e)
        {
            Core.SetDynamicControls2(true, cretNew, choosExistig, label12, label14, numericUpDown2, textBox3, textBox2, button1, checkBox1);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Multiselect = false;
            fileDialog.Filter =
                "QEMU Copy On Write 2 (*.qcow2)|*.qcow2|QEMU Copy On Write (*.qcow)|*.qcow|Microsoft Virtual Hard Disk (*.vhd)|*.vhd|Microsoft Virtual Hard Disk Extended (*.vhdx)|*.vhdx|Raw disk (*.raw)|*.raw|Raw disk (*.img)|*.img|All files (*.*)|*.*";
            fileDialog.ShowDialog();
            textBox2.Text = fileDialog.FileName;
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            Core.SetDynamicControls(false, false, true, comboBox2, comboBox3, radioButton1, radioButton2, radioButton3, trackBar1, trackBar2, label10, label16);
        }
    }
}