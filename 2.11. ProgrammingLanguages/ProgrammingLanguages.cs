/*
 Problem 11. Programming Languages

    Perform a research (e.g. in Google or Wikipedia) and provide a short list with information about the most popular programming languages. How similar are they to C#? How do they differ from C#?
    Write in a text file called “programming-languages.txt” at least five languages along with 2-3 sentences about each of them. Use English.

 */
using System;
using System.IO;//to use classes StreamWriter and StreamReader


class ProgrammingLanguages
{
    static void Main()
    {
        string fileName = @"programming-languages.txt";// variable type string to store file name. @ is use to avoid escape sequences and preserve format
        // Create a StreamWriter instance
        StreamWriter writer = new StreamWriter("programming-languages.txt");

        // Ensure the writer will be closed when no longer used
        using (writer)
        {
            //write in a file      
            writer.WriteLine(
@"C 
	is a general-purpose, imperative computer programming language. 
	It supports structured programming, lexical variable scope and recursion, 
	while a static type system prevents many unintended operations. 
	By design, C provides constructs that map efficiently to typical machine instructions, 
	and therefore it has found lasting use in applications that had formerly been coded in assembly language,
	including operating systems as well as various application software for computers ranging from supercomputers
	to embedded systems.
Java
	Java is a functional computer programming language that is concurrent, class-based, object-oriented, 
	and specifically designed to have as few implementation dependencies as possible. 
	It is intended to let application developers ""write once, run anywhere"" (WORA),
	meaning that code that runs on one platform does not need to be recompiled to run on another. 
	Java applications are typically compiled to bytecode that can run on any Java virtual machine (JVM)
	 regardless of computer architecture. Java is, as of 2015, one of the most popular programming languages in use, 
	particularly for client-server web applications.
PHP
	PHP is a server-side scripting language designed for web development but also used as a general-purpose programming language. 
	PHP code can be simply mixed with HTML code, or it can be used in combination with various templating engines and web frameworks.
	PHP code is usually processed by a PHP interpreter, which is usually implemented as a web server's native module or a Common Gateway Interface (CGI) executable. 
	After the PHP code is interpreted and executed, the web server sends resulting output to its client, usually in form of a part of the generated web page; for example, 
	PHP code can generate a web page's HTML code, an image, or some other data. 
	PHP has also evolved to include a command-line interface (CLI) capability and can be used in standalone graphical applications.
Ruby
	Ruby is a dynamic, reflective, object-oriented, general-purpose programming language. 
	It was designed and developed in the mid-1990s by Yukihiro ""Matz"" Matsumoto in Japan.
	According to its authors, Ruby was influenced by Perl, Smalltalk, Eiffel, Ada, and Lisp.
	It supports multiple programming paradigms, including functional, object-oriented, and imperative. 
	It also has a dynamic type system and automatic memory management.
Python
	Python is a widely used general-purpose, high-level programming language.
	Its design philosophy emphasizes code readability, and its syntax allows programmers to express concepts in fewer lines of code
	than would be possible in languages such as C++ or Java.
	The language provides constructs intended to enable clear programs on both a small and large scale.");

        }
        //Start reading and handling exceptions. Construction try...catch is used for handling exceptions.
        try
        {
            // Create a StreamReader instance
            StreamReader reader = new StreamReader(fileName);
            Console.WriteLine(
                "File {0} successfully opened.", fileName);
            Console.WriteLine("File contents:");
            // Ensure the reader will be closed when no longer used
            using (reader)
            {
                //read file using method ReadToEnd
                Console.WriteLine(reader.ReadToEnd());
            }
        }
        // catch and handling exceptions
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


