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

namespace RPG_Manager
{
    public partial class Form1 : Form
    {
        
        
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            




        }

        private void button8_Click(object sender, EventArgs e)
        {
        
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader openedFile = new StreamReader(openFileDialog1.FileName);
                textBox1.Text = openedFile.ReadToEnd();
                openedFile.Close();
            
            
            }

            
        }
    }
}
