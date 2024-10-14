//Ett litet namnregister
Console.Clear();
Console.WriteLine("Ett litet namnregister");
List<string> namnlista = [];


//Programloopen
while (true)
{
    //Visa en meny
    Console.WriteLine("""
1. Registrera namn
2. Skriva ut alla namn
3. Avsluta programet
Ange ditt val: 
""");
    string val = Console.ReadLine();
    if (val == "1")
    {
        // Läs in namn i register
        Console.Write("Ange ett namn: ");
        string namn = Console.ReadLine();
        namnlista.Add(namn);
    }
    else if (val == "2")
    {
        //Skriver ut alla namn från lista
        foreach (var namnet in namnlista)
        {
            Console.Write($"{namnet}, ");
        }
    }
    else if (val == "3")
    {
        break;
    }
}
