/*Problem 14.* Current Date and Time

    Create a console application that prints the current date and time. Find out how in Internet.
*/
using System;
using System.Globalization;//to use class CultureInfo


class CurrentDateAndTime
{
    static void Main(string[] args)
    {
        string format = "dd MMMM yyyy HH:mm:ss";//parameter for method ToString, determinate how to look like date format
        string currentDate = DateTime.Now.ToString(format, CultureInfo.InvariantCulture);//format current date without take into account current culture
        Console.WriteLine("{0:D}", currentDate);
        string currentDateBG = DateTime.Now.ToString(format, CultureInfo.GetCultureInfo("bg-BG"));//format current date in Bulgarian datetime format
        Console.WriteLine("{0:D}", currentDateBG);
        string currentDateDE = DateTime.Now.ToString(format, CultureInfo.GetCultureInfo("de-DE"));
        Console.WriteLine("{0:D}", currentDateDE);//format current date in German datetime format
        string currentDateRU = DateTime.Now.ToString(format, CultureInfo.GetCultureInfo("ru-RU"));
        Console.WriteLine("{0:D}", currentDateRU);//format current date in Russian datetime format
        string currentDatePT = DateTime.Now.ToString(format, CultureInfo.GetCultureInfo("pt-PT"));
        Console.WriteLine("{0:D}", currentDatePT);//format current date in Portuguese datetime format
    }
}
