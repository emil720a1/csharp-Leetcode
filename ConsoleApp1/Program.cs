

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
      
      
      // Изначально это было мое решение, а второе это из курса по алгоритмам что я смотрел
      public ListNode RemoveNthFromEnd(ListNode head, int n)
      {
          ListNode dummy = new ListNode(0);

          dummy.next = head;
          ListNode first = dummy;

          for (int i = 0; i <= n; i++)
          {
              first = first.next;
          }
          ListNode second = dummy;

          while (first != null)
          {
              first = first.next;
              second = second.next;
          }
          
          second.next = second.next.next;
          return dummy.next;
      }


      public ListNode RemoveNthFromEnd2(ListNode head, int n)
      {
          var dummyNode = new ListNode(0);
          
          
          int length = 0;
          dummyNode.next = head;
          var current = dummyNode;
          while (current != null)
          {
              current = current.next;
              length++;
          }
          
          current = dummyNode;
          for (int i = 0; i < length - n - 1; i++)
          {
              current = current.next;
          }
          
          current.next = current.next.next;
          
          return dummyNode.next;

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