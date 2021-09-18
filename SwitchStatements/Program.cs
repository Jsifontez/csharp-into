using System;

namespace SwitchStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetDay(80));
            Console.ReadLine();
        }

        static string GetDay(int dayNum) {
            string dayName;

            // the switch statement compare the value that put in the parenthesis again a bunch of options
            switch (dayNum)
            {
                case 0:
                    dayName = "Sunday";
                    break;
                case 1:
                    dayName = "Monday";
                    break;
                case 2:
                    dayName = "Tuesday";
                    break;
                case 3:
                    dayName = "Wednesday";
                    break;
                case 4:
                    dayName = "Thursday";
                    break;
                case 5:
                    dayName = "Friday";
                    break;
                case 6:
                    dayName = "Saturday";
                    break;
                default: // this is in case the user type a invalid day number
                    dayName = "Invalid Name Number";
                    break;
            }
            return dayName;
        }
    }
}
