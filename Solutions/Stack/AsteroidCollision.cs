using System.Text;

namespace Application;
public partial class StackSolution
{
    public int[] AsteroidCollision(int[] asteroids)
    {
        var stack = new Stack<int>();
        foreach (var asteroid in asteroids)
        {
            if (asteroid > 0)
            {
                stack.Push(asteroid);
            }
            else
            {
                while (stack.Count > 0 && stack.Peek() > 0 && stack.Peek() < Math.Abs(asteroid))
                {
                    stack.Pop();
                }
                if (stack.Count > 0 && stack.Peek() == Math.Abs(asteroid))
                {
                    stack.Pop();
                }
                else if (stack.Count == 0 || stack.Peek() < 0)
                {
                    stack.Push(asteroid);
                }
            }
        }
        var result = new int[stack.Count];
        var index = stack.Count - 1;
        while (stack.Count > 0)
        {
            result[index--] = stack.Pop();
        }
        return result;
    }
}