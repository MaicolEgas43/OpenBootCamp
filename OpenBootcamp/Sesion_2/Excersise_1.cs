//Variables Escribe un programa que reciba datos de una persona y genera un mensaje,
//usa una variable para cada dato y otra para el mensaje. Ej: nombre, apellido, edad, sabe programar, etc.

public class Excersise_1
{
    private static void Main(string[] args)
    {
        var fullName = Console.ReadLine();
        var lastName = Console.ReadLine();
        int yearsOld = Convert.ToInt32(Console.ReadLine());
        bool isProgrammer = true;

        Console.WriteLine("Your full name is " + fullName);
        Console.WriteLine("Your lastName is  " + lastName);
        Console.WriteLine("You have  " + yearsOld + "years old");
        Console.WriteLine("and is " + isProgrammer + " that you are programmer");


    }
}