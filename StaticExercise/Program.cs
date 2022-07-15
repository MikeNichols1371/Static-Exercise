using StaticExercise;

Console.WriteLine("Welcome to Temperature Converter");
Console.WriteLine();
Console.WriteLine("Would you like to Convert a Temperature");
Console.WriteLine();
Console.WriteLine("Yes:No");
Console.WriteLine();
Console.WriteLine("Type Y for yes or N for no");
Console.WriteLine();
var userInput = Console.ReadLine().ToLower();
string yes = "y";
string no = "n";
string fahrenheit = "f";
string celsius = "c";
if (userInput == yes)
{
    Console.WriteLine();
    Console.WriteLine("Would you like to Convert to Fahrenheit or Celsius");
    Console.WriteLine();
    Console.WriteLine("Type F for fahrenheit or C for celsius");
    Console.WriteLine();
    userInput = Console.ReadLine().ToLower();
    if (userInput == fahrenheit)
    {
        Console.WriteLine();
        Console.WriteLine("What temperature Fahrenheit would you like to convert to Celsius");
        Console.WriteLine();
        double temperature = double.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine($"{temperature} degrees Fahrenheit to Celsius is: {TempConverter.FahrenheitToCelsius(temperature)}");
        Console.WriteLine();
        Console.WriteLine("Thank you have a nice day");
    }
    else if (userInput == celsius)
    {
        Console.WriteLine();
        Console.WriteLine("What temperature Celsius would you like to convert to Fahrenheit");
        Console.WriteLine();
        double temperature = double.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine($"{temperature} degrees Celsius to Fahrenheit is: {TempConverter.CelsiusToFahrenheit(temperature)}.");
        Console.WriteLine();
        Console.WriteLine("Thank you have a nice day");

    }
}
else if (userInput == no)
{
    Console.WriteLine();
    Console.WriteLine("Thank you have a nice day");

}





