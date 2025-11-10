

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
    public bool CanAttendMeetings(Interval[] intervals)
    {
        Array.Sort(intervals, (a, b) => a.start.CompareTo(b.start));


        for (int i = 0; i < intervals.Length - 1; i++)
        {
            if (intervals[i].end > intervals[i + 1].start)
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
        
    }
}