using FluentAssertions;
using Xunit;

namespace SamsungTestTask;

public class WaysCounterTests
{
    [Theory]
    [InlineData(0,0)]
    [InlineData(1,1)]
    [InlineData(2,2)]
    [InlineData(4,7)]
    [InlineData(7,44)]
    public void CountMethod_WithGivenSteps_ReturnExpectedResult(uint nSteps, int resultWays) => 
        WaysCounter.Count(nSteps).Should().Be(resultWays);
}