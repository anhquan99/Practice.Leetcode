namespace Application;
public partial class BackTrackingSolution
{
    public IList<IList<int>> CombinationSum2(int[] candidates, int target)
    {
        Array.Sort(candidates);
        var combinationSumResult = new List<List<int>>();
        PermuteCombinationSum(new List<int>(), candidates, 0, target);
        var result = combinationSumResult.Distinct(new ListEqualityComparer<int>()).Select(x => (IList<int>)x).ToList();
        return result;
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
            for (int i = index; i < candidates.Length; i++)
            {
                subResult.Add(candidates[i]);
                PermuteCombinationSum(subResult, candidates, i + 1, target);
                subResult.RemoveAt(subResult.Count - 1);
            }
        }
    }
    public class ListEqualityComparer<T> : IEqualityComparer<List<T>>
    {
        public bool Equals(List<T> x, List<T> y)
        {
            if (x == null || y == null)
                return x == y; // Both null or one is null

            return x.Count == y.Count && x.SequenceEqual(y);
        }

        public int GetHashCode(List<T> obj)
        {
            return obj == null ? 0 : obj.Sum(item => item.GetHashCode());
        }
    }
}