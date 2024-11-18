 Console.Clear();
 
 while (true) // Möjlighet att köra programmet igen
        {
            // Be användaren skriva sitt namn
            Console.Write("Ange ditt namn: ");
            string userName = Console.ReadLine();

            // Be användaren ange antalet repetitioner
            int repetitions = 0;
            while (true)
            {
                Console.Write("Hur många gånger vill du skriva ut ditt namn? (1-10): ");
                string input = Console.ReadLine();
                if (int.TryParse(input, out repetitions) && repetitions >= 1 && repetitions <= 10)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Felaktig inmatning. Ange ett tal mellan 1 och 10.");
                }
            }

            // Skriv ut namnet det valda antalet gånger
            Console.WriteLine("\nResultat:");
            for (int i = 0; i < repetitions; i++)
            {
                Console.WriteLine($"{i + 1}. {userName}");
            }

            // Be användaren mata in ett tal för beräkningar
            Console.WriteLine("\nNu ska vi göra beräkningar. Mata in ett tal.");
            double number = 0;
            while (true)
            {
                Console.Write("Ange ett tal: ");
                string input = Console.ReadLine();
                if (double.TryParse(input, out number))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Felaktig inmatning. Ange ett giltigt tal.");
                }
            }

            // Utför beräkningarna
            Console.WriteLine($"\nResultat av beräkningar:");
            Console.WriteLine($"Multiplicerat med 2: {number * 2}");
            Console.WriteLine($"Dividerat med 2: {number / 2}");
            Console.WriteLine($"Adderat med 2: {number + 2}");
            Console.WriteLine($"Subtraherat med 2: {number - 2}");

            // Möjlighet att köra programmet igen
            Console.WriteLine("\nVill du köra programmet igen? (j/n): ");
            string choice = Console.ReadLine()?.ToLower();
            if (choice != "j")
            {
                Console.WriteLine("Programmet avslutas. Tack!");
                break;
            }
        }