using MediumProblems.RotateArray;

namespace Tests.MediumProblemsTests;

public class RotateArrayTests
{
    private RotateArray _rotateArray;
    
    
    [Theory]
    [InlineData(new [] { 1, 2, 3, 4, 5, 6, 7 }, 3, new [] { 5, 6, 7, 1, 2, 3, 4 })]
    [InlineData(new [] { -1, -100, 3, 99 }, 2, new [] { 3, 99, -1, -100 })]
    public void Solution_ReturnsExpected_WhenTestCasesGiven(int[] nums, int k, int[] expected)
    {
        // arrange
        _rotateArray = new RotateArray();
        
        // act
        _rotateArray.Solution(nums, k);
        
        // assert
        Assert.True(nums.SequenceEqual(expected));
    }
}