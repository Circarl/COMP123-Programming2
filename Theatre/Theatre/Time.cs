
namespace Theatre_Assignment
{
    class Time
    {
        public int Hours { get; private set; }
        public int Minutes { get; private set; }

        public Time(int hours, int minutes)
            => (Hours, Minutes) = (hours, minutes);
        public static Boolean operator ==(Time lhs, Time rhs)
        {
            if (lhs.Hours + rhs.Hours + lhs.Minutes + rhs.Minutes <= 15)
                return true;
            else
                return false;
        }
        public static Boolean operator !=(Time lhs, Time rhs)
        {
            return false;
        }
        public override string ToString()
        {
            return $"{Hours:D2}:{Minutes:D2} ";
        }
    }
}