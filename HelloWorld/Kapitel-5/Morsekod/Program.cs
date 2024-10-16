// En liten morsekod app med förbättrad ljuduppspelning och kortare pauser
using System.IO.Compression;
using System.Text; // Lägg till denna för att använda Encoding

Console.Clear();
Console.WriteLine("En liten morsekod app");

// För att kunna skriva svenska och ryska tecken
Console.InputEncoding = Encoding.Unicode;
Console.OutputEncoding = Encoding.Unicode;

// Två parallella samlingar för svenska, ryska alfabeten och siffror
List<string> alfabet = new List<string> { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J",
            "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T",
            "U", "V", "W", "X", "Y", "Z", "Å", "Ä", "Ö", " ", 
            "0", "1", "2", "3", "4", "5", "6", "7", "8", "9",
            "А", "Б", "В", "Г", "Д", "Е", "Ё", "Ж", "З", "И", "Й", "К", "Л", "М", "Н", "О", "П", "Р", "С", "Т", "У",
            "Ф", "Х", "Ц", "Ч", "Ш", "Щ", "Ъ", "Ы", "Ь", "Э", "Ю", "Я"};

List<string> morsekod = new List<string> { ".-", "-...", "-.-.", "-..", ".", "..-.", "--.",
            "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.",
            "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-",
            "-.--", "--..", ".--.-", ".-.-", "---.", "/", "-----", ".----", "..---", "...--", "....-", ".....",
            "-....", "--...", "---..", "----.",
            ".-", "-...", ".--", "--.", "-..", ".", ".", "...-", "--..", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", ".-.", "...", "-", "..-", "..-.", "....", "-.-.", "---.", "----", "--.-", "--.--", "-.--", "-..-", "..-..", "..--", ".-.-" };

// Läs in ett meddelande
Console.Write("Ange ett meddelande att översätta: ");
string meddelande = Console.ReadLine().ToUpper();

// Justeringar för ljuduppspelning
int kortSignalLängd = 150; // Kort signal (punkt) i ms
int långSignalLängd = 450; // Lång signal (streck) i ms
int mellanrumMellanSignaler = 50; // Paus mellan signaler i samma bokstav
int mellanrumMellanBokstäver = 200; // Paus mellan olika bokstäver

// Gå igenom meddelandet bokstav för bokstav (loop)
foreach (char bokstav in meddelande)
{
    // Hitta bokstaven i alfabetet
    int index = alfabet.IndexOf(bokstav.ToString());

    // Hittar morsetecken (A-Ö eller ryska tecken)?
    if (index >= 0)
    {
        // Skriv ut morsekoden
        string morsetecken = morsekod[index];
        Console.Write($"{morsetecken} ");

        // Spela upp ljud för morsekoden
        foreach (var signal in morsetecken)
        {
            if (signal == '.') // Kort signal (punkt)
            {
                Console.Beep(1000, kortSignalLängd); // Frekvens 1000 Hz, kort signal
            }
            else // Lång signal (streck)
            {
                Console.Beep(1000, långSignalLängd); // Frekvens 1000 Hz, lång signal
            }
            Thread.Sleep(mellanrumMellanSignaler); // Paus mellan signaler
        }

        Thread.Sleep(mellanrumMellanBokstäver); // Paus mellan bokstäver
    }
    else
    {
        Console.Write("? "); // Okänt tecken
    }
}

Console.WriteLine(); // Ny rad efter översättningen
