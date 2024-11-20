 // Del 1: Summera jämna siffror i en sekvens
        Console.Write("Ange startvärde: ");
        if (!int.TryParse(Console.ReadLine(), out int start))
        {
            Console.WriteLine("Felaktigt värde för startvärdet. Ange ett heltal.");
            return;
        }

        Console.Write("Ange slutvärde: ");
        if (!int.TryParse(Console.ReadLine(), out int slutvärde))
        {
            Console.WriteLine("Felaktigt värde för slutvärdet. Ange ett heltal.");
            return;
        }

        int summa = 0; // Variabel för att hålla summan
        for (int i = start; i <= slutvärde; i++)
        {
            if (i % 2 == 0) // Kontrollera om talet är jämnt
            {
                summa += i;
            }
        }
        Console.WriteLine($"Summan av jämna siffror från {start} till {slutvärde} är: {summa}");

        // Del 2: Skriv ut jämna och udda siffror från 1 till 20
        Console.WriteLine("\nJämna siffror från 1 till 20:");
        for (int i = 1; i <= 20; i++)
        {
            if (i % 2 == 0) // Kontrollera om talet är jämnt
            {
                Console.Write($"{i} ");
            }
        }

        Console.WriteLine("\n\nUdda siffror från 1 till 20:");
        for (int i = 1; i <= 20; i++)
        {
            if (i % 2 != 0) // Kontrollera om talet är udda
            {
                Console.Write($"{i} ");
            }
        }