using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemStudentsTeachers
{
    class RegistroAsistencia
    {
        private List<Persona> personas = new List<Persona>();

        public void AgregarPersona(Persona persona)
        {
            personas.Add(persona);
        }

        public void MarcarAsistencia(string nombre, string apellido)
        {
            Persona persona = personas.Find(p => p.Nombre == nombre && p.Apellido == apellido);
            if (persona != null)
            {
                persona.Asistencias++;
            }
            else
            {
                Console.WriteLine("Persona no encontrada.");
            }
        }

        public void MarcarInasistencia(string nombre, string apellido)
        {
            Persona persona = personas.Find(p => p.Nombre == nombre && p.Apellido == apellido);
            if (persona != null)
            {
                persona.Inasistencias++;
            }
            else
            {
                Console.WriteLine("Persona no encontrada.");
            }
        }

        public void MostrarDatosPersona(string nombre, string apellido)
        {
            Persona persona = personas.Find(p => p.Nombre == nombre && p.Apellido == apellido);
            if (persona != null)
            {
                Console.WriteLine($"Nombre: {persona.Nombre}");
                Console.WriteLine($"Apellido: {persona.Apellido}");
                Console.WriteLine($"Correo: {persona.Correo}");
                Console.WriteLine($"Asistencias: {persona.Asistencias}");
                Console.WriteLine($"Inasistencias: {persona.Inasistencias}");

                if (persona is Alumno alumno)
                {
                    Console.WriteLine($"Código de Estudiante: {alumno.CodigoEstudiante}");
                    Console.WriteLine($"Matriculado: {alumno.Matriculado}");
                }
                else if (persona is Profesor profesor)
                {
                    Console.WriteLine($"Carreras Dictadas: {profesor.CarrerasDictadas}");
                    Console.WriteLine($"Sedes de Asistencia: {profesor.SedesAsistencia}");
                }
            }
            else
            {
                Console.WriteLine("Persona no encontrada.");
            }
        }
    }
       
}
