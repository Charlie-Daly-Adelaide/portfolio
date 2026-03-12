using System;
using Bank;

public class Program
{
    static void Main()
    {
        string own = "john";
        int bal = 5;
        BankAccoun john = new BankAccoun(own, bal);
        john.BankInfo();
        john.Deposit(5.6);
        john.BankInfo();
        john.Deposit(5);
        john.BankInfo();
        
    }
}