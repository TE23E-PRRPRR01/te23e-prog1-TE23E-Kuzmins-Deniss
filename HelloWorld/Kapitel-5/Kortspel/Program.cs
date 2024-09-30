//Ett anna exermpel. Lista på 3 årtal   
//List<int> årtal = [1957, 1969, 1989];
//Hur man skapar och anväbder listor
using System.ComponentModel;

Console.Clear();
Console.WriteLine("Slumpa kort ur ett kortlek!");

//Skapa en lista kort
List<string> kortlek = ["Ess","Tvåa","Trea","Fyra","Femma","Sexa","Sjua","Åtta","Nia","Tia","Knekt","Dam","Kung"];

internal antal = 5;
while (true)
{
//Slumpa index 0-12
int index = Random.Shared.Next(0, kortlek.Count);
//Console.WriteLine($"Det slumpade index = {index}");

//Plocka ut det sjunde kortet, index = 6
string kort = kortlek[index];

//Ta bort kortet ur kortleket
kortlek.RemoveAt(index);

//Skriv ut 7:e kortet
Console.WriteLine($"Det slumpade jortet är {kort}");

//Räkna ned
antal--;
}