namespace EasyProblems;

/*
 * @lc app=leetcode id=14 lang=csharp
 *
 * [14] Longest Common Prefix
 */
public class LongestCommonPrefix
{
    public string Solution(string[] strs) {
        var j = 0;

        if (strs.Length == 1)
        {
            return strs[0];
        }

        while (strs.Length > 0)
        {
            for (var i = 1; i < strs.Length; i++)
            {
                if (!(j < strs[i].Length && j < strs[i - 1].Length))
                {
                    return strs[i][..j];
                }

                if (strs[i][j] != strs[i - 1][j])
                {
                    return strs[i][..j];
                }
            }

            j++;
        }

        return "";
    }
}