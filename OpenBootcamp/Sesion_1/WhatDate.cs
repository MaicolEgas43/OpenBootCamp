
public class WhatDate
{
    private static void Main(string[] args)
    {
        var dateActual = DateTime.Now;

        Console.WriteLine("La fecha actual es: " + dateActual.ToString("dd/MM/yyyy HH:mm:ss"));
    }
}