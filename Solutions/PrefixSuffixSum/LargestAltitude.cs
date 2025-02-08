using System.Collections;

namespace Application;
public partial class PrefixSuffixSumSolution
{
    public int LargestAltitude(int[] gain)
    {
        int max = 0, sum = 0;
        foreach (var i in gain)
        {
            sum += i;
            max = Math.Max(max, sum);
        }
        return max;
    }
}
