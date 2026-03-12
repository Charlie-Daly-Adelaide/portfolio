using System;
using Bank;
using Xunit;

public class UnitTest1
{
    [Fact]
    public void DepositIntCheck()
    {
        var p = new BankAccoun("John", 5);
        int d = 5;
        p.Deposit(d);
        Assert.Equal(10, p.Balance);
    }

    [Fact]
    public void DepositDoubleCheck()
    {
        var p = new BankAccoun("John", 5);
        double d = 5.5;
        p.Deposit(d);
        Assert.Equal(10.5, p.Balance);
    }

    [Fact]
    public void WithdrawIntCheck()
    {
        var p = new BankAccoun("John", 5);
        int w = 5;
        p.Withdraw(w);
        Assert.Equal(0, p.Balance);
    }

    [Fact]
    public void WithdrawDoubleCheck()
    {
        var p = new BankAccoun("John", 5.5);
        double w = 5.5;
        p.Withdraw(w);
        Assert.Equal(0, p.Balance);
    }
}
