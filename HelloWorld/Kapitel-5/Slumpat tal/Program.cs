using System.ComponentModel;

Console.Clear();
Console.WriteLine("Slumpa många tal och spara i lista");

List<int> listaSlumptal = [];

Console.Write("ange antal slumptal: ");
int antal = int.Parse(Console.ReadLine());

Console.Write("Ange minsta värde för slumptal: ");
int min = int.Parse(Console.ReadLine());
Console.Write("Ange högsta värde för slumptal: ");


//Loopa 5 gånger
for (int i = 0; i < antal; i++)
{
    //Slumpa ett tal 1-100
    int slumptal = 0;
    slumptal = Random.Shared.Next(min, max + 1);

    //Lägg till slumptalet i listan
    listaSlumptal.Add(slumptal);

    Console.WriteLine($"Slumpat tal {i + 1}: {slumptal}");
}