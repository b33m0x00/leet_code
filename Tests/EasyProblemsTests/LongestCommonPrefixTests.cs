using EasyProblems;
using FluentAssertions;

namespace Tests.EasyProblemsTests;

public class LongestCommonPrefixTests
{
    private readonly LongestCommonPrefix _longestCommonPrefix;
    
    public LongestCommonPrefixTests()
    {
        _longestCommonPrefix = new LongestCommonPrefix();
    }
    
    [Theory]
    [InlineData(new string[] { "", "b" }, "")]
    [InlineData(new string[] { "flower","flow","flight" }, "fl")]
    [InlineData(new string[] { "dog","racecar","car" }, "")]
    [InlineData(new string[] { "flower","flower","flower","flower" }, "flower")]
    [InlineData(new string[] { "ab", "a" }, "a")]
    public void Solution_ReturnsExpected_WhenGivenTestCases(string[] testCase, string expected)
    {
        // Act
        var response = _longestCommonPrefix.Solution(testCase);
        
        // Assert
        response.Should().Be(expected);
    }
}