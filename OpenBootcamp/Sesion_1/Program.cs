namespace MiPrograma
{
    class Program1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("INgresa el ancho: ");
            var ancho = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("INgresa el ancho: ");
            var alto = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Para el relleno 1 si;  0 no : ");
            var relleno = Convert.ToInt32(Console.ReadLine());

            for (var i = 0; i < alto; i++)
            {
                for (var j = 0; j < ancho; j++)
                {
                    if(relleno == 1)
                    {
                        Console.Write("*");
                    }
                    
                    
                    else
                    {
                        if(i == 0 || i == alto-1 || j == 0 || j == ancho  -1  )
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                    
                }
                Console.WriteLine();
            }
        }
    }
}

