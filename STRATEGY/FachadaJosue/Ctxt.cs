using Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FachadaJosue
{
    public class Ctxt : Istrategy
    {
        public void Imprimir(Formulario jar)
        {
           Formulario form = new Formulario();
            form.informaciongen();
            
            StreamWriter escribir = new StreamWriter(@"C:\Users\User\Desktop\Mis Datos.txt", true);
            escribir.WriteLine(form.ToString());
            escribir.Close();
        }
    }
}
