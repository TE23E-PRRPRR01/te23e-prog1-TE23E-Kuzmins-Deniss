//Använda listor för att skapa/hantera samlingar
Console.Clear();

//Lista på trevliga frukter, till exempel "äpple", "apelsin", "ananas"
List<string> frukter = ["äpple", "apelsin", "ananas"];
Console.WriteLine($"Min friktlista: {frukter[0]}, {frukter[1]}, {frukter[2]}");

//Ändra i listan
frukter[0] = "banan";
Console.WriteLine($"Min friktlista: {frukter[0]}, {frukter[1]}, {frukter[2]}");

//Gå ifenom lista = lopa igenom = från första till sista
foreach (var frukt in frukter)
{
    Console.WriteLine(frukt);
}

//Skapa en lista på valfri sak (4st)
//Skriv ut varje sak på samma rad
//Lista på trevliga frukter, till exempel "äpple", "apelsin", "ananas"
List<string> anlednigartillattdö = ["Matte", "Fysik", "Språk", "Barn"];

//Gå ifenom lista = lopa igenom = från första till sista
foreach (var anlednigtillattdö in anlednigartillattdö)
{
    Console.Write($"{anlednigtillattdö} ");
}
for (int i = 0; i < anlednigartillattdö.Count; i++)
{
    Console.Write($"{anlednigartillattdö}");
}

//Skapa ett register
//En tom lista
Console.Clear();
List<string> namnlista = [];

// while-loop
while (true)
{
    Console.Write("Ange ett namn: ");
    string namn = Console.ReadLine();
    namnlista.Add(namn);

    //Skriv ut hela lista på en rad
    foreach (var namnet in namnlista)
    {
        Console.Write($"{namnet}, ");
    }
    Console.WriteLine();
}