Console.Clear();
Console.InputEncoding = System.Text.Encoding.Unicode;

// Meny för att välja kryptering eller dekryptering
Console.WriteLine("Ceasar-krypto: Kryptera eller dekryptera ett meddelande.");
Console.WriteLine("1. Kryptera meddelande");
Console.WriteLine("2. Dekryptera meddelande");
Console.Write("Ange ditt val: ");
string val = Console.ReadLine();

if (val == "1")
{
    Kryptera();
}
else if (val == "2")
{
    Dekryptera();
}
else
{
    Console.WriteLine("Ogiltigt val. Avslutar programmet.");
}

static void Kryptera()
{
    Console.WriteLine("Ceasar-krypto: Kryptera ett meddelande.");
    Console.Write("Ange ett meddelande: ");
    string meddelande = Console.ReadLine().ToUpper();

    if (string.IsNullOrWhiteSpace(meddelande))
    {
        Console.WriteLine("Tomt meddelande är inte tillåtet.");
        return;
    }

    Console.Write("Ange en nyckel (1-9): ");
    int nyckel;
    while (!int.TryParse(Console.ReadLine(), out nyckel) || nyckel < 1 || nyckel > 9)
    {
        Console.WriteLine("Nyckeln måste vara ett heltal mellan 1 och 9.");
        Console.Write("Ange en nyckel (1-9): ");
    }

    string alfabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZÅÄÖ";
    string krypteradText = "";

    foreach (char bokstav in meddelande)
    {
        int index = alfabet.IndexOf(bokstav);
        if (index != -1)
        {
            int nyPosition = (index + nyckel) % alfabet.Length;
            krypteradText += alfabet[nyPosition];
        }
        else
        {
            krypteradText += bokstav; // Också behålla tecken som inte finns i alfabetet
        }
    }

    Console.WriteLine($"Chiffertext: {krypteradText}");
}

static void Dekryptera()
{
    Console.WriteLine("Ceasar-krypto: Dekryptera ett meddelande.");
    Console.Write("Ange ett meddelande: ");
    string meddelande = Console.ReadLine().ToUpper();

    if (string.IsNullOrWhiteSpace(meddelande))
    {
        Console.WriteLine("Tomt meddelande är inte tillåtet.");
        return;
    }

    Console.Write("Ange en nyckel (1-9): ");
    int nyckel;
    while (!int.TryParse(Console.ReadLine(), out nyckel) || nyckel < 1 || nyckel > 9)
    {
        Console.WriteLine("Nyckeln måste vara ett heltal mellan 1 och 9.");
        Console.Write("Ange en nyckel (1-9): ");
    }

    string alfabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZÅÄÖ";
    string dekrypteradText = "";

    foreach (char bokstav in meddelande)
    {
        int index = alfabet.IndexOf(bokstav);
        if (index != -1)
        {
            int nyPosition = (index - nyckel + alfabet.Length) % alfabet.Length;
            dekrypteradText += alfabet[nyPosition];
        }
        else
        {
            dekrypteradText += bokstav; // Också behålla tecken som inte finns i alfabetet
        }
    }

    Console.WriteLine($"Klartext: {dekrypteradText}");
}