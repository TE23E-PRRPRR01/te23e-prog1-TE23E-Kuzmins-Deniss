// Program som simulerar kända Engineering Flowchart
using System.Xml.Schema;

Console.Clear();
Console.WriteLine("Välkommen till ingenjörens flödesschema");

//Visa en ASCii art
Console.WriteLine($"""

                                 _..-------++._
                             _.-'/ |      _||  \"--._
                       __.--'`._/_\j_____/_||___\    `----.
                  _.--'_____    |          \     _____    /
                _j    /,---.\   |        =o |   /,---.\   |_
               [__]==// .-. \\==`===========/==// .-. \\=[__]
                 `-._|\ `-' /|___\_________/___|\ `-' /|_.'    
                       `---'                     `---'
""");

Console.Write("Does it move? (Yes/No)");
string answer = Console.ReadLine();

//Kolla om svara ja eller nej
if (answer == "Yes")
{ // Yes
    Console.Write("Should it? (Yes/No)");
    answer = Console.ReadLine();
    if (answer == "Yes")
    {
        Console.WriteLine("No problem!");
    }
    else
    {
        Console.WriteLine("Plz use Duct Tape!");
    }
}
else
{ // No
        Console.Write("Should it? (Yes/No)");
 answer = Console.ReadLine();
 if (answer == "Yes")
 {
    Console.WriteLine("Plz use WD-40!");
 }
 else
 {
    Console.WriteLine("No problem!");
 }
 
}
