using System;
namespace CSharpOOP.BankSample
{
    public class Transaction
    {
        public decimal Amount { get; set; }

        public DateTime Date { get; set; }

        public string Notes { get; set; }


        //Constructor üzerinden property leri SET ETMEK
        public Transaction(decimal amount, DateTime date, string notes)
        {
            this.Amount = amount;
            this.Date = date;
            this.Notes = notes;
        }

    }
}
