

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


    public ListNode ReverseList2(ListNode head)
    {
        
        
        
        // 1 -> 2 -> 3 -> 4 -> 5 -> null
        
         // через несколько шагов он будет таким 
         // <- 1 <- 2        3 -> 4 -> 5 -> null
         //        prev      curr 
        
        
        
        ListNode prev = null; 
        ListNode curr = head;

        while (curr != null)
        {
            var tmp = curr;
            curr = curr.Next;
            tmp.Next = prev;
            prev = tmp;
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