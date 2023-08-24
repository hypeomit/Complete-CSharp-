//Check Notion Section 274. for Task Info
using System;
using System.Collections.Generic;
using System.IO;

namespace DirectoryExample
{
    class Program
    {
        static void Main()
        {
            //1. Create a folder "countries" in "c:\practice".
            //CreateDirectory
            string countriesFolderPath = @"c:\practice\countries";//target file path
            Directory.CreateDirectory(countriesFolderPath);//directory is a static  class so, it cannot store the direct path so we pass path as an arguement
            Console.WriteLine("countries folder created");

            //2. Create three folders "India","UK","USA" in "countries folder.
            string indiaPath = countriesFolderPath + @"\India";
            string ukPath = countriesFolderPath + @"\UK";
            string usaPath = countriesFolderPath + @"\USA";
            Directory.CreateDirectory(indiaPath);
            Directory.CreateDirectory(ukPath);
            Directory.CreateDirectory(usaPath);
            Console.WriteLine("Sub directories 'India', 'UK' and 'USA' created");

            //3. Create three files "capital.txt", "sports.txt" and "population.txt" in "countries folder"
            string capitalsFilePath = countriesFolderPath + @"\capitals.txt";
            string sportsFilePath = countriesFolderPath + @"\sports.txt";
            string populationFilePath = countriesFolderPath + @"\population.dat";

            //File.Create
            File.Create(capitalsFilePath).Close();
            File.Create(sportsFilePath).Close();
            File.Create(populationFilePath).Close();
            Console.WriteLine("Files 'capitals.txt', 'sports.txt', 'population.dat' created");

            //4. Move/rename "countries" as "world".
            string worldFolderPath = @"c:\practice\world";
            Directory.Move(countriesFolderPath, worldFolderPath);
            Console.WriteLine("'countries' folder moved to 'world'");

            //5. List the files of "world" folder.
            string[] files = Directory.GetFiles(worldFolderPath, "*.txt");
            Console.WriteLine("\nFiles:");
            foreach (string file in files)
            {
                Console.WriteLine(file);
            }

            //6. List the folders of "world" folder.
            string[] directories = Directory.GetDirectories(worldFolderPath);
            Console.WriteLine("\nSub directories:");
            foreach (string dir in directories)
            {
                Console.WriteLine(dir);
            }

            //7. Delete the "world" folder, including its files and sub folders.
            Directory.Delete(worldFolderPath, true);
            Console.WriteLine("'world' folder deleted");
            Console.ReadKey();
        }
    }
}
