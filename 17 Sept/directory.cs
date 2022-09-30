using System.Diagnostics;
using System.IO;
using System.Net.NetworkInformation;
using System;

public class DirectoryFile
{
    public static void Main(string[] args)
    {
        string fileName = "C:\Users\OJAS NIGAM\repos\Utkarsh.txt";
        if (File.Exists(fileName))
        {
            Console.WriteLine("File exists.");
        }

        else if (File.Exists("C:\Users\OJAS NIGAM\repos\Utkarsh.txt"))
        {
            Console.WriteLine("The file exists in a directory");
        }
        //After that check whether the file exists in a directory or not.  
        else
        {
            Console.WriteLine("File does not exist.");

        }
    }
}
Footer
© 2022 GitHub, Inc.
