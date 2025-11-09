

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
    public bool IsPalindrome(ListNode head)
    {
         ListNode first_half_end_node = middleNode(head);
         ListNode second_half_begin_node = reverseList(first_half_end_node);
         
         //     p1          p2
         // in: 1 ->  2  -> 3
        // out: 1 ->  2  <- 3 
        
        
        //     p1             p2
        // in: 1 -> 2 -> 3 -> 4
        // out:1 -> 2 <- 3 <- 4
        //              /
        //        null<|
        
        
         ListNode p1 = head;
         ListNode p2 = second_half_begin_node;

         while (p1 != null && p2 != null)
         {
             if (p1.Data != p2.Data)
             {
                 return false;
             }

             p1 = p1.Next;
             p2 = p2.Next;
         }
         return true;
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