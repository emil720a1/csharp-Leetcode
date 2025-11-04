
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


    public bool IsPalindrome2(int x)
    {
            if (x < 0 || (x % 10 == 0 && x != 0)) return false;

            int temp = x;
            int rev = 0;

            while (temp > 0) {
                int digit = temp % 10;
                rev = rev * 10 + digit;
                temp /= 10;
            }

            return rev == x;
        }
}
class Program
{
    static void Main(string[] args)
    {
        Solution s = new Solution();
        Console.WriteLine(s.IsPalindrome(123123));
        
        
        Console.WriteLine(s.IsPalindrome2("ahhe"));
    }
}