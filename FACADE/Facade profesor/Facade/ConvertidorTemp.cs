using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class ConvertidorTemp
    {
        // convertir de grados celcius a fahrenheit   
        public double cel_to_fah(double num1)
        {
            return (num1 * 9 / 5) + 32;

        }


        // convertir de grados fahrenheit a celcius

        public double fah_to_cel(double num1)
        {
            return (num1 - 32) * 5 / 9;
        }


 

    }
}
