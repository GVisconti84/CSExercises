using System;

namespace CSExercises
{
    class Date
    {
        public int Month { get; set; }
        public int Day { get; set; }
        public int Year { get; set; }

        public Date (int day, int month, int year)
        {
            Month = month;
            Day = day;
            Year = year;
        }

        public void DisplayDate ()
        {
             Console.WriteLine("{0} / {1} / {2} ", Convert.ToString(Day), Convert.ToString(Month), Convert.ToString(Year));
        }
    }
}
