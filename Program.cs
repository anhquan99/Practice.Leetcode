using Application;

Solution s = new Solution();
var example = new[] { 1, 2, 3, 4, 5 };
var index = 0;
var head = new ListNode(example[index]);
var temp = head;
for (int i = 1; i < example.Length; i++)
{
    temp.next = new ListNode(example[i]);
    temp = temp.next;
}
s.RemoveNthFromEnd(head, 2);