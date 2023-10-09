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

//Prompts 
Console.WriteLine("Please Enter the first Number you want to divide:");
string firstUserInput = Console.ReadLine();

double convertfirstUserInput = 0;
//Looks to make sure that the user is only putting in an Double -------------------------------- 
try
{ convertfirstUserInput = Convert.ToDouble(firstUserInput); }
catch
{

    Console.WriteLine("Hey!!! Numbers only. We only serve ints around here. Talk to the sheriff");
    Console.WriteLine("Last chance before the program dies. Please Enter a Number: ");

    firstUserInput = Console.ReadLine();
    //convertfirstUserInput = Convert.ToDouble(firstUserInput);
    bool success = double.TryParse(firstUserInput, out convertfirstUserInput);
    if (success)
    {
        Console.WriteLine("Your First entry was Successflly converted to Double");
    }
    else
    {
        Console.WriteLine("invalid Entry, Program is ending. Relaunch the app and try again");
        return;
    }
}


Console.WriteLine("Please Enter the Second Number you want to divide by:");
string secondUserInput = Console.ReadLine();


double convertSecondUserInput = 0;
try
{ convertSecondUserInput = Convert.ToDouble(secondUserInput); }
catch
{
    Console.WriteLine("I guess you dont know how to listen or read. Enjoy digging holes.");
    Console.WriteLine("Last chance before the program dies. Please Enter a Number: ");
    secondUserInput = Console.ReadLine();
    //convertSecondUserInput = Convert.ToDouble(secondUserInput);
    bool success = double.TryParse(secondUserInput, out convertSecondUserInput);
    if (success)
    {
        Console.WriteLine("Your second entry was Successflly converted to Double");
    }
    else
    {
        Console.WriteLine("invalid Entry, Program is ending. Relaunch the app and try again");
        return;
    }
}
//----------------------------------------------------------------------------------------------
//Output
double result = convertfirstUserInput / convertSecondUserInput;
Console.WriteLine($"The numbers you entered {convertfirstUserInput} and {convertSecondUserInput}");
Console.WriteLine($"Lets divide these numbers buddy. " +
    $"Your Numbers are {convertfirstUserInput} divided by {convertSecondUserInput}. This in an equation format is:" +
    $" {convertfirstUserInput} / {convertSecondUserInput} = {result}.");