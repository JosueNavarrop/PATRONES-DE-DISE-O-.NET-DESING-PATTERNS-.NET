using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class Caluladora
    {
        //suma
        public void sumar(double num1, double num2)
        {
            Console.WriteLine($"El resultado de su suma es: {num1 + num2}");
        }
        //Resta
        public void restar(double num1, double num2)
        {
            Console.WriteLine($"El resultado de su resta es: {num1 - num2}");
        }
        //Multiplicar
        public void multiplicar(double num1, double num2)
        {
            Console.WriteLine($"El resultado de su multiplicación es: {num1 * num2}");
        }
        //Dividir
        public void dividir(double num1, double num2)
        {
            Console.WriteLine($"El resultado de su diviciíon es: {num1 / num2}");
        }
    }
}