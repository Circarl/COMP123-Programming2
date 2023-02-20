
namespace Theatre_Assignment
{
    struct Time
    {
        public int Hours { get; }
        public int Minutes { get; }
        public Time(int hours, int minutes = 0)
        {
            Hours = hours;
            Minutes = minutes;
        }
        public override string ToString()
        {
            return $"{Hours:00}:{Minutes:00}";
        }
        public static bool operator ==(Time lhs, Time rhs)
        {
            int lhsHrs_Min = lhs.Hours * 60;
            int rhsHrs_Min = rhs.Hours * 60;
            int lhsTime = lhsHrs_Min + lhs.Minutes;
            int rhsTime = rhsHrs_Min + rhs.Minutes;
            if (Math.Abs(lhsTime - rhsTime) <= 15)
                return true;
            else
                return false;
        }
        public static bool operator !=(Time lhs, Time rhs)
        {
            return !(lhs == rhs);
        }
    }
}