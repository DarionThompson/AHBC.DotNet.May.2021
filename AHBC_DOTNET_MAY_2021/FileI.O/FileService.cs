using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace FileI.O
{
    public static class FileService
    {
        public static void CreateFile(string fileName)
        {
            if (!File.Exists(fileName))
            {
                File.Create(fileName);
            }
        }

        public static void UpdateFile(string fileName, List<string> linesOfInput = null)
        {
            using StreamWriter streamWriter = new StreamWriter(fileName, true);
            
            if(linesOfInput == null || !linesOfInput.Any())
            {
                streamWriter.WriteLine("This is a new line that I am writing");
            }
            else
            {
                foreach(var line in linesOfInput)
                {   
                    streamWriter.WriteLine(line);
                }
            }
        }

        public static void ReadFromFile(string fileName)
        {
            using StreamReader streamReader = new StreamReader(fileName);
            //This is the old way
            //while (true)
            //{
            //    var line = streamReader.ReadLine();
            //    if(line == null)
            //    {
            //        break;
            //    }
            //    Console.WriteLine(line);
            //}

            //This is new way
            while (!streamReader.EndOfStream)
            {
                Console.WriteLine(streamReader.ReadLine());
            }
        }

        public static void DeleteFile(string fileName)
        {
            File.Delete(fileName);
        }
    }
}
