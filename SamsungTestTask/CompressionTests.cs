using FluentAssertions;
using Xunit;

namespace SamsungTestTask;

public class CompressionTests
{
    [Theory]
    [InlineData("aaaabbccca", "a4b2c3a1")]
    [InlineData("aaabcc", "aaabcc")]
    [InlineData("abc", "abc")]
    [InlineData("", "")]
    [InlineData("111112", "1521")]
    public void CompressionMethod_WithGivenSource_ReturnExpectedResult(string source, string result) => 
        Compression.Compress(source).Should().Be(result);
}