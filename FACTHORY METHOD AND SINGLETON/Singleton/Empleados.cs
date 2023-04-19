using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    internal class Empleados : IIempleados
    {

       
        public string? cedulaEmp { get; private set; }
        public string? nombre { get; private set; }

        public string? codigoDep { get; private set; }

        public double precioPorH { get; private set; }

        public double horasWork { get; private set; }
        public void crear()
        {
            
            Random rnd = new Random();
            int pararnd = rnd.Next(1000, 9000);

            Console.WriteLine("Ingrese cedula");
            cedulaEmp = Console.ReadLine();
            Console.WriteLine(@"");
            Console.WriteLine("Ingrese nombre empleado");
            nombre = Console.ReadLine();
            Console.WriteLine(@"");
            Console.WriteLine("Ingrese departamento");
            codigoDep = Console.ReadLine();
            Console.WriteLine(@"");
            Console.WriteLine("Ingrese lo que usted cobra por hora");
            precioPorH = double.Parse(Console.ReadLine());
            Console.WriteLine(@"");
            Console.WriteLine("Ingrese las horas trabajadas o las que va a trabajar");
            horasWork = double.Parse (Console.ReadLine());
            Console.WriteLine(@"");

        }

        public void mostrarEmp()
        {
            Salario sal = new Salario();
            Random rnd = new Random();
            int pararnd = rnd.Next(1000, 9000);
            Console.WriteLine("Su empleado");
            Console.WriteLine(@"");
            Console.WriteLine($"Cedula: {cedulaEmp}");
            Console.WriteLine($"Nombre: {nombre}");
            Console.WriteLine($"Departamento: {codigoDep}{pararnd}");
            Console.WriteLine($"Su salario es de: {sal.salariototal(precioPorH, horasWork)}");


        }

        public override string ToString()
        {
            return $"cedula: {cedulaEmp} Nombre: {nombre} CodigoDEp: {codigoDep} Sueldo: {horasWork}";
        }


    }
}
