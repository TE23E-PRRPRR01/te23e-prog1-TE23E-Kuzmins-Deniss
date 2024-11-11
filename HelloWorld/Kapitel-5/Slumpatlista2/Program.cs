// Program som smapar lista med slumpade tal samt validerar användarens inmatning för att se till att allt är giltigt

/***************************************************************************
**                                  Main                                  **
****************************************************************************/


// Skapar en variabel för antalet slumptal för global användning

Console.Clear();
Console.WriteLine("""
Välkommen till v2 av Slumpad Lista.

""");

// Deklarerar variabler
// Skapa en tom lista för att spara det slumpade talet
List<int> listaSlumptal = [];

// Kallar till en loop som frågar användaren tills den matar in ett giltigt svar
Console.WriteLine("Hur många slumptal vill du ha?");
int antal = LäsInHeltal();

// Koden nedan är fortsättningen efter att användaren angett ett giltigt antal slumptal (efter att loopen "breakat")
Console.WriteLine($"Du vill ha {antal} slumptal!");

// Kallar till en while-loop för att definiera min-värde
Console.WriteLine("Vad ska minimumvärdet vara?");
int min = LäsInHeltal();

// Kallar till en while-loop för att definiera max-värde
Console.WriteLine("Vad ska maximumvärdet vara?");
int max = LäsInHeltal();

// Loopar {antal} gånger
for (var i = 0; i < antal; i++)
{
    // Slumpar ett mellan {min} och {max}
    int slumptal = Random.Shared.Next(min, max + 1);

    // Lägger in slumptalet i en lista
    listaSlumptal.Add(slumptal);

    // Skriver ut
    Console.WriteLine($"Slumpat tal nummer {i + 1} är: {slumptal}");
}

/***************************************************************************
**                            Expanded Universe                           **
****************************************************************************/

static int LäsInHeltal()
{
    int heltal = 0;
    while (true)
    {

        // Fråga användaren om max-värde
        Console.Write("Ange heltal här: ");

        bool lyckades = int.TryParse(Console.ReadLine(), out heltal); // Istället för int.Parse för att säkerställa stabilt program, bool = true/false

        if (lyckades == true)
        {
            break;
        }
        else
        {
            Console.WriteLine("Nu gick något fel. Kom ihåg att du måste ange ett positivt heltal.");
        }
    }
    return heltal;
}