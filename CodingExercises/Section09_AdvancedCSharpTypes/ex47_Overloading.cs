using System;

namespace Coding.Exercise
{
    public struct Time
    {
        public int Hour { get; }
        public int Minute { get; }
    
        public Time(int hour, int minute)
        {
            if (hour < 0 || hour > 23)
            {
                throw new ArgumentOutOfRangeException(
                    "Hour is out of range of 0-23");
            }
            if (minute < 0 || minute > 59)
            {
                throw new ArgumentOutOfRangeException(
                    "Minute is out of range of 0-59");
            }
            Hour = hour;
            Minute = minute;
        }
    
        public override string ToString() =>
            $"{Hour.ToString("00")}:{Minute.ToString("00")}";
    
        public static bool operator ==(Time time, Time other) =>
            time.Hour == other.Hour &&
            time.Minute == other.Minute;
            
        public static bool operator !=(Time time, Time other) =>
            !(time == other);
            
        public static Time operator +(Time time, Time other)
        {
            var hour = (time.Hour + other.Hour) % 24;
            var minute = (time.Minute + other.Minute);
            if (minute > 59)
            {
                hour++;
                minute %= 60;
            }
            hour %= 24;
            return new Time(hour, minute);
        }
    }

}
