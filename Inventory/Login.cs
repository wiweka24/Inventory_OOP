﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (uname.Text == "admin" && passw.Text == "admin")
            {
                Product cat = new Product();
                cat.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please check your username or password");
            }
        }
    }
}