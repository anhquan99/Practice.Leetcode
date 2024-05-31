namespace Application;
public partial class BackTrackingSolution
{
    public IList<IList<int>> CombinationSum2(int[] candidates, int target)
    {
        Array.Sort(candidates);
        var combinationSumResult = new List<IList<int>>();
        PermuteCombinationSum(new List<int>(), candidates, 0, target);
        return combinationSumResult;
        void PermuteCombinationSum(List<int> subResult, int[] candidates, int index, int target)
        {
            var sum = subResult.Sum();
            if (sum >= target || index >= candidates.Length)
            {
                if (sum == target)
                {
                    combinationSumResult.Add(new List<int>(subResult));
                }
                return;
            }
            var lastRemove = 0;
            for (int i = index; i < candidates.Length; i++)
            {
                if (lastRemove == candidates[i]) continue;
                subResult.Add(candidates[i]);
                PermuteCombinationSum(subResult, candidates, i + 1, target);
                lastRemove = subResult[^1];
                subResult.RemoveAt(subResult.Count - 1);
            }
        }
    }
}