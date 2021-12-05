using day01;
using FluentAssertions;
using Xunit;

namespace day01test;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        var Day01Caclulator = new Day01Calculator();
        var inputNumbers = new int[] { 1 };

        var result = Day01Caclulator.Calculate(inputNumbers);
        result.Should().Be(0);
    }
}