﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi05_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "AVI File|*.avi|MP4 File|*.mp4";
            if(openFile.ShowDialog()==DialogResult.OK)
            {
                axWindowsMediaPlayer1.URL = openFile.FileName;
            }    
        }
    }
}
