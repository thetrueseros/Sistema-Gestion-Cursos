using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Gestion_Cursos
{
    public class Virtual : Curso
    {
        public Virtual(string nombreCurso, string docente, double intensidadHoraria, int cantidadEstudiantes, double precioUnit)
            : base(nombreCurso, docente, intensidadHoraria, cantidadEstudiantes, precioUnit)
        {
        }
        public override double CalcularPrecioFinal(int cantidadEstudiantes, double precioUnit)
        {
            if (cantidadEstudiantes > 50)
            {
                return precioUnit * 0.85; // 15% de descuento
            }
            else
            {
                return precioUnit;
            }
        }
    }
}
