using OpenBootcamp.Sesion_3;

namespace OpenBootcamp
{
    class Program
    {
        static void Main(string[] args)
        {
            var Cliente = new Cliente();

            //Cliente.Nombre = Cliente.Nombre;
            //Cliente.Telefono = Cliente.Telefono;
            //Cliente.Email = Cliente.Email;
            //Cliente.Direccion = Cliente.Direccion;
            //Cliente.isNewClient = false;
            Cliente.Nombre = "Maicol Estiben Egas";
            Cliente.Telefono = "3158211221";
            Cliente.Email = "maicolegas43@gmail.com";
            Cliente.Direccion = "Cra 36a #94a - 43";
            Cliente.isNewClient = true;


            Console.WriteLine($"Los datos del cliente son: Nombre {Cliente.Nombre}, Telefono: {Cliente.Telefono}, Email {Cliente.Email}, Dirección {Cliente.Direccion}, y {(Cliente.isNewClient ? "No es nuevo" : "Es nuevo")} Cliente");
        }

        
    }
}
