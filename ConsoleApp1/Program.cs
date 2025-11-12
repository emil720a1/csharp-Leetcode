using System.Runtime.InteropServices.ComTypes;

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
    private bool IsLeaf(TreeNode node)
    {
        return node.left == null && node.right == null;
    }


    public bool HasPathSum(TreeNode root, int targetSum)
    {
        return HasSum(root, 0, targetSum);
    }


    private bool HasSum(TreeNode node, int currSum, int targetSum)
    {
        if (node == null) return false;

        int newCurrSum = currSum + node.val;

        if (IsLeaf(node) && newCurrSum == targetSum)
        {
            return true;
        }
        
        bool isLeftSubtreeHasSum = HasSum(node.left, newCurrSum, targetSum);
        bool isRightSubtreeHasSum = HasSum(node.right, newCurrSum, targetSum);
        
        return isLeftSubtreeHasSum || isRightSubtreeHasSum;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Solution s = new Solution();
    }
}