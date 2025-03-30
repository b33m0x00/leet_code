namespace EasyProblems.BestTimeToBuyAndSellStock;

public class BestTimeToBuyAndSellStock
{
    public int Solution(int[] prices)
    {
        var min = int.MaxValue;
        var max = 0;

        foreach (var t in prices)
        {
            if (t < min)
            {
                min = t;
            } else if (t - min > max)
            {
                max = t;
            }
        }

        return max;
    }
}