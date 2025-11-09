

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
    // f 
    // 1 -> 2 -> 3 -> 4 -> 5 -> null
    // s
    
    //           f
    // 1 -> 2 -> 3 -> 4 -> 5 -> null
    // s
    
    
    //                     f
    // 1 -> 2 -> 3 -> 4 -> 5 -> null
    //           s
    public ListNode middleNode(ListNode head)
    {
        ListNode slow = head;
        ListNode fast = head;

        while (fast != null && fast.Next != null)
        {
            slow = slow.Next;
            fast = fast.Next.Next;
        }
        return slow;
    }
}
class Program
{
    static void Main(string[] args)
    {
        Solution s = new Solution();
    }
}