using System;
//Problem 6.	Print Numbers
//Write a program to print the numbers 1, 101 and 1001, each at a separate line. 
//Name the program correctly. You should submit in your homework the Visual Studio
//project holding the source code of the PrintNumbers program.


    class PrintNumbers
    {
        static void Main(string[] args)
        {

            //1st variant - easiest
            Console.WriteLine(1);
            Console.WriteLine(101);
            Console.WriteLine(1001);
            //2nd variant
            /* In this case you can use placeholders and mathematical function power and the escape sequence '\n' for new line
             * you also declarate some variable - in our case:byte, after this you increment this variable with 1 before adding number 1 again*/
            byte m = 0;
            Console.WriteLine("{0}\n{1}\n{2}",0+Math.Pow(10,m),1+Math.Pow(10,++m+1),1+Math.Pow(10,++m+1));
             //3rd variant
            int n=1;
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("{0,4}",Convert.ToString(n, 2));
                n += 4;
            }
            
        }
    }

