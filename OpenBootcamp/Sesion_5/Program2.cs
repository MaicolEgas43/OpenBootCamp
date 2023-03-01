using System;

namespace OpenBootcamp.Sesion_5
{
    class Program2
    {
        static void Main(string[] args)
        {
            List<string> lenguajesProgramation = new List<string>() { "1. Java", "2. Python", "3. C#", "4. C", "5. Javascript" };
            Console.WriteLine("Elige un lenguaje de programacion. ");
            foreach (var item in lenguajesProgramation)
            {
                Console.WriteLine($"{item}");
            }
             var opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.WriteLine("En Java se escribe un hola mundo de la siguente forma: ");
                    Console.WriteLine("Class Program {");
                    Console.WriteLine(" public void main(string[] args) {");
                    Console.WriteLine("    System.out.println(\"Hola mundo \");");
                    Console.WriteLine("  }");
                    Console.WriteLine("}");
                    break;
                case 2:
                    Console.WriteLine("En Python se escribe un hola mundo de la siguente forma: ");
                    Console.WriteLine("print(Hola Mundo)");
                    break;
                case 3:
                    
                    Console.WriteLine("En C# se escribe un hola mundo de la siguente forma: ");
                    Console.WriteLine("Class Program {");
                    Console.WriteLine(" static void main(string[] args) {");
                    Console.WriteLine("    Console.WriteLine(\"Hola mundo \");");
                    Console.WriteLine("  }");
                    Console.WriteLine("}");
                    break;
                case 4:
                    Console.WriteLine("En C se escribe un hola mundo de la siguente forma: ");
                    Console.WriteLine("# include <stdio.h>");
                    Console.WriteLine("int main(){");
                    Console.WriteLine(" printf(\"Hola, mundo!\\n\");");
                    Console.WriteLine("return 0;");
                    Console.WriteLine("}");
                    break;
                default:
                    Console.WriteLine("En JavaScript se escribe un hola mundo de la siguente forma: ");
                    Console.WriteLine("console.log(\"Hola, mundo\");");
                    break;
            }

        }
    }
}
