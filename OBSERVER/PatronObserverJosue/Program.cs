using PatronObserverJosue;
using System;
using System.Net.Mail;
using System.Numerics;
using System.Reflection.Emit;

namespace josuenav
{
    class program
    {
        static void Main(string[] args)
        {
            Estudiantes est1 = new Estudiantes(20220077, "Josue navarro", 19, "josuenavarrop2003janp@gmail.com", "Software");
            Estudiantes est2 = new Estudiantes(20220088, "Alba dulce", 20, "ksjfhaksfhiuehf@gmail.com", "Software");
            Estudiantes est3 = new Estudiantes(20229933, "Manuel muñoz", 22, "klfhasljha@gmail.com", "software");
            Estudiantes est4 = new Estudiantes(20213451, "Anthony mercedes", 21, "qwyuioqyuio@gmail.com", "Software");
            Estudiantes est5 = new Estudiantes(20203490, "patricia alcantara", 23, "qwyighdk@gmail.com", "Software");

            Console.WriteLine("BIENVENIDO AL PROGRAMA!!\n" +
                "Antes de enviar los correos electronicos quiere ver los datos de los etudiantes?");
            string duba = Console.ReadLine();
            if (duba == "si".ToLower())
            {
                Console.WriteLine(@"");
                Console.WriteLine("ESTUDIANTE 1");
                Console.WriteLine(est1.ToString());
                Console.WriteLine(@"");
                Console.WriteLine("ESTUDIANTE 2");
                Console.WriteLine(est2.ToString());
                Console.WriteLine(@"");
                Console.WriteLine("ESTUDIANTE 3");
                Console.WriteLine(est3.ToString());
                Console.WriteLine(@"");
                Console.WriteLine("ESTUDIANTE 4");
                Console.WriteLine(est4.ToString());
                Console.WriteLine(@"");
                Console.WriteLine("ESTUDIANTE 5");
                Console.WriteLine(est5.ToString());
            }

            Console.ReadKey();
            Materias mat1 = new Materias("TDS-006", "Programacion ll", "Lunes 8:00 a 1:00PM", "no hay");
            Materias mat2 = new Materias("TDS-007", "Programacion lll", "Miercoles 2:00 a 8:00PM", "no hay");
            Materias mat3 = new Materias("TDS-103", "Mineria de Datos", "Lunes 8:00 a 1:00PM", "no hay");
            Materias mat4 = new Materias("TDS-303", "Introdudion a la ingenieria de software", "Martes 8:00 a 1:00PM", "no hay");
            Materias mat5 = new Materias("TDS-011", "Introduccion al desarrollo de aplicaciones moviles",
            "Domingo Aula virtual 2:00 a 5:00PM", "no hay");
            Console.WriteLine(@"");
            Console.WriteLine("A que materia le quiere cambiar el cupo?\n" +
                "[1]TDS-006 Programacion ll Lunes 8:00 a 1:00PM\n" +
                "[2]TDS-007 Programacion lll Miercoles 2:00 a 8:00PM\n" +
                "[3]TDS-103 Mineria de Datos Lunes 8:00 a 1:00PM\n" +
                "[4]TDS-303 Introdudion a la ingenieria de software Martes 8:00 a 1:00PM\n" +
                "[5]TDS-011 Introduccion al desarrollo de aplicaciones moviles Domingo Aula virtual 2:00 a 5:00PM");
            int resp = int.Parse(Console.ReadLine());
            switch (resp)
            {
                case 1:
                    
                    Console.WriteLine("Quiere cambiarlo para que halla cupo?\n" +
                        "[1]SI\n" +
                        "[2]NO");
                    int cols = int.Parse(Console.ReadLine());
                    if(cols == 1)
                    {
                        mat1.cupos = "hay";
                    }
                    else
                    {
                        Console.WriteLine("No se le cambio el cupo");
                    }

                    break;

                case 2:
                    Console.WriteLine("Quiere cambiarlo para que halla cupo?\n" +
                        "[1]SI\n" +
                        "[2]NO");
                    int cols1 = int.Parse(Console.ReadLine());
                    if (cols1 == 1)
                    {
                        mat2.cupos = "hay";
                    }
                    else
                    {
                        Console.WriteLine("No se le cambio el cupo");
                    }

                    break;

                case 3:
                    Console.WriteLine("Quiere cambiarlo para que halla cupo?\n" +
                        "[1]SI\n" +
                        "[2]NO");
                    int cols2 = int.Parse(Console.ReadLine());
                    if (cols2 == 1)
                    {
                        mat3.cupos = "hay";
                    }
                    else
                    {
                        Console.WriteLine("No se le cambio el cupo");
                    }

                    break;

                case 4:
                    Console.WriteLine("Quiere cambiarlo para que halla cupo?\n" +
                        "[1]SI\n" +
                        "[2]NO");
                    int cols3 = int.Parse(Console.ReadLine());
                    if (cols3 == 1)
                    {
                        mat4.cupos = "hay";
                    }
                    else
                    {
                        Console.WriteLine("No se le cambio el cupo");
                    }

                    break;

                case 5:
                    Console.WriteLine("Quiere cambiarlo para que halla cupo?\n" +
                        "[1]SI\n" +
                        "[2]NO");
                    int cols4 = int.Parse(Console.ReadLine());
                    if (cols4 == 1)
                    {
                        mat5.cupos = "hay";
                    }
                    else
                    {
                        Console.WriteLine("No se le cambio el cupo");
                    }

                    break;

                 default:
                    Console.WriteLine("Inserte una opcion valida del menu");
                    break;

            }

            Empleados emp1 = new Empleados("Purificacion Maza",30,"sipisay480@gmail.com","Limpieza","19163850525");
            Empleados emp2 = new Empleados("Arsenio Farre",49, "fekkofufyu@gmai.com","Bookshop","4474807282902");
            Empleados emp3 = new Empleados("Alina Ferrer",32,"nacrigrattahi-1271@gmail.com","Becas","9163850525");
            Empleados emp4 = new Empleados("Aday Caballero",45,"tuddoreuhoije-6225@gmail.com","Residencia","7480728290");
            Empleados emp5 = new Empleados("Noe Tirado",23, "couttouzoipauprou-7584@gmail.com","Biblioteca","3069884048");

            Profesores prof1 = new Profesores(001,"Manel Ceballos",30,"diffocreddate-2786@gmail.com","Ingeniero en sistemas");
            Profesores prof2 = new Profesores(129, "Brian Roman", 43, "dippeuyavunne-8039@gmail.com","Matematico") ;
            Profesores prof3 = new Profesores(356,"Gabriel Garrido",45,"lijoiceuhoufe-2811@gmail.com","Fisico");
            Profesores prof4 = new Profesores(768,"Jose-Pablo Baez",32,"wammaquouremo-9830@gmail.com","Licenciado informatico");
            Profesores prof5 = new Profesores(269,"Alexandru Sans",52,"yoideutoiheimmou-7491@gmail.com","INgeniero de software");

            Materias.AgregarSUB(emp1);
            Materias.AgregarSUB(emp2);
            Materias.AgregarSUB(emp3);
            Materias.AgregarSUB(emp4);
            Materias.AgregarSUB(emp5);

            Materias.AgregarSUB(est1);
            Materias.AgregarSUB(est2);
            Materias.AgregarSUB(est3);
            Materias.AgregarSUB(est4);
            Materias.AgregarSUB(est5);

            Materias.AgregarSUB(prof1);
            Materias.AgregarSUB(prof2);
            Materias.AgregarSUB(prof3);
            Materias.AgregarSUB(prof4);
            Materias.AgregarSUB(prof5);

            switch (resp)
            {
                case 1:
                    mat1.NotificarSUB();
                    break;

                case 2:
                    mat2.NotificarSUB();
                    break;

                case 3:
                    mat3.NotificarSUB();
                    break;

                case 4:
                    mat4.NotificarSUB();
                    break;

                case 5:
                    mat5.NotificarSUB();
                    break;

            }

        
        }


    }
} 