Console.Clear();
Console.WriteLine("Filmregister");

//Lista för att lagra filmer
List<string> listaFilmer = [];

//Be användare mätta in antal filmer
Console.Write("Ange antal filmer per sidan (3-5): ");
string antalText = Console.ReadLine();
int antal = 0;
while (true)
{
bool success = int.TryParse(antalText, out antal);
if (success)
{
    break;
}
}

//Programloop
while (true)
{
    //Vissa en meny
    Console.WriteLine("""
1. Lägg till filmer
2. Lista alla filmer
3. Sök en film
4. Avsluta
Välj en alternativ: 
""");

    string val = Console.ReadLine();
    Console.WriteLine();

    //Hantera valet
    if (val == "1")
    {
        //Lägg till filmer
        for (int i = 0; i < antal; i++)
        {
            Console.WriteLine("Ange filmen: ");
            string film = Console.ReadLine();
            listaFilmer.Add(film);
        }
    }
    else if (val == "2")
    {
        //Skriv ut alla filmer
        foreach (var filmnamn in listaFilmer)
        {
            Console.WriteLine($"- {filmnamn}");
        }
    }
    else if (val == "3")
    {
        //Sök en film
        Console.Write("Ange en film att söka eftr (förats bokstaven): ");
        string bokstav = Console.ReadLine();
        foreach (var filmnamn in listaFilmer)
        {
            //Kolla om varje film börjar på bokstaven
            if (filmnamn.StartsWith(bokstav))
            {
                Console.WriteLine(filmnamn);
            }
        }
    }
    else if (val == "4")
    {
        Console.WriteLine("Tack för idag!");
        break;
    }
    else
    {
        Console.WriteLine("Fel val. Försök igen!");
    }
}