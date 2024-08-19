using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deber_POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GestorAlumnos gestor = new GestorAlumnos();

            // Ejemplo de uso
            Alumno alumno1 = new Alumno { DNI = "12345678A", Apellidos = "Pérez García", Nombre = "Juan", Nota = 8.5 };
            Alumno alumno2 = new Alumno { DNI = "12345678B", Apellidos = "Pérez García", Nombre = "Juan", Nota = 8.5 };
            Alumno alumno3 = new Alumno { DNI = "12345678C", Apellidos = "Pérez García", Nombre = "Juan", Nota = 8.5 };
            gestor.AgregarAlumno(alumno1);
            gestor.AgregarAlumno(alumno2);
            gestor.AgregarAlumno(alumno3);
            gestor.eliminarALumno("12345678C");

            // Mostrar todos los alumnos
           
            foreach (Alumno alumno in gestor.alumnos)
            {
                Console.WriteLine($"{alumno.DNI} {alumno.Apellidos}, {alumno.Nombre} {alumno.Nota} {alumno.Calificacion}");
            }
            Console.ReadKey();
        }
    }
}
