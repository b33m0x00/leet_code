namespace EasyProblems.RomanToInteger;

public class RomanToInteger
{
    private Dictionary<string, int> RomanToIntegerDictionary = new Dictionary<string, int>()
    {
        { "I", 1 },
        { "V", 5 },
        { "X", 10 },
        { "L", 50 },
        { "C", 100 },
        { "D", 500 },
        { "M", 1000 },
    };
    
    public int Solutiom(string s)
    {
        var result = 0;
        var prev = 0;

        for (var i = s.Length - 1; i >= 0; i--)
        {
            var curr = RomanToIntegerDictionary[$"{s[i]}"];

            result += (curr < prev) ? -curr : curr;

            prev = curr;
        }

        return result;
    }
}