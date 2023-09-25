using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemStudentsTeachers
{
    class Program
    {
        static void Main(string[] args)
        {
            RegistroAsistencia registro = new RegistroAsistencia();

            while (true)
            {
                Console.WriteLine("Seleccione una opción:");
                Console.WriteLine("1. Agregar persona");
                Console.WriteLine("2. Marcar asistencia");
                Console.WriteLine("3. Marcar inasistencia");
                Console.WriteLine("4. Mostrar datos de persona");
                Console.WriteLine("5. Salir");

                int opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Ingrese el nombre:");
                        string nombre = Console.ReadLine();
                        Console.WriteLine("Ingrese el apellido:");
                        string apellido = Console.ReadLine();
                        Console.WriteLine("Ingrese el correo:");
                        string correo = Console.ReadLine();
                        Console.WriteLine("Seleccione el tipo (1: Alumno, 2: Profesor):");
                        int tipo = int.Parse(Console.ReadLine());

                        if (tipo == 1)
                        {
                            Console.WriteLine("Ingrese el código de estudiante:");
                            int codigoEstudiante = int.Parse(Console.ReadLine());
                            Console.WriteLine("¿Está matriculado? (true/false):");
                            bool matriculado = bool.Parse(Console.ReadLine());

                            Alumno alumno = new Alumno
                            {
                                Nombre = nombre,
                                Apellido = apellido,
                                Correo = correo,
                                CodigoEstudiante = codigoEstudiante,
                                Matriculado = matriculado
                            };

                            registro.AgregarPersona(alumno);
                        }
                        else if (tipo == 2)
                        {
                            Console.WriteLine("Ingrese la cantidad de carreras dictadas:");
                            int carrerasDictadas = int.Parse(Console.ReadLine());
                            Console.WriteLine("Ingrese la cantidad de sedes de asistencia:");
                            int sedesAsistencia = int.Parse(Console.ReadLine());

                            Profesor profesor = new Profesor
                            {
                                Nombre = nombre,
                                Apellido = apellido,
                                Correo = correo,
                                CarrerasDictadas = carrerasDictadas,
                                SedesAsistencia = sedesAsistencia
                            };

                            registro.AgregarPersona(profesor);
                        }
                        else
                        {
                            Console.WriteLine("Tipo no válido.");
                        }
                        break;

                    case 2:
                        Console.WriteLine("Ingrese el nombre de la persona:");
                        string nombreAsistencia = Console.ReadLine();
                        Console.WriteLine("Ingrese el apellido de la persona:");
                        string apellidoAsistencia = Console.ReadLine();
                        registro.MarcarAsistencia(nombreAsistencia, apellidoAsistencia);
                        break;

                    case 3:
                        Console.WriteLine("Ingrese el nombre de la persona:");
                        string nombreInasistencia = Console.ReadLine();
                        Console.WriteLine("Ingrese el apellido de la persona:");
                        string apellidoInasistencia = Console.ReadLine();
                        registro.MarcarInasistencia(nombreInasistencia, apellidoInasistencia);
                        break;

                    case 4:
                        Console.WriteLine("Ingrese el nombre de la persona:");
                        string nombreMostrar = Console.ReadLine();
                        Console.WriteLine("Ingrese el apellido de la persona:");
                        string apellidoMostrar = Console.ReadLine();
                        registro.MostrarDatosPersona(nombreMostrar, apellidoMostrar);
                        break;

                    case 5:
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
            }
        }
    }
}
