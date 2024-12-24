namespace MediumProblems.RotateArray;

public class RotateArray
{
    public void Solution(int[] nums, int k)
    {
        // revert entire array
        var i = 0;
        var j = nums.Length - 1;
        k %= nums.Length;
        
        while (i < j)
        {
            nums[i] += nums[j];
            nums[j] = nums[i] - nums[j];
            nums[i] -= nums[j];

            i++;
            j--;
        }

        // revert first k elements
        i = 0;
        j = k - 1;

        while (i < j)
        {
            nums[i] += nums[j];
            nums[j] = nums[i] - nums[j];
            nums[i] -= nums[j];
            
            i++;
            j--;
        }
        
        // revert last n - k elements
        i = k;
        j = nums.Length - 1;

        while (i < j)
        {
            nums[i] += nums[j];
            nums[j] = nums[i] - nums[j];
            nums[i] -= nums[j];

            i++;
            j--;
        }
    }
}