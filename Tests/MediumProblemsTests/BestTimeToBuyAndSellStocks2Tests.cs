using FluentAssertions;
using MediumProblems.BestTimeToBuyAndSellStock2;

namespace Tests.MediumProblemsTests;

public class BestTimeToBuyAndSellStocks2Tests
{
    [Theory]
    [InlineData(new[] { 7, 1, 5, 3, 6, 4 }, 7)]
    [InlineData(new[] { 1, 2, 3, 4, 5 }, 4)]
    [InlineData(new[] { 7, 6, 4, 3, 1 }, 0)]
    public void Solution_ReturnsExpected_WhenTestCasesGiven(int[] inputs, int expected)
    {
        // Arrange
        var solutionClass = new BestTimeToBuyAndSellStock2();
        
        // Act
        var response = solutionClass.Solution(inputs);
        
        // Assert

        response.Should().Be(expected);
    }
}