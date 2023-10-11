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
    Console.WriteLine("Please Enter the first Number you want to divide:");
    string firstUserInput = Console.ReadLine();

    double convertFirstUserInput = 0;

    convertFirstUserInput = Convert.ToDouble(firstUserInput);
    //Looks to make sure that the user is only putting in an Double -------------------------------- 
    bool firstInputParce = double.TryParse(firstUserInput, out convertFirstUserInput);
    if (firstInputParce)
    {
        Console.WriteLine("Your First entry was Successflly converted to Double");
    }
    else
    {
        Console.WriteLine("invalid Entry, Program is ending. Relaunch the app and try again");
        return;
    }
    
    Console.WriteLine("Please Enter the Second Number you want to divide by:");

    string secondUserInput = Console.ReadLine();
    double convertSecondUserInput = 0;
    
    convertSecondUserInput = Convert.ToDouble(secondUserInput); 

        
    bool secondInputParce = double.TryParse(secondUserInput, out convertSecondUserInput);
    if (secondInputParce)
    {
        Console.WriteLine("Your second entry was Successflly converted to Double");
    }
    else
    {
        Console.WriteLine("invalid Entry, Program is ending. Relaunch the app and try again");
        return;
    }
    //}
    //----------------------------------------------------------------------------------------------
    //Output
    double result = convertFirstUserInput / convertSecondUserInput;
    Console.WriteLine($"The numbers you entered {convertFirstUserInput} and {convertSecondUserInput}");
    Console.WriteLine($"Lets divide these numbers buddy. " +
        $"Your Numbers are {convertFirstUserInput} divided by {convertSecondUserInput}. This in an equation format is:" +
        $" {convertFirstUserInput} / {convertSecondUserInput} = {result}.");

}
catch(Exception ex) {

    DateTime now = DateTime.Now;
    string writeText = ex.Message + " " + now;
    string path = "C:\\Users\\jacob\\Desktop\\P_Projects\\c#\\DivideProject\\DivideProject\\logs\\";

    File.WriteAllText(path + "logFileTest2.txt", writeText);
    File.WriteAllText("logFileTest.txt", writeText);
    Console.WriteLine($"The Aplication has Encountered an error. The error states: {ex.Message}");
    Console.WriteLine("Please look at this Directory for the log file: \\DivideProject\\logs\\");
   
}