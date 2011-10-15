using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Learning4
{
    public partial class Form1 : Form
    {
        string[] numbers = new string[2];
        double equal;
        int x = 0;
        char operand;

        public Form1()
        {
            InitializeComponent();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            numberBox.Focus();
            numberBox.Text = "";
            calcText.Text = "";
            numbers[0] = numbers[1] = "";
            x = 0;
        }

        private void addOperator(char ch)
        {
            operand = ch;
            numbers[x] = numberBox.Text;
            printToLabel(numbers[x], operand);
            numberBox.Text = "";
            x++;
        }

        private void divBtn_Click(object sender, EventArgs e)
        {
            addOperator('/');
        }

        private void mulBtn_Click(object sender, EventArgs e)
        {
            addOperator('*');
        }

        private void subBtn_Click(object sender, EventArgs e)
        {
            addOperator('-');
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            addOperator('+');
        }

        private void zero_Click(object sender, EventArgs e)
        {
            numberBox.Text += 0;
        }

        private void nine_Click(object sender, EventArgs e)
        {
            numberBox.Text += 9;
        }

        private void eight_Click(object sender, EventArgs e)
        {
            numberBox.Text += 8;
        }

        private void seven_Click(object sender, EventArgs e)
        {
            numberBox.Text += 7;
        }

        private void six_Click(object sender, EventArgs e)
        {
            numberBox.Text += 6;
        }

        private void five_Click(object sender, EventArgs e)
        {
            numberBox.Text += 5;
        }

        private void four_Click(object sender, EventArgs e)
        {
            numberBox.Text += 4;
        }

        private void three_Click(object sender, EventArgs e)
        {
            numberBox.Text += 3;
        }

        private void two_Click(object sender, EventArgs e)
        {
            numberBox.Text += 2;
        }

        private void one_Click(object sender, EventArgs e)
        {
            numberBox.Text += 1;
        }

        private void solveBtn_Click(object sender, EventArgs e)
        {
            printToLabel(numberBox.Text, '=');
            switch ((int)operand)
            {
                case 42:
                    equal = Convert.ToDouble(numbers[0]) * Convert.ToDouble(numberBox.Text);
                    break;
                case 43:
                    equal = Convert.ToDouble(numbers[0]) + Convert.ToDouble(numberBox.Text);
                    break;
                case 45:
                    equal = Convert.ToDouble(numbers[0]) - Convert.ToDouble(numberBox.Text);
                    break;
                case 47:
                    equal = Convert.ToDouble(numbers[0]) / Convert.ToDouble(numberBox.Text);
                    break;
            }
            printToLabel(equal);
        }

        private void numberBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            char[] ch2 = new char[] { '*', '+', ',', '-', '.', '/' };
            // 8 = Backspace; 32 = Space; 42-47 = * + , - . /
            if (!Char.IsDigit(ch) && ch != 8 && ch != 32 && !ch2.Contains(ch))
                e.Handled = true;
        }

        private void printToLabel(double stringOne)
        {
            calcText.Text += stringOne;
            numberBox.Focus();
            numberBox.Text = "";
        }

        private void printToLabel(string stringOne, char stringTwo)
        {
            calcText.Text += stringOne + stringTwo;
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
