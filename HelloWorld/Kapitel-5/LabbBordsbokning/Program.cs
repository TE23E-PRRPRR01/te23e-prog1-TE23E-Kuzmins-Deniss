  // Variabler
        string filnamn = "centralbord.csv";
        string tomtBordBeskrivning = "0,Inga gäster,0";
        int antalBord = 8;
        string[] bordsInformation;

        // Kontrollera om filen finns, annars skapa en ny
        if (!File.Exists(filnamn))
        {
            bordsInformation = new string[antalBord];
            for (int i = 0; i < antalBord; i++)
            {
                bordsInformation[i] = tomtBordBeskrivning;
            }
            File.WriteAllLines(filnamn, bordsInformation);
            Console.WriteLine("Fil med bordsinformation hittades ej, ny information skapades.");
        }
        else
        {
            bordsInformation = File.ReadAllLines(filnamn);
        }

        // Huvudmeny
        while (true)
        {
            Console.WriteLine("\nVälj ett alternativ:");
            Console.WriteLine("1. Visa alla bord");
            Console.WriteLine("2. Lägg till/ändra bordsinformation");
            Console.WriteLine("3. Markera att ett bord är tomt");
            Console.WriteLine("4. Ange nota för ett bord");
            Console.WriteLine("5. Avsluta programmet");

            Console.Write("Välj ett alternativ: ");
            string val = Console.ReadLine();

            switch (val)
            {
                case "1":
                    VisaAllaBord(bordsInformation);
                    break;
                case "2":
                    ÄndraBordsInformation(bordsInformation, filnamn);
                    break;
                case "3":
                    MarkeraBordSomTomt(bordsInformation, filnamn, tomtBordBeskrivning);
                    break;
                case "4":
                    AngeNota(bordsInformation, filnamn);
                    break;
                case "5":
                    Console.WriteLine("Avslutar programmet...");
                    return;
                default:
                    Console.WriteLine("Ogiltigt val, försök igen.");
                    break;
            }
        }

    static void VisaAllaBord(string[] bordsInformation)
    {
        Console.WriteLine("\nBordsinformation:");
        int totaltAntalGäster = 0;
        int totaltNota = 0;

        for (int i = 0; i < bordsInformation.Length; i++)
        {
            string[] delar = bordsInformation[i].Split(',');
            int antalGäster = int.Parse(delar[0]);
            string namn = delar[1];
            int nota = int.Parse(delar[2]);

            Console.WriteLine($"Bord {i + 1} - Namn: {namn}, Antal gäster: {antalGäster}, Nota: {nota} kr");

            totaltAntalGäster += antalGäster;
            totaltNota += nota;
        }

        Console.WriteLine($"Totalt antal gäster: {totaltAntalGäster}");
        Console.WriteLine($"Total nota: {totaltNota} kr");
    }

    static void ÄndraBordsInformation(string[] bordsInformation, string filnamn)
    {
        Console.Write("Ange bordsnummer (1-8): ");
        if (int.TryParse(Console.ReadLine(), out int bordsnummer) && bordsnummer >= 1 && bordsnummer <= 8)
        {
            Console.Write("Skriv in bordets namn: ");
            string namn = Console.ReadLine();
            Console.Write("Hur många gäster finns vid bordet? ");
            if (int.TryParse(Console.ReadLine(), out int antalGäster))
            {
                bordsInformation[bordsnummer - 1] = $"{antalGäster},{namn},0";
                File.WriteAllLines(filnamn, bordsInformation);
                Console.WriteLine("Bordsinformationen uppdaterades.");
            }
            else
            {
                Console.WriteLine("Ogiltigt antal gäster.");
            }
        }
        else
        {
            Console.WriteLine("Ogiltigt bordsnummer.");
        }
    }

    static void MarkeraBordSomTomt(string[] bordsInformation, string filnamn, string tomtBordBeskrivning)
    {
        Console.Write("Ange bordsnummer (1-8): ");
        if (int.TryParse(Console.ReadLine(), out int bordsnummer) && bordsnummer >= 1 && bordsnummer <= 8)
        {
            bordsInformation[bordsnummer - 1] = tomtBordBeskrivning;
            File.WriteAllLines(filnamn, bordsInformation);
            Console.WriteLine("Bordet markerades som tomt.");
        }
        else
        {
            Console.WriteLine("Ogiltigt bordsnummer.");
        }
    }

    static void AngeNota(string[] bordsInformation, string filnamn)
    {
        Console.Write("Ange bordsnummer (1-8): ");
        if (int.TryParse(Console.ReadLine(), out int bordsnummer) && bordsnummer >= 1 && bordsnummer <= 8)
        {
            Console.Write("Ange nota för bordet: ");
            if (int.TryParse(Console.ReadLine(), out int nota))
            {
                string[] delar = bordsInformation[bordsnummer - 1].Split(',');
                bordsInformation[bordsnummer - 1] = $"{delar[0]},{delar[1]},{nota}";
                File.WriteAllLines(filnamn, bordsInformation);
                Console.WriteLine("Notan uppdaterades.");
            }
            else
            {
                Console.WriteLine("Ogiltigt belopp.");
            }
        }
        else
        {
            Console.WriteLine("Ogiltigt bordsnummer.");
        }
    }