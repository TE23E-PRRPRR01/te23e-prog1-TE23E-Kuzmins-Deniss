//Program för att räkna BMI värde

Console.Clear();
Console.WriteLine("Program för att räkna BMI värde");

//Läser in din vikt och längd
Console.Write("Ange din längd (m): ");
double Längd = double.Parse(Console.ReadLine());
Console.Write("Ange din vikt (kg) ");
double Vikt = double.Parse(Console.ReadLine());

//Konvertera längd och Vikt till BMI
double BMI = Vikt / (Längd * Längd);
Console.WriteLine($"Ditt BMI är {BMI}");