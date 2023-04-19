using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Fabrica_empleados
    {
        public static IIempleados GetIempleados(string yes)
        {
            if (yes == "si")
            {
                return new Empleados();
            }
            else
            {
                return new Empleados();
            }
        }

    }
}
