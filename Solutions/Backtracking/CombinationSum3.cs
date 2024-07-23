namespace Application;
public partial class BackTrackingSolution
{
    public IList<IList<int>> CombinationSum3(int k, int n)
    {
        var list = Enumerable.Range(1, 9).ToArray();
        var combinationSumResult = new List<IList<int>>();
        PermuteCombinationSum(new List<int>(), 0, k, n);
        return combinationSumResult;

        void PermuteCombinationSum(List<int> subResult, int index, int k, int n)
        {
            if (subResult.Count == k)
            {
                if (subResult.Sum() == n)
                {
                    combinationSumResult.Add(new List<int>(subResult));
                }
                return;
            }
            for (int i = index; i < list.Length; i++)
            {
                subResult.Add(list[i]);
                PermuteCombinationSum(subResult, i + 1, k, n);
                subResult.RemoveAt(subResult.Count - 1);
            }
        }
    }
}