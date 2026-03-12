using Microsoft.VisualBasic;

namespace Bank;

public class BankAccoun
{
    public string Owner {get; set;}
    public double Balance {get; set;}

    public BankAccoun(string owner, int balance)
    {
        Owner = owner;
        Balance = balance;
    }

    public void Deposit(int increase)
    {
        Balance += (double)increase;
    }

    public void Deposit(double increase)
    {
        Balance += (double)increase;
    }

    public void Withdraw(int increase)
    {
        if ((Balance - increase) >= 0)
        {
            Balance -= (double)increase;
        }
        else
        {
            throw new Exception ("Balance too low to reduce");
        }
    }

public void Withdraw(double increase)
    {
        if ((Balance - increase) >= 0)
        {
            Balance -= increase;
        }
        else
        {
            throw new Exception ("Balance too low to reduce");
        }
    }

    public void BankInfo()
    {
        Console.Write("Owner: " + Owner + " Balance: " + Balance + " ");
    }
}
