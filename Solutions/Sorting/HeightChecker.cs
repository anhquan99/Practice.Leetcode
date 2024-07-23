namespace Application;
public partial class SortSolution
{
    public int HeightChecker(int[] heights)
    {
        int[] sortedHeigths = new int[heights.Length];
        Array.Copy(heights, sortedHeigths, heights.Length);
        Array.Sort(sortedHeigths);
        int count = 0;
        for (int i = 0; i < sortedHeigths.Length; i++)
        {
            if (heights[i] != sortedHeigths[i]) count++;
        }
        return count;

    }
}
