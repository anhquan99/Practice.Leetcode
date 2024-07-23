
namespace Application;
public partial class SortSolution
{
    public bool IsNStraightHand(int[] hand, int groupSize)
    {
        if (hand.Length % groupSize != 0) return false;
        Array.Sort(hand);
        var list = hand.ToList();
        var dic = new Dictionary<int, int>();
        for (int i = 0; i < (hand.Length / groupSize); i++)
        {
            dic.Add(i, -1);
        }
        dic[0] = hand[0];
        list.RemoveAt(0);
        int turn = 0;
        while (list.Count > 0 && turn < dic.Count)
        {
            int index = 0;
            int i = 0;
            if (turn == 0) i = 1;
            for (; i < groupSize; i++)
            {
                while (index < list.Count && dic[turn] >= list[index])
                {
                    index++;
                }
                if (index == list.Count || (i != 0 && dic[turn] + 1 != list[index])) return false;
                if (dic[turn] < list[index])
                {
                    dic[turn] = list[index];
                    list.RemoveAt(index);
                }
            }
            turn++;
        }
        return true;
    }
}