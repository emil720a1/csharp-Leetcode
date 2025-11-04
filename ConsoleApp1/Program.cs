
public class Solution {
    public bool IsPalindrome(int x)
    {
       var a = x.ToString().ToCharArray();
        for (int first = 0, last = a.Length - 1; first < last; ++first, --last)
        {
            if (a[first] != a[last])
            {
                return false;
            }
        }
      
        return true;
    }
}
class Program
{
    static void Main(string[] args)
    {
        Solution s = new Solution();
        Console.WriteLine(s.IsPalindrome(123123));
    }
}