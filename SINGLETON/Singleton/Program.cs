using Singleton;
using System;

namespace josue
{
    class Program
    {
        static void Main(string[] args)
        {
            string rexh = null;
            Empleados emp = new Empleados();
            Console.WriteLine("Bienvenido al programa de empleados!!\nCree su o sus empleados:");
            Random rnd = new Random();
            int pararnd = rnd.Next(1000, 9000);
            Salario sal = new Salario();
        
                emp.crearEmpleado();

            do
            {
                
                Console.WriteLine(@"");

                Console.WriteLine("A que arganización quiere pertencer o ya pertence?");
                Console.WriteLine("1.Gerente (Solo puede haber un solo gerente)!!\n2.Administrativo\n3.Operativo");
                string respswitch = Console.ReadLine();

                switch (respswitch)
                {
                    case "Gerente":
                        Console.WriteLine(@"");
                        Console.WriteLine("su empleado");
                        Console.WriteLine(emp.cedulaEmp);
                        Console.WriteLine(emp.nombre);
                        Console.WriteLine($"{emp.codigoDep}{pararnd}");
                        Gerencial gerencial = Gerencial.GetGerencial(respswitch);
                        Console.WriteLine($"Usted pertence al Rango de: {gerencial}");
                        Console.WriteLine(@"");
                        Console.WriteLine("Quiere cmbiar el empleado de rago?");
                        rexh= Console.ReadLine();
                        break;


                    case "Administrativo":
                        Console.WriteLine(@"");
                        Console.WriteLine("su empleado");
                        Console.WriteLine(emp.cedulaEmp);
                        Console.WriteLine(emp.nombre);
                        Console.WriteLine($"{emp.codigoDep}{pararnd}");
                        Console.WriteLine("Felicidades usted pertence al rango de: " + respswitch);
                        Console.WriteLine(@"");
                        Console.WriteLine("Quiere cmbiar el empleado de rago?");
                        rexh = Console.ReadLine();
                        break;

                    case "Operativo":
                        Console.WriteLine(@"");
                        Console.WriteLine("su empleado");
                        Console.WriteLine(emp.cedulaEmp);
                        Console.WriteLine(emp.nombre);
                        Console.WriteLine($"{emp.codigoDep}{pararnd}");
                        Console.WriteLine("Felicidades usted pertence al rango de: " + respswitch);
                        Console.WriteLine(@"");
                        Console.WriteLine("Quiere cmbiar el empleado de rago?");
                        rexh = Console.ReadLine();
                        break;
                }

            } while (rexh == "si");


        }

    }


   
}