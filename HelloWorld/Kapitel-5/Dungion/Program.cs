// Ett Dungeon-spel med massa rum, saker, fiender, skatter..
Console.Clear();
Console.WriteLine("Ett Dungeon-spel");

//Program variabler (state variabels)
string rum = "hallen";
List<string> inventory = [];

//spelloop
while (true)
{
    //Är vi i hallen?
    if (rum == "hallen")
    {
        Console.WriteLine("Du är i hallen");
        Console.WriteLine("1. titta runt");
        Console.WriteLine("2. gå till nästa rum");
        Console.WriteLine("Vad vill du göra? ");
        string val = Console.ReadLine();
        if (val == "1")
        {
            Console.WriteLine("Du kollar dig omkring och ser en gammal matta med ljus på väggarna");
        }
        else if (val == "2")
        {
            rum = "rum 1";
            Console.WriteLine("Du tar dig vidare till nästa rum");
        }
    }
    else if (rum == "rum 1")
    {
        Console.WriteLine("Du är i rum 1");
        Console.WriteLine("1. titta runt");
        Console.WriteLine("2. går tillbacka");
        Console.WriteLine("3. gå till nästa rum");
        Console.WriteLine("Vad vill du göra? ");
        string val = Console.ReadLine();
        if (val == "1")
        {
            Console.WriteLine("Du kollar dig omkring och ser en nyckel");
            Console.WriteLine("Vill du plocka up den? (j/n)");
            val = Console.ReadLine().ToLower();
            if (val == "j")
            {
                inventory.Add("nyckel");
                Console.WriteLine("nyckeln tillagld till inventory");
            
            }
            else
            {
                Console.WriteLine("du lämna nyckeln");
            }
        }
        else if (val == "2")
        {
            Console.WriteLine("");
            rum = "hallen";
        }
        else if (val == "3")
        {
            Console.WriteLine("Du tar dig vidare till nästa rum");
            rum = "rum 2";
        }
    }
    else if (rum == "rum 2")
    {

    }
}

