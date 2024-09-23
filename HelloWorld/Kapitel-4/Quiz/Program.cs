using System;

partial class Program
{
    static void Main()
    {
        bool playAgain = true;

        while (playAgain)
        {
            // Rensa konsolen
            Console.Clear();

            // Fråga efter användarens namn
            Console.WriteLine("Vad heter du?");
            string namn = Console.ReadLine();
            Console.WriteLine($"Hej, {namn}! Välkommen till quizet.");

            // Definiera frågor och svarsalternativ
            string[] questions = {
                "Vad är huvudstaden i Sverige?\n a) Oslo\n b) Stockholm\n c) Köpenhamn",
                "Vilket år började första världskriget?\n a) 1912\n b) 1914\n c) 1916",
                "Vad är den kemiska symbolen för guld?\n a) Au\n b) Ag\n c) Pb"
            };

            char[] correctAnswers = { 'b', 'b', 'a' };

            // Rensa konsolen innan varje fråga
            Console.Clear();

            // Loop igenom frågorna
            for (int i = 0; i < questions.Length; i++)
            {
                Console.Clear(); // Rensa konsolen innan varje fråga
                Console.WriteLine(questions[i]);
                char answer = Console.ReadKey().KeyChar;
                Console.WriteLine(); // För att gå till nästa rad

                // Kontrollera svaret
                if (char.ToLower(answer) == correctAnswers[i])
                {
                    Console.WriteLine("Rätt svar!");
                }
                else
                {
                    Console.WriteLine("Fel svar. Försök igen.");
                }
            }

            // Fråga om användaren vill spela igen
            Console.WriteLine($"{namn}, vill du spela igen? (j/n)");
            char playAgainResponse = Console.ReadKey().KeyChar;
            Console.WriteLine(); // För att gå till nästa rad

            if (char.ToLower(playAgainResponse) != 'j')
            {
                playAgain = false;
                Console.WriteLine("Tack för att du spelade! Hejdå!");
            }
        }
    }
}
