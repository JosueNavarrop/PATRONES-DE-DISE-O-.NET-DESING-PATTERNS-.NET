using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el telefono");

            string tel = Console.ReadLine();

            Telefono telefono = Telefono.GetTelefono(tel);

            Console.WriteLine("Ingrese otro telefono");

            string tel2 = Console.ReadLine();

            Telefono telefono2 = Telefono.GetTelefono(tel2);

            Console.WriteLine($"{telefono} & {telefono2}");
            Console.WriteLine(telefono==telefono2);

        }
    }
}
