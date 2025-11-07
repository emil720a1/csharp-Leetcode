

  using System.Collections;

  public class ListNode {
      public int val;
      public ListNode next;
      public ListNode(int val=0, ListNode next=null) {
          this.val = val;
         this.next = next;
      }
  }
  

public class Solution {
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        if (list1 == null) return list2;
        if (list2 == null) return list1;
        if (list1 == null && list2 == null) return null;
        
        List<int> newList = new List<int>();
        while (list1 != null)
        {
            newList.Add(list1.val);
            list1 = list1.next;
        }

        while (list2 != null)
        {
            newList.Add(list2.val);
            list2 = list2.next;
        }

        newList.Sort();

        ListNode dummy = new ListNode(-1);
        ListNode current = dummy;

        foreach (int i in newList)
        {
            current.next = new ListNode(i);
            current = current.next;
        }

        return dummy.next;

    }
}

class Program
{
    static void Main(string[] args)
    {
        
        ListNode list1 = new ListNode(1, new ListNode(2, new ListNode(4)));
        ListNode list2 = new ListNode(1, new ListNode(3, new ListNode(4)));

        Solution solution = new Solution();

        solution.MergeTwoLists(list1, list2);

    }
}