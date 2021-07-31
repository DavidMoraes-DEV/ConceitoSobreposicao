﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Sobreposicao_E_Palavras_Virtual_Override_Base.Entities
{
    class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }

        public Account() {}

        public Account (int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        public virtual void WithDraw(double amount)
        {
            Balance -= amount + 5.0;
        }

        public void Deposit (double amount)
        {
            Balance += amount;
        }
    }
}