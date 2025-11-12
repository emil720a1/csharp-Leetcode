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

    private bool Check(TreeNode l, TreeNode r)
    {
        if (l == null || r == null)
        {
            return l == null && r == null;
        }

        if (l.val != r.val) return false;

        bool outerSymmetric = Check(l.left, r.right);
        bool innerSymmetric = Check(l.right, r.left);

        return outerSymmetric && innerSymmetric;
    }
    
    public bool IsSymmetric(TreeNode root)
    {
        if (root == null) return true;
        
        return Check(root.left, root.right);
    }

}

class Program
{
    static void Main(string[] args)
    {
        Solution s = new Solution();
    }
}