﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_1._0
{
    public partial class AddQuote : Form
    {
        public AddQuote()
        {
            InitializeComponent();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btGetQuote_Click(object sender, EventArgs e)
        {
            
        }

        private void AddQuote_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((MainMenu)this.Tag).Show();
        }

       

       

        }
    }

