﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class About : Form
    {
        MainForm mf;
        public About()
        {
            InitializeComponent();
        }

        public About(MainForm mf) : this() {
            this.mf = mf;
        }

        private void About_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
