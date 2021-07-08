using System;
using System.Collections.Generic;

namespace FileI.O
{
    class Program
    {
        static void Main(string[] args)
        {
            //C.R.U.D
            //Create Read Update and Delete
            //Create
            var fileName = "DarionsFile";
            FileService.CreateFile(fileName);

            //Update
            var linesOfInput = new List<string>
            {
                "Darion Likes Lebron James",
                "Starwars is a gift to mankind, Thanks George Lucas",
                "I am named my son Anikan :)"
            };
            FileService.UpdateFile(fileName);
            FileService.UpdateFile(fileName, linesOfInput);

            //Read
            FileService.ReadFromFile(fileName);


            //Delete
            FileService.DeleteFile(fileName);
        }
    }
}
