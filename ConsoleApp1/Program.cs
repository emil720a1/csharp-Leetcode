public class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;

    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}
public class Solution
{
    public void PreOrder(TreeNode node, int level, IList<int> result)
    {
        if (node == null)
        {
            return;
        }

        if (level == result.Count)
        {
            result.Add(0);
        }
        
        result[level] = node.val;
        
         PreOrder(node.left, level + 1, result);
         PreOrder(node.right, level + 1, result);
        
    }

    public IList<int> RightSideView(TreeNode root)
    {
        IList<int> result = new List<int>();
        
        PreOrder(root, 0, result);
        
        return result;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Solution s = new Solution();
    }
}