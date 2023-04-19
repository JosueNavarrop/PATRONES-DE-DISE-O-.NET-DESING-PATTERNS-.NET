using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronObserverJosue
{
    public class Materias
    {
        public string codigo { get; set; }
        public string nombreMat { get; set; }
        public string horario { get; set; }
        public string cupos { get; set; }


        public Materias(string codigo, string nombreMat, string horario, string cupos)
        {
            this.codigo = codigo;
            this.nombreMat = nombreMat;
            this.horario = horario;
            this.cupos = cupos;
            
        }

        public static List<IObservador> Josue = new List<IObservador>();



        //AGREAGR
        public static void AgregarSUB(IObservador observador)
        {
            Josue.Add(observador);
        }



        //QUITAR
        public static void QuitarSUB(IObservador observador)
        {
            Josue.Remove(observador);
        }



        //NOTIFICAR
        public void NotificarSUB()
        {

            foreach (var elemento in Josue)
            {
                elemento.Actualizar();
            }
        }



        //Logica propuia
        public void cuandohaycupo(string valor)
        {

            cupos = valor;

            NotificarSUB();

        }

    }
}