using System.Diagnostics.Metrics;

namespace Application
{
    public partial class Solution
    {
        public bool ValidPath(int n, int[][] edges, int source, int destination)
        {
            if (edges.Length == 0 || edges[0].Length == 0) return true;
            var stack = new Stack<int>();
            var visited = new List<int>();
            var list = BuildArrary(n, edges);
            stack.Push(source);
            while (stack.Count > 0)
            {
                var temp = stack.Pop();
                visited.Add(temp);
                if (list[temp].Contains(destination)) return true;
                foreach (var i in list[temp])
                {
                    if (!visited.Contains(i)) stack.Push(i);
                }
            }
            return false;
        }
        private List<List<int>> BuildArrary(int n, int[][] edges)
        {
            var list = new List<List<int>>();
            for (int i = 0; i < n; i++)
            {
                list.Add(new List<int>());
            }
            foreach (var i in edges)
            {
                list[i[0]].Add(i[1]);
                list[i[1]].Add(i[0]);
            }
            return list;
        }

        // public bool ValidPath(int n, int[][] edges, int source, int destination) {
        //     var root = new int[n];
        //     for (int i = 0; i < n; i++) root[i] = i;

        //     for (int i = 0; i < edges.Length; i++) {
        //         Union(root, edges[i][0], edges[i][1]);
        //     }

        //         return Find(root, source) == Find(root, destination);
        // }

        // private static int Find(int[] root, int x)
        // {
        //     if (root[x] == x) return x;
        //     return root[x] = Find(root, root[x]);
        // }

        // private static void Union(int[] root, int x, int y)
        // {
        //     var rootX = Find(root, x);
        //     var rootY = Find(root, y);

        //     root[rootX] = rootY;
        // }
    }
}