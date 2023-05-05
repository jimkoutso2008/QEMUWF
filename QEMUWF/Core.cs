using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Management;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace QEMUWF
{
    internal class Core
    {
        public static string qemuPath = (string)Properties.Settings.Default.qemuPath;
        public static DirectoryInfo dinfo = new DirectoryInfo(qemuPath);
        public static ComputerInfo info = new ComputerInfo();
        public static void SetStaticControls(TrackBar trackBar, TrackBar trackBar1, ComboBox comboBox1, ComboBox comboBox2, ComboBox comboBox4, TabControl tabControl, NumericUpDown numericUpDown)
        {
            var f = dinfo.GetFiles("qemu-system-*.exe");
            ulong h = info.TotalPhysicalMemory / (1024 * 1024);
            ulong v = h;
            for (int i=0; i<f.Length; i++)
            {
                string name = f[i].Name.Replace(".exe", "").Replace("qemu-system-", "");
                if (name[name.Length - 1] != 'w')
                {
                    comboBox2.Items.Add(f[i].Name.Replace(".exe", "").Replace("qemu-system-", ""));
                }
            }

            foreach (ManagementObject mo in new ManagementObjectSearcher("select AdapterRAM from Win32_VideoController").Get())
            {
                var vram = mo.Properties["AdapterRAM"].Value as ulong?;
                if (vram.HasValue)
                {
                    v = (ulong)(vram / 1024 * 1024);
                }
            }
            trackBar.Minimum = 2;
            trackBar.Maximum = (int)h;
            trackBar.TickFrequency = 128;
            trackBar.SmallChange = trackBar.Maximum / trackBar.TickFrequency;
            trackBar1.Maximum = Math.Abs((int)v);
            trackBar1.TickFrequency = 128;
            trackBar1.SmallChange = trackBar1.Maximum / trackBar1.TickFrequency;
            trackBar1.Minimum = 2;
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            tabControl.Location = new Point(0, -25);
            tabControl.Size = new Size(438, 480);
            numericUpDown.Maximum = Environment.ProcessorCount;
        }

        public static void SetDynamicControls(bool isCombox, bool isTrackbar, bool isTrackbar2, ComboBox comboBox, ComboBox comboBox2,
                RadioButton radioButton1, RadioButton radioButton2, RadioButton radioButton3, TrackBar trackBar, TrackBar trackBar1, Label label, Label label1)
        {
            if (isCombox)
            {
               /* string[] h = File.ReadAllLines(Directory.GetCurrentDirectory()
                + @"\Resources\cpu" + comboBox.SelectedItem.ToString().ToLower() + ".cfg");

                comboBox2.Items.Clear();
                for (int i = 0; i < h.Length; i++)
                {
                    comboBox2.Items.Add(h[i]);
                }
                comboBox2.SelectedIndex = 0;

                if (comboBox.SelectedIndex == 0 || comboBox.SelectedIndex == 1)
                {
                    radioButton1.Enabled = true;
                    radioButton2.Enabled = true;
                    radioButton3.Enabled = true;
                }
                else
                {
                    radioButton2.Checked = false;
                    radioButton3.Checked = false;
                    radioButton1.Enabled = true;
                    radioButton2.Enabled = false;
                    radioButton3.Enabled = false;
                } */
            }
            if (isTrackbar)
            {
                label.Text = "Selected RAM: " + trackBar.Value.ToString() + " MB";
            }
            if (isTrackbar2)
            {
                label1.Text = "Selected Video RAM: " + trackBar1.Value.ToString() + " MB";
            }
        }

        public static void SetDynamicControls2(bool diskSelec, RadioButton newdisk, RadioButton existig, Label sizeLbl, Label Formatlbl, NumericUpDown nmrSize,
                TextBox formatTxt, TextBox pathTxt, Button brsButton, CheckBox allocChexbox)
        {
            if (diskSelec)
            {
                pathTxt.Enabled = true;
                brsButton.Enabled = true;
                sizeLbl.Enabled = false;
                Formatlbl.Enabled = false;
                nmrSize.Enabled = false;
                formatTxt.Enabled = false;
                allocChexbox.Checked = false;
                allocChexbox.Enabled = false;
                if (newdisk.Checked)
                {
                    pathTxt.Enabled = false;
                    brsButton.Enabled = false;
                    sizeLbl.Enabled = true;
                    Formatlbl.Enabled = true;
                    nmrSize.Enabled = true;
                    formatTxt.Enabled = true;
                    allocChexbox.Checked = false;
                    allocChexbox.Enabled = true;
                }
            }
        }

        public static void Navigate(int direction, TabControl tabControl)
        {
            if (direction == 1)
            {
                if (tabControl.SelectedIndex != tabControl.TabCount - 1) tabControl.SelectedIndex++;
            }
            else
            {
                if (tabControl.SelectedIndex != 0) tabControl.SelectedIndex--;
            }
        }
        public static void QemuInvoke(string cpu, ref List<string> value, string whitelist, string argument)
		{
            var proc = new Process();
            ProcessStartInfo si = new ProcessStartInfo
            {
                FileName = Path.Combine(Properties.Settings.Default.qemuPath, "qemu-system-" + cpu + ".exe"),
                Arguments = argument,
                UseShellExecute = false,
                RedirectStandardOutput = true,
                CreateNoWindow = true
            };
            proc.StartInfo = si;
            proc.Start();
            while (!proc.StandardOutput.EndOfStream)
            {
                string line = proc.StandardOutput.ReadLine();
                const string reduceMultiSpace = @"(?<!^)\s{2}(?!$).+";
                line = Regex.Replace(line, reduceMultiSpace, "");
                if (!string.IsNullOrWhiteSpace(line) && line.Contains("Recognized CPUID flags:"))
                {
                    break;
                }
                if (!line.Contains(whitelist) && !string.IsNullOrWhiteSpace(line))
                {
                    value.Add(line.Trim());
                }
            }
        }
    }
}