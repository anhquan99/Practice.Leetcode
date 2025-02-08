using System.Collections;

namespace Application;
public partial class PrefixSuffixSumSolution
{
    public bool CheckSubarraySum(int[] nums, int k)
    {
        var dic = new Dictionary<int, int>();
        dic.Add(0, -1);
        int sum = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            sum += nums[i];
            var remainder = sum % k;
            if (dic.ContainsKey(remainder) && i - dic[remainder] >= 2)
            {
                return true;
            }
            dic.TryAdd(remainder, i);
        }
        return false;
    }
}
