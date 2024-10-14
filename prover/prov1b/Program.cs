//Det här programmet räknar ut din lön, sk nettolön, efter marginalskatten.
Console.Clear();
Console.WriteLine("""
Det här programmet räknar ut din lön, sk nettolön, efter marginalskatten.
Marginalskatten räknas ut baserat på din bruttolön.
Med bruttolön avses din årslön före skatt.
""");

Console.Write("Vad heter du?");
string namn = Console.ReadLine();

//Programloop
while (true)
{
    Console.Write("Ange din bruttolön i kronor");
    int bruttolön = int.Parse(Console.ReadLine());

    //Har användaren matat vettiga sifror
    if (bruttolön < 10000 || bruttolön > 10000000)
    {
        Console.WriteLine($"{namn} Bruttolön måste vara mellan 10000:- och 1000000:-");
    }

    else
    {
        //Vad är skattesatsen?
        //10000:- till 145000:- -> 22%
        int skattesatsen = 0; //Skapa variabel skattesatsen
        if (bruttolön >= 10000 && bruttolön < 145000)
        {
            skattesatsen = 22;
        }
        //145000:- till 515000:- -> 33%
        if (bruttolön >= 14500 && bruttolön < 515000)
        {
            skattesatsen = 33;
        }
        //515000:- eller mer -> 53%
        else if (bruttolön >= 515000)
        {
            skattesatsen = 53;
        }42        //skatteuträkning
        int nettolön = bruttolön * (100 - skattesatsen) / 100;

        //Fedback till användaren, resultatet
        Console.WriteLine($"Din nettolön blir {nettolön} kr. Uträkningar baserad på bruttolön {bruttolön} kr marginalskattet {skattesatsen}%.");
    }
    //Vill du göra ny beräkning?
    Console.Write("Vill du göra ny beräkning?");
    string görOm = Console.ReadLine().ToLower().Trim();
    if (görOm != "j")
    {
        break;
    }
}

