using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_OOP_3
{
    public class Duration
    {
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }
        public Duration(int hours, int minutes, int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }
        public Duration(int TotalSeconds)
        {
            Hours = TotalSeconds / 3600;
            Minutes = (TotalSeconds % 3600) / 60;
            Seconds = TotalSeconds % 60;
        }
        public override int GetHashCode()
        {
            return Hours.GetHashCode() ^ Minutes.GetHashCode() ^ Seconds.GetHashCode();
        }
        public override string ToString()
        {
            return $"Hours is {Hours}, Minutes is {Minutes}, Seconds is {Seconds}";
        }

        public static Duration operator +(Duration d1, Duration d2)
        {
            int totalSeconds = (d1.Hours * 3600 + d1.Minutes * 60 + d1.Seconds) + (d2.Hours * 3600 + d2.Minutes * 60 + d2.Seconds);
            return new Duration(totalSeconds);
        }

        public static Duration operator +(Duration d1, int seconds)
        {
            int totalSeconds = (d1.Hours * 3600 + d1.Minutes * 60 + d1.Seconds) + seconds;
            return new Duration(totalSeconds);
        }
 
        public static Duration operator ++(Duration d)
        {
            int totalSeconds = (d.Hours * 3600 + d.Minutes * 60 + d.Seconds) + 60;  
            return new Duration(totalSeconds);
        }

        public static Duration operator --(Duration d)
        {
            int totalSeconds = (d.Hours * 3600 + d.Minutes * 60 + d.Seconds) - 60; 
            return new Duration(totalSeconds);
        }

        public static Duration operator -(Duration d1, Duration d2)
        {
            int totalSeconds = (d1.Hours * 3600 + d1.Minutes * 60 + d1.Seconds) - (d2.Hours * 3600 + d2.Minutes * 60 + d2.Seconds);
            return new Duration(totalSeconds);
        }
        public static bool operator >(Duration d1, Duration d2)
        {
            return d1.Hours > d2.Hours || d1.Minutes > d2.Minutes || d1.Seconds > d2.Seconds;
        }
        public static bool operator <(Duration d1, Duration d2)
        {
            return d1.Hours < d2.Hours || d1.Minutes < d2.Minutes || d1.Seconds < d2.Seconds;
        }
        public static bool operator >=(Duration d1, Duration d2)
        {
            return d1.Hours >= d2.Hours || d1.Minutes >= d2.Minutes || d1.Seconds >= d2.Seconds;
        }
        public static bool operator <=(Duration d1, Duration d2)
        {
            return d1.Hours <= d2.Hours || d1.Minutes <= d2.Minutes || d1.Seconds <= d2.Seconds;
        }



    }

}
