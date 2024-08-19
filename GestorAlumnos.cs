using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deber_POO
{
   public  class GestorAlumnos
    {
        public List<Alumno> alumnos = new List<Alumno>();

        // Método para agregar un alumno
        public void AgregarAlumno(Alumno alumno)
        {
            if (alumnos.Any(a => a.DNI == alumno.DNI))
            {
                Console.WriteLine("Ya existe un alumno con ese DNI.");
            }
            else
            {
                alumnos.Add(alumno);
            }
        }

        public void eliminarALumno(string dni)
        {
            for (int i = alumnos.Count - 1; i >= 0; i--)
            {
                if (alumnos[i].DNI == dni)
                {
                    alumnos.RemoveAt(i);
                    Console.WriteLine($"Alumno con DNI {dni} eliminado.");
                    return; // Si se encuentra y elimina, se puede salir del bucle
                }
            }
            Console.WriteLine($"No se encontró ningún alumno con DNI {dni}.");
        }
    }
}
