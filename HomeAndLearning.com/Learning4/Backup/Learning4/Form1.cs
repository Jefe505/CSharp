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
        bool[] proceed = { true, true };

        public Form1()
        {
            InitializeComponent();
        }

        private void clearNumbers()
        {
            numberBox.Focus();
            numberBox.Text = "";
            calcText.Text = "";
            numbers[0] = numbers[1] = "";
            x = 0;
            proceed[0] = true;
            proceed[1] = true;
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            clearNumbers();
        }

        private void addOperator(char ch)
        {
            if (proceed[0])
            {
                operand = ch;
                numbers[x] = numberBox.Text;
                printToLabel(numbers[x], operand);
                numberBox.Text = "";
                x++;
                proceed[0] = false;
            }
        }

        private void addNumber(short a)
        {
            if (proceed[1])
            {
                numberBox.Text += a;
            }
            else
            {
                clearNumbers();
                numberBox.Text += a;
            }
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
            addNumber(0);
        }

        private void nine_Click(object sender, EventArgs e)
        {
            addNumber(9);
        }

        private void eight_Click(object sender, EventArgs e)
        {
            addNumber(8);
        }

        private void seven_Click(object sender, EventArgs e)
        {
            addNumber(7);
        }

        private void six_Click(object sender, EventArgs e)
        {
            addNumber(6);
        }

        private void five_Click(object sender, EventArgs e)
        {
            addNumber(5);
        }

        private void four_Click(object sender, EventArgs e)
        {
            addNumber(4);
        }

        private void three_Click(object sender, EventArgs e)
        {
            addNumber(3);
        }

        private void two_Click(object sender, EventArgs e)
        {
            addNumber(2);
        }

        private void one_Click(object sender, EventArgs e)
        {
            addNumber(1);
        }

        private void comma_Click(object sender, EventArgs e)
        {
            numberBox.Text += ",";
        }
        private void solveBtn_Click(object sender, EventArgs e)
        {
            printToLabel(numberBox.Text, '=');
            numbers[1] = numberBox.Text;
            switch ((int)operand)
            {
                case 42:
                    equal = double.Parse(numbers[0]) * double.Parse(numbers[1]);
                    break;
                case 43:
                    equal = double.Parse(numbers[0]) + double.Parse(numbers[1]);
                    break;
                case 45:
                    equal = double.Parse(numbers[0]) - double.Parse(numbers[1]);
                    break;
                case 47:
                    equal = double.Parse(numbers[0]) / double.Parse(numbers[1]);
                    break;
            }
            proceed[1] = false;
            printToLabel(equal);
        }

        private void numberBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            char[] ch2 = new char[] { '*', '+', ',', '-', '.', '/' };
            // 8 = Backspace; 32 = Space; 42-47 = * + , - . /
            if (!Char.IsDigit(ch) && ch != 8 && ch != 32 && !ch2.Contains(ch))
                e.Handled = true;
            switch (Convert.ToUInt16(e.KeyChar))
            {
                case 42:
                    this.mulBtn.PerformClick();
                    break;
                case 43:
                    this.addBtn.PerformClick();
                    break;
                case 44:
                case 46:
                    this.comma.PerformClick();
                    break;
                case 45:
                    this.subBtn.PerformClick();
                    break;
                case 47:
                    this.divBtn.PerformClick();
                    break;
                case 1:
                    this.one.PerformClick();
                    break;
                case 2:
                    this.two.PerformClick();
                    break;
                case 3:
                    this.three.PerformClick();
                    break;
                case 4:
                    this.four.PerformClick();
                    break;
                case 5:
                    this.five.PerformClick();
                    break;
                case 6:
                    this.six.PerformClick();
                    break;
                case 7:
                    this.seven.PerformClick();
                    break;
                case 8:
                    this.eight.PerformClick();
                    break;
                case 9:
                    this.nine.PerformClick();
                    break;
                case 0:
                    this.zero.PerformClick();
                    break;
                case 127:
                    this.clearBtn.PerformClick();
                    break;
            }
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

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
