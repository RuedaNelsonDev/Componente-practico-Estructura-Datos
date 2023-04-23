using Fase3NelsonRueda.ejercicio_lista;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fase3NelsonRueda
{
    public partial class FormLista : Form
    {
        public FormLista()
        {
            InitializeComponent();
        }

        private List<ListaEstudiante> estudiantes = new List<ListaEstudiante>();

        private void RegistrarEstudiante(ListaEstudiante nuevoEstudiante)
        {
            estudiantes.Add(nuevoEstudiante);
            ActualizarDataGridView();
        }

        private void ActualizarDataGridView()
        {
            dgvListaEstudiantes.DataSource = null;
            dgvListaEstudiantes.DataSource = estudiantes;
        }

        private ListaEstudiante ConsultarEstudiante(string identificacion)
        {
            return estudiantes.FirstOrDefault(e => e.Identificacion == identificacion);
        }

        private void EliminarEstudiante(string identificacion)
        {
            ListaEstudiante estudiante = ConsultarEstudiante(identificacion);
            if (estudiante != null)
            {
                estudiantes.Remove(estudiante);
                ActualizarDataGridView();
            }
        }

        private void btnListaRegistrar_Click(object sender, EventArgs e)
        {
            // Tomar los datos del formulario
            string tipoIdentificacion = cmbListaTipoIdentificacion.SelectedItem.ToString();
            string identificacion = txtListaIdentificacion.Text;
            string nombreCompleto = txtListaNombre.Text;
            int estratoSocioeconomico = Convert.ToInt32(cmbListaEstrato.SelectedItem);
            DateTime fechaNacimiento = dtpListaNacimiento.Value;
            int grado = Convert.ToInt32(cmbListaGrado.SelectedItem);
            bool usaPAE = rbListaSiPae.Checked;

            // Crear un nuevo objeto ListaEstudiante
            ListaEstudiante nuevoEstudiante = new ListaEstudiante(tipoIdentificacion, identificacion, nombreCompleto, estratoSocioeconomico, fechaNacimiento, grado, usaPAE);

            // Llamar al método RegistrarEstudiante() para agregar el nuevo estudiante a la lista
            RegistrarEstudiante(nuevoEstudiante);

            // Limpiar los campos del formulario
            cmbListaTipoIdentificacion.SelectedIndex = -1;
            txtListaIdentificacion.Clear();
            txtListaNombre.Clear();
            cmbListaEstrato.SelectedIndex = -1;
            dtpListaNacimiento.Value = DateTime.Now;
            cmbListaGrado.SelectedIndex = -1;
            rbListaSiPae.Checked = false;
            rbListaNoPae.Checked = false;

            // Actualizar el DataGridView para mostrar el nuevo registro
            ActualizarDataGridView();

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            string identificacion = txtListaIdentificacion.Text;
            ListaEstudiante estudiante = ConsultarEstudiante(identificacion);

            if (estudiante != null)
            {
                // Mostrar los datos del estudiante en los controles del formulario
                cmbListaTipoIdentificacion.SelectedItem = estudiante.TipoIdentificacion;
                txtListaNombre.Text = estudiante.NombreCompleto;
                cmbListaEstrato.SelectedItem = estudiante.Estrato.ToString();
                dtpListaNacimiento.Value = estudiante.FechaNacimiento;
                cmbListaGrado.SelectedItem = estudiante.Grado.ToString();
                rbListaSiPae.Checked = estudiante.UtilizaServicioPAE;
                rbListaNoPae.Checked = !estudiante.UtilizaServicioPAE;

                // Habilitar el botón Eliminar
                btnListaEliminar.Enabled = true;
            }
            else
            {
                // Mostrar un mensaje indicando que el estudiante no fue encontrado
                MessageBox.Show("Estudiante no encontrado", "Consulta", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Limpiar los campos del formulario y deshabilitar el botón Eliminar
                cmbListaTipoIdentificacion.SelectedIndex = -1;
                txtListaNombre.Clear();
                cmbListaEstrato.SelectedIndex = -1;
                dtpListaNacimiento.Value = DateTime.Now;
                cmbListaGrado.SelectedIndex = -1;
                rbListaSiPae.Checked = false;
                rbListaNoPae.Checked = false;
                btnListaEliminar.Enabled = false;
            }
        }

        private void btnListaEliminar_Click(object sender, EventArgs e)
        {
            string identificacion = txtListaIdentificacion.Text;
            EliminarEstudiante(identificacion);

            // Limpiar los campos del formulario
            cmbListaTipoIdentificacion.SelectedIndex = -1;
            txtListaIdentificacion.Clear();
            txtListaNombre.Clear();
            cmbListaEstrato.SelectedIndex = -1;
            dtpListaNacimiento.Value = DateTime.Now;
            cmbListaGrado.SelectedIndex = -1;
            rbListaSiPae.Checked = false;
            rbListaNoPae.Checked = false;

            // Deshabilitar el botón Eliminar
            btnListaEliminar.Enabled = false;

            // Actualizar el DataGridView para reflejar la eliminación del estudiante
            ActualizarDataGridView();
        }
    }
}
