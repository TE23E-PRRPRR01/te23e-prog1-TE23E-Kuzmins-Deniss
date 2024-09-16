//spelet - Gissa ett slumpyal 1-100
Console.Clear();
Console.WriteLine("Spelet - gissa ett slumptal 1-100");

//Be användaren ange min och max slumptalet
Console.WriteLine("Ange slumptalets min-värde?");
int min = int.Parse(Console.ReadLine());
Console.WriteLine("Ange slumptalets max-värde?");
int max = int.Parse(Console.ReadLine());

//Slumpar ett tal 1-100
int slumptal = Random.Shared.Next(min, max +1);

//upprepning - lopp
while (true)
{
//ställ fråga till användare
Console.WriteLine($"Gissa ett tal ({min}-{max})");
int gissning = int.Parse(Console.ReadLine());


//Kontroll om gissning är rätt?
if (gissning == slumptal)
{
    Console.WriteLine("Jackpot");
    break;
}
else if (gissning > slumptal)
{
    Console.WriteLine("För högt!");
}
else
{
    Console.WriteLine("För lågt!");
}

//Vill du gissa en gång till?
Console.Write("Vill du gissa en gång till? (ja/nej)");
string svar = Console.ReadLine();
if (svar == "nej")
{
    break;
}
}
//Slut på spelet
Console.WriteLine("Slut! Tack för att du spelade mi fina spel!"); 