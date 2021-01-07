using System;
using System.Collections.Generic;
using System.Globalization;

namespace DateTimeStruct
{
    class Program
    {
        static void Main(string[] args)
        {

            //Write a program counting in time interval non working days!  i used some help for this example from friends from softuni !!
            var startDate = DateTime.ParseExact(Console.ReadLine(),"dd.MM.yyyy", CultureInfo.InvariantCulture);
            var endDate = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture);
            var holidaysCount = 0;

            for (var date = startDate;  date <= endDate; date = date.AddDays(1))   // date Object is referencing the same place as startDate Object!
            {
                if (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday)
                {
                    holidaysCount++;
                }                
            }
            Console.WriteLine(holidaysCount);

        }
        
    }
}
