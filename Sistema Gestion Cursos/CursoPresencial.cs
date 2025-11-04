using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Gestion_Cursos
{
    public class CursoPresencial : Curso
    {
        public CursoPresencial(string nombreCurso, string docente, double intensidadHoraria, int cantidadEstudiantes, double precioUnit)
            : base("Presencial", nombreCurso, docente, intensidadHoraria, cantidadEstudiantes, precioUnit)
        {
        }
        public override double CalcularPrecioFinal(int cantidadEstudiantes, double precioUnit)
        {
            if (cantidadEstudiantes > 30)
            {
                return precioUnit * 1.20; // 20% adicional
            }
            else
            {
                return precioUnit;
            }
        }
    }
}
