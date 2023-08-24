using System;
using System.IO;

namespace FileExample
{
    class Program
    {
        static void Main()
        {
            string filePath = @"c:\practice\India.txt", filePath2 = @"c:\practice\India2.txt", filePath3 = @"c:\practice\another.txt";

            File.Create(filePath).Close(); //Create Method
            Console.WriteLine("India.txt created");

            bool exists = File.Exists(filePath);//Exists Method
            if (exists)
            {
                File.Copy(filePath, filePath2);//Copy Method 
                Console.WriteLine("Copied India.txt to India2.txt");

                File.Move(filePath2, filePath3);//Move Method
                Console.WriteLine("Moved India2.txt to another.txt");

                File.Delete(filePath3);//Delete Method
                Console.WriteLine("another.txt deleted");
            }
            else
            {
                Console.WriteLine("File not found");
            }
            Console.ReadKey();
        }
    }
}
