using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deber_POO
{
    public class Alumno
    {
        public string DNI { get; set; }
        public string Apellidos { get; set; }
        public string Nombre { get; set; }
        public double Nota { get; set; }
        public string Calificacion
        {
            get
            {
                if (Nota < 5) return "SS";
                else if (Nota < 7) return "AP";
                else if (Nota < 9) return "NT";
                else return "SB";
            }
        }
    }
}
