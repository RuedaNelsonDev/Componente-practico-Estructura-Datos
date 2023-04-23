using Fase3NelsonRueda.ejercicio_cola;
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
    public partial class FormCola : Form
    {
        ColaInfraccion colaInfraccion;
        public FormCola()
        {
            InitializeComponent();
            colaInfraccion = new ColaInfraccion();
        }

        // Método para validar los campos del formulario
        private bool ValidarCampos()
        {
            // Aquí puedes agregar las validaciones necesarias para cada campo, por ejemplo:
            if (string.IsNullOrEmpty(txtColaIdentificacion.Text) || string.IsNullOrEmpty(txtColaNombre.Text) || string.IsNullOrEmpty(txtColaDireccion.Text) || string.IsNullOrEmpty(txtColaPlaca.Text) || cmbColaTipoVehiculo.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor complete todos los campos obligatorios y verifique que los datos ingresados sean válidos.");
                return false;
            }
            return true;
        }
        private void btmColaRegistrar_Click(object sender, EventArgs e)
        {

            if (ValidarCampos())
            {
                Infractor nuevoInfractor = new Infractor
                {
                    Identificacion = txtColaIdentificacion.Text,
                    NombreCompleto = txtColaNombre.Text,
                    Direccion = txtColaDireccion.Text,
                    Placa = txtColaPlaca.Text,
                    TipoAutomotor = (string)cmbColaTipoVehiculo.SelectedItem,
                    AnioMatricula = int.Parse(cmbColaAnio.Text),
                    FechaComparendo = dtpColaFecha.Value

                };
                nuevoInfractor.DiasDesdeExpedicion = (DateTime.Now - nuevoInfractor.FechaComparendo).Days;
                nuevoInfractor.ValorComparendo = nuevoInfractor.CalcularValorConDescuento();

                colaInfraccion.AgregarInfractor(nuevoInfractor);
                ActualizarDataGridView();
            }

        }

        private void btnColaEliminar_Click(object sender, EventArgs e)
        {

            colaInfraccion.EliminarInfractor();
            ActualizarDataGridView();

        }

        private void btnColaReportes_Click(object sender, EventArgs e)
        {
            txtColaRegistros.Text = colaInfraccion.Count().ToString();
        }


        private void ActualizarDataGridView()
        {

            
            foreach (Infractor infractor in colaInfraccion.ObtenerInfractores())
            {
                dgvColaInfractores.Rows.Add(infractor.Identificacion, infractor.NombreCompleto, infractor.Direccion, infractor.Placa, infractor.TipoAutomotor, infractor.AnioMatricula, infractor.FechaComparendo, infractor.DiasDesdeExpedicion, infractor.ValorComparendo);
            }
        }

        private void FormCola_Load(object sender, EventArgs e)
        {
            // Crear las columnas del DataGridView
            DataGridViewTextBoxColumn columnaIdentificacion = new DataGridViewTextBoxColumn();
            columnaIdentificacion.HeaderText = "Identificación";
            dgvColaInfractores.Columns.Add(columnaIdentificacion);

            DataGridViewTextBoxColumn columnaNombreCompleto = new DataGridViewTextBoxColumn();
            columnaNombreCompleto.HeaderText = "Nombre Completo";
            dgvColaInfractores.Columns.Add(columnaNombreCompleto);

            DataGridViewTextBoxColumn columnaDireccion = new DataGridViewTextBoxColumn();
            columnaDireccion.HeaderText = "Dirección";
            dgvColaInfractores.Columns.Add(columnaDireccion);

            DataGridViewTextBoxColumn columnaPlaca = new DataGridViewTextBoxColumn();
            columnaPlaca.HeaderText = "Placa";
            dgvColaInfractores.Columns.Add(columnaPlaca);

            DataGridViewTextBoxColumn columnaTipoAutomotor = new DataGridViewTextBoxColumn();
            columnaTipoAutomotor.HeaderText = "Tipo de Automotor";
            dgvColaInfractores.Columns.Add(columnaTipoAutomotor);

            DataGridViewTextBoxColumn columnaAnioMatricula = new DataGridViewTextBoxColumn();
            columnaAnioMatricula.HeaderText = "Año de Matrícula";
            dgvColaInfractores.Columns.Add(columnaAnioMatricula);

            DataGridViewTextBoxColumn columnaFechaComparendo = new DataGridViewTextBoxColumn();
            columnaFechaComparendo.HeaderText = "Fecha del Comparendo";
            dgvColaInfractores.Columns.Add(columnaFechaComparendo);

            DataGridViewTextBoxColumn columnaDiasDesdeComparendo = new DataGridViewTextBoxColumn();
            columnaDiasDesdeComparendo.HeaderText = "Días desde el comparendo";
            dgvColaInfractores.Columns.Add(columnaDiasDesdeComparendo);

            DataGridViewTextBoxColumn columnaValorComparendo = new DataGridViewTextBoxColumn();
            columnaValorComparendo.HeaderText = "Valor del comparendo";
            dgvColaInfractores.Columns.Add(columnaValorComparendo);

            // Llamar a ActualizarDataGridView para llenar el DataGridView con los datos iniciales
            ActualizarDataGridView();
        }

    }
}
