﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsTest4
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

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            trb1.Maximum = 100;
            prb1.Maximum = 100;
            prb1.Value = trb1.Value;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            prb1.Maximum = int.Parse(txtLoopCount.Text);
            prb1.Step = int.Parse(txtLoopCount.Text) / 100;
            for (int i = 0; i <= int.Parse(txtLoopCount.Text); i++)
            {
                prb1.Value = i;
            }
        }
    }
}
