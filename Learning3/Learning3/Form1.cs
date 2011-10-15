using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Learning3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void getTextBtn_Click(object sender, EventArgs e)
        {
            setText.ForeColor = Color.Black;
            String text;
            if (setText.Text.Length == 0)
            {
                setText.Text = "Write text here...";
                setText.ForeColor = Color.Gray;
            }
            else
            {
                text = setText.Text;
                showText.Text = text;
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            DialogResult x = MessageBox.Show("Do you want to close the program?", "Close?", MessageBoxButtons.YesNo);
            if (x == DialogResult.Yes)
                Application.Exit();
        }
    }
}
