﻿// See https://aka.ms/new-console-template for more information
Console.Clear();
Console.InputEncoding = System.Text.Encoding.Unicode;
Console.OutputEncoding = System.Text.Encoding.Unicode;
Console.WriteLine("Program för att registrera förnamn och efternamn...");
Console.Write("Ange förnamn:");
string förnamn = Console.ReadLine();
Console.Write("Ange efternamn:");
string efternamn = Console.ReadLine();
Console.WriteLine("Hej! " + förnamn + " " + efternamn);
Console.WriteLine($"Hej! {förnamn} {efternamn}");

// Är det Deniss som loggar in?
if (förnamn == "Deniss")
{
    Console.WriteLine("Vad trevligt att du är tillbacka!");
}

if (efternamn == "Kuzmins")
{
    Console.WriteLine("Vackert efternamn!");
}