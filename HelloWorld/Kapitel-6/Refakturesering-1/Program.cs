/* *************************************************
 * Namn: Konsolgrafik
 * Beskrivning: Ett program för att rita konsolgrafik
 * Datum: 2024-09-01
 *********************************************** */

VisaIntro();

while (true)
{

    SkrivaUtMeny();

    string val = Console.ReadLine();

    // Hantera användarens val
    if (val == "1")
    {
        int tal = LäsInHeltal();

        // Skriv ut fyrkanten
        RutaFyrkant(tal);
    }
    else if (val == "2")
    {
        int tal = LäsInHeltal();

        // Skriv ut triangeln
       RitaUtTriangel(tal);
    }
    else if (val == "3")
    {
        break;
    }
    else
    {
        Console.WriteLine("Ogiltigt alternativ, vg försök igen.");
    }
}

/* **********************************************
 *  Metoder 
 ********************************************** */


/// <summary>
/// Program för att rita konsolgrafik
/// </summary>
static void VisaIntro()
{
    Console.Clear();
    Console.WriteLine("""
Program för att rita konsolgrafik
===================================
""");

}

/// <summary>
/// Skriva ut menyn
/// </summary>
static void SkrivaUtMeny()
{
    // Skriva ut menyn
    Console.WriteLine("""
    1. Skriv ut fyrkant
    2. Skriv ut triangel
    3. Avsluta
    """);
    Console.Write("Välj ett alternativ: ");
}


/// <summary>
/// Ritar ut ett fyrkant
/// </summary>
/// <param name="tal"></param>
static void RutaFyrkant(int tal)
{
    for (int i = 0; i < tal; i++)
    {
        for (int j = 0; j < tal; j++)
        {
            Console.Write("*");
        }
        Console.WriteLine();
    }
}


/// <summary>
/// Ritar ut ett triangel
/// </summary>
/// <param name="tal"></param>
static void RitaUtTriangel(int tal)
{
     for (int i = 0; i < tal; i++)
        {
            for (int j = 0; j <= i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
}


    /// <summary>
    /// Skriv in och läser av en heltal
    /// </summary>
    /// <returns></returns>
    static int LäsInHeltal()
    {
        Console.Write("Ange ett heltal: ");
        string talString = Console.ReadLine();
        int tal;
        while (!int.TryParse(talString, out tal))
        {
            Console.Write("Ange ett giltigt heltal: ");
            talString = Console.ReadLine();
        }

        return tal;
    }