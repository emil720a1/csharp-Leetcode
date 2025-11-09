

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

    public ListNode reorderList(ListNode head)
    {
        ListNode tmp = preMiddleNode(head);
        // in: 1 -> 2 -> 3-> 4 -> 5 ->
        //              tmp
        ListNode p2 = reverseList(tmp.Next);
        // curr: 1 -> 2 -> 3 -> 4 <- 5
        //                     /    p2
        //               Null <
        
        tmp.Next = null;
        // p1: 1 -> 2 -> 3 -> None
        // p2: 5 -> 4 -> None
        
        ListNode newHead = head;
        ListNode p1 = head;

        while (p2 != null)
        {
            // ListNode temp1 = p1.Next;
            // ListNode temp2 = p2.Next;
            
            p1.Next = p1.Next;
            p1.Next = p2;
            p1 = p2;
            p2 = p1.Next;
        }
        return newHead;
    }

    public ListNode reverseList(ListNode head)
    {
        ListNode prev = null;
        ListNode curr = head;

        while (curr != null)
        {
            ListNode temp = curr;
            curr = curr.Next;
            temp.Next = prev;
            prev = temp;
        }
        return prev;
    }
    
    
    public ListNode preMiddleNode(ListNode head)
    {
        ListNode slow = head;
        ListNode fast = head;

        while (fast != null && fast.Next != null && fast.Next.Next != null)
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