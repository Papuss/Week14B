using System;
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
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                listBox1.Items.Clear();
                string[] files = Directory.GetFiles(fbd.SelectedPath,"*.txt");
                string[] directories = Directory.GetDirectories(fbd.SelectedPath);
                showPathTextBox.Text = fbd.SelectedPath;
                foreach (string file in files)
                {
                    listBox1.Items.Add(Path.GetFileName(file));
                }
                foreach (string dir in directories)
                {
                    listBox1.Items.Add(Path.GetFileName(dir));
                }
            }
            
            
           

        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Object selectedItem = comboBox1.SelectedItem;
            listBox1.Items.Clear();
            string[] files = Directory.GetFiles(selectedItem.ToString(),"*.txt");
            string[] directories = Directory.GetDirectories(selectedItem.ToString());
            showPathTextBox.Text = selectedItem.ToString();
            foreach (string file in files)
            {
                listBox1.Items.Add(Path.GetFileName(file));
            }
            foreach (string dir in directories)
            {
                listBox1.Items.Add(Path.GetFileName(dir));
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
    }
}
