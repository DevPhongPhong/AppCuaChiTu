﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppCuaChiTu
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void load_Click(object sender, EventArgs e)
        {
            Repo repo = new Repo();
            List<Product> products = repo.Gets();
            dataGridView1.DataSource = products;
        }
    }
}
