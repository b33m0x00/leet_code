namespace MediumProblems.BestTimeToBuyAndSellStock2;

public class BestTimeToBuyAndSellStock2
{
    public int Solution(int[] prices)
    {
        var maxProfit = 0;

        for (var i = 0; i < prices.Length - 1; i++)
        {
            if (prices[i] < prices[i + 1])
            {
                maxProfit += prices[i + 1] - prices[i];
            }
        }

        return maxProfit;
    }
}