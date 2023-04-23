namespace Fase3NelsonRueda
{
    partial class FormLista
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
            this.lblListaTipoIdentificacion = new System.Windows.Forms.Label();
            this.lblListaIdentificacion = new System.Windows.Forms.Label();
            this.lblListaNombre = new System.Windows.Forms.Label();
            this.lblListaEstrato = new System.Windows.Forms.Label();
            this.lblListaNacimiento = new System.Windows.Forms.Label();
            this.lblListaGrado = new System.Windows.Forms.Label();
            this.lblListaPAE = new System.Windows.Forms.Label();
            this.cmbListaTipoIdentificacion = new System.Windows.Forms.ComboBox();
            this.txtListaIdentificacion = new System.Windows.Forms.TextBox();
            this.txtListaNombre = new System.Windows.Forms.TextBox();
            this.cmbListaEstrato = new System.Windows.Forms.ComboBox();
            this.dtpListaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.cmbListaGrado = new System.Windows.Forms.ComboBox();
            this.rbListaSiPae = new System.Windows.Forms.RadioButton();
            this.dgvListaEstudiantes = new System.Windows.Forms.DataGridView();
            this.rbListaNoPae = new System.Windows.Forms.RadioButton();
            this.btnListaRegistrar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnListaEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaEstudiantes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblListaTipoIdentificacion
            // 
            this.lblListaTipoIdentificacion.AutoSize = true;
            this.lblListaTipoIdentificacion.Location = new System.Drawing.Point(175, 44);
            this.lblListaTipoIdentificacion.Name = "lblListaTipoIdentificacion";
            this.lblListaTipoIdentificacion.Size = new System.Drawing.Size(108, 15);
            this.lblListaTipoIdentificacion.TabIndex = 0;
            this.lblListaTipoIdentificacion.Text = "Tipo identificación:";
            // 
            // lblListaIdentificacion
            // 
            this.lblListaIdentificacion.AutoSize = true;
            this.lblListaIdentificacion.Location = new System.Drawing.Point(175, 73);
            this.lblListaIdentificacion.Name = "lblListaIdentificacion";
            this.lblListaIdentificacion.Size = new System.Drawing.Size(85, 15);
            this.lblListaIdentificacion.TabIndex = 1;
            this.lblListaIdentificacion.Text = "Identificación: ";
            // 
            // lblListaNombre
            // 
            this.lblListaNombre.AutoSize = true;
            this.lblListaNombre.Location = new System.Drawing.Point(175, 102);
            this.lblListaNombre.Name = "lblListaNombre";
            this.lblListaNombre.Size = new System.Drawing.Size(111, 15);
            this.lblListaNombre.TabIndex = 2;
            this.lblListaNombre.Text = "Nombre completo: ";
            // 
            // lblListaEstrato
            // 
            this.lblListaEstrato.AutoSize = true;
            this.lblListaEstrato.Location = new System.Drawing.Point(175, 131);
            this.lblListaEstrato.Name = "lblListaEstrato";
            this.lblListaEstrato.Size = new System.Drawing.Size(46, 15);
            this.lblListaEstrato.TabIndex = 3;
            this.lblListaEstrato.Text = "Estrato:";
            // 
            // lblListaNacimiento
            // 
            this.lblListaNacimiento.AutoSize = true;
            this.lblListaNacimiento.Location = new System.Drawing.Point(175, 160);
            this.lblListaNacimiento.Name = "lblListaNacimiento";
            this.lblListaNacimiento.Size = new System.Drawing.Size(104, 15);
            this.lblListaNacimiento.TabIndex = 4;
            this.lblListaNacimiento.Text = "Fecha nacimiento:";
            // 
            // lblListaGrado
            // 
            this.lblListaGrado.AutoSize = true;
            this.lblListaGrado.Location = new System.Drawing.Point(175, 189);
            this.lblListaGrado.Name = "lblListaGrado";
            this.lblListaGrado.Size = new System.Drawing.Size(42, 15);
            this.lblListaGrado.TabIndex = 5;
            this.lblListaGrado.Text = "Grado:";
            // 
            // lblListaPAE
            // 
            this.lblListaPAE.AutoSize = true;
            this.lblListaPAE.Location = new System.Drawing.Point(175, 216);
            this.lblListaPAE.Name = "lblListaPAE";
            this.lblListaPAE.Size = new System.Drawing.Size(92, 15);
            this.lblListaPAE.TabIndex = 6;
            this.lblListaPAE.Text = "Usa servcio PAE:";
            // 
            // cmbListaTipoIdentificacion
            // 
            this.cmbListaTipoIdentificacion.FormattingEnabled = true;
            this.cmbListaTipoIdentificacion.Items.AddRange(new object[] {
            "CC",
            "TI",
            "CE",
            "NIP",
            "NIT"});
            this.cmbListaTipoIdentificacion.Location = new System.Drawing.Point(289, 36);
            this.cmbListaTipoIdentificacion.Name = "cmbListaTipoIdentificacion";
            this.cmbListaTipoIdentificacion.Size = new System.Drawing.Size(237, 23);
            this.cmbListaTipoIdentificacion.TabIndex = 7;
            // 
            // txtListaIdentificacion
            // 
            this.txtListaIdentificacion.Location = new System.Drawing.Point(289, 65);
            this.txtListaIdentificacion.Name = "txtListaIdentificacion";
            this.txtListaIdentificacion.Size = new System.Drawing.Size(237, 23);
            this.txtListaIdentificacion.TabIndex = 8;
            // 
            // txtListaNombre
            // 
            this.txtListaNombre.Location = new System.Drawing.Point(289, 94);
            this.txtListaNombre.Name = "txtListaNombre";
            this.txtListaNombre.Size = new System.Drawing.Size(237, 23);
            this.txtListaNombre.TabIndex = 9;
            // 
            // cmbListaEstrato
            // 
            this.cmbListaEstrato.FormattingEnabled = true;
            this.cmbListaEstrato.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.cmbListaEstrato.Location = new System.Drawing.Point(289, 123);
            this.cmbListaEstrato.Name = "cmbListaEstrato";
            this.cmbListaEstrato.Size = new System.Drawing.Size(237, 23);
            this.cmbListaEstrato.TabIndex = 10;
            // 
            // dtpListaNacimiento
            // 
            this.dtpListaNacimiento.Location = new System.Drawing.Point(289, 152);
            this.dtpListaNacimiento.Name = "dtpListaNacimiento";
            this.dtpListaNacimiento.Size = new System.Drawing.Size(237, 23);
            this.dtpListaNacimiento.TabIndex = 11;
            // 
            // cmbListaGrado
            // 
            this.cmbListaGrado.FormattingEnabled = true;
            this.cmbListaGrado.Items.AddRange(new object[] {
            "6",
            "7",
            "8",
            "9",
            "10",
            "11"});
            this.cmbListaGrado.Location = new System.Drawing.Point(289, 181);
            this.cmbListaGrado.Name = "cmbListaGrado";
            this.cmbListaGrado.Size = new System.Drawing.Size(237, 23);
            this.cmbListaGrado.TabIndex = 12;
            // 
            // rbListaSiPae
            // 
            this.rbListaSiPae.AutoSize = true;
            this.rbListaSiPae.Location = new System.Drawing.Point(289, 214);
            this.rbListaSiPae.Name = "rbListaSiPae";
            this.rbListaSiPae.Size = new System.Drawing.Size(34, 19);
            this.rbListaSiPae.TabIndex = 13;
            this.rbListaSiPae.TabStop = true;
            this.rbListaSiPae.Text = "Si";
            this.rbListaSiPae.UseVisualStyleBackColor = true;
            // 
            // dgvListaEstudiantes
            // 
            this.dgvListaEstudiantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaEstudiantes.Location = new System.Drawing.Point(12, 288);
            this.dgvListaEstudiantes.Name = "dgvListaEstudiantes";
            this.dgvListaEstudiantes.RowTemplate.Height = 25;
            this.dgvListaEstudiantes.Size = new System.Drawing.Size(776, 150);
            this.dgvListaEstudiantes.TabIndex = 14;
            // 
            // rbListaNoPae
            // 
            this.rbListaNoPae.AutoSize = true;
            this.rbListaNoPae.Location = new System.Drawing.Point(329, 214);
            this.rbListaNoPae.Name = "rbListaNoPae";
            this.rbListaNoPae.Size = new System.Drawing.Size(41, 19);
            this.rbListaNoPae.TabIndex = 15;
            this.rbListaNoPae.TabStop = true;
            this.rbListaNoPae.Text = "No";
            this.rbListaNoPae.UseVisualStyleBackColor = true;
            // 
            // btnListaRegistrar
            // 
            this.btnListaRegistrar.Location = new System.Drawing.Point(602, 38);
            this.btnListaRegistrar.Name = "btnListaRegistrar";
            this.btnListaRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnListaRegistrar.TabIndex = 16;
            this.btnListaRegistrar.Text = "Registrar";
            this.btnListaRegistrar.UseVisualStyleBackColor = true;
            this.btnListaRegistrar.Click += new System.EventHandler(this.btnListaRegistrar_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(602, 73);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 23);
            this.btnConsultar.TabIndex = 17;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnListaEliminar
            // 
            this.btnListaEliminar.Location = new System.Drawing.Point(602, 111);
            this.btnListaEliminar.Name = "btnListaEliminar";
            this.btnListaEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnListaEliminar.TabIndex = 18;
            this.btnListaEliminar.Text = "Eliminar";
            this.btnListaEliminar.UseVisualStyleBackColor = true;
            this.btnListaEliminar.Click += new System.EventHandler(this.btnListaEliminar_Click);
            // 
            // FormLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnListaEliminar);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnListaRegistrar);
            this.Controls.Add(this.rbListaNoPae);
            this.Controls.Add(this.dgvListaEstudiantes);
            this.Controls.Add(this.rbListaSiPae);
            this.Controls.Add(this.cmbListaGrado);
            this.Controls.Add(this.dtpListaNacimiento);
            this.Controls.Add(this.cmbListaEstrato);
            this.Controls.Add(this.txtListaNombre);
            this.Controls.Add(this.txtListaIdentificacion);
            this.Controls.Add(this.cmbListaTipoIdentificacion);
            this.Controls.Add(this.lblListaPAE);
            this.Controls.Add(this.lblListaGrado);
            this.Controls.Add(this.lblListaNacimiento);
            this.Controls.Add(this.lblListaEstrato);
            this.Controls.Add(this.lblListaNombre);
            this.Controls.Add(this.lblListaIdentificacion);
            this.Controls.Add(this.lblListaTipoIdentificacion);
            this.Name = "FormLista";
            this.Text = "FormLista";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaEstudiantes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblListaTipoIdentificacion;
        private Label lblListaIdentificacion;
        private Label lblListaNombre;
        private Label lblListaEstrato;
        private Label lblListaNacimiento;
        private Label lblListaGrado;
        private Label lblListaPAE;
        private ComboBox cmbListaTipoIdentificacion;
        private TextBox txtListaIdentificacion;
        private TextBox txtListaNombre;
        private ComboBox cmbListaEstrato;
        private DateTimePicker dtpListaNacimiento;
        private ComboBox cmbListaGrado;
        private RadioButton rbListaSiPae;
        private DataGridView dgvListaEstudiantes;
        private RadioButton rbListaNoPae;
        private Button btnListaRegistrar;
        private Button btnConsultar;
        private Button btnListaEliminar;
    }
}