﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kurzor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            int n = e.X;
            int m = e.Y;

            lblSzoveg.Text = ($"X:{n}, Y:{m}");
            lblSzoveg.Top = m;
            lblSzoveg.Left = n;
        }
    }
}
