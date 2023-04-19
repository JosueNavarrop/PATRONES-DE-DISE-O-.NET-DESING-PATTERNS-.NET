using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    internal class Empleados
    {

        public Empleados()
        {
           
        }
        public int salariototal(double num1, double num2)
        {
            return (int)(num1 * num2 * 0.18);

        }
        public string? cedulaEmp { get; private set; }
        public string? nombre { get; private set; }

        public string? codigoDep { get; private set; }

        public double precioPorH { get; private set; }

        public double horasWork { get; private set; }
        public void crearEmpleado()
        {
            Console.WriteLine("Ingrese Cedula:");
            cedulaEmp = Console.ReadLine();
            Console.WriteLine(@"");

            Console.WriteLine("Ingrese nombre del empleado");
            nombre = Console.ReadLine();
            Console.WriteLine(@"");

            Console.WriteLine("Ingrese las inciales del departamento\nEjmplo: si su departamento es el de contabilidad su codigo es 'CON'" +
             "\nLas primeras letras de su depatamento ");
            codigoDep = Console.ReadLine();
            Console.WriteLine(@"");

            Console.WriteLine("Ingrese lo que usted cobre por hora");
            precioPorH = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese las horas que va a trabajar o que ya trabajo");
            horasWork = int.Parse(Console.ReadLine());
            Console.WriteLine(@"");

            Console.WriteLine("Su identificación es:");

            Console.WriteLine($"Cedula: {cedulaEmp}");
            Console.WriteLine($"Nombre: {nombre}");

            Random rnd = new Random();

            int pararnd = rnd.Next(1000, 9000);
            Salario sal = new Salario();
            Console.WriteLine($"Departamento {codigoDep}{pararnd}");

            Console.WriteLine($"Su salario calculado con ITBIS es de : {sal.salariototal(precioPorH, horasWork)}\n(Ten en cuenta que para aplicar ITBIS el salario tiene que ser mayor a 35,000)");
        }



    }
}
