

public class Solution {
    public int SearchInsert(int[] nums, int target)
    {
        var min = 0;
        var max = nums.Length - 1;
        while (min <= max)
        {
            var mid = (min + max) / 2;
            var found = nums[mid];
            if (found == target)
            {
                return mid;
            }
            else if (found > target)
            {
                max = mid - 1; // Search in the right half
            }
            else
            {
                min = mid + 1; // Search in the left half
            }
        }
        return min;
    }
}


class Program
{
    static void Main(string[] args)
    {
        Solution s = new Solution();
        Console.WriteLine(s.SearchInsert([1,3,5,6], 2));
    }
}