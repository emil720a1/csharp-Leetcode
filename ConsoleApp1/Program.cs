

public class ListNode
{
    public int Data;
    public ListNode Next;

    public ListNode(int data)
    {
        Data = data;
        Next = null;
    }
}

public class Solution
{ 
    public ListNode ReverseList(ListNode head)
    {
        ListNode curr = head;
        ListNode prev = null;
        ListNode next;

        while (curr != null)
        {
            next = curr.Next;
            curr.Next = prev;
            
            
            prev = curr;
            curr = next;
        }
        return prev;
    }

}
class Program
{
    static void Main(string[] args)
    {
        Solution s = new Solution();
    }
}