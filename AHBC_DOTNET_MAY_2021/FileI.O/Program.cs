using System;
using System.Collections.Generic;

namespace FileI.O
{
    class Program
    {
        static void Main(string[] args)
        {
            //#region
            ////C.R.U.D
            ////Create Read Update and Delete
            ////Create
            //var fileName = "DarionsFile";
            //FileService.CreateFile(fileName);

            ////Update
            //var linesOfInput = new List<string>
            //{
            //    "Darion Likes Lebron James",
            //    "Starwars is a gift to mankind, Thanks George Lucas",
            //    "I am named my son Anikan :)"
            //};
            //FileService.UpdateFile(fileName);
            //FileService.UpdateFile(fileName, linesOfInput);

            ////Read
            //FileService.ReadFromFile(fileName);


            ////Delete
            //FileService.DeleteFile(fileName);
            //#endregion

            var nameOfFile = "dictionary";
            //Create
            FileService.CreateFile(nameOfFile);
            
            //Modify
            var linesToWrite = new List<string>
            {
                "hello,hola",
                "food,comida",
                "world,mundo",
                "computer,computadora",
                "exercise,ejercicio"
            };

            FileService.UpdateFile(nameOfFile, linesToWrite);

            //Read File
            var translationLookUp = new Dictionary<string, string>();
            FileService.ReadTranslationFromFile(nameOfFile,translationLookUp);
            Console.WriteLine("Hey enter a word for translation");
            var userInput = Console.ReadLine();

            var translationValue = translationLookUp[userInput];

            Console.WriteLine($"{translationValue} is {userInput} in spanish");
        }
    }
}
