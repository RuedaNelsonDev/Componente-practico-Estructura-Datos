namespace Fase3NelsonRueda
{
    partial class FormLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblLoginAutor = new System.Windows.Forms.Label();
            this.lblLoginNombreApp = new System.Windows.Forms.Label();
            this.lblLoginContrasena = new System.Windows.Forms.Label();
            this.txtLoginContrasena = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(201, 201);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Ingresar";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblLoginAutor
            // 
            this.lblLoginAutor.AutoSize = true;
            this.lblLoginAutor.Location = new System.Drawing.Point(163, 54);
            this.lblLoginAutor.Name = "lblLoginAutor";
            this.lblLoginAutor.Size = new System.Drawing.Size(164, 15);
            this.lblLoginAutor.TabIndex = 1;
            this.lblLoginAutor.Text = "Nelson Miguel Rueda Chacón";
            // 
            // lblLoginNombreApp
            // 
            this.lblLoginNombreApp.AutoSize = true;
            this.lblLoginNombreApp.Location = new System.Drawing.Point(181, 91);
            this.lblLoginNombreApp.Name = "lblLoginNombreApp";
            this.lblLoginNombreApp.Size = new System.Drawing.Size(124, 15);
            this.lblLoginNombreApp.TabIndex = 2;
            this.lblLoginNombreApp.Text = "StructureManagerApp";
            // 
            // lblLoginContrasena
            // 
            this.lblLoginContrasena.AutoSize = true;
            this.lblLoginContrasena.Location = new System.Drawing.Point(152, 123);
            this.lblLoginContrasena.Name = "lblLoginContrasena";
            this.lblLoginContrasena.Size = new System.Drawing.Size(197, 15);
            this.lblLoginContrasena.TabIndex = 3;
            this.lblLoginContrasena.Text = "Para continua, ingrese la contraseña";
            // 
            // txtLoginContrasena
            // 
            this.txtLoginContrasena.Location = new System.Drawing.Point(192, 154);
            this.txtLoginContrasena.Name = "txtLoginContrasena";
            this.txtLoginContrasena.PasswordChar = '*';
            this.txtLoginContrasena.Size = new System.Drawing.Size(100, 23);
            this.txtLoginContrasena.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(355, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(156, 196);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 284);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtLoginContrasena);
            this.Controls.Add(this.lblLoginContrasena);
            this.Controls.Add(this.lblLoginNombreApp);
            this.Controls.Add(this.lblLoginAutor);
            this.Controls.Add(this.btnLogin);
            this.Name = "FormLogin";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnLogin;
        private Label lblLoginAutor;
        private Label lblLoginNombreApp;
        private Label lblLoginContrasena;
        private TextBox txtLoginContrasena;
        private PictureBox pictureBox1;
    }
}