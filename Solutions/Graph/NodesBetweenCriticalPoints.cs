using System.Globalization;

namespace Application
{
    public partial class GraphSolution
    {
        public int[] NodesBetweenCriticalPoints(ListNode head)
        {
            var resultArr = new List<int>();
            var index = 1;
            var minDistance = int.MaxValue;
            while (head != null && head.next != null && head.next.next != null)
            {
                if (IsLocalMaxima(head) || IsLocalMinima(head))
                {
                    if (resultArr.Count <= 2) resultArr.Add(index);
                    else
                    {
                        resultArr[1] = resultArr[2];
                        resultArr[2] = index;
                    }
                    if (resultArr.Count > 1)
                    {
                        minDistance = Math.Min(minDistance, resultArr[^1] - resultArr[resultArr.Count - 2]);
                    }
                }
                index++;
                head = head.next;
            }
            if (resultArr.Count < 2) return [-1, -1];
            return [minDistance, resultArr[^1] - resultArr[0]];
        }
        bool IsLocalMaxima(ListNode prev)
        {
            return prev.val < prev.next.val && prev.next.val > prev.next.next.val;
        }
        bool IsLocalMinima(ListNode prev)
        {
            return prev.val > prev.next.val && prev.next.val < prev.next.next.val;
        }
    }
}