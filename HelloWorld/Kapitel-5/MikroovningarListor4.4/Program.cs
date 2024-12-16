Console.Clear();

// 1. Skapa listor för action- och äventyrsspel
        List<string> actionSpel = new List<string> { "GTA V", "Battlefield" };
        List<string> aventyrsspel = new List<string> { "Uncharted", "The Last of Us" };

        // 3. Användaren fyller på listan med action-spel
        Console.WriteLine("Nu ska du fylla i två action-spel i listan:");
        for (int i = 0; i < 2; i++)
        {
            Console.Write("Ange ett action-spel: ");
            string spel = Console.ReadLine();
            actionSpel.Add(spel);
        }

        // 4. Användaren fyller på lista med äventyrsspel med for-loop
        Console.WriteLine("Nu ska du fylla i tre äventyrsspel i listan:");
        for (int i = 0; i < 3; i++)
        {
            Console.Write("Ange ett äventyrsspel: ");
            string spel = Console.ReadLine();
            aventyrsspel.Add(spel);
        }

        // 6. Skriv ut de två första action-spelen
        Console.WriteLine("\nHär är de två första action-spelen i listan:");
        Console.WriteLine("- Spel 1: " + actionSpel[0]);
        Console.WriteLine("- Spel 2: " + actionSpel[1]);

        // 7. Skriv ut de två sista äventyrsspelen
        Console.WriteLine("\nHär är de två sista äventyrsspelen i listan:");
        Console.WriteLine("- Spel 3: " + aventyrsspel[aventyrsspel.Count - 2]);
        Console.WriteLine("- Spel 4: " + aventyrsspel[aventyrsspel.Count - 1]);

        // 8. Skriv ut alla action- och äventyrsspel med foreach-loop
        Console.WriteLine("\nHär är alla action-spel i listan:");
        foreach (var spel in actionSpel)
        {
            Console.WriteLine("- " + spel);
        }

        Console.WriteLine("\nHär är alla äventyrsspel i listan:");
        foreach (var spel in aventyrsspel)
        {
            Console.WriteLine("- " + spel);
        }
         // 10. Låt användaren fylla på listorna med två spel i varje kategori
        Console.WriteLine("\nRegistrera fler action-spel:");
        for (int i = 0; i < 2; i++)
        {
            Console.Write("Ange ett action-spel: ");
            string spel = Console.ReadLine();
            actionSpel.Add(spel);
        }

        Console.WriteLine("\nRegistrera fler äventyrsspel:");
        for (int i = 0; i < 2; i++)
        {
            Console.Write("Ange ett äventyrsspel: ");
            string spel = Console.ReadLine();
            aventyrsspel.Add(spel);
        }

  