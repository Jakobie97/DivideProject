﻿/*
 * Names: Jacob Stockwell, Jason Fulton  
 *  
 * 
 * 
 * Description: This project is to go through the steps of co programming with co workers, Logging files, Execption Handing, 
 * and version control practice  
 * 
 */


//definitions 
using System.Reflection.Metadata.Ecma335;

string number1 = "";
string number2 = "";

double convertNumber1 = 0;
double convertNumber2 = 0;
double result = 0;

//test

//Prompts 
Console.WriteLine("Please Enter the first Number you want to divide:");
number1 = Console.ReadLine();

//Looks to make sure that the user is only putting in an Double -------------------------------- 
try
{ convertNumber1 = Convert.ToDouble(number1);}
catch {

    Console.WriteLine("Hey!!! Numbers only. We only serve ints around here. Talk to the sheriff");
    Console.WriteLine("Last chance before the program dies. Please Enter a Number: ");
     
    number1 = Console.ReadLine();
    //convertNumber1 = Convert.ToDouble(number1);
    bool success = double.TryParse(number1, out convertNumber1);
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
number2 = Console.ReadLine();

try
{convertNumber2 = Convert.ToDouble(number2);}
catch
{
    Console.WriteLine("I guess you dont know how to listen or read. Enjoy digging holes.");
    Console.WriteLine("Last chance before the program dies. Please Enter a Number: ");
    number2 = Console.ReadLine();
    //convertNumber2 = Convert.ToDouble(number2);
    bool success = double.TryParse(number2, out convertNumber2);
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

result = convertNumber1 / convertNumber2;
Console.WriteLine($"The numbers you entered {convertNumber1} and {convertNumber2}");
Console.WriteLine($"Lets divide these numbers buddy. " +
    $"Your Numbers are {convertNumber1} divided by {convertNumber2}. This in an equation format is:" +
    $" {convertNumber1} / {convertNumber2} = {result}.");