using day01;
using FluentAssertions;
using Xunit;

namespace day01test;

public class UnitTest1
{
    [Fact]
    public void TestOneNumber()
    {
        var Day01Caclulator = new Day01Calculator();
        var inputNumbers = new int[] { 1 };

        var result = Day01Caclulator.Calculate(inputNumbers);
        result.Should().Be(0);
    }

    [Fact]
    public void TestTwoNumbersIncreasing()
    {
        var Day01Caclulator = new Day01Calculator();
        var inputNumbers = new int[] { 1, 2 };

        var result = Day01Caclulator.Calculate(inputNumbers);
        result.Should().Be(1);
    }   

    [Fact]
    public void TestTwoNumbersDecreasing()
    {
        var Day01Caclulator = new Day01Calculator();
        var inputNumbers = new int[] { 2, 1 };

        var result = Day01Caclulator.Calculate(inputNumbers);
        result.Should().Be(0);
    }

    [Fact]
    public void TestTwoNumbersTheSame()
    {
        var Day01Caclulator = new Day01Calculator();
        var inputNumbers = new int[] { 1, 1 };

        var result = Day01Caclulator.Calculate(inputNumbers);
        result.Should().Be(0);
    }

    [Fact] void TestMultipleNumbers()
    {
        var Day01Caclulator = new Day01Calculator();
        var inputNumbers = new int[] { 1, 1, 5, 3, 5, 8 };

        var result = Day01Caclulator.Calculate(inputNumbers);
        result.Should().Be(3);
    }

    [Fact] void TestEmptyInput()
    {
        var Day01Caclulator = new Day01Calculator();
        var inputNumbers = new int[] { };

        var result = Day01Caclulator.Calculate(inputNumbers);
        result.Should().Be(0);
    }   
}