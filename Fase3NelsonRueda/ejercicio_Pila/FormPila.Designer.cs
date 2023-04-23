namespace Fase3NelsonRueda
{
    partial class FormPila
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtValorMensual = new System.Windows.Forms.TextBox();
            this.lblValorMensual = new System.Windows.Forms.Label();
            this.txtTotalPagos = new System.Windows.Forms.TextBox();
            this.btnReporte = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.lblTotalPago = new System.Windows.Forms.Label();
            this.cmbVelocidadInternet = new System.Windows.Forms.ComboBox();
            this.lblVelocidad = new System.Windows.Forms.Label();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblMesAflicion = new System.Windows.Forms.Label();
            this.dtpMesAfiliacion = new System.Windows.Forms.DateTimePicker();
            this.cmbEstrato = new System.Windows.Forms.ComboBox();
            this.lblEstrato = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtIdentificacion = new System.Windows.Forms.TextBox();
            this.lblIdentifiacion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // txtValorMensual
            // 
            this.txtValorMensual.Location = new System.Drawing.Point(200, 244);
            this.txtValorMensual.Name = "txtValorMensual";
            this.txtValorMensual.ReadOnly = true;
            this.txtValorMensual.Size = new System.Drawing.Size(100, 23);
            this.txtValorMensual.TabIndex = 44;
            // 
            // lblValorMensual
            // 
            this.lblValorMensual.AutoSize = true;
            this.lblValorMensual.Location = new System.Drawing.Point(109, 244);
            this.lblValorMensual.Name = "lblValorMensual";
            this.lblValorMensual.Size = new System.Drawing.Size(81, 15);
            this.lblValorMensual.TabIndex = 43;
            this.lblValorMensual.Text = "Valor mensual";
            // 
            // txtTotalPagos
            // 
            this.txtTotalPagos.Location = new System.Drawing.Point(200, 287);
            this.txtTotalPagos.Name = "txtTotalPagos";
            this.txtTotalPagos.ReadOnly = true;
            this.txtTotalPagos.Size = new System.Drawing.Size(100, 23);
            this.txtTotalPagos.TabIndex = 42;
            // 
            // btnReporte
            // 
            this.btnReporte.Location = new System.Drawing.Point(560, 98);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(75, 23);
            this.btnReporte.TabIndex = 41;
            this.btnReporte.Text = "Reporte";
            this.btnReporte.UseVisualStyleBackColor = true;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(560, 66);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 40;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(560, 32);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 39;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dgvClientes
            // 
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(-15, 329);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.RowTemplate.Height = 25;
            this.dgvClientes.Size = new System.Drawing.Size(817, 120);
            this.dgvClientes.TabIndex = 38;
            // 
            // lblTotalPago
            // 
            this.lblTotalPago.AutoSize = true;
            this.lblTotalPago.Location = new System.Drawing.Point(109, 287);
            this.lblTotalPago.Name = "lblTotalPago";
            this.lblTotalPago.Size = new System.Drawing.Size(62, 15);
            this.lblTotalPago.TabIndex = 37;
            this.lblTotalPago.Text = "Total pago";
            // 
            // cmbVelocidadInternet
            // 
            this.cmbVelocidadInternet.FormattingEnabled = true;
            this.cmbVelocidadInternet.Items.AddRange(new object[] {
            "5",
            "10",
            "20",
            "50"});
            this.cmbVelocidadInternet.Location = new System.Drawing.Point(200, 183);
            this.cmbVelocidadInternet.Name = "cmbVelocidadInternet";
            this.cmbVelocidadInternet.Size = new System.Drawing.Size(100, 23);
            this.cmbVelocidadInternet.TabIndex = 36;
            // 
            // lblVelocidad
            // 
            this.lblVelocidad.AutoSize = true;
            this.lblVelocidad.Location = new System.Drawing.Point(109, 186);
            this.lblVelocidad.Name = "lblVelocidad";
            this.lblVelocidad.Size = new System.Drawing.Size(58, 15);
            this.lblVelocidad.TabIndex = 35;
            this.lblVelocidad.Text = "Velocidad";
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Items.AddRange(new object[] {
            "Urbano",
            "Rural"});
            this.cmbCategoria.Location = new System.Drawing.Point(200, 154);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(100, 23);
            this.cmbCategoria.TabIndex = 34;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(109, 157);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(58, 15);
            this.lblCategoria.TabIndex = 33;
            this.lblCategoria.Text = "Categoria";
            // 
            // lblMesAflicion
            // 
            this.lblMesAflicion.AutoSize = true;
            this.lblMesAflicion.Location = new System.Drawing.Point(109, 125);
            this.lblMesAflicion.Name = "lblMesAflicion";
            this.lblMesAflicion.Size = new System.Drawing.Size(71, 15);
            this.lblMesAflicion.TabIndex = 32;
            this.lblMesAflicion.Text = "Mes aflición";
            // 
            // dtpMesAfiliacion
            // 
            this.dtpMesAfiliacion.Location = new System.Drawing.Point(200, 125);
            this.dtpMesAfiliacion.Name = "dtpMesAfiliacion";
            this.dtpMesAfiliacion.Size = new System.Drawing.Size(213, 23);
            this.dtpMesAfiliacion.TabIndex = 31;
            // 
            // cmbEstrato
            // 
            this.cmbEstrato.FormattingEnabled = true;
            this.cmbEstrato.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.cmbEstrato.Location = new System.Drawing.Point(200, 95);
            this.cmbEstrato.Name = "cmbEstrato";
            this.cmbEstrato.Size = new System.Drawing.Size(49, 23);
            this.cmbEstrato.TabIndex = 30;
            // 
            // lblEstrato
            // 
            this.lblEstrato.AutoSize = true;
            this.lblEstrato.Location = new System.Drawing.Point(109, 98);
            this.lblEstrato.Name = "lblEstrato";
            this.lblEstrato.Size = new System.Drawing.Size(46, 15);
            this.lblEstrato.TabIndex = 29;
            this.lblEstrato.Text = "Estrato:";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(200, 66);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(213, 23);
            this.txtDireccion.TabIndex = 28;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(109, 66);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(60, 15);
            this.lblDireccion.TabIndex = 27;
            this.lblDireccion.Text = "Dirección:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(200, 37);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(213, 23);
            this.txtNombre.TabIndex = 26;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(109, 37);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(57, 15);
            this.lblNombre.TabIndex = 25;
            this.lblNombre.Text = "Nombre: ";
            // 
            // txtIdentificacion
            // 
            this.txtIdentificacion.Location = new System.Drawing.Point(200, 11);
            this.txtIdentificacion.Name = "txtIdentificacion";
            this.txtIdentificacion.Size = new System.Drawing.Size(213, 23);
            this.txtIdentificacion.TabIndex = 24;
            // 
            // lblIdentifiacion
            // 
            this.lblIdentifiacion.AutoSize = true;
            this.lblIdentifiacion.Location = new System.Drawing.Point(105, 19);
            this.lblIdentifiacion.Name = "lblIdentifiacion";
            this.lblIdentifiacion.Size = new System.Drawing.Size(85, 15);
            this.lblIdentifiacion.TabIndex = 23;
            this.lblIdentifiacion.Text = "Identificación: ";
            // 
            // FormPila
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtValorMensual);
            this.Controls.Add(this.lblValorMensual);
            this.Controls.Add(this.txtTotalPagos);
            this.Controls.Add(this.btnReporte);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.lblTotalPago);
            this.Controls.Add(this.cmbVelocidadInternet);
            this.Controls.Add(this.lblVelocidad);
            this.Controls.Add(this.cmbCategoria);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblMesAflicion);
            this.Controls.Add(this.dtpMesAfiliacion);
            this.Controls.Add(this.cmbEstrato);
            this.Controls.Add(this.lblEstrato);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtIdentificacion);
            this.Controls.Add(this.lblIdentifiacion);
            this.Name = "FormPila";
            this.Text = "FormPila";
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtValorMensual;
        private Label lblValorMensual;
        private TextBox txtTotalPagos;
        private Button btnReporte;
        private Button btnEliminar;
        private Button btnAgregar;
        private DataGridView dgvClientes;
        private Label lblTotalPago;
        private ComboBox cmbVelocidadInternet;
        private Label lblVelocidad;
        private ComboBox cmbCategoria;
        private Label lblCategoria;
        private Label lblMesAflicion;
        private DateTimePicker dtpMesAfiliacion;
        private ComboBox cmbEstrato;
        private Label lblEstrato;
        private TextBox txtDireccion;
        private Label lblDireccion;
        private TextBox txtNombre;
        private Label lblNombre;
        private TextBox txtIdentificacion;
        private Label lblIdentifiacion;
    }
}