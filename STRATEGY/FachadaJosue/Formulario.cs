using SpreadsheetLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class Formulario
    {
        public string nombre;

        public string apellido;

        public double fechaNac;

        public double edad;

        public string provincia;

        public string nombreComp;


        public void informaciongen()
        {
            Console.WriteLine("Ingrese su nombre");
            nombre = Console.ReadLine();
            Console.WriteLine(@"");
            Console.WriteLine("Ingrese su apellido");
            apellido = Console.ReadLine();
            nombreComp = nombre + " " + apellido;
            Console.WriteLine(@"");
            Console.WriteLine("Ingrese su fecha de nacimiento");
            fechaNac = double.Parse(Console.ReadLine());
            edad = 2023 - fechaNac;
            Console.WriteLine(@"");
            Console.WriteLine("ingrese su provincia");
            provincia = Console.ReadLine();


            Console.WriteLine(@"");
            Console.WriteLine($"Su nombre completo es: {nombreComp}");
            Console.WriteLine($"Su edad es: {edad}");
            Console.WriteLine($"Usted pertenese a la provincia de: {provincia}");
            Console.WriteLine(@"");
        }

        public override string ToString()
        {
            return "Nombre:"+nombre+ " "+"Edad:"+edad+ " "+"Provincia:" + provincia;
        }
    }
}
