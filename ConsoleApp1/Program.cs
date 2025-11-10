

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
    public ListNode RemoveElements(ListNode head, int val)
    {
        ListNode dummy = new ListNode(0);
        dummy.Next = head;

        ListNode current = dummy;

        while (current.Next != null)
        {
            if (current.Next.Data == val)
            {
                current.Next = current.Next.Next;
            }
            else
            {
                current = current.Next;
            }
        }
        return dummy.Next;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Solution s = new Solution();
    }
}