using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Facade;

namespace FachadaJosue
{
    public class Cjson : Istrategy
    {


        static string filepath = @"C:\Users\User\Desktop\Mis Datos.json";
        public void Imprimir(Formulario jar)
        {
            Formulario form1 = new Formulario();
            form1.informaciongen();

            string json = "";

            json = JsonConvert.SerializeObject(form1.ToString());

            File.WriteAllText(filepath, json);

        }
    }
}
