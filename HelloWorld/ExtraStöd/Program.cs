// See https://aka.ms/new-console-template for more information
Console.Clear();
Console.WriteLine("Listor");

//Skapa en tom lista för pizzarätter
List<string> pizzalist = [];

//Skapa en tom lista för frukter
List<string> frukter= [];

//Skapa en tom lista på skorstorleker
List<int> storlekar = [];

//Skapa en lista med tre förnamn
List<string> namnlista = ["Kalle", "Lisa", "Anna"];

//Lägg till i listowor med .Add()
//Lägg till tre pizzor
pizzalist.Add("Margarita");
pizzalist.Add("Vesuvio");
pizzalist.Add("Hawaii");

//Lägg till tre frukter
frukter.Add("Äpple");
frukter.Add("Banan");
frukter.Add("Citron");

//Sriv ut alla frukter
foreach (var frukt in frukter)
{
    Console.WriteLine($"Frukter: {frukt}");
}

//Låt användaren skriva in ett fjärde pizza
Console.WriteLine("Ange en pizza: ");
string nypizza = Console.ReadLine();
pizzalist.Add(nypizza);

//Skriv ut alla pizzor
foreach (var pizza in pizzalist)
{
    Console.WriteLine($"- {pizza}");
}

//Låt användaren skriva in ett fjärde namn
Console.WriteLine("Ange ett namn: ");
string nynamn = Console.ReadLine();
namnlista.Add(nynamn);

//Skriv ut alla namn
foreach (var namn in namnlista)
{
    Console.WriteLine(namn);
}
//Nu låter vi användaren skriva in skorstorlekar
Console.WriteLine("Ange din skorstorlek: ");
int input = int.Parse(Console.ReadLine());
storlekar.Add(input);

//Skriv ut alla skorstorlekar
foreach (var storlek in storlekar)
{
    Console.WriteLine($"* {storlek}");
}
//Hur många pizzor har vi?
int AntalPizzor = pizzalist.Count;
Console.WriteLine($"Antal pizzor: {AntalPizzor}");

//Hur många frukter har vi?
Console.WriteLine($"Antal frukter: {frukter.Count}");

//Hur många namn har vi?
Console.WriteLine($"Antal namn: {namnlista.Count}");

//Skriv utt den första namnet
Console.WriteLine($"Det första namnet är {namnlista[0]}");

//Skriv ut den andra namnet
Console.WriteLine($"Det andra namnet är {namnlista[1]}");

//Skriv ut den sista namnet
Console.WriteLine($"Det sista namnet är {namnlista[namnlista.Count-1]}");

//Byta ut första namnet med annat namn
namnlista[0] = "Andreas";

//Skriv utt den första namnet
Console.WriteLine($"Det första namnet är {namnlista[0]}");

//Skriv ut andra namn med nåt annat
namnlista[1] = "Johanna";

//Skriv ut den andra namnet
Console.WriteLine($"Det andra namnet är {namnlista[1]}");


//Be användare byta ut den första pizzan
Console.WriteLine("Vilken pizza vill du byta ut?");
string gammalpizza = Console.ReadLine();
Console.WriteLine("Vilken pizza vill du ha istället?");
string nyapizza = Console.ReadLine();


