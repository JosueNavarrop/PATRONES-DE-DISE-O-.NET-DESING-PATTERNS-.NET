using Singleton;
using System;
using System.IO;
using System.Runtime.CompilerServices;

namespace josue
{
    class Program
    {
        static void Main(string[] args)
        {
            string rexh = null;
            Console.WriteLine("Quiere crear un empleado?");
            string yes = Console.ReadLine();

            IIempleados iempleados = Fabrica_empleados.GetIempleados(yes);

            iempleados.crear();

            iempleados.mostrarEmp();
            do
            {
                Console.WriteLine(@"");

                Console.WriteLine("A que arganización quiere pertencer o ya pertence?");
                Console.WriteLine("1.Gerente (Solo puede haber un solo gerente)!!\n2.Administrativo\n3.Operativo");
                string respquieroser = Console.ReadLine();


                switch (respquieroser)
                {

                    case "Gerente":
                        Console.WriteLine(@"");
                        iempleados.mostrarEmp();
                        Gerencial gerencial = Gerencial.GetGerencial(respquieroser);
                        Console.WriteLine($"{gerencial}");
                        Console.WriteLine(@"");
                        Console.WriteLine("Quiere imprimir la factura?");
                        string yesfac = Console.ReadLine();
                        if (yesfac == "si")
                        {
                            Console.WriteLine(@"");
                            Console.WriteLine("Ingrese lo que cobra por hora nuevamente:");
                            double cxHora = double.Parse(Console.ReadLine());
                            Console.WriteLine("Ingrese las horas que va trabajar o que ya trabajo nuevamente:");
                            double hTra = double.Parse(Console.ReadLine());
                            StreamWriter escribir = new StreamWriter(@"C:\Users\User\Desktop\Factura.txt", true);
                                escribir.WriteLine(iempleados.ToString());
                            escribir.Close();
                            Console.WriteLine("Quiere cambiar el empleado de rango?\n'no' para imprimir la factura");
                            rexh = Console.ReadLine();

                        }
                        break;

                    case "Administrativo":
                        Console.WriteLine(@"");
                        iempleados.mostrarEmp();
                        Console.WriteLine("Felicidades usted pertence al rango de: " + respquieroser);
                        Console.WriteLine(@"");
                        Console.WriteLine("Quiere imprimir la factura?");
                        string yesfac2 = Console.ReadLine();
                        if (yesfac2 == "si")
                        {
                            Console.WriteLine(@"");
                            Console.WriteLine("Ingrese lo que cobra por hora nuevamente:");
                            double cxHora = double.Parse(Console.ReadLine());
                            Console.WriteLine("Ingrese las horas que va trabajar o que ya trabajo nuevamente:");
                            double hTra = double.Parse(Console.ReadLine());
                            StreamWriter escribir = new StreamWriter(@"C:\Users\User\Desktop\Factura.txt", true);
                            escribir.WriteLine(iempleados.mostrarEmp);
                            escribir.Close();
                            Console.WriteLine("Quiere cambiar el empleado de rango?\n'no' para imprimir la factura");
                            rexh = Console.ReadLine();

                        }
                        break;

                    case "Operativo":
                        Console.WriteLine(@"");
                        iempleados.mostrarEmp();
                        Console.WriteLine("Felicidades usted pertence al rango de: " + respquieroser);
                        Console.WriteLine(@"");
                        Console.WriteLine("Quiere imprimir la factura?");
                        string yesfac3 = Console.ReadLine();
                        if (yesfac3 == "si")
                        {
                            Console.WriteLine(@"");
                            Console.WriteLine("Ingrese lo que cobra por hora nuevamente:");
                            double cxHora = double.Parse(Console.ReadLine());
                            Console.WriteLine("Ingrese las horas que va trabajar o que ya trabajo nuevamente:");
                            double hTra = double.Parse(Console.ReadLine());
                            StreamWriter escribir = new StreamWriter(@"C:\Users\User\Desktop\Factura.txt", true);
                            escribir.WriteLine(iempleados.mostrarEmp);
                            escribir.Close();
                            Console.WriteLine("Quiere cambiar el empleado de rango?\n'no' para imprimir la factura");
                            rexh = Console.ReadLine();

                        }
                        break;
                }
            } while (rexh == "si");

            
        }

    }


   
}