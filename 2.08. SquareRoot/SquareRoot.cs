using System;
//Problem 8.	Square Root
//Create a console application that calculates and prints the square root of the number 12345. 
//Find in Internet “how to calculate square root in C#”.



    class SquareRoot
    {
        static void Main(string[] args)
        {
            short n = 12345;
            Console.WriteLine("Number:{0}\nSquare:{1}",n,Math.Round(Math.Sqrt(n),4));//using two mathematical functions from class Math - Round and Square Root as well as placeholders for the variable and the result
        }
    }

