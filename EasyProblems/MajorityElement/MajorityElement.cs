namespace EasyProblems.MajorityElement;

public class MajorityElement
{
    public int Solution(int[] nums)
    {
        var max = 0;
        var curr = 0;

        foreach (var v in nums)
        {
            if (max == 0)
            {
                curr = v;
            }

            if (v == curr)
            {
                max++;
            }
            else
            {
                max--;
            }
        }

        return curr;
    }
}