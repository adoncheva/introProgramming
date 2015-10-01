/*Problem 16.* Print Long Sequence
  Write a program that prints the first 1000 members of the sequence: 2, -3, 4, -5, 6, -7, …
  You might need to learn how to use loops in C# (search in Internet).*/
using System;


class PrintLongSequence
{
    static void Main()
    {
        int positive = 2, negative = -3, sequence = 500, step = 2;//declarate and initialize variables needed for loop
        for (int i = 0; i < sequence; i++)// A loop 'for' has three parts: start point of a loop, condition when loop ends and step of loop.
        //All parts of a loop are optional. When you have empty 'for' statement, this is called endless loop.
        {
            Console.Write("{0,6:D},{1,6:D},", positive, negative);/* writing a posetive and a negative number of sequence
                                                                        one after the other*/
            positive += step;/*incrementing the positive number with step equat to two*/
            negative -= step;/*decrementing the negative number with step equat to two*/
            if ((i + 1) % 5 == 0) Console.WriteLine();/*writing every ten members of sequence in a new line*/
        }
        Console.WriteLine();
    }

}
