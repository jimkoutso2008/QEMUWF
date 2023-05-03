﻿using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace QEMUWF
{
    class Core
    {
        public static void SetStaticControls(TrackBar trackBar, ComboBox comboBox, ComboBox comboBox2, TabControl tabControl, NumericUpDown numericUpDown)
        {
            ComputerInfo info = new ComputerInfo();
            ulong h = info.TotalPhysicalMemory;
            h = h / (1024 * 1024);
            trackBar.Minimum = 2;
            trackBar.Maximum = (int)h;
            trackBar.TickFrequency = 128;
            trackBar.SmallChange = trackBar.Maximum / trackBar.TickFrequency;
            comboBox2.SelectedIndex = 0;
            comboBox.SelectedIndex = 0;
            tabControl.Location = new Point(0, -22);
            tabControl.Size = new Size(438, 480);
            numericUpDown.Maximum = Environment.ProcessorCount;
        }
        public static void SetDynamicControls(bool isCombox, bool isTrackbar, ComboBox comboBox, ComboBox comboBox2, 
                RadioButton radioButton1, RadioButton radioButton2, RadioButton radioButton3, TrackBar trackBar1, Label label10)
        {
            if (isCombox)
            {
                string[] h = File.ReadAllLines(Directory.GetCurrentDirectory()
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
                }
            }
            if (isTrackbar)
            {
                label10.Text = "Selected RAM: " + trackBar1.Value.ToString() + " MB";
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

            if (direction==1)
            {
                if (tabControl.SelectedIndex != tabControl.TabCount - 1) tabControl.SelectedIndex++;
            }
            else
            {
                if (tabControl.SelectedIndex != 0) tabControl.SelectedIndex--;
            }
        }
    }
}