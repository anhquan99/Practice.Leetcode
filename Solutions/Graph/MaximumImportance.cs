namespace Application;

public partial class GraphSolution
{
    public long MaximumImportance(int n, int[][] roads)
    {
        var degree = new int[n];
        foreach (var road in roads)
        {
            degree[road[0]]++;
            degree[road[1]]++;
        }
        Array.Sort(degree);

        long result = 0;
        for (int i = 0; i < degree.Length; i++)
        {
            result += (long)(i + 1) * degree[i];
        }
        return result;
    }
}