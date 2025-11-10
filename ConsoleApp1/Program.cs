



public class Solution()
{
    public int peakIndexMountainArray(int[] arr)
    {
        int left = 0;
        int right = arr.Length - 1;

        while (left <= right)
        {
            int mid = (left + right) / 2;

            if (arr[mid] < arr[mid + 1])
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }
        return left;
    }

}


class Program
{
    static void Main(string[] args)
    {
        
    }
}