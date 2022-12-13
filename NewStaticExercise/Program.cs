

using NewStaticExercise;
using System.ComponentModel.DataAnnotations;

Console.WriteLine("This program will convert a temperature from Celsius to Fahrenheight or Fahrenheight to Celsius. ");
Console.WriteLine("");
Console.WriteLine("To convert from Celsius type 'C' and then the temperature");
Console.WriteLine("");
Console.WriteLine("Example 'C' then when prompted '0' - Conversion = 32 Fahrenheight"); 
Console.WriteLine("");
Console.WriteLine("To convert from Farhenheight to Celsius type 'F' a space and then the temperature");
Console.WriteLine("");
Console.WriteLine("Example 'F' then when prompted '32' - Conversion = 0 Celsius");
Console.WriteLine("");
Console.WriteLine("Please type in F or C to start: ");
Console.WriteLine("");

var userInput = Console.ReadLine();


if (userInput.ToUpper() == "F")
{
    Console.WriteLine("");
    Console.WriteLine("You have selected Farhenheight; please type the temperature to convert to Celsius: ");
    
    var f_Input = Console.ReadLine();
    var fc_Input = Double.Parse(f_Input);

    Temp_Converter.FtoC(fc_Input);
    Console.WriteLine();
    Console.WriteLine($"Your conversion is {Temp_Converter.FtoC(fc_Input)} degrees celsius");

}
else if (userInput.ToUpper() == "C")
{
    Console.WriteLine("");
    Console.WriteLine("You have selected Celsius; please type the temperature to convert to Fahrenheight: ");
    
    var c_Input = Console.ReadLine();
    var dc_Input = Double.Parse(c_Input);

    Temp_Converter.CtoF(dc_Input);
    Console.WriteLine();
    Console.WriteLine($"Your conversion is {Temp_Converter.CtoF(dc_Input)} degress fahrenheight");
}

else
{
    Console.WriteLine("");
    Console.WriteLine("That was an invalid response.");
}

