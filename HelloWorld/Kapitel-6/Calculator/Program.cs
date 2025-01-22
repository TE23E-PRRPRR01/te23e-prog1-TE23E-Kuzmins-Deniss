/* **********************************************************************************************
* ************************** MAIN ****************************************************************
************************************************************************************************* */

using System;

Console.Clear();

VisaVälkomsttext();

while (true)
{
    VisaMeny();
    string val = Console.ReadLine();

    if (val == "1")
    {
        Addition();
    }
    else if (val == "2")
    {
        Subtraktion();
    }
    else if (val == "3")
    {
        Multiplikation();
    }
    else if (val == "4")
    {
        Division();
    }
    else if (val == "5")
    {
        Console.WriteLine("👋 Tack för att du använde miniräknaren!");
        break;
    }
    else
    {
        Console.WriteLine("⚠️ Ogiltigt val. Försök igen.");
    }
}

/* **********************************************************************************************
* ************************** METODER ****************************************************************
************************************************************************************************* */

static void VisaVälkomsttext()
{
    Console.WriteLine("🧮 Miniräknare\n");
}

static void VisaMeny()
{
    Console.WriteLine("""
    1. Addition
    2. Subtraktion
    3. Multiplikation
    4. Division
    5. Avsluta
    """);
    Console.Write("Ange ditt val: ");
}

static void Addition()
{
    double tal1 = LäsInTal("Ange tal 1: ");
    double tal2 = LäsInTal("Ange tal 2: ");
    Console.WriteLine($"Svar: {tal1} + {tal2} = {tal1 + tal2}\n");
}

static void Subtraktion()
{
    double tal1 = LäsInTal("Ange tal 1: ");
    double tal2 = LäsInTal("Ange tal 2: ");
    Console.WriteLine($"Svar: {tal1} - {tal2} = {tal1 - tal2}\n");
}

static void Multiplikation()
{
    double tal1 = LäsInTal("Ange tal 1: ");
    double tal2 = LäsInTal("Ange tal 2: ");
    Console.WriteLine($"Svar: {tal1} * {tal2} = {tal1 * tal2}\n");
}

static void Division()
{
    double tal1 = LäsInTal("Ange tal 1: ");
    double tal2;
    do
    {
        tal2 = LäsInTal("Ange tal 2 (ej 0): ");
        if (tal2 == 0)
        {
            Console.WriteLine("Division med 0 är inte tillåten. Försök igen.");
        }
    } while (tal2 == 0);
    Console.WriteLine($"Svar: {tal1} / {tal2} = {tal1} / {tal2}");
}

static double LäsInTal(string meddelande)
{
    Console.Write(meddelande);
    while (true)
    {
        if (double.TryParse(Console.ReadLine(), out double tal))
        {
            return tal;
        }
        else
        {
            Console.WriteLine("Ogiltig inmatning. Ange ett numeriskt värde.");
            Console.Write(meddelande);
        }
    }
}
