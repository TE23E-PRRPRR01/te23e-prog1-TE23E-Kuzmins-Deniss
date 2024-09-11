//Progrm för att konvertera från Fahrenheit till Celsius
Console.Clear();
Console.WriteLine("Program för att konvertera från Fahrenheit till Celsius");

//Läser in temperaturen i Fahrenheit
Console.Write("Ange temperaturen i Fahrenheit: ");
double tempFahrenheit = double.Parse(Console.ReadLine());
//Konvertera Fa -> Ce
double tempCelsius = (tempFahrenheit -32) * 5 / 9;

//Skriva ut resultatet med decimalen
Console.WriteLine($"{tempFahrenheit} F blir {tempCelsius} C");