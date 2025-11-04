using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Gestion_Cursos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregarCurso_Click(object sender, EventArgs e)
        {
            ///Validaciones de los campos
            try
            {
                if (cmbModalidad.Text == "(Seleccione)") //modalidad obligatoria
                {
                    throw new ArgumentException("No has seleccionado una modalidad");
                }
                if (string.IsNullOrWhiteSpace(txtbCantEstudiantes.Text)) //si cantidad estudiantes está vacio
                {
                    throw new ArgumentNullException("El campo de cantidad de estudiantes base no puede estar vacío.");
                }
                if (double.TryParse(txtbCantEstudiantes.Text, out double precioBase) == false) //si no ingresa numero en cant estudiantes
                {
                    throw new ArgumentException("El campo de cantidad de estudiantes debe ser un número válido.");
                }
                if (double.Parse(txtbCantEstudiantes.Text) <= 0) //num estudiantes no negativo
                {
                    throw new ArgumentOutOfRangeException("El campo de cantidad de estudiantes no puede ser menor a 1");
                }
                if (string.IsNullOrWhiteSpace(txtbCantEstudiantes.Text)) //si intensidad horaria está vacio
                {
                    throw new ArgumentNullException("El campo de cantidad de estudiantes base no puede estar vacío.");
                }
                if (double.TryParse(txtbIntensidadHoraria.Text, out double intensidadHoraria) == false) //si no ingresa numero en intensidad horaria
                {
                    throw new ArgumentException("El campo de cantidad de estudiantes debe ser un número válido.");
                }
                if (double.Parse(txtbCantEstudiantes.Text) <= 0) //intensidad horaria no negativa
                {
                    throw new ArgumentOutOfRangeException("El campo de intensidad horaria no puede ser menor a 1");
                }
                if (string.IsNullOrWhiteSpace(txtbNombreCurso.Text)) //nombre curso obligatorio
                {
                    throw new ArgumentNullException("El campo de nombre del curso no puede estar vacío.");
                }
                if (string.IsNullOrWhiteSpace(txtbDocente.Text)) //docente obligatorio
                {
                    throw new ArgumentNullException("El campo de nombre del docente no puede estar vacío.");
                }
                if (string.IsNullOrWhiteSpace(txtbPrecioUnit.Text)) //precio unit obligatorio
                {
                    throw new ArgumentNullException("El campo de precio unit no puede estar vacío.");
                }
                if (double.TryParse(txtbPrecioUnit.Text, out double precioUnit) == false) //si no ingresa numero en precio unit
                {
                    throw new ArgumentException("El campo de precio unitario debe ser un número válido.");
                }
                if (double.Parse(txtbPrecioUnit.Text) <= 0) //precio unit no negativo
                {
                    throw new ArgumentOutOfRangeException("El campo de precio unitario no puede ser menor a 1");
                }
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
