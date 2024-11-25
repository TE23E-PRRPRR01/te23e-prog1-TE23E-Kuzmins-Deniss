        // Steg 1: Skapa en lista
        List<string> namnLista = new List<string> { "Anna", "Bjorn", "Cecilia" };
        Console.WriteLine("Nuvarande lista: " + string.Join(", ", namnLista));

        // Steg 2: Lägg till ett namn
        Console.Write("Ange ett namn att lägga till: ");
        string namnAttLäggaTill = Console.ReadLine();
        namnLista.Add(namnAttLäggaTill);
        Console.WriteLine("Listan efter tillägg: " + string.Join(", ", namnLista));

        // Steg 3: Ta bort ett namn
        Console.Write("Ange ett namn att ta bort: ");
        string namnAttTaBort = Console.ReadLine();
        if (namnLista.Contains(namnAttTaBort))
        {
            namnLista.Remove(namnAttTaBort);
            Console.WriteLine("Listan efter borttagning: " + string.Join(", ", namnLista));
        }
        else
        {
            Console.WriteLine($"Fel: {namnAttTaBort} finns inte i listan.");
        }

        // Steg 4: Sök efter ett namn
        Console.Write("Ange ett namn att söka efter: ");
        string namnAttSöka = Console.ReadLine();
        if (namnLista.Contains(namnAttSöka))
        {
            Console.WriteLine($"{namnAttSöka} finns i listan.");
        }
        else
        {
            Console.WriteLine($"{namnAttSöka} finns inte i listan.");
        }

