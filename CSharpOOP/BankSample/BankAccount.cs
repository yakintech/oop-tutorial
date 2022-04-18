using System;
using System.Collections.Generic;

namespace CSharpOOP.BankSample
{
    public class BankAccount
    {
        List<Transaction> transactions = new List<Transaction>();


        //Banka hesap numarası
        public string Number { get; } = Guid.NewGuid().ToString();

        //Hesap sahibi
        public string Owner { get; set; }

        //Bakiye
        public decimal Balance
        {
            get
            {
                decimal balance = 0;

                foreach (var item in transactions)
                {
                    balance = balance + item.Amount;
                }

                return balance;
            }

        }

        public BankAccount(string name, decimal initalBalance)
        {
            this.Owner = name;

            MakeDeposit(initalBalance, DateTime.Now, "first deposit!");
        }


      

        public void MakeDeposit(decimal amount, DateTime date, string note)
        {
            Transaction depositTransaction = new Transaction(amount, date, note);
            transactions.Add(depositTransaction);
        }

        public void MakeWithdrawal(decimal amount, DateTime date, string note)
        {
            Transaction withdrawalTransaction = new Transaction(-amount, date, note);
            transactions.Add(withdrawalTransaction);
        }

    }
}
