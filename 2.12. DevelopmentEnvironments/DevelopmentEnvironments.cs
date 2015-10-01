/*Problem 12. Development Environments

    Perform a research (e.g. in Google or Wikipedia) and provide a short list with popular development environments (IDEs) like Visual Studio.
    Write in a text file called “list-of-IDEs.txt” at least five IDEs along with 2-3 sentences about each of them. Use English.
*/

using System;
using System.IO;

//The task solution is the same as Problem 11 only has been changed file name and contents.
class DevelopmentEnvironments
{
    static void Main()
    {
        string fileName = @"list-of-IDEs.txt";
        // Create a StreamWriter instance
        StreamWriter writer = new StreamWriter("list-of-IDEs.txt");

        // Ensure the writer will be closed when no longer used
        using (writer)
        {

            writer.WriteLine(
@"KDevelop
    is a free, open source IDE (Integrated Development Environment) for Linux, Solaris, FreeBSD,
    Mac OS X and other Unix flavors.
    It is a feature-full, plugin extensible IDE for C/C++ and other programming languages.
    It is based on KDevPlatform, and the KDE and Qt libraries
    KDevelop offers all amenities of modern IDEs. For large projects and applications, 
    the most important feature is that KDevelop understands C++: 
    it parses the entire source base and remembers which classes have which member functions, 
    where variables are defined, what their types are, and many other things about your code.

XCode
	The Xcode IDE is at the center of the Apple development experience. 
	Tightly integrated with the Cocoa and Cocoa Touch frameworks, 
	Xcode is an incredibly productive environment for building amazing apps for Mac, iPhone, and iPad.

Dev-C++
	Free IDE that works well with wxWidgets and MinGW
	Features:
    		Support GCC-based compilers
    		Integrated debugging (using GDB)
    		Support for multiple languages (localization)
    		Class Browser
    		Code Completion
    		Debug variable Browser
    		Project Manager
    		Customizable syntax highlighting editor
    		Quickly create Windows, console, static libraries and DLLs
    		Support of templates for creating your own project types
    		Makefile creation
   		    Edit and compile Resource files
    		Tool Manager
    		Print support
    		Find and replace facilities
   		    Package manager, for easy installation of add-on libraries
    		CVS Support
    		To-Do List
    		CPU Window

NetBeans IDE
	NetBeans IDE includes project types for C and C++ and appropriate project templates. 
	You can work with and create C/C++ applications with dynamic and static libraries, and you can also create C/C++ projects from existing code. 
	C/C++ projects also support Fortran and Assembler files.
	Users can now easily create new projects from scratch by simply dragging-and-dropping a binary file to IDE. 
	The project system automatically finds the source files, adds them to the project, configures code assistance and even explores project dependencies. 
	Users also now have more flexibility in configuring the ""Run"" and ""Debug"" command and thus can run and debug static and dynamic libraries.

Eclipse
	Eclipse is famous for our Java Integrated Development Environment (IDE),
    but our C/C++ IDE and PHP IDE are pretty cool too. You can easily combine language support
	and other features into any of our default packages, and the Eclipse Marketplace allows for virtually unlimited customization and extension.");
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


