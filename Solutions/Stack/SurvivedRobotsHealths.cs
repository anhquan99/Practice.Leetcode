namespace Application;
public partial class StackSolution
{
    class Robot
    {
        public int Index { get; set; }
        public int Health { get; set; }
        public int Position { get; set; }
        public char Direction { get; set; }
        public Robot(int index, int health, int position, char direction)
        {
            Index = index;
            Health = health;
            Position = position;
            Direction = direction;
        }
    }
    public IList<int> SurvivedRobotsHealths(int[] positions, int[] healths, string directions)
    {
        var stack = new Stack<Robot>();
        List<Robot> robots = new List<Robot>();
        for (int i = 0; i < positions.Length; i++)
        {
            robots.Add(new Robot(i, healths[i], positions[i], directions[i]));
        }
        robots = robots.OrderBy(r => r.Position).ToList();
        foreach (var i in robots)
        {
            if (i.Direction == 'R')
            {
                stack.Push(i);
                continue;
            }
            Collide(stack, i);
            if (i.Health > 0)
            {
                stack.Push(i);
            }
        }
        return GetRobots(stack);
    }
    void Collide(Stack<Robot> stack, Robot robot)
    {
        while (stack.Count > 0 && stack.Peek().Direction == 'R' && robot.Health > 0)
        {
            if (stack.Peek().Health > robot.Health)
            {
                stack.Peek().Health--;
                robot.Health = 0;
            }
            else if (stack.Peek().Health < robot.Health)
            {
                stack.Pop();
                robot.Health--;
            }
            else
            {
                robot.Health = 0;
                stack.Pop();
            }
        }
    }
    List<int> GetRobots(Stack<Robot> stack)
    {
        var result = new List<int>();
        var robots = stack.ToList();
        return robots.OrderBy(x => x.Index).Select(x => x.Health).ToList();
    }
}