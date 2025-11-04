using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Gestion_Cursos
{
    public class CursoRepository
    {
        public static CursoRepository instancia;
        private List<string> cursos = new List<string>();
        private readonly string rutaArchivo = "cursoss.txt";

        /// <summary>
        /// Constructor privado para implementar el patrón Singleton
        /// </summary>
        private CursoRepository()
        {
            if (!File.Exists(rutaArchivo))
            {
                File.Create(rutaArchivo).Close();
            }
            cursos = File.ReadAllLines(rutaArchivo).ToList();
        }

        /// <summary>
        /// Instancia singleton de CursoRepository
        /// </summary>
        public static CursoRepository Instancia
        {
            get
            {
                if (instancia == null)
                    instancia = new CursoRepository();
                return instancia;
            }
        }

        /// <summary>
        /// Devuelve una copia de la lista de líneas (para mostrar en la UI)
        /// </summary>
        public List<string> ObtenerListaCursos()
        {
            // se devuelve una copia para evitar modificaciones directas desde la UI
            return new List<string>(cursos);
        }

        /// <summary>
        /// Agrega un vehículo (construye la línea) y la guarda en el fichero en modo append
        /// </summary>
        public void Agregar(Curso cur)
        {
            if (cur == null) return;
            string linea = "Modalidad. " + cur.modalidad +
                           ", Nombre curso: " + cur.nombreCurso +
                           ", Docentee: " + cur.docente +
                           ", Cant. Estudiantes: " + cur.cantidadEstudiantes +
                           ", Precio unit. Neto: " + cur.CalcularPrecioFinal(cur.cantidadEstudiantes, cur.precioUnit);
            cursos.Add(linea);

            // se guarda sólo la línea nueva en modo append para no sobrescribir el fichero
            using (StreamWriter sw = new StreamWriter(rutaArchivo, true))
            {
                sw.WriteLine(linea);
            }
        }
    }
}
