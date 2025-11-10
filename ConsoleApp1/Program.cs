
public class ListNode
{
    public int val;
    public ListNode next;

    public ListNode(int x)
    {
        val = x;
        next = null;
    }
}

public class Solution
    {
        public bool HasCycle(ListNode head)
        {
            if (head == null || head.next == null) return false;

            ListNode fast = head;
            ListNode slow = head;

            while (fast != null && fast.next != null)
            {
                fast = fast.next.next;
                slow = slow.next;

                if (fast == slow) return true;
            }

            return false;

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            s.HasCycle(null);

        }
    }
