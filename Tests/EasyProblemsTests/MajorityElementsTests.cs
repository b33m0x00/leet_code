using EasyProblems.MajorityElement;

namespace Tests.EasyProblemsTests;

public class MajorityElementsTests
{
    [Theory]
    [InlineData(new [] { 3, 2, 3,}, 3)]
    [InlineData(new [] { 2, 2, 1, 1, 1, 2, 2 }, 2)]
    public void Solution_ReturnsExpected_WhenTestCasesGiven(int[] data, int expected)
    {
        // arrange
        var majorityElements = new MajorityElement();

        // act
        var response = majorityElements.Solution(data);

        // assert
        Assert.Equal(response, expected);
    }
}