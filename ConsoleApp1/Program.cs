

  public class ListNode { 
      public int val;
      public ListNode next;
      public ListNode(int val=0, ListNode next=null) {
         this.val = val;
        this.next = next;
      }
  }

  public class Solution
  {
      public ListNode RemoveNthFromEnd(ListNode head, int n)
      {
          ListNode dummy = new ListNode(0);

          dummy.next = head;
          ListNode first = dummy;
          ListNode second = dummy;

          for (int i = 0; i <= n; i++)
          {
              first = first.next;
          }

          while (first != null)
          {
              first = first.next;
              second = second.next;
          }
          
          second.next = second.next.next;
          return dummy.next;
      }

      public void printList(ListNode head)
      {
          while (head != null)
          {
              Console.Write(head.val + " -> ");
              head = head.next;
          }

          Console.WriteLine("null");
      }
  }

  class Program
{
    static void Main(string[] args)
    {
        
        ListNode head = new ListNode(1);
        head.next = new ListNode(2);
        head.next.next = new ListNode(3);
        head.next.next.next = new ListNode(4);
        head.next.next.next.next = new ListNode(5);

        int n = 1;
        
        Solution s = new Solution();
        head = s.RemoveNthFromEnd(head, n);
        
       s.printList(head);
        
        
    }
}