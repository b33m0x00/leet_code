using EasyProblems.RomanToInteger;

namespace Tests.EasyProblemsTests;

public class RomanToIntegerTests
{
    private RomanToInteger _romanToInteger = null!;
    
    [Theory]
    [InlineData("III", 3)]
    [InlineData("LVIII", 58)]
    [InlineData("MCMXCIV", 1994)]
    public void RomanToInteger(string romanNumber, int response)
    {
        // arrange
        _romanToInteger = new RomanToInteger();
        
        // act
        var result = _romanToInteger.Solutiom(romanNumber);
        
        // assert
        Assert.Equal(result, response);
    }
}