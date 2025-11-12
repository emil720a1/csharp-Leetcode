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
    public IList<IList<int>>PreOrder(TreeNode node, int level, IList<IList<int>> levels)
    {
        if (node == null)
        {
            return levels;
        }

        if (level == levels.Count)
        {
            levels.Add(new List<int>());
        }
        
        levels[level].Add(node.val);
        
        levels = PreOrder(node.left, level + 1, levels);
        levels = PreOrder(node.right, level + 1, levels);
        
        return levels;
    }

    public IList<IList<int>> LevelOrder(TreeNode root)
    {
        IList<IList<int>> levels = new List<IList<int>>();
        
        return PreOrder(root, 0, levels);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Solution s = new Solution();
    }
}