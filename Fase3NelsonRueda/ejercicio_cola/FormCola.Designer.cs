namespace Fase3NelsonRueda
{
    partial class FormCola
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
            this.lblColaIdentificacion = new System.Windows.Forms.Label();
            this.txtColaIdentificacion = new System.Windows.Forms.TextBox();
            this.txtColaNombre = new System.Windows.Forms.TextBox();
            this.lblColaNombre = new System.Windows.Forms.Label();
            this.txtColaDireccion = new System.Windows.Forms.TextBox();
            this.lblColaDireccion = new System.Windows.Forms.Label();
            this.txtColaPlaca = new System.Windows.Forms.TextBox();
            this.lblColaPlaca = new System.Windows.Forms.Label();
            this.lblColaTipoVehiculo = new System.Windows.Forms.Label();
            this.cmbColaTipoVehiculo = new System.Windows.Forms.ComboBox();
            this.lblColaAnio = new System.Windows.Forms.Label();
            this.cmbColaAnio = new System.Windows.Forms.ComboBox();
            this.lblColaFecha = new System.Windows.Forms.Label();
            this.dtpColaFecha = new System.Windows.Forms.DateTimePicker();
            this.lblColaRegistros = new System.Windows.Forms.Label();
            this.txtColaRegistros = new System.Windows.Forms.TextBox();
            this.btmColaRegistrar = new System.Windows.Forms.Button();
            this.btnColaEliminar = new System.Windows.Forms.Button();
            this.btnColaReportes = new System.Windows.Forms.Button();
            this.dgvColaInfractores = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvColaInfractores)).BeginInit();
            this.SuspendLayout();
            // 
            // lblColaIdentificacion
            // 
            this.lblColaIdentificacion.AutoSize = true;
            this.lblColaIdentificacion.Location = new System.Drawing.Point(303, 36);
            this.lblColaIdentificacion.Name = "lblColaIdentificacion";
            this.lblColaIdentificacion.Size = new System.Drawing.Size(85, 15);
            this.lblColaIdentificacion.TabIndex = 0;
            this.lblColaIdentificacion.Text = "Identificación: ";
            // 
            // txtColaIdentificacion
            // 
            this.txtColaIdentificacion.Location = new System.Drawing.Point(429, 28);
            this.txtColaIdentificacion.Name = "txtColaIdentificacion";
            this.txtColaIdentificacion.Size = new System.Drawing.Size(228, 23);
            this.txtColaIdentificacion.TabIndex = 1;
            // 
            // txtColaNombre
            // 
            this.txtColaNombre.Location = new System.Drawing.Point(429, 57);
            this.txtColaNombre.Name = "txtColaNombre";
            this.txtColaNombre.Size = new System.Drawing.Size(228, 23);
            this.txtColaNombre.TabIndex = 3;
            // 
            // lblColaNombre
            // 
            this.lblColaNombre.AutoSize = true;
            this.lblColaNombre.Location = new System.Drawing.Point(303, 65);
            this.lblColaNombre.Name = "lblColaNombre";
            this.lblColaNombre.Size = new System.Drawing.Size(108, 15);
            this.lblColaNombre.TabIndex = 2;
            this.lblColaNombre.Text = "Nombre completo:";
            // 
            // txtColaDireccion
            // 
            this.txtColaDireccion.Location = new System.Drawing.Point(429, 86);
            this.txtColaDireccion.Name = "txtColaDireccion";
            this.txtColaDireccion.Size = new System.Drawing.Size(228, 23);
            this.txtColaDireccion.TabIndex = 5;
            // 
            // lblColaDireccion
            // 
            this.lblColaDireccion.AutoSize = true;
            this.lblColaDireccion.Location = new System.Drawing.Point(303, 94);
            this.lblColaDireccion.Name = "lblColaDireccion";
            this.lblColaDireccion.Size = new System.Drawing.Size(60, 15);
            this.lblColaDireccion.TabIndex = 4;
            this.lblColaDireccion.Text = "Dirección:";
            // 
            // txtColaPlaca
            // 
            this.txtColaPlaca.Location = new System.Drawing.Point(429, 115);
            this.txtColaPlaca.Name = "txtColaPlaca";
            this.txtColaPlaca.Size = new System.Drawing.Size(228, 23);
            this.txtColaPlaca.TabIndex = 7;
            // 
            // lblColaPlaca
            // 
            this.lblColaPlaca.AutoSize = true;
            this.lblColaPlaca.Location = new System.Drawing.Point(303, 123);
            this.lblColaPlaca.Name = "lblColaPlaca";
            this.lblColaPlaca.Size = new System.Drawing.Size(38, 15);
            this.lblColaPlaca.TabIndex = 6;
            this.lblColaPlaca.Text = "Placa:";
            // 
            // lblColaTipoVehiculo
            // 
            this.lblColaTipoVehiculo.AutoSize = true;
            this.lblColaTipoVehiculo.Location = new System.Drawing.Point(303, 152);
            this.lblColaTipoVehiculo.Name = "lblColaTipoVehiculo";
            this.lblColaTipoVehiculo.Size = new System.Drawing.Size(81, 15);
            this.lblColaTipoVehiculo.TabIndex = 8;
            this.lblColaTipoVehiculo.Text = "Tipo vehiculo:";
            // 
            // cmbColaTipoVehiculo
            // 
            this.cmbColaTipoVehiculo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbColaTipoVehiculo.FormattingEnabled = true;
            this.cmbColaTipoVehiculo.Items.AddRange(new object[] {
            " Automóvil",
            "Motocicleta",
            "Taxi",
            "Camión",
            "Bus"});
            this.cmbColaTipoVehiculo.Location = new System.Drawing.Point(429, 144);
            this.cmbColaTipoVehiculo.Name = "cmbColaTipoVehiculo";
            this.cmbColaTipoVehiculo.Size = new System.Drawing.Size(228, 23);
            this.cmbColaTipoVehiculo.TabIndex = 9;
            // 
            // lblColaAnio
            // 
            this.lblColaAnio.AutoSize = true;
            this.lblColaAnio.Location = new System.Drawing.Point(303, 181);
            this.lblColaAnio.Name = "lblColaAnio";
            this.lblColaAnio.Size = new System.Drawing.Size(85, 15);
            this.lblColaAnio.TabIndex = 10;
            this.lblColaAnio.Text = "Año matricula:";
            // 
            // cmbColaAnio
            // 
            this.cmbColaAnio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbColaAnio.FormattingEnabled = true;
            this.cmbColaAnio.Items.AddRange(new object[] {
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023"});
            this.cmbColaAnio.Location = new System.Drawing.Point(429, 173);
            this.cmbColaAnio.Name = "cmbColaAnio";
            this.cmbColaAnio.Size = new System.Drawing.Size(228, 23);
            this.cmbColaAnio.TabIndex = 11;
            // 
            // lblColaFecha
            // 
            this.lblColaFecha.AutoSize = true;
            this.lblColaFecha.Location = new System.Drawing.Point(303, 210);
            this.lblColaFecha.Name = "lblColaFecha";
            this.lblColaFecha.Size = new System.Drawing.Size(112, 15);
            this.lblColaFecha.TabIndex = 12;
            this.lblColaFecha.Text = "Fecha comparendo:";
            // 
            // dtpColaFecha
            // 
            this.dtpColaFecha.Location = new System.Drawing.Point(429, 202);
            this.dtpColaFecha.Name = "dtpColaFecha";
            this.dtpColaFecha.Size = new System.Drawing.Size(228, 23);
            this.dtpColaFecha.TabIndex = 13;
            // 
            // lblColaRegistros
            // 
            this.lblColaRegistros.AutoSize = true;
            this.lblColaRegistros.Location = new System.Drawing.Point(303, 239);
            this.lblColaRegistros.Name = "lblColaRegistros";
            this.lblColaRegistros.Size = new System.Drawing.Size(118, 15);
            this.lblColaRegistros.TabIndex = 14;
            this.lblColaRegistros.Text = "Número de registros:";
            // 
            // txtColaRegistros
            // 
            this.txtColaRegistros.Location = new System.Drawing.Point(427, 231);
            this.txtColaRegistros.Name = "txtColaRegistros";
            this.txtColaRegistros.ReadOnly = true;
            this.txtColaRegistros.Size = new System.Drawing.Size(230, 23);
            this.txtColaRegistros.TabIndex = 15;
            // 
            // btmColaRegistrar
            // 
            this.btmColaRegistrar.Location = new System.Drawing.Point(802, 65);
            this.btmColaRegistrar.Name = "btmColaRegistrar";
            this.btmColaRegistrar.Size = new System.Drawing.Size(103, 23);
            this.btmColaRegistrar.TabIndex = 16;
            this.btmColaRegistrar.Text = "Registrar";
            this.btmColaRegistrar.UseVisualStyleBackColor = true;
            this.btmColaRegistrar.Click += new System.EventHandler(this.btmColaRegistrar_Click);
            // 
            // btnColaEliminar
            // 
            this.btnColaEliminar.Location = new System.Drawing.Point(802, 143);
            this.btnColaEliminar.Name = "btnColaEliminar";
            this.btnColaEliminar.Size = new System.Drawing.Size(103, 23);
            this.btnColaEliminar.TabIndex = 17;
            this.btnColaEliminar.Text = "Eliminar";
            this.btnColaEliminar.UseVisualStyleBackColor = true;
            this.btnColaEliminar.Click += new System.EventHandler(this.btnColaEliminar_Click);
            // 
            // btnColaReportes
            // 
            this.btnColaReportes.Location = new System.Drawing.Point(802, 210);
            this.btnColaReportes.Name = "btnColaReportes";
            this.btnColaReportes.Size = new System.Drawing.Size(103, 23);
            this.btnColaReportes.TabIndex = 18;
            this.btnColaReportes.Text = "Mostrar reportes";
            this.btnColaReportes.UseVisualStyleBackColor = true;
            this.btnColaReportes.Click += new System.EventHandler(this.btnColaReportes_Click);
            // 
            // dgvColaInfractores
            // 
            this.dgvColaInfractores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvColaInfractores.Location = new System.Drawing.Point(12, 288);
            this.dgvColaInfractores.Name = "dgvColaInfractores";
            this.dgvColaInfractores.RowTemplate.Height = 25;
            this.dgvColaInfractores.Size = new System.Drawing.Size(1184, 150);
            this.dgvColaInfractores.TabIndex = 19;
            // 
            // FormCola
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(1208, 450);
            this.Controls.Add(this.dgvColaInfractores);
            this.Controls.Add(this.btnColaReportes);
            this.Controls.Add(this.btnColaEliminar);
            this.Controls.Add(this.btmColaRegistrar);
            this.Controls.Add(this.txtColaRegistros);
            this.Controls.Add(this.lblColaRegistros);
            this.Controls.Add(this.dtpColaFecha);
            this.Controls.Add(this.lblColaFecha);
            this.Controls.Add(this.cmbColaAnio);
            this.Controls.Add(this.lblColaAnio);
            this.Controls.Add(this.cmbColaTipoVehiculo);
            this.Controls.Add(this.lblColaTipoVehiculo);
            this.Controls.Add(this.txtColaPlaca);
            this.Controls.Add(this.lblColaPlaca);
            this.Controls.Add(this.txtColaDireccion);
            this.Controls.Add(this.lblColaDireccion);
            this.Controls.Add(this.txtColaNombre);
            this.Controls.Add(this.lblColaNombre);
            this.Controls.Add(this.txtColaIdentificacion);
            this.Controls.Add(this.lblColaIdentificacion);
            this.Name = "FormCola";
            this.Text = "FormCola";
            this.Load += new System.EventHandler(this.FormCola_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvColaInfractores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblColaIdentificacion;
        private TextBox txtColaIdentificacion;
        private TextBox txtColaNombre;
        private Label lblColaNombre;
        private TextBox txtColaDireccion;
        private Label lblColaDireccion;
        private TextBox txtColaPlaca;
        private Label lblColaPlaca;
        private Label lblColaTipoVehiculo;
        private ComboBox cmbColaTipoVehiculo;
        private Label lblColaAnio;
        private ComboBox cmbColaAnio;
        private Label lblColaFecha;
        private DateTimePicker dtpColaFecha;
        private Label lblColaRegistros;
        private TextBox txtColaRegistros;
        private Button btmColaRegistrar;
        private Button btnColaEliminar;
        private Button btnColaReportes;
        private DataGridView dgvColaInfractores;
    }
}