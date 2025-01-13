// /* **********************************************************************************************
// * ************************** MAIN ****************************************************************
// ************************************************************************************************* */
// using System.Net.WebSockets;

 Console.Clear();

// //Skriv ett meddelande vertikalt
// string meddelande = "Måndag!";
// //SkrivVertikalt(meddelande);

// //Skriv ett meddelande vertikalt
// string meddelande1 = "Tisdag är bättre!";
// //SkrivVertikalt(meddelande1);

// //Skriv ett meddelande vertikalt
// string meddelande2 = "Tisdag är bättre!";
// //SkrivVertikalt(meddelande2);

// //Ritta ut en fyrkant med sidlägd 3
// // RitaKvadrat(3);
// // Console.WriteLine();
// // RitaKvadrat(4);

KastaTärning(6);

//Testa metode OmvandlaCTillF
// OmvadlaCTillF(37);

// //Testar metoden UpprepaText
// UpprepaText("Hej", 3);
// UpprepaText("Hejsan", 5);

// /* *************************************************************************************************
// * **************************** METODER *********************************************************************
// ************************************************************************************************** */


// /// <summary>
// /// Skriv ett meddelande vertikalt
// /// </summary>
// /// <param name="meddelande"></param>
// static void SkrivVertikalt(string meddelande)
// {
// for (int i = 0; i < meddelande.Length; i++) //0 - 6
// {
//     Console.WriteLine(meddelande[i]);
// }
// }
// static void RitaKvadrat(int sidlängd)
// {
//    for (int i = 0; i < sidlängd; i++)
//    {
//     for (int j = 0; j < sidlängd; j++)
//     {
//         Console.Write("*");
//     }
//        Console.WriteLine();
//    }
// }


// static void UpprepaText(string text, int antal)
// {
//     for (int i = 0; i < antal; i++)
//     {
//         Console.WriteLine(text);
//     }
// }


//Omvandla C till F


// static void OmvadlaCTillF(int celsius)
// {
//     int fahrenhite = celsius * 9/5 + 32;
// Console.WriteLine($"{celsius} grader Celsius motsvarar {fahrenhite} grader Fahrenhite");
// }

static void KastaTärning(int antal)
{
 for (int i = 0; i < antal; i++)
 {
    Console.WriteLine($"Tärningen visar {Random.Shared.Next(1,7)}");
 }
}