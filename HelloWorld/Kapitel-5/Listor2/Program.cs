Console.Clear();
Console.WriteLine("Allt om listor");

//Skapa en tom lista
List<string> listaNamn = [];

//Infoga i en lista
listaNamn.Add("Alex");  //Verb (Gör nåt, l'gger till)
listaNamn.Add("Alexander");
Console.WriteLine($"Antal: {listaNamn.Count}");

//Skriv ut listan (Går inte)
Console.WriteLine($"Lista: {listaNamn}");

//Skriv ut lista med hälp av loop
foreach (var namn in listaNamn)
{
    Console.WriteLine($"- {namn}");
}


//Skriv ut första elementet i listan (index = 0)
Console.WriteLine($"Första elementet: {listaNamn[0]}");

//Skriv ut två namn ur listan
for (var i = 0; i < listaNamn.Count; i++)
{
    Console.WriteLine($"- {listaNamn[i]}");
}
