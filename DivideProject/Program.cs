/*
 * Names: Jacob Stockwell, Jason Fulton  
 *  
 * Description: This project is to go through the steps of co programming with co workers, Logging files, Execption Handing, 
 * and version control practice  
 * 
 * Varaible will have cammileCase
 * Functions will have PascalCase
 * 
 */

//definitions 
using System.Reflection.Metadata.Ecma335;
using System.IO;
try
{
 
    //Prompts 
    Console.WriteLine("How many Numbers do you want to Add");
    string countOfNumbersToAdd = Console.ReadLine();
    int UserInputNumber = 0;
    int sum = 0;
    int[] myArray = new int[2] { 5, 100 };
    int convertCountOfNumbersToAdd = Convert.ToInt32(countOfNumbersToAdd);

    for (int i = 0; i < convertCountOfNumbersToAdd; i++)
    {
        Console.WriteLine("Please Enter a Number");

        UserInputNumber = Convert.ToInt32(Console.ReadLine());
        sum += UserInputNumber;
    }
    Console.WriteLine(sum);

    //----------------------------------------------------------------------------------------------
    //Output
}
catch(Exception ex) {

    DateTime now = DateTime.Now;
    string writeText = ex.Message + " " + now;
    string path = @"C:\Users\jacob\Desktop\P_Projects\c#\DivideProject\DivideProject\logs\";

    File.WriteAllText(path + "logFileTest2.txt", writeText);
    File.WriteAllText("logFileTest.txt", writeText);
    Console.WriteLine($"The Aplication has Encountered an error. \nThe error states: {ex.Message}");
    Console.WriteLine(@"Please look at this Directory for the log file: \DivideProject\logs\");
   
}