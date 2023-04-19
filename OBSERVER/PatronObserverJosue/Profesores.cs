using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronObserverJosue
{
    public class Profesores: IObservador
    {
        
        public int id { get; set; }

        public string nombre { get; set; }

        public int edad { get; set; }

        public string correo { get; set; }

        public string profesion { get; set; }
        
        public Profesores(int id, string nombre, int edad, string correo, string profesion)
        {
            this.id = id;
            this.nombre = nombre;
            this.edad = edad;
            this.correo = correo;
            this.profesion = profesion;


        }

        public void Actualizar()
        {
            Console.WriteLine("Se le a alterado el cupo a una materia('Profesores')");
        }
    }
}
