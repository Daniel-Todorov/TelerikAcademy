//Write a program to traverse the directory 
//C:\WINDOWS and all its subdirectories recursively and 
//to display all files matching the mask *.exe. Use the 
//class System.IO.Directory.

namespace _02.FindExeInWindowsDirectory
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.IO;

    class FindExeInWindowsDirectory
    {
        static void Main()
        {
            //var windowsDirectory = Directory.EnumerateDirectories("C:\\WINDOWS");

            //NOTE!!! using stack for the recursion
            Stack<string> directories = new Stack<string>();
            directories.Push("C:\\WINDOWS");
            List<string> exeFilesInDirectory = new List<string>();

            while (directories.Count > 0)
            {
                var currentDirectory = directories.Pop();

                try
                {
                    var subdirectories = Directory.GetDirectories(currentDirectory);

                    foreach (var subdirectory in subdirectories)
                    {
                        directories.Push(subdirectory);
                    }

                    var exeFilesInSubdirectory = Directory.GetFiles(currentDirectory)
                        .Where(file => file.EndsWith(".exe"))
                        .Select(file => file.Split('\\')[file.Split('\\').Length - 1]); //remove this select if you want the path + file name

                    //Prints the files on the console.
                    //Duplicate filenames are dued to the files being in different directories.
                    //Remove the .Select line of code above to get the path to the file too.
                    foreach (var item in exeFilesInSubdirectory)
                    {
                        Console.WriteLine(item);
                    }

                    //Adds the exe files to a list in case we wanna do soemthign with them... eventually.
                    exeFilesInDirectory.AddRange(exeFilesInSubdirectory);
                }
                catch (Exception)
                {
                    //do nothing
                }
            }
        }
    }
}
