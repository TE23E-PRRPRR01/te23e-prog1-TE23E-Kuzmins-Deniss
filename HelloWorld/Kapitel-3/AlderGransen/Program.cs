Console.Clear();
Console.WriteLine("Länders Åldersgränser på Alkohol");

Console.WriteLine("Hur gammal är du?");

string ÅlderTexr = Console.ReadLine();

int Ålder = int.Parse(ÅlderTexr);

if (Ålder == 16)
{
    Console.WriteLine("Österrike 16, Belgien 16,  Bosnien 16, Tyskland 16, Italien 16, Liechtenstein 16, Luxemburg 16, Nederländerna 16, Schweiz 16");
}
if (Ålder == 17)
{
    Console.WriteLine("Cypern 17, Malta	17");
}
if (Ålder == 18)
{
    Console.WriteLine("Vitryssland	18, Kroatien 18, Tjeckien 18, Danmark 18, Finland 18, Frankrike	18, Grekland 18, Ungern	18, Irland 18, Litauen 18, Norge 18, Polen	18, Portugal 18, Ryssland 18, Serbien 18, Slovakien	18, Slovenien 18, Spanien 18, Sverige 18, Ukraina 18, Storbritannien 18");
}
if (Ålder ==  20)
{
    Console.WriteLine("Island 20");
}
if (Ålder < 16)
{
    Console.WriteLine("Du får inte dricka någonstans din jävla unge (Jag mennar lagligt din idiot)!!");
}

if (Ålder > 20)
{
    Console.WriteLine("Du är fritt, och du kan dricka vad du vill");
}