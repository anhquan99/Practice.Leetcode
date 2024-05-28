namespace Application;
public partial class GraphSolution
{
    public ListNode RemoveNodes(ListNode head)
    {
        var reverseNode = ReverseLinkedList(head);
        var result = reverseNode;
        var pre = result;
        var node = result.next;
        while (node != null)
        {
            if (node.val >= pre.val)
            {
                pre.next = node;
                pre = pre.next;
            }
            node = node.next;
        }
        pre.next = null;
        return ReverseLinkedList(result);
    }
    public ListNode ReverseLinkedList(ListNode head)
    {
        ListNode prev = null, curr = head, next = null;
        while (curr != null)
        {
            next = curr.next;
            curr.next = prev;
            prev = curr;
            curr = next;
        }
        return prev;
    }
}