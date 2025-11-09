

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


public class Solution()
{

// bad code
    public ListNode MergeKListsBAD(IList<ListNode> lists)
    {
        int minNodeIdx = GetMinNodeIndex(lists);
        if (minNodeIdx == -1)
        {
            return null;
        }
        
        ListNode head = lists[minNodeIdx];
        
        lists[minNodeIdx] = lists[minNodeIdx].Next;

        ListNode curr = head;

        while (true)
        {
            minNodeIdx = GetMinNodeIndex(lists);

            if (minNodeIdx == -1)
            {
                curr.Next = null;
                break;
            }
            
            curr.Next = lists[minNodeIdx];
            curr = curr.Next;
            
            lists[minNodeIdx] = lists[minNodeIdx].Next;
        }
        return head;
    }


    public ListNode MergeKLists(IList<ListNode> lists)
    {
        ListNode dummy = new ListNode(0);
        ListNode curr = dummy;

        while (true)
        {
            int minNodeIdx = GetMinNodeIndex(lists);
            if (minNodeIdx == null)
            {
                curr.Next = null;
                break;
            }
            curr.Next = lists[minNodeIdx];
            curr = curr.Next;
            lists[minNodeIdx] = lists[minNodeIdx].Next;
            
        }
        return dummy.Next;
    }
    
    

    private int GetMinNodeIndex(IList<ListNode> lists)
    {
        double minListVal = double.PositiveInfinity;
        int minListIndex = -1;

        for (int i = 0; i < lists.Count; i++)
        {
            ListNode currentNode = lists[i];

            if (currentNode == null)
            {
                continue;
            }

            if ((double)currentNode.Data < minListVal)
            {
                minListVal = currentNode.Data;
                minListIndex = i;
            }
        }

        if (minListVal == double.PositiveInfinity)
        {
            return -1;
        }
        
        return minListIndex;
    }
    
}



class Program
{
    static void Main(string[] args)
    {
    }
}