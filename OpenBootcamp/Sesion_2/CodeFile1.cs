
/*
 * Variables Escribe un programa que reciba datos de una persona y genera un mensaje, usa una variable para cada dato y otra para el mensaje. 
 * Ej: nombre, apellido, edad, sabe programar, etc. 
 */


using Humanizer;

var nombre = Console.ReadLine();
var apellido = Console.ReadLine();
var edad = Convert.ToInt32(Console.ReadLine());
bool isProgrammer = false;


//Console.WriteLine($"Tu nombre es {nombre} {apellido} y tienes {edad.ToWords("NO", new System.Globalization.CultureInfo("es"))} y {isProgrammer} programador");


string mensaje = $"Tu nombre es {nombre} {apellido} y tienes {edad} y {(isProgrammer ? "eres" : "no eres")} programador";
Console.WriteLine(mensaje);




