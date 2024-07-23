using System.Runtime.InteropServices;

namespace Application;
public partial class HeapSolution
{
    class MinHeapComparer : IComparer<int>
    {
        public int Compare(int x, int y) => x - y;
    }
    public int[] KWeakestRows(int[][] mat, int k)
    {
        // var sortedDic = new Dictionary<int, int>();
        // for (int i = 0; i < mat.Length; i++)
        // {
        //     var row = mat[i];
        //     int index = 0;
        //     while (index < row.Length && row[index] == 1)
        //     {
        //         index++;
        //     }
        //     sortedDic.Add(i, index);
        // }
        // return sortedDic.OrderBy(x => x.Value).Select(x => x.Key).Take(k).ToArray();
        var queue = new PriorityQueue<int, int>(new MinHeapComparer());
        for (int i = 0; i < mat.Length; i++)
        {
            queue.Enqueue(i, mat[i].Count(x => x == 1) * 10000 + i);
        }
        List<int> result = new();
        while (k-- > 0)
        {
            result.Add(queue.Dequeue());
        }
        return result.ToArray();
    }
}