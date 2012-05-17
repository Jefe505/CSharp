using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter3
{
    abstract public class Account
    {
        protected double balance=0;
        private string name;

        public void Account(string name, double credit)
        {
            this.name = name;
            this.balance = credit;
        }
        public double[] Debit(double x)
        {
            double[] y = new double [] {0, this.balance};

            if ((this.balance - x) < 0)
                y[0] = 0;
            else
            {
                y[0] = 1;
                y[1] = this.balance - x;
            }
            return y;
        }
        public void Credit(double x)
        {
            this.balance += x;
        }
        public double CurrBalance()
        {
            return this.balance;
        }
        public string Name()
        {
            return this.name;
        }
    }
    public class SavingsAccount : Account
    {
        private double minBalance;

        public SavingsAccount(string name, double money, double min) : base()
        {
            this.minBalance = min;
        }
        public void Debit(double x)
        {
            if (x <= balance)
                base.Debit(x);
        }
    }
}
