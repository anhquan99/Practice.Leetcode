namespace Application
{
    public partial class HashTableSolution
    {
        public int[][] MergeArrays(int[][] nums1, int[][] nums2)
        {
            var dic = new Dictionary<int, int>();
            foreach (var i in nums1)
            {
                if (!dic.ContainsKey(i[0]))
                {
                    dic.Add(i[0], i[1]);
                }
            }
            foreach (var i in nums2)
            {
                if (!dic.ContainsKey(i[0]))
                {
                    dic.Add(i[0], i[1]);
                }
                else
                {
                    dic[i[0]] += i[1];
                }
            }
            var result = new int[dic.Count][];
            var index = 0;
            foreach (var i in dic.OrderBy(x => x.Key))
            {
                result[index] = new int[] { i.Key, i.Value };
                index++;
            }
            GC.Collect();
            return result;
        }
    }
}