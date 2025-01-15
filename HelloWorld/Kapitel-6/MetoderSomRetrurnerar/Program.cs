/* **********************************************************************************************
* ************************** MAIN ****************************************************************
************************************************************************************************* */
//Använd metoder här!
// int svar = Addera(3, 5);
// Console.WriteLine($"Svaret är {svar}");
// Console.WriteLine(Addera(3, 5));
// Console.WriteLine($"3 + 5 = {Addera(3, 5)}");

// string namn = "Daria";
// Console.WriteLine($"{namn} beklänges är {VändText(namn)}");


using System.Reflection;

// Console.WriteLine($"3 * 2 = {Multiplicera(3, 2)}");

// Console.WriteLine($"4 / 2 = {Dividera(4, 2)}");


Console.WriteLine($"Detta ord  {Längst("Hej", "Hejdå")}");

Console.Write("Ange ett tal");
int nyttTal1 = LäsInHeltal();

Console.Write("Ange ett tal");
int nyttTal2 = LäsInHeltal();

/* **********************************************************************************************
* ************************** METODER ****************************************************************
************************************************************************************************* */
//Skapa metoder här!

/// <summary>
/// Summer två tal
/// </summary>
/// <param name="tal1"></param>
/// <param name="tal2"></param>
/// <returns></returns>¨


// static int Addera(int tal1, int tal2) //Signatur
// {
//     int summa = tal1 + tal2;
//     return summa;
// }

// static string VändText(string text)
// {
//     string omvändText = "";
//     for (int i = text.Length - 1; i >= 0; i--)
//     {
//         omvändText += text[i];
//     }
//     return omvändText;
// }


/// <summary>
/// MUltiplication
/// </summary>
/// <param name="tal1"></param>
/// <param name="tal2"></param>
/// <returns></returns>
// static double Multiplicera(double tal1, double tal2)
// {
//     double summa = tal1 * tal2;
//     return summa;
// }

/// <summary>
/// Divission
/// </summary>
/// <param name="tal1"></param>
/// <param name="tal2"></param>
/// <returns></returns>
static double Dividera(double tal1, double tal2)
{
    double summa = tal1 / tal2;
    return summa;
}

/// <summary>
/// Kollar vilken ord är längre
/// </summary>
/// <param name="text1"></param>
/// <param name="text2"></param>
/// <returns></returns>

static string Längst(string text1, string text2)
{
if (text1.Length > text2.Length)
{
    return text1;
}else
{
    return text2;
}
}

static int LäsInHeltal()
{
    int tal = 0;
    while (true)
    {
        //Läs in 
            string textSomBlirTal = Console.ReadLine();
        //Kolla om texten är ett tal
           bool lyckades = int.TryParse(textSomBlirTal, out tal);

           if (lyckades = true)
           {
            break;
           }else
           {
            Console.WriteLine("Felaktigt! Vad god ange ett heltal!");
           }
    }
   return tal;
}
