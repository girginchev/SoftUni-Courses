namespace Count_Work_Days
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Globalization;

    public class CountWorkDays
    {
        public static object Official { get; private set; }

        public static void Main()
        {
            var startDateAsString = Console.ReadLine();
            var endDateAsString = Console.ReadLine();

            var startDate = DateTime.ParseExact(startDateAsString, "dd-MM-yyyy", CultureInfo.InvariantCulture);
            var endDate = DateTime.ParseExact(endDateAsString, "dd-MM-yyyy", CultureInfo.InvariantCulture);

            var holidays = OfficialHolidays();
            var workingDaysCounter = 0;

            for (DateTime i = startDate; i <= endDate; i = i.AddDays(1))
            {
                if (!holidays.Any(x => x.Month == i.Month && x.Day == i.Day) && i.DayOfWeek != DayOfWeek.Saturday && i.DayOfWeek != DayOfWeek.Sunday)
                {
                    workingDaysCounter++;
                }
              
            }
            Console.WriteLine(workingDaysCounter);


        }

        private static List<DateTime> OfficialHolidays()
        {
            var holidays = new List<DateTime>();
            holidays.Add(DateTime.ParseExact("01-01", "dd-MM", CultureInfo.InvariantCulture));
            holidays.Add(DateTime.ParseExact("03-03", "dd-MM", CultureInfo.InvariantCulture));
            holidays.Add(DateTime.ParseExact("01-05", "dd-MM", CultureInfo.InvariantCulture));
            holidays.Add(DateTime.ParseExact("06-05", "dd-MM", CultureInfo.InvariantCulture));
            holidays.Add(DateTime.ParseExact("24-05", "dd-MM", CultureInfo.InvariantCulture));
            holidays.Add(DateTime.ParseExact("06-09", "dd-MM", CultureInfo.InvariantCulture));
            holidays.Add(DateTime.ParseExact("22-09", "dd-MM", CultureInfo.InvariantCulture));
            holidays.Add(DateTime.ParseExact("01-11", "dd-MM", CultureInfo.InvariantCulture));
            holidays.Add(DateTime.ParseExact("24-12", "dd-MM", CultureInfo.InvariantCulture));
            holidays.Add(DateTime.ParseExact("25-12", "dd-MM", CultureInfo.InvariantCulture));
            holidays.Add(DateTime.ParseExact("26-12", "dd-MM", CultureInfo.InvariantCulture));
            return holidays; 

        }
    }
}
