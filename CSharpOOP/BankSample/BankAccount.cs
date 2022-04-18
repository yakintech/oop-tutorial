using System;
namespace CSharpOOP.BankSample
{
    public class BankAccount
    {
        //Banka hesap numarası
        public string Number { get; } = Guid.NewGuid().ToString();

        //Hesap sahibi
        public string Owner { get; set; }

        //Bakiye
        public decimal Balance { get; }

        public BankAccount(string name, decimal initalBalance)
        {
            this.Owner = name;
            this.Balance = initalBalance;
        }


        public void MakeDeposit(decimal amount, DateTime date, string note)
        {

        }

        public void MakeWithdrawal(decimal amount, DateTime date, string note)
        {

        }

    }
}
