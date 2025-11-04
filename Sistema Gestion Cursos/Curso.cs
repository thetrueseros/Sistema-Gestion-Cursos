using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Gestion_Cursos
{
    public abstract class Curso
    {
        public string nombreCurso { get; set; }
        public string docente { get; set; }
        public double intensidadHoraria { get; set; }
        public int cantidadEstudiantes { get; set; }
        public double precioUnit { get; set; }

        public Curso(string nombreCurso, string docente, double intensidadHoraria, int cantidadEstudiantes, double precioUnit)
        {
            this.nombreCurso = nombreCurso;
            this.docente = docente;
            this.intensidadHoraria = intensidadHoraria;
            this.cantidadEstudiantes = cantidadEstudiantes;
            this.precioUnit = precioUnit;
        }

        public abstract double CalcularPrecioFinal(int cantidadEstudiantes, double precioUnit);
    }
}
