//difference between directory(static class) and directoryinfo(instance class: have to create object) is same as file and fileinfo 
//If you want to perform the single operation on the particular folder like delete: Directory Static class is better
// In a large program if you want to perform the multiple operation on the same directory, so you dont want to mention the directory path everytime when you call the method in that case : Directory info class is better

//Same Task as in Directory 
using System;
using System.Collections.Generic;
using System.IO;

namespace DirectoryInfoExample
{
    class Program
    {
        static void Main()
        {
            string countriesPath = @"c:\practice\countries";
            DirectoryInfo directoryInfo = new DirectoryInfo(countriesPath);

            //Create
            directoryInfo.Create();
            Console.WriteLine("countries folder created");

            //CreateSubdirectory
            directoryInfo.CreateSubdirectory("India");
            directoryInfo.CreateSubdirectory("UK");
            directoryInfo.CreateSubdirectory("USA");
            Console.WriteLine("'India', 'UK', 'USA' folders created");

            //FileInfo.Create()
            new FileInfo(directoryInfo.FullName + @"\capitals.txt").Create().Close();
            new FileInfo(directoryInfo.FullName + @"\sports.txt").Create().Close();
            new FileInfo(directoryInfo.FullName + @"\population.txt").Create().Close();
            Console.WriteLine("'capitals.txt', 'sports.txt', 'population.txt' files created");

            //MoveTo
            string worldPath = @"c:\practice\world";
            directoryInfo.MoveTo(worldPath);
            Console.WriteLine("'countries' moved to 'world'");

            //GetFiles
            FileInfo[] files = directoryInfo.GetFiles();
            Console.WriteLine("\nFiles:");
            foreach(FileInfo file in files)
            {
                Console.WriteLine(file.FullName, file.Length);
            }

            //GetDirectories
            DirectoryInfo[] directories = directoryInfo.GetDirectories();
            Console.WriteLine("\nSub directories:");
            foreach (DirectoryInfo dir in directories)
            {
                Console.WriteLine(dir.FullName);
            }

            //Delete
            directoryInfo.Delete(true);
            Console.WriteLine("'world' folder deleted");
            Console.ReadKey();
        }
    }
}
