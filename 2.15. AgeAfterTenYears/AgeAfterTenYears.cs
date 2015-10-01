/*
 Problem 15.* Age after 10 Years

 Write a program to read your birthday from the console and print how old you are now
 and how old you will be after 10 years.

 */
using System;
using System.Threading;//to use class Thread
using System.Globalization;//to use class CultureInfo

class AgeAfterTenYears
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("bg-BG");//set format to Bulgarian datetime format
        DateTime birthday;
        string birthdate = "";
        char[] separators = new char[] { ' ', '/', '.','-' };//create an array for separating different parts of string 'birthdate'
        string[] birthdateParts;

        //start loop do...while until valid date be written
        do
        {
            Console.WriteLine("When were you born?");
            birthdate = Console.ReadLine();
            if (DateTime.TryParse(birthdate, out birthday) == false)//validate date
                Console.WriteLine("Invalid date.Try again.");

            birthdateParts = birthdate.Split(separators);//split string to take the year of your birth
        } while ((!DateTime.TryParse(birthdate, out birthday)) || (Int32.Parse(birthdateParts[2]) < 1900));//condition of loop
        byte difference = Convert.ToByte(DateTime.Today.Year - birthday.Year);
        if (DateTime.Today.Month.CompareTo(birthday.Month) == -1)//compare months
        {

            Console.WriteLine("Today you are {0} years old. At the same time ten years later you will be {1} years old", difference - 1, difference - 1 + 10);
        }
        else
            Console.WriteLine("Today you are {0} years old. At same time ten years later you will be {1} years old", difference, difference + 10);

    }
}

