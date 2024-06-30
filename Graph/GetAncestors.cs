namespace Application;

public partial class GraphSolution
{
    List<IList<int>> AncestorsResult;
    public IList<IList<int>> GetAncestors(int n, int[][] edges)
    {
        var paths = new List<List<int>>();
        AncestorsResult = new List<IList<int>>();
        var visited = new bool[n];
        for (int i = 0; i < n; i++)
        {
            paths.Add(new List<int>());
            AncestorsResult.Add(new List<int>());
        }
        foreach (var edge in edges)
        {
            paths[edge[0]].Add(edge[1]);
        }
        for (int i = 0; i < n; i++)
        {
            DFS(i, paths);
            ResetVisited(visited);
        }
        // var result = new List<IList<int>>();
        // foreach (var i in AncestorsResult)
        // {
        //     var tmp = i.ToList();
        //     tmp.Sort();
        //     result.Add(tmp);
        // }
        return AncestorsResult;
    }
    void DFS(int node, List<List<int>> paths)
    {
        var queue = new Queue<int>();
        queue.Enqueue(node);
        var visited = new bool[paths.Count];
        visited[node] = true;
        while (queue.Count > 0)
        {
            var currentNode = queue.Dequeue();
            foreach (var i in paths[currentNode])
            {
                if (visited[i]) continue;
                visited[i] = true;
                queue.Enqueue(i);
                AncestorsResult[i].Add(node);
            }
        }
    }
    void ResetVisited(bool[] visted)
    {
        for (int i = 0; i < visted.Length; i++)
        {
            visted[i] = false;
        }
    }
}