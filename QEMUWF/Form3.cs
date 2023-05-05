using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QEMUWF
{
	public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
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
            // fix j logic
            Core.SetDynamicControls(true, false, false, comboBox2, comboBox3, radioButton1, radioButton2, radioButton3, trackBar1, trackBar2, label10, label16);
            comboBox3.Items.Clear();
            comboBox5.Items.Clear();
            string cpu = comboBox2.GetItemText(comboBox2.SelectedItem);
            radioButton2.Enabled = radioButton3.Enabled = false;
            List<string> cpus = new List<string>();
            Task.Factory.StartNew(() => Core.QemuInvoke(cpu, ref cpus, "Available CPUs:", "-cpu ?")).Wait();
            for (int i = 0; i < cpus.Count; i++)
			{
                comboBox3.Items.Add(cpus[i]);
			}
            try
            {
                comboBox3.SelectedIndex = 0;
            }
            catch 
            {
                comboBox3.Items.Add("default");
                comboBox3.SelectedIndex = 0;
            }
            List<string> machine = new List<string>();
            Task.Factory.StartNew(() => Core.QemuInvoke(cpu, ref machine, "Supported machines are:", "-machine help")).Wait();
            for (int i = 0; i< machine.Count; i++)
			{
                comboBox5.Items.Add(machine[i]);
			}
            comboBox5.SelectedIndex = 0;
            List<string> accel = new List<string>();
            Task.Factory.StartNew(() => Core.QemuInvoke(cpu, ref accel, "Accelerators supported in QEMU binary:", "-accel ?")).Wait();
            for (int i = 0; i < accel.Count; i++)
            {
                if (accel[i] == "hax")
				{
                    radioButton2.Enabled = true;
				}
                else if (accel[i] == "whpx")
				{
                    radioButton3.Enabled = true;
				}
            }
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

		private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
		{
            comboBox4.Items.Clear();
            string cpu = comboBox2.GetItemText(comboBox2.SelectedItem);
            string machine = comboBox5.GetItemText(comboBox5.SelectedItem);
            List<string> gpu = new List<string>();
            Core.QemuInvoke(cpu, ref gpu, "n000", "-vga help -machine " + machine);
            for (int i = 0; i < gpu.Count; i++)
            {
                comboBox4.Items.Add(gpu[i]);
            }
            try
            {
                comboBox4.SelectedIndex = 0;
            }
            catch { }
        }

		private void Form3_Shown(object sender, EventArgs e)
		{
            Core.SetStaticControls(trackBar1, trackBar2, comboBox1, comboBox2, comboBox4, tabControl1, numericUpDown1);
		}
	}
}