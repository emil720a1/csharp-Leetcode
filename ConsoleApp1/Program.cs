

public class Solution 
{
    public int[] PlusOne(int[] digits) 
    {
        for(int i = digits.Length - 1; i >= 0; i--)
        {
            if(digits[i] == 9)
            {
                digits[i] = 0;
                continue;
            }
            else
            {
                digits[i]++;
                return digits;
            }
        }

        int[] overflowed = new int[digits.Length + 1];
        overflowed[0] = 1;
        return overflowed;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Solution s = new Solution();
        Console.WriteLine(s.PlusOne([9]));
    }
}