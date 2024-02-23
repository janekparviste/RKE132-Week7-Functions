Console.WriteLine("Do you want to convert to Celcius or to Farenheit? Please enter (Celcius/Farenheit)");
string userChoice = Console.ReadLine();

Console.WriteLine("Provide degree: ");
int userInput = Int32.Parse(Console.ReadLine());

if (userChoice == "Celcius")
{
    ConverToCelsius(userInput);
} else
{
    ConvertToFahrenheit(userInput);
}

static void ConverToCelsius(int argument) 
{
    double celsius = (argument - 32) * 5 / 9;
    Console.WriteLine(celsius);
}
static void ConvertToFahrenheit(int argument) 
{
    double fahrenheit = (argument * 9) / 5 + 32;
    Console.WriteLine(fahrenheit);
}