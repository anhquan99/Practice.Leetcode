namespace Application;
public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}
public partial class Solution
{
    public ListNode RemoveNthFromEnd(ListNode head, int n)
    {
        ListNode dummy = new(0, head), slow = dummy, fast = dummy;

        for (; n >= 0; n--)
            fast = fast.next;

        while (fast != null)
        {
            slow = slow.next;
            fast = fast.next;
        }

        slow.next = slow.next.next;

        return dummy.next;
    }
}