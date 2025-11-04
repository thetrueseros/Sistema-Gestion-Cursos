using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Gestion_Cursos
{
    public class CursoFactory
    {
        public static Curso CrearCurso(string modalidad, string nombreCurso, string docente, double intensidadHoraria, int cantidadEstudiantes, double precioUnit)
        {
            try
            {
                switch (modalidad)
                {
                    case "Virtual":
                        return new CursoVirtual(nombreCurso, docente, intensidadHoraria, cantidadEstudiantes, precioUnit);
                    case "Presencial":
                        return new CursoPresencial(nombreCurso, docente, intensidadHoraria, cantidadEstudiantes, precioUnit);
                    default:
                        throw new ArgumentException("Modalidad de curso no válida.");
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

        }
    }
}
