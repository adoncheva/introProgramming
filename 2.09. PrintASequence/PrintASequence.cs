using System;
//Problem 9.	Print a Sequence
//Write a program that prints the first 10 members of the sequence: 2, -3, 4, -5, 6, -7, ...

    class PrintASequence
    {
        static void Main(string[] args)
        {
            //variant 1st
            sbyte val = 2;//declarating variable
            do
            {
                Console.Write("{0}, ",(val%2)==0?val:-val);//using loop 'do...while' and conditional ternary operator '?:'
                                                           //in this case output the result to the console several times while given
                                                           //condition is true and increasing variable with 1
                                                           //Ternary conditional operator determinates how output will look like. 
                val++;
            } while (val<12);
            Console.WriteLine();

            int posVal = 2, negVal = -3, step = 2;
            for (int i = 0; i < 5; i++)
			{
			  Console.Write("{0},{1},",posVal,negVal);
              posVal+=step; negVal-=step;
			}
            Console.WriteLine();
            int val1 = 2;
            for (int i = 0; i < 10; i++)
            {
                if (val1 % 2 != 0)
                {
                    Console.Write("{0},", -val1);
                }
                else
                {
                    Console.Write("{0},", val1);
                }
                val1++;
            }
        }
    }

