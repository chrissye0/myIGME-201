﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GifFinder
{
    public partial class SearchForm : Form
    {
        public string response;
        public string searchTerm;
        public int maxItems;

        public SearchForm()
        {
            InitializeComponent();
            this.okButton.Click += new EventHandler(okButton_Click);
            this.cancelButton.Click += new EventHandler(cancelButton_Click);
            this.maxItemsTextBox.KeyPress += new KeyPressEventHandler(MaxItemsTextBox_KeyPress);
        }

        private void MaxItemsTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;

            if(Char.IsDigit(e.KeyChar) || e.KeyChar == '\b')
            {
                e.Handled = false;
            }
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            this.response = "OK";
            this.searchTerm = searchTermTextBox.Text;
            maxItems = Convert.ToInt32(maxItemsTextBox.Text);
            this.Hide();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.response = "Cancel";
            this.Hide();
        }
    }
}
