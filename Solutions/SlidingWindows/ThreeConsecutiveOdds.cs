namespace Application;
public partial class SlidingWindowsSolution
{
    public bool ThreeConsecutiveOdds(int[] arr)
    {
        int odd = 0, i = 0;
        for (; i < 3 && i < arr.Length; i++)
        {
            if (arr[i] % 2 == 1) odd++;
        }
        if (odd == 3) return true;
        for (; i < arr.Length; i++)
        {
            if ((arr[i] % 2) == 1) odd++;
            if (arr[i - 3] % 2 == 1) odd--;
            if (odd >= 3) return true;
        }
        return false;
    }
}