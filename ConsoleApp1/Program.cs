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
    private void Traverse(TreeNode node, IList<int> result)
    {
        if (node == null)
        {
            return;
        }
        
        result.Add(node.val);
        Traverse(node.left, result);
        Traverse(node.right, result);
    }
    
    public IList<int> PreorderTraversal(TreeNode root)
    {
        IList<int> result = new List<int>();
        Traverse(root, result);
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