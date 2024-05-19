namespace Application;
public partial class Solution
{
    public bool SatisfiesConditions(int[][] grid)
    {
        if (grid.Length == 0 || (grid.Length == 1 && grid[0].Length > 1)) return false;
        if (grid.Length == 1 && grid[0].Length == 1) return true;
        for (int i = 0; i < grid.Length - 1; i++)
        {
            for (int j = 0; j < grid[i].Length; j++)
            {
                if (j != grid[i].Length - 1)
                {
                    if (grid[i][j] != grid[i + 1][j] || grid[i][j] == grid[i][j + 1]) return false;
                }
                else if (grid[i][j] != grid[i + 1][j]) return false;
            }
        }
        return true;
    }
}