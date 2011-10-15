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
        bool NumberEntered = false;
        public Form1()
        {
            InitializeComponent();
            getTextBtn.Enabled = false;
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

        private void testNumberBtn_Click(object sender, EventArgs e)
        {
            showNumbers(3290094091, 1092390438871873);
        }

        private void setText_TextChanged(object sender, EventArgs e)
        {
            if (setText.Text.Length != 0)
                getTextBtn.Enabled = true;
            else
                getTextBtn.Enabled = false;
        }

        private void showNumbers(float a, double b)
        {
            MessageBox.Show(a + "\n" + b, "Some numbers");
        }

        private void setText_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            char[] ch2 = new char[] { '*', '+', ',', '-', '.', '/' };
            // 8 = Backspace; 32 = Space; 42-47 = * + , - . /
            if (!Char.IsDigit(ch) && ch != 8 && ch != 32 && !ch2.Contains(ch))
                e.Handled = true;
        }
    }
}
