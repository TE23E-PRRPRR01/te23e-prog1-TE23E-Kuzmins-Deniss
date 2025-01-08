﻿/* **********************************************************************************************
* ************************** MAIN ****************************************************************
************************************************************************************************* */

using System.Runtime.InteropServices.Marshalling;

Console.Clear();
Console.WriteLine("Hello, World!");

SägHejNamn("Deniss");
KvadreraTal(2);


/* *************************************************************************************************
* **************************** METODER *********************************************************************
************************************************************************************************** */

static void SägHejNamn(string namn)
{
    Console.WriteLine($"Hej på dig {namn}!");
}


static void KvadreraTal(int tal)
{
    Console.WriteLine($"{tal} i kvadrat = {tal*tal}");
}