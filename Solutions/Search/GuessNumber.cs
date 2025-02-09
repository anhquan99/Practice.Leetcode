namespace Application;
public partial class SearchSolution
{
    private int _picked = 0;
    public int GuessNumber(int n)
    {
        var left = 0;
        var right = n;

        while (left <= right)
        {
            var mid = left + (right - left) / 2;
            var result = guess(mid);
            if (result == 0)
            {
                return mid;
            }
            else if (result == -1)
            {
                right = mid - 1;
            }
            else
            {
                left = mid + 1;
            }
        }

        throw new InvalidOperationException();
    }
    private int guess(int n)
    {
        if (_picked == 0)
        {
            var rand = new Random();
            _picked = rand.Next(1000);
        }
        if (n > _picked) return -1;
        else if (n < _picked) return 1;
        return 0;
    }
    public void SetPicked(int n)
    {
        _picked = n;
    }

}