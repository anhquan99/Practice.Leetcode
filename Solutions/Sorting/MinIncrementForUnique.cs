namespace Application;
public partial class SortiSolution
{
    public int MinIncrementForUnique(int[] nums)
    {
        var result = 0;
        Array.Sort(nums);
        var dic = new Dictionary<int, int>();
        foreach (var i in nums)
        {
            if (dic.ContainsKey(i)) dic[i]++;
            else dic.Add(i, 0);
        }
        int index = nums[0];
        foreach (var i in dic)
        {
            if (i.Value > 0)
            {
                index = i.Key > index ? i.Key : index;
                int numberOfCheckedDuplicates = 1;
                for (; numberOfCheckedDuplicates <= i.Value && index < i.Key + nums.Length; index++)
                {
                    if (!dic.ContainsKey(index))
                    {
                        numberOfCheckedDuplicates++;
                        result += index - i.Key;
                    }
                }
            }
        }
        return result;
    }
}