Console.Clear();

List<string> listaNamn = ["Anna", "Björn", "Cecilia", "Daniel", "Eva"];
Console.WriteLine($"Min kompisar är: {string.Join(",", listaNamn)}");

List<string> listaOrter = ["Stockholm", "Göteborg", "Malmö", "Uppsala", "Lund"];

List<int> listaÅrtal = [1492, 1776, 1914, 1945, 1969];
Console.WriteLine($"Fem viktiga årtal: {string.Join("', '", listaÅrtal)}");

// Exempel med språk
Console.WriteLine("Första namn: " + listaNamn[0]);
Console.WriteLine("Sista namn: " + listaNamn[4]);

List<string> listaDryckor = ["Kaffe", "Te", "Cola", "Juice", "Vatten"];
Console.WriteLine($"Mina favoritdrycker: {string.Join("', '", listaDryckor)}");

Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine(listaDryckor[0]);
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine(listaDryckor[1]);
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine(listaDryckor[2]);
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine(listaDryckor[3]);
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine(listaDryckor[4]);
Console.ResetColor();

List<int> listaFödelseår = [2000, 1995, 1990, 1985, 1980];
Console.WriteLine($"Födelseår: {string.Join("', '", listaFödelseår)}");