using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Fase3NelsonRueda.ejercicio_Pila;
// Declaración del espacio de nombres Fase3NelsonRueda.
namespace Fase3NelsonRueda
{
    // Declaración de la clase FormPila, que hereda de Form.
    public partial class FormPila : Form
    {
        // Declaración de una variable privada de tipo PilaClientes.
        private PilaClientes pilaClientes;

        // Constructor de la clase FormPila.
        public FormPila()
        {
            // Inicialización de los componentes de la GUI.
            InitializeComponent();

            // Creación de un nuevo objeto PilaClientes.
            pilaClientes = new PilaClientes();

            // Establecimiento del estilo del ComboBox cmbEstrato a DropDownList.
            cmbEstrato.DropDownStyle = ComboBoxStyle.DropDownList;

            // Establecimiento del estilo del ComboBox cmbVelocidadInternet a DropDownList.
            cmbVelocidadInternet.DropDownStyle = ComboBoxStyle.DropDownList;

            // Establecimiento del estilo del ComboBox cmbCategoria a DropDownList.
            cmbCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        // Método llamado cuando se hace clic en el botón btnAgregar.
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Verifica que los campos estén correctamente llenados antes de agregar un cliente.
            if (ValidarCampos())
            {
                // Crea una instancia de Cliente con la información de los campos de texto y combobox.
                string identificacion = txtIdentificacion.Text;
                string nombre = txtNombre.Text;
                string direccion = txtDireccion.Text;
                int estrato = int.Parse(cmbEstrato.SelectedItem.ToString());
                DateTime mesAfiliacion = dtpMesAfiliacion.Value;
                string categoria = cmbCategoria.SelectedItem.ToString();
                int velocidadInternet = int.Parse(cmbVelocidadInternet.SelectedItem.ToString());

                Cliente cliente = new Cliente(identificacion, nombre, direccion, estrato, mesAfiliacion, categoria, velocidadInternet);

                // Agrega el cliente a la pila de clientes.
                pilaClientes.AgregarCliente(cliente);

                // Muestra el valor mensual del cliente en el campo de texto txtValorMensual.
                txtValorMensual.Text = cliente.ValorMensual.ToString("N0");

                // Actualiza el DataGridView con la lista de clientes.
                ActualizarDataGridView();
            }
        }

        // Método que actualiza el DataGridView con la lista de clientes.
        private void ActualizarDataGridView()
        {
            // Obtiene la lista de clientes de la pila de clientes.
            List<Cliente> listaClientes = pilaClientes.ObtenerClientes();

            // Establece el origen de datos del DataGridView a la lista de clientes.
            dgvClientes.DataSource = null;
            dgvClientes.DataSource = listaClientes;
        }

        // Método llamado cuando se carga el formulario.
        private void FormPila_Load(object sender, EventArgs e)
        {
            // Limpia el campo de texto txtIdentificacion.
            txtIdentificacion.Text = "";
        }

        // Método que valida que todos los campos estén llenados antes de agregar un cliente.
        private bool ValidarCampos()
        {
            // Si el campo de identificación está vacío o contiene solo espacios en blanco
            if (string.IsNullOrWhiteSpace(txtIdentificacion.Text))
            {
                // Se muestra un mensaje de advertencia al usuario indicando que debe ingresar un número de identificación
                MessageBox.Show("Por favor, ingrese el número de identificación.", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                // Se establece el foco en el campo de identificación para que el usuario pueda ingresar datos
                txtIdentificacion.Focus();

                // Se devuelve un valor booleano false para indicar que la validación no fue exitosa
                return false;
            }

            // Si el campo de nombre está vacío o contiene solo espacios en blanco
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                // Se muestra un mensaje de advertencia al usuario indicando que debe ingresar un nombre
                MessageBox.Show("Por favor, ingrese el nombre del cliente.", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                // Se establece el foco en el campo de nombre para que el usuario pueda ingresar datos
                txtNombre.Focus();

                // Se devuelve un valor booleano false para indicar que la validación no fue exitosa
                return false;
            }

            // Si el campo de dirección está vacío o contiene solo espacios en blanco
            if (string.IsNullOrWhiteSpace(txtDireccion.Text))
            {
                // Se muestra un mensaje de advertencia al usuario indicando que debe ingresar una dirección
                MessageBox.Show("Por favor, ingrese la dirección del cliente.", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                // Se establece el foco en el campo de dirección para que el usuario pueda ingresar datos
                txtDireccion.Focus();

                // Se devuelve un valor booleano false para indicar que la validación no fue exitosa
                return false;
            }

            // Si no se ha seleccionado un valor para el campo de estrato
            if (cmbEstrato.SelectedItem == null)
            {
                // Se muestra un mensaje de advertencia al usuario indicando que debe seleccionar un estrato
                MessageBox.Show("Por favor, seleccione el estrato del cliente.", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                // Se establece el foco en el campo de estrato para que el usuario pueda seleccionar un valor
                cmbEstrato.Focus();

                // Se devuelve un valor booleano false para indicar que la validación no fue exitosa
                return false;
            }

            // Si no se ha seleccionado un valor para el campo de categoría
            if (cmbCategoria.SelectedItem == null)
            {
                // Se muestra un mensaje de advertencia al usuario indicando que debe seleccionar una categoría
                MessageBox.Show("Por favor, seleccione la categoría del cliente.", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                // Se establece el foco en el campo de categoría para que el usuario pueda seleccionar un valor
                cmbCategoria.Focus();

                // Se devuelve un valor booleano false para indicar que la validación no fue exitosa
                return false;
            }

            // Si no se ha seleccionado un valor para el campo de velocidad de Internet
            if (cmbVelocidadInternet.SelectedItem == null)
            {
                // Se muestra un mensaje de advertencia al usuario indicando que debe seleccionar una velocidad de Internet
                MessageBox.Show("Por favor, seleccione la velocidad de Internet del cliente.", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                // Se establece el foco en el campo de velocidad de Internet para que el usuario pueda seleccionar un valor
                cmbVelocidadInternet.Focus();

                // Se devuelve un valor booleano false para indicar que la validación no fue exitosa
                return false;
            }

            // Si se pasan todas las validaciones anteriores, se devuelve un valor booleano true para indicar que la validación fue exitosa
            return true;
        }

        // Método llamado cuando se hace clic en el botón btnReporte.
        private void btnReporte_Click(object sender, EventArgs e)
        {
            // Muestra el total de pagos en el campo de texto txtTotalPagos.
            txtTotalPagos.Text = pilaClientes.ObtenerTotalPagos().ToString("N0");
        }

        // Método llamado cuando se hace clic en el botón btnEliminar.
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Elimina el último cliente agregado de la pila de clientes.
            pilaClientes.EliminarCliente();

            // Actualiza el DataGridView con la lista de clientes.
            ActualizarDataGridView();
        }
    }
}
