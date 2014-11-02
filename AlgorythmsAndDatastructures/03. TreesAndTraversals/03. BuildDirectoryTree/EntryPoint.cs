//Define classes File { string name, int size } and 
//Folder { string name, File[] files, Folder[]
//childFolders } and using them build a tree keeping 
//all files and folders on the hard drive starting from 
//C:\WINDOWS. Implement a method that calculates 
//the sum of the file sizes in given subtree of the tree 
//and test it accordingly. Use recursive DFS traversal.

//NOTE!!! Please, don't try this with your C:/ drive.
//It will take too long.
//Try with some other, smaller directory that you can easily test.

namespace _03.BuildDirectoryTree
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    public class EntryPoint
    {
        static void Main()
        {
            Folder head = new Folder("C:\\WINDOWS");
            //var windowsDirectory = Directory.EnumerateDirectories("C:\\WINDOWS");

            Stack<Folder> directories = new Stack<Folder>();
            directories.Push(head);

            while (directories.Count > 0)
            {
                var currentDirectory = directories.Pop();

                try
                {
                    //Get subdirectories
                    var subdirectoryNames = Directory.GetDirectories(currentDirectory.Name);
                    List<Folder> allChildDirectories = new List<Folder>();
                    foreach (var subdirectory in subdirectoryNames)
                    {
                        var childDirectory = new Folder(subdirectory);
                        allChildDirectories.Add(childDirectory);
                        directories.Push(childDirectory);
                    }
                    currentDirectory.ChildFolders = allChildDirectories.ToArray();



                    //Get files in the directory
                    var fileNamesIndirectory = Directory.GetFiles(currentDirectory.Name);
                    List<File> filesInDirectory = new List<File>();
                    foreach (var file in fileNamesIndirectory)
                    {
                        var fileInfo = new FileInfo(file);
                        var currentFile = new File(fileInfo.Name, (int)fileInfo.Length);
                        filesInDirectory.Add(currentFile);
                    }
                    currentDirectory.Files = filesInDirectory.ToArray();

                }
                catch (Exception)
                {
                    //Do nothing when you have no permissions to read the folder
                }
            }

            Console.WriteLine("{0} bytes", GetSizeOfFolder(head));
        }

        //This method can calculate the size of any subtree too.
        //Just pass as paramether to head of the subtree.
        static long GetSizeOfFolder(Folder head)
        {
            long result = 0;
            Stack<Folder> folders = new Stack<Folder>();
            folders.Push(head);

            while (folders.Count > 0)
            {
                var currentFolder = folders.Pop();

                foreach (var folder in currentFolder.ChildFolders)
                {
                    folders.Push(folder);
                }

                foreach (var file in currentFolder.Files)
                {
                    result += file.Size;
                }
            }

            return result;
        }
    }
}
