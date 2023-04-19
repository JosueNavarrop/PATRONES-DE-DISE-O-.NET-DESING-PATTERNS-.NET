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
            Console.WriteLine("Quiere guardar los documentos en un archivo de excel?");
            string resp = Console.ReadLine().ToLower();
            if (resp == "si")
            {
                string pathFile = "C:\\Users\\User\\Desktop\\Mis Datos.xlsx";

                SLDocument oSLDocument = new SLDocument();

                System.Data.DataTable dt = new System.Data.DataTable();


                dt.Columns.Add("Nombre Completo", typeof(string));
                dt.Columns.Add("Edad", typeof(int));
                dt.Columns.Add("Provincia", typeof(string));


                dt.Rows.Add(nombreComp, edad, provincia);


                oSLDocument.ImportDataTable(1, 1, dt, true);

                oSLDocument.SaveAs(pathFile);
            }
        }

    }
}
