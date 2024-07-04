namespace Application;

public partial class GraphSolution
{
    public ListNode MergeNodes(ListNode head)
    {
        if (head == null) return head;
        var node = new ListNode(head.val);
        var result = node;
        head = head.next;
        while (head != null)
        {
            if (head.val == 0 && head.next != null)
            {
                node.next = new ListNode(head.val);
                node = node.next;
            }
            else
            {
                node.val += head.val;
            }
            head = head.next;
        }
        return result;
    }
}