namespace PayrollCalculator.Tests;
using Xunit;
using PayrollCalculator;

public class payrollTest
{
    [Fact]
    public void CorrectTaxCalcTest()
    {
        var p = new PayrollCalculator(3, 5, 2);
        Assert.Equal(-15, p.CalculateNetPay());
    }
    public void CorrectTaxChangeTest()
    {
        var p = new PayrollCalculator(3, 5, 2);
        p.ChangeTaxRate(1);
        Assert.Equal(1, p.GetTaxRate());
    }
}
