/* **********************************************************************************************
* ************************** MAIN ****************************************************************
************************************************************************************************* */

Console.Clear();

VisaPresentation();
string FilNamn = "Text.medd";

while (true)
{
    VisaMeny();
    string val = Console.ReadLine();
    if (val == "1")
    {
        SparaMeddelande(FilNamn);
    }
    else if (val == "2")
    {
        LäsMeddelande(FilNamn);
    }
    else if (val == "3")
    {
        Console.WriteLine("Tack för idag!");
        break;
    }
    else
    {
        Console.WriteLine("Fel val! Försök igen!");
    }

}



/* **********************************************************************************************
* ************************** METODER ****************************************************************
************************************************************************************************* */

static void VisaPresentation()
{
    Console.WriteLine("""
    ===============================================================================
    Program för att spara meddelande på disken
    Av xxx yyyy 2025
    ===============================================================================
    """);
}

static void VisaMeny()
{
    Console.WriteLine("""
    1. Spara meddelande
    2. Läsa meddelande
    3. Avsluta programmet
    """);
    Console.Write("Ange ditt val: ");
}

static void SparaMeddelande(string filen)
{
    Console.Write("Ange ett meddelande: ");
    string meddelande = Console.ReadLine();
    File.WriteAllText("meddelande.txt", meddelande);
Console.WriteLine("Ditt meddelande har sparats!");
}

static void LäsMeddelande(string filen)
{
    string meddelande = File.ReadAllText(filen);
    Console.WriteLine("Ditt senaste meddelande: ");
    Console.WriteLine("-------------------");
    Console.WriteLine(meddelande);
    Console.WriteLine("-------------------");
}