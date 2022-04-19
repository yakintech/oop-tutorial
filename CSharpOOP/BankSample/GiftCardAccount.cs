using System;
namespace CSharpOOP.BankSample
{
    //Inheritance
    public class GiftCardAccount : BankAccount
    {

        public GiftCardAccount(string name, decimal initalBalance) : base(name, initalBalance)
        {

        }
    }
}
