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
    public bool IsSameTree(TreeNode p, TreeNode q)
    {
        if (p == null || q == null)
        {
            return p == null && q == null;
        }

        if (p.val != q.val)
        {
            return false;
        }
       
        return IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right);
    }

}

class Program
{
    static void Main(string[] args)
    {
        Solution s = new Solution();
    }
}