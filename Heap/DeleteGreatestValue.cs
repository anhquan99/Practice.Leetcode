namespace Application;
public partial class HeapSolution
{
    public int DeleteGreatestValue(int[][] grid)
    {
        foreach (var i in grid)
        {
            Array.Sort(i);
        }
        var result = 0;
        for (int i = 0; i < grid[0].Length; i++)
        {
            var max = grid[0][i];
            for (int j = 1; j < grid.Length; j++)
            {
                if (grid[j][i] > max)
                {
                    max = grid[j][i];
                }
            }
            result += max;
        }
        return result;
    }
}