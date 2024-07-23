namespace Application;
public partial class GraphSolution
{
    public int FindTheWinner(int n, int k)
    {
        if (n < 2) return 1;
        if (k == 1) return n;
        var root = new ListNode(1);
        var tmpNode = root;
        for (int i = 2; i <= n; i++)
        {
            var newNode = new ListNode(i);
            tmpNode.next = newNode;
            tmpNode = tmpNode.next;
        }
        tmpNode.next = root;
        tmpNode = root;
        var slow = tmpNode;
        while (tmpNode.next != null)
        {
            for (int i = 1; i < k && tmpNode.next != null; i++)
            {
                slow = tmpNode;
                tmpNode = tmpNode.next;
            }
            if (tmpNode.next == slow)
            {
                return slow.val;
            }
            else if (tmpNode.next != null)
            {
                slow.next = tmpNode.next;
                tmpNode = tmpNode.next;
            }
        }
        return tmpNode.val;
    }
}