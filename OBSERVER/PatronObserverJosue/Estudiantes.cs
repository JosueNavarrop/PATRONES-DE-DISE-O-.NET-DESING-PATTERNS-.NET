using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;
using System.Reflection.Emit;

namespace PatronObserverJosue
{
    public class Estudiantes: IObservador
    {
        public int matricula { get; set; }

        public string nombre { get; set; }

        public int edad { get; set; }

        public string correo { get; set; }

        public string carrera { get; set; }

        public Estudiantes(int matricula, string nombre, int edad, string correo, string carrera)
        {
            this.matricula = matricula;
            this.nombre = nombre;
            this.edad = edad;
            this.correo = correo;
            this.carrera = carrera;
        }

        public void Actualizar()
        {
            Console.WriteLine("Se le a alterado el cupo a una materia ('Estudiantes')");

            MailMessage mail = new MailMessage();
            mail.To.Add(correo);
            mail.From = new MailAddress("paratareadejuanrosario@gmail.com");
            mail.Subject = "CAMBIO DE CUPO!!!!";
            mail.Body = "Se ha agregado un cupo a la materia que usted a cambiado!";

            SmtpClient smtp = new SmtpClient();
            smtp.Port = 587;
            smtp.EnableSsl = true;
            smtp.UseDefaultCredentials = false;
            smtp.Host = "smtp.gmail.com";
            smtp.Credentials = new System.Net.NetworkCredential("paratareadejuanrosario@gmail.com", "uqrqbkvcbgduutxl");
            smtp.Send(mail);
        }



        public override string ToString()
        {
            return "Matricula: " + matricula + "\n" + "Nombre: " + nombre + "\n" + "Edad: " +edad+ "\n" + "correo: " +correo + "\n" + "carrera: " + carrera;
        }

    }
}
