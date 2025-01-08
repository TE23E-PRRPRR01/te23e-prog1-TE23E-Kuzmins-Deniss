Console.Clear();
Console.WriteLine("Hej metoder!");

//Anropa/använd metosen
SägHEj();
SägHEj();
SägHEj();
SägHEj();
SägHEj();

//Anropa med metoden meny
VIsaMeny();


//Anropa metoden Registrera namn
RegistreraNman();



/* *********************************************************************************************************************************
***************************  METODER ***********************************************************************
**************************************************************************************************************************** */

/// <summary>
/// Metod som skriver ut en hälsning
/// </summary>

static void SägHEj()
{
    Console.WriteLine("Hej på dig!");
}

/// <summary>
/// Metod för att visa en meny
/// </summary>

static void VIsaMeny()
{
    Console.WriteLine("""
    1.Lägg till uppgift
    2.Ta bort uppgift
    3.Skriv ut alla uppgifter
    4.Avsluta
    """);
}

/// <summary>
/// Metod för att ange namn
/// </summary>
static void RegistreraNman()
{
Console.Write("Ange namn: ");
string namn = Console.ReadLine();
Console.WriteLine(namn);
}