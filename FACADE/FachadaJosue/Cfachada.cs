using Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FachadaJosue
{
    public class Cfachada
    {
        //Calculadora
        Caluladora cal;
        Caluladora cal2;
        Caluladora cal3;
        Caluladora cal4;

        //Convertidor
        ConvertidorTemp conv;
        ConvertidorTemp conv2;
        ConvertidorTemp conv3;
        ConvertidorTemp conv4;
        ConvertidorTemp conv5;
        ConvertidorTemp conv6;

        //Formulario
        Formulario form;

        public void operacionCalculadora()
        {
            Console.WriteLine("Que quiere calcular?");
            Console.WriteLine("[1]SUMAR [2]RESTA [3]MULTIPLICACIÓN [4]DIVISIÍON");
            int rest = int.Parse(Console.ReadLine());
                switch (rest)
                {
                    case 1:
                        Console.WriteLine(@"");
                        Console.WriteLine("Ingrese primer numero a sumar");
                        double num1 = double.Parse(Console.ReadLine());
                        Console.WriteLine(@"");
                        Console.WriteLine("Ingrese segundo numero a sumar");
                        double num2 = double.Parse(Console.ReadLine());
                        Console.WriteLine(@"");
                        cal = new Caluladora();
                        cal.sumar(num1, num2);
                        break;

                    case 2:
                        Console.WriteLine(@"");
                        Console.WriteLine("Ingrese primer numero a restar");
                        double rest1 = double.Parse(Console.ReadLine());
                        Console.WriteLine(@"");
                        Console.WriteLine("Ingrese segundo numero a restar");
                        double rest2 = double.Parse(Console.ReadLine());
                        Console.WriteLine(@"");
                        cal2 = new Caluladora();
                        cal2.restar(rest1, rest2);
                        break;
                    case 3:
                        Console.WriteLine(@"");
                        Console.WriteLine("Ingrese primer numro a multiplicar");
                        double mult1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese segundo numero a multiplicar");
                        double mult2 = double.Parse(Console.ReadLine());
                        Console.WriteLine(@"");
                        cal3 = new Caluladora();
                        cal3.multiplicar(mult1, mult2);
                        break;

                    case 4:
                        Console.WriteLine(@"");
                        Console.WriteLine("Ingrese primer numero a dividir");
                        double div1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese segundo numero dividir");
                        double div2 = double.Parse(Console.ReadLine());
                        Console.WriteLine(@"");
                        cal4 = new Caluladora();
                        cal4.dividir(div1, div2);
                        break;
                }
        }


        public void operacioneConvertidor()
        {
            Console.WriteLine("Como quieres convertir? [1]De Celcius a fahrenheit [2]De Fahrenheit a celcius [3]Celcius a kelvin " +
                "[4]Kelvin a celcius [5]Fahrenheit a kelvin [6]Kelvin a Fahrenheit");
            int dov = int.Parse(Console.ReadLine());
            switch (dov)
            {
                case 1:
                    Console.WriteLine(@"");
                    Console.WriteLine("Ingrese sus celcius para convertir a fahrenheit");
                    double fah1 = double.Parse(Console.ReadLine());
                    Console.WriteLine(@"");
                    conv = new ConvertidorTemp();
                    conv.cel_to_fah(fah1);
                    break;

                case 2:
                    Console.WriteLine(@"");
                    Console.WriteLine("Ingrese sus grados fahrenheit para converitr en celcius");
                    double cel1 = double.Parse(Console.ReadLine());
                    Console.WriteLine(@"");
                    conv2 = new ConvertidorTemp();
                    conv2.fah_to_cel(cel1);
                    break;

                case 3:
                    Console.WriteLine(@"");
                    Console.WriteLine("Ingrese sus grados celcius para convertir a kelvin");
                    double kel1 = double.Parse(Console.ReadLine());
                    conv3 = new ConvertidorTemp();
                    conv3.cel_to_kelvin(kel1);

                    break;

                case 4:
                    Console.WriteLine(@"");
                    Console.WriteLine("Ingrese sus grados kelvin para convertir en celcius");
                    double cel2 = double.Parse(Console.ReadLine());
                    conv4 = new ConvertidorTemp();
                    conv4.kelvin_to_cel(cel2);

                    break;

                case 5:
                    Console.WriteLine(@"");
                    Console.WriteLine("Ingrese sus grados fahrenheit para convertir a kelvin");
                    double fah3 = double.Parse(Console.ReadLine());
                    conv5 = new ConvertidorTemp();
                    conv5.fah_to_kelvin(fah3);

                    break;

                case 6:
                    Console.WriteLine(@"");
                    Console.WriteLine("Ingrese sus grados kelvin para convertir a fahrenheit");
                    double kelv4 = double.Parse(Console.ReadLine());
                    conv6 = new ConvertidorTemp();
                    conv6.kelvin_to_fah(kelv4);
                    break;

            }
        }

        public void operacionFormulario()
        {
            form = new Formulario();
            form.informaciongen();

        }

    }
}
