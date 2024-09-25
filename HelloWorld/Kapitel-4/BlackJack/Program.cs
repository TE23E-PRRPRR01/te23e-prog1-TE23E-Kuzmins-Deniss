//Spelet BlackJack, även kallat 21:an
Console.Clear();
Console.WriteLine("Spelet BlackJack");

//Kortens värde är
//Alla bilder värd = 10 poäng
//Alla sifror med sin egen naminal = 2-10
//Ess = 1 (eller 11)
//@todo slump måste efterlikna riktigt kortlek, dvs 4x1, 4x2, .... 4xkung

//VAriabler
int summaSpelare = 0;
int summaDealer = 0;
int kort = 0;

//Dela ut två kort till spelaren
kort = Random.Shared.Next(1, 11); //@todo Knekt, Dam och Kung?
summaSpelare += kort;
kort = Random.Shared.Next(1, 11); //@todo Knekt, Dam och Kung?
summaSpelare += kort;
//Dela ut två kort till Dator
kort = Random.Shared.Next(1, 11); //@todo Knekt, Dam och Kung?
summaDealer += kort;
kort = Random.Shared.Next(1, 11); //@todo Knekt, Dam och Kung?
summaDealer += kort;

//Flera gånger (loop)
while (true)
{
    //Skriv utt summorna
Console.WriteLine($"Du har {summaSpelare} poäng");
Console.WriteLine($"Dealer har {summaDealer} poäng");

//Stanna eller dra ett till kort
Console.Write("Vill du ha ett nytt kort? (ja/nej)");
string svar = Console.ReadLine().ToLower();

if (svar == "nej")
{
    //@todo datorn får ta extra kort <= 17
    while (summaDealer < 17)
    {
    kort = Random.Shared.Next(1, 11); //@todo Knekt, Dam och Kung?
summaDealer += kort;    
    }

// Vem har vunnit?
    //Den som har närmast 21 har vunnit
if (summaSpelare > summaDealer && summaSpelare < 21)
{
    Console.WriteLine("Du har vunnit!");
}
else
{
    Console.WriteLine("Datorn har vunnit!");
}
    break;
}

// Ta ett exktra kort om man vill
kort = Random.Shared.Next(1, 11); //@todo Knekt, Dam och Kung?
summaSpelare += kort;
//Skriv ut kortet
Console.WriteLine($"Du fick {kort} poäng");


// Datorn får också ett nytt kort
kort = Random.Shared.Next(1, 11); //@todo Knekt, Dam och Kung?
summaDealer += kort;
Console.WriteLine($"Dealer fick {kort} poäng");
//Har datorn fått 21 och vunnit?
if (summaDealer == 21)
{
    Console.WriteLine("Dealer har vunnit");
    break;
}
//Har spelaren fått 21 har den vunnit
if (summaSpelare == 21)
{
    Console.WriteLine("Du har vunnit!");
    break;
}

//Är spelaren tjock?
if (summaSpelare > 21)
{
    Console.WriteLine("Du har förlurat!");
    break;
}
//Är dealer tjock?
if (summaDealer > 21)
{
    Console.WriteLine("Dealer har förlurat");
    break;
}
}