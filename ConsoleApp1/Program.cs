

public class Interval
{
    public int start;
    public int end;
    
    public Interval(int start, int end)
    {
        this.start = start;
        this.end = end;
    }
}

public class Solution()
{
    public int BinarySearch(int[] nums, int item)
    {
        int min = 0;
        int max = nums.Length - 1;

        while (min <= max)
        {
            int mid = (min + max) / 2;
            int guess = nums[mid];

            if (guess == item)
            {
                return guess;
            }else if (guess > item)
            {
                max = mid - 1;
            }
            else
            {
                max = mid + 1;
            }
        }

        return min;
    }
}


class Program
{
    static void Main(string[] args)
    {
        
    }
}