using System.Text;

namespace Application;

public partial class ArraySolution
{
    public int[] SortJumbled(int[] mapping, int[] nums)
    {
        var mapped = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == 0)
            {
                mapped.Add(i, mapping[0]);
                continue;
            }
            var mapStr = new StringBuilder();
            var num = nums[i];
            while (num > 0)
            {
                mapStr.Append(mapping[num % 10]);
                num = num / 10;
            }
            mapped.Add(i, int.Parse(new string(mapStr.ToString().Reverse().ToArray())));
        }
        var result = new int[nums.Length];
        var index = 0;
        foreach (var i in mapped.OrderBy(x => x.Value).Select(x => x.Key))
        {
            result[index++] = nums[i];
        }
        return result;
    }
}