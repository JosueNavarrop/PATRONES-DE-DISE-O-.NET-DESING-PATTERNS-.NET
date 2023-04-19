using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    internal class Salario
    {

        public int salariototal(double num1, double num2)
        {
           double mult = num1 * num2;

            if(mult > 35000)
            {
                return (int)(mult * 0.18);
            }
            else
            {
                return (int)mult;
            }
            

        }
    }
}
