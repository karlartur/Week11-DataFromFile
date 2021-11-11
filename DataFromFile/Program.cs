﻿using System;
using System.IO;

namespace DataFromFile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your favourite colour:");
            string userColour = Console.ReadLine();

            string output = GetLineFromFileData(userColour);

            if (output.Length != 0)
            {
                Console.WriteLine(output);
            }
            else
            {
                Console.WriteLine("Sorry, I did not find the colour.");
            }

        }
        private static string[] ReadDataFromFile()
        {
            string directoryPath = @"C:\Users\opilane\Sample";
            string fileName = "personality.txt";
            string fullPath = $@"{directoryPath}\{fileName}";
            string[] dataFromFile = File.ReadAllLines(fullPath);
            return dataFromFile;
        }
        private static string GetLineFromFileData(string userInput)
        {
            string[] dataFromFile = ReadDataFromFile();
            string result = "";

            foreach(string line in dataFromFile)
            {
                if (line.Contains(userInput))
                {
                    result = line;
                    break;
                }
            }
            return result;
        }
            

     
       
        
    }
}
