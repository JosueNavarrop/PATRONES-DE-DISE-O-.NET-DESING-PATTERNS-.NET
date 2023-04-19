using josuenav;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace PatronObserverJosue
{
    public class Empleados: IObservador
    {
        
        public string nombre { get; set; }

        public int edad { get; set; }

        public string correo { get; set; }

        public string departamento { get; set; }

        public string Telefono { get; set; }
        

        public Empleados(string nombre, int edad, string correo, string departamento, string telefono)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.correo = correo;
            this.departamento = departamento;
            this.Telefono = telefono;
        }


        public void Actualizar()
        {
            Console.WriteLine("Se le a alterado los cupos a una materia ('Empleados')");

        }


    }
}
