namespace Application
{
    public partial class GraphSolution
    {
        public int IslandPerimeter(int[][] grid)
        {
            bool[,] visited = new bool[grid.Length, grid[0].Length];
            int sum = 0;
            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[i].Length; j++)
                {
                    if (grid[i][j] == 1)
                    {
                        if (i == 0) sum++;
                        else if (grid[i - 1][j] == 0) sum++;
                        if (i == grid.Length - 1) sum++;
                        else if (grid[i + 1][j] == 0) sum++;
                        if (j == 0) sum++;
                        else if (grid[i][j - 1] == 0) sum++;
                        if (j == grid[i].Length - 1) sum++;
                        else if (grid[i][j + 1] == 0) sum++;
                        visited[i, j] = true;
                    }
                }
            }
            GC.Collect();
            return sum;
        }
    }
}