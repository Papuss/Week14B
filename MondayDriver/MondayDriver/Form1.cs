﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MondayDriver
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            
            string path = listBox1.SelectedItem.ToString();
            listBox1.Items.Clear();
            string[] files = Directory.GetFiles(path, "*.txt");
            string[] directories = Directory.GetDirectories(path);
            showPathTextBox.Text = path;
             foreach (string file in files)
             {
                 listBox1.Items.Add(file);
             }
            foreach (string dir in directories)
            {
                listBox1.Items.Add(dir);
            }
        
    
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string[] files = Directory.GetFiles(comboBox1.Text,"*.txt");
            string[] directories = Directory.GetDirectories(comboBox1.Text);
            showPathTextBox.Text = comboBox1.Text;
            foreach (string file in files)
            {
                listBox1.Items.Add(file);
            }
            foreach (string dir in directories)
            {
                listBox1.Items.Add(dir);
            }

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.AddRange(Environment.GetLogicalDrives());
            


        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void showPathTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
