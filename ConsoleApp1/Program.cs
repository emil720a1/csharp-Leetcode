

  public class ListNode {
      public int val;
      public ListNode next;
     public ListNode(int val=0, ListNode next=null) {
          this.val = val;
         this.next = next;
      }
  }
 
public class Solution {
    public ListNode DeleteDuplicates(ListNode head) {
        ListNode curr1 = head;

        while (curr1 != null)
        {
            ListNode curr2 = curr1;

            while (curr2.next != null)
            {
                if (curr2.next.val == curr1.val)
                {
                    curr2.next = curr2.next.next;
                }
                else
                {
                    curr2 = curr2.next;
                }
            }
            
            curr1 = curr1.next;
        }
        return head;
    }
}
class Program
{
    static void Main(string[] args)
    {
        Solution s = new Solution();

        ListNode l = new ListNode(1, new ListNode(1, new ListNode(2)));
    }
}