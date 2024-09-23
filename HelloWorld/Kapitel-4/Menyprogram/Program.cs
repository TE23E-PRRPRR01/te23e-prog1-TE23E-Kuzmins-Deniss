//
using System.Runtime.CompilerServices;

Console.Clear();
Console.WriteLine("Litet program med meny");
Console.InputEncoding = System.Text.Encoding.Unicode;
Console.OutputEncoding = System.Text.Encoding.Unicode;


//Variabel för valet

string val="";

while (true)
{
//Visar en meny och läser användarens namn
Console.WriteLine("""
1. Omvandla en text till versaler
2. Omvandla en text till gemener
3. Avsluta
Välj ett av alternativ ovan:
""");
val = Console.ReadLine();
//handera användarens val
if (val== "1")
{
    Console.WriteLine("Skriv in en text");
}
else if (val=="1")
{
    Console.WriteLine("Skriv in en text");
    string texten= Console.ReadLine().ToUpper();
Console.WriteLine($"Texten i versaler blir: {texten}");
}
else if (val == "2")
{
     Console.WriteLine("Skriv in en text");
    string texten= Console.ReadLine().ToUpper();
Console.WriteLine($"Texten i versaler blir: {texten}");
}
else if (val == "3")
{
    Console.WriteLine("Avslutar...");
    break;
}
else
{
    Console.WriteLine("Dahri vad gör du?!?!?!?!");
}
}