﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AISCarwash
{
    public partial class MainForm : Form
    {
        private string _mode;
        public MainForm(string mode)
        {
            _mode = mode;

            InitializeComponent();

        }
    }
}