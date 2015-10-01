/*Problem 13. C# and .NET Differences

    Describe the difference between C# and .NET Framework in 2-3 sentences.
    Write your description in a text file called “csharp-and-dot-net-framework.txt”. Use English.
*/
using System;
using System.IO;

//The task solution is the same as Problem 11 only has been changed file name and contents.
class CSharpAndDotNetDifferences
{
    static void Main()
    {
        string fileName = @"csharp-and-dot-net-framework.txt";
        // Create a StreamWriter instance
        StreamWriter writer = new StreamWriter("csharp-and-dot-net-framework.txt");

        // Ensure the writer will be closed when no longer used
        using (writer)
        {

            writer.WriteLine(
@"C# is programming object-oriented language. People can write different types of application in C#.
.Net framework is a software framework oriented primarily for Microsoft Windows. It includes a large library and several programming languages including C#.
Programs written in C# execute in a software environment, which provides .NET Framework.
The knowledge of C# implies some knowledge of .NET (because the C# object model corresponds to the .NET object model and you can do anything interesting in C# just by using .NET libraries). 
The opposite isn't necessarily true as you can use other languages to write .NET applications.
");
        }

        try
        {
            StreamReader reader = new StreamReader(fileName);
            Console.WriteLine(
                "File {0} successfully opened.", fileName);
            Console.WriteLine("File contents:");
            using (reader)
            {
                Console.WriteLine(reader.ReadToEnd());
            }
        }
        catch (FileNotFoundException)
        {
            Console.Error.WriteLine(
                "Can not find file {0}.", fileName);
        }
        catch (DirectoryNotFoundException)
        {
            Console.Error.WriteLine(
                "Invalid directory in the file path.");
        }
        catch (IOException)
        {
            Console.Error.WriteLine(
                "Can not open the file {0}", fileName);
        }
    }
}


