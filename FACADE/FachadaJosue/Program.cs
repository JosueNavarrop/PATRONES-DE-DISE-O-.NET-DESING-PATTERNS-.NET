using Facade;
using FachadaJosue;
using System;

namespace Josue_Navarro
{
    class Program
    {
        static void Main(string[] args)
        {
            Cfachada cfachada = new Cfachada();

        
               Console.Clear();
               Console.WriteLine("Bienvenido al multi menú");
               Console.WriteLine(@"");
               Console.WriteLine("Que quiere utilizar?");
               Console.WriteLine("[1]CALCULADORA [2]CONVERTIDOR [3]FORMULARIO [4]SALIR DEL MENÚ");
               int respt = int.Parse(Console.ReadLine());
               switch (respt)
               {
                   case 1:
                       cfachada.operacionCalculadora();
                       break;

                   case 2:
                       cfachada.operacioneConvertidor();
                       break;

                   case 3:
                       cfachada.operacionFormulario();
                       break;
                }
  
        }
    }
}