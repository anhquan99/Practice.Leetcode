namespace Application;
public partial class SearchSolution
{
    public int MaxDistance(int[] position, int m)
    {
        Array.Sort(position);
        int left = 1, right = position[position.Length - 1];
        while (left < right)
        {
            int mid = (left + right + 1) >> 1;
            if (CanPlaceBall(position, mid, m))
            {
                left = mid;
            }
            else
            {
                right = mid - 1;
            }
        }
        return left;
    }
    bool CanPlaceBall(int[] position, int distance, int m)
    {
        int prevPosition = position[0];
        int count = 1;
        for (int i = 0; i < position.Length; i++)
        {
            int currentPosition = position[i];
            if (currentPosition - prevPosition >= distance)
            {
                prevPosition = currentPosition;
                count++;
            }
        }
        return count >= m;
    }
}