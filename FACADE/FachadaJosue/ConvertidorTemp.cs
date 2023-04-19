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
        public void cel_to_fah(double num1)
        {
            Console.WriteLine("Sus grados celcius fueron convertidos a " + (num1 * 9 / 5) + 32 + " Grados FAHRENHEIT");

        }


        // convertir de grados fahrenheit a celcius
        public void fah_to_cel(double num1)
        {
            Console.WriteLine("Sus grados fahrenheit fueron covertidos a " + (num1 - 32) * 5 / 9 + " Grados CELCIUS");
        }

        //De delcius a kelvin
        public void cel_to_kelvin(double num1)
        {
            Console.WriteLine("Sus grados celcius fueron convertidos a " + num1 + 273.15 + "GRADOS KELVIN");
        }


        //De kelvin a Celcius
        public void kelvin_to_cel(double num1)
        {
            Console.WriteLine("Sus grados celcius fueron convertidos a "+ (num1 - 273.15) +" GRADOS CELCIUS");
        }

        // De fahrenheit a kelvin

        public void fah_to_kelvin(double num1)
        {
            Console.WriteLine("Sus grados fahrenheit fueron convertidos a " + (num1 - 32) * 5/9 + 273.15 +" GRADOS KELVIN");
        }

        //De kelvin a Fah
        public void kelvin_to_fah(double num1)
        {
            Console.WriteLine("sus grados kelvin fueron convertidos a "+(num1 - 273.15) * 9 / 5 + 32 + " GRADOS FAHRENHEITS");
        }

    }
}