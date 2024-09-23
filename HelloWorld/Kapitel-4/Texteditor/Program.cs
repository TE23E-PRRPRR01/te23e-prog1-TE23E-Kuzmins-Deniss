//Texteditor so mgör omvandlar texten till fill eller tvärtom från fillen till text
Console.Clear();
Console.WriteLine("ПедоFil");
Console.InputEncoding = System.Text.Encoding.Unicode;
Console.OutputEncoding = System.Text.Encoding.Unicode;

//Variabler för valet
string val ="";


while (true)
{
 //Visar en meny och läser användarens val
 Console.Write("""
 1. Skriv till fil
 2. Läs från fil
 3. Avsluta...
 Välj ett av alernative ovan:
 """);
 val=Console.ReadLine();
 //Handera 
 if (val=="1")
 {
    Console.WriteLine("Skriv in en text");
    string texten = Console.ReadLine();
    File.WriteAllText("filanmn.txt", texten);
 }
 else if(val=="2")
 if (File.Exists("filnamn.txt"))
 {
  string texten = File.ReadAllText("filnamn.txt");  
  Console.WriteLine(texten);
 }
 else
 {
    Console.WriteLine("Filen finn inte!");
 }
 else if(val=="3")
 {
    Console.WriteLine("Avslutar...");
    break;
 }

}