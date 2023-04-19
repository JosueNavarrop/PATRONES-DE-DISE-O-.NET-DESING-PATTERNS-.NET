using Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FachadaJosue
{
    public class Contexto
    {
        Istrategy strategy;

        public Contexto(Istrategy objeto)
        {
            this.strategy = objeto;
        }
        
        public void ejecutar(Formulario jar)
        {
            strategy.Imprimir(jar);
        }


    }
}
