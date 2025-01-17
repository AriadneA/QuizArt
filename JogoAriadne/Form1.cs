﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoAriadne
{
    public partial class Form1 : Form
    {
        TelaGame telaGame = new TelaGame();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(progressBar1.Step);
            label1.Text = progressBar1.Value.ToString() + "%";
            if (progressBar1.Value == 100)
            {
                timer1.Enabled = false;
                this.Hide();
                telaGame.ShowDialog();
                this.Close();
            }
        }
    }
}
