using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class Gerencial
    {
        private static Gerencial gerencial;//1

        private string gerente;

        private Gerencial(string gerenAgg)//2
        {
            gerente = gerenAgg; 
        }

        public static Gerencial GetGerencial(string gen)
        {
            if (gerencial == null)
            {
                gerencial = new Gerencial(gen);
                return gerencial;
            }
            else
            {
                return gerencial;
            }
        }

        public override string ToString()
        {
            return $"Usted pertece al rango de: {gerente}";
        }

    }

    
}
