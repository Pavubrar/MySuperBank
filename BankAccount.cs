using System;
using System.Collections.Generic;
using System.Text;

namespace MySuperBank
{
    public class BankAccount
    {
        public string Number { get; }
        public string Owner { get; set; }
        public decimal Balance { get;  }

        public BankAccount(string name, decimal initialAmount)
        {
            this.Owner = name;
            this.Balance = initialAmount;
        }

        public void MakeDeposit(decimal amount, DateTime date, string note)
        {

        }
        public void MakeWithdraw(decimal amount, DateTime date, string note)
        {

        }
    }
}
