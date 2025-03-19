using Xunit;
using MyLibrary;
using System;

public class CalculatorTests
{
    private readonly Calculator _calculator;

    public CalculatorTests()
    {
        _calculator = new Calculator();
    }

    [Fact]
    public void Add_ShouldReturnCorrectSum()
    {
        var result = _calculator.Add(5, 7);
        Assert.Equal(12, result);
    }

    [Fact]
    public void Subtract_ShouldReturnCorrectResult()
    {
        var result = _calculator.Subtract(10, 3);
        Assert.Equal(7, result);
    }

    [Fact]
    public void Multiply_ShouldReturnCorrectProduct()
    {
        var result = _calculator.Multiply(4, 6);
        Assert.Equal(24, result);
    }

    [Fact]
    public void Divide_ShouldReturnCorrectQuotient()
    {
        var result = _calculator.Divide(10, 2);
        Assert.Equal(5, result);
    }

    [Fact]
    public void Divide_ByZero_ShouldThrowException()
    {
        Assert.Throws<DivideByZeroException>(() => _calculator.Divide(10, 0));
    }

    [Fact]
    public void Power_ShouldReturnCorrectValue()
    {
        var result = _calculator.Power(2, 3);
        Assert.Equal(8, result);
    }

    [Theory]
    [InlineData(3, 2, 9)]
    [InlineData(2, 4, 16)]
    [InlineData(5, 0, 1)]
    public void Power_WithDifferentValues_ShouldReturnExpectedResult(int baseNum, int exponent, double expected)
    {
        var result = _calculator.Power(baseNum, exponent);
        Assert.Equal(expected, result);
    }
}
