//Program för att räkna ut kostnaden på Biluthyring

Console.Clear();
Console.WriteLine("Program för att räkna ut kostnaden på Biluthyring");

//Räknar antal mil och längd på dagar
Console.WriteLine("Hur långt du ska köra den: ");
double Mil = double.Parse(Console.ReadLine());
Console.WriteLine("Hur lång tid ska du ha bilen: ");
double Dagar = double.Parse(Console.ReadLine());

//Räkna totalt kostnad för biluthyring
double Kostnad = (Mil * 5 + Dagar * 100) + 500;

//Totalt kostnad
Console.WriteLine($"Din hela kostnat för biluthyring är {Kostnad}kr");