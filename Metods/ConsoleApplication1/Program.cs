using System;
using System.Globalization;


namespace _10_Date_Modifier
{
    // Create a class DateModifier which stores the difference of the days between two Dates.It should have a method which takes two string parameters 
    // representing a date as strings and calculates the difference in the days between them. 

    public class DataModifier
    {
        public static TimeSpan GetDifferenceDaysBetweenTwoDates(string dateFirst, string dateSecond)
        {
            DateTime dateTimeFirst = ParseStringToDate(dateFirst);
            DateTime dateTimeSecond = ParseStringToDate(dateSecond);

            var days =  dateTimeSecond - dateTimeFirst;

            return days;
        }

        private static DateTime ParseStringToDate(string dateInput)
        {
            string[] data = dateInput.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            int year = int.Parse(data[0]);
            int month = int.Parse(data[1]);
            int day = int.Parse(data[2]);

            DateTime date = new DateTime(year, month, day);

            return date;
        }
    }

    public class DateModifierMain
    {
        public static void Main()
        {
            string dateFirst = Console.ReadLine();
            string dateSecond = Console.ReadLine();
            int day = (DataModifier.GetDifferenceDaysBetweenTwoDates(dateFirst, dateSecond)).Days;
            Console.WriteLine(Math.Abs(day));
        }
    }
}
