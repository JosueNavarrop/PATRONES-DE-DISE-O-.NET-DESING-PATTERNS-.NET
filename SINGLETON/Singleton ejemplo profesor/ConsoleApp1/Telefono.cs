using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Telefono
    {
        private static Telefono telefono; //1
        private string NumeroTelefonico;
        private Telefono(string numero) //2
        {
            NumeroTelefonico = numero;    
        }

        public static Telefono GetTelefono(string num)
        {
            if (telefono == null)
            {
                telefono = new Telefono(num);
                return telefono;
            }
            else
            {   
                return telefono;
            }

        }

        public override string ToString()
        {
            return $"El numero telefonico es {NumeroTelefonico}";
        }

    }
}
