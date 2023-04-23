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
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void mostrarForm(Type formType)
        {
            Form formInstance = (Form)Activator.CreateInstance(formType);
            formInstance.Show();
        }

        private void pilaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mostrarForm(typeof(FormPila));
        }

        private void colaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mostrarForm(typeof(FormCola));
        }

        private void listaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mostrarForm(typeof(FormLista));
        }

        private void btnPila_Click(object sender, EventArgs e)
        {
            mostrarForm(typeof(FormPila));
        }

        private void btnCola_Click(object sender, EventArgs e)
        {
            mostrarForm(typeof(FormCola));
        }

        private void btnLista_Click(object sender, EventArgs e)
        {
            mostrarForm(typeof(FormLista));
        }

    }
}
