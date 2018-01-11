using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Grand Circus Deliverable 2
//John Floreno
namespace DateDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            string dateFormat = "yyyy/MM/dd";
            string day1, day2;
            DateTime date1, date2;
            TimeSpan timeDiff;
            double days, hours, minutes;

            Console.WriteLine("Hello, please enter the first date: <YYYY/MM/DD>");
           
            if(DateTime.TryParseExact(Console.ReadLine(), dateFormat, CultureInfo.InvariantCulture, 
                DateTimeStyles.None, out date1))
            {
                Console.WriteLine("Please enter the second date: <YYYY/MM/DD>");
                if (DateTime.TryParseExact(Console.ReadLine(), dateFormat, CultureInfo.InvariantCulture,
                DateTimeStyles.None, out date2))
                {
                    timeDiff = (date1 - date2);
                    days = timeDiff.TotalDays;
                    hours = timeDiff.TotalHours;
                    minutes = timeDiff.TotalMinutes;
                    day1 = date1.ToString("yyyy/MM/dd");
                    day2 = date2.ToString("yyyy/MM/dd");

                    Console.WriteLine("The time between " + day1 + " and " + day2 + " is:");
                    Console.WriteLine("Days: " + Math.Abs(days));
                    Console.WriteLine("Hours: " + Math.Abs(hours));
                    Console.WriteLine("Minutes: " + Math.Abs(minutes));
                    Console.Read();

                }
                else
                {
                    Console.WriteLine("Invalid date format. Please start over.");
                    Console.Read();
                }


            }
            else
            {
                Console.WriteLine("Invalid date format. Please start over");
                Console.Read();
            }

        }
    }
}
