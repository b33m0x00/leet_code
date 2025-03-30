using EasyProblems.BestTimeToBuyAndSellStock;
using FluentAssertions;

namespace Tests.EasyProblemsTests;

public class BestTimeToBuyAndSellStockTests
{
    private readonly BestTimeToBuyAndSellStock _bestTimeToBuyAndSellStock = new();

    [Theory]
    [InlineData(new int[] { 7, 1, 5, 3, 6, 4 }, 5)]
    [InlineData(new int[] { 7, 6, 4, 3, 1 }, 0)]
    public void Solution_ReturnsExpected_WhenGivenTestCases(int[] testCase, int expected)
    {
        // Act
        var response = _bestTimeToBuyAndSellStock.Solution(testCase);
        
        // Assert
        response.Should().Be(expected);
    }
}