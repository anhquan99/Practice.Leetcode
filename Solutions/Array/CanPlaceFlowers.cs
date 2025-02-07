namespace Application;

public partial class ArraySolution
{
    public bool CanPlaceFlowers(int[] flowerbed, int n)
    {
        var start = 0;
        if (flowerbed.Length > 2 && flowerbed[0] == 1)
        {
            start = 2;
        }
        for (int i = start; i <= flowerbed.Length - 1 && n > 0;)
        {
            if (flowerbed[i] == 1)
            {
                i += 2;
                continue;
            }
            if (i <= flowerbed.Length - 2 && flowerbed[i + 1] == 1)
            {
                i = i + 3;
                continue;
            }
            i += 2;
            n--;
        }
        return n == 0;
    }
}