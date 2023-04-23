namespace Fase3NelsonRueda
{
    partial class FormPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pilaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPila = new System.Windows.Forms.Button();
            this.btnCola = new System.Windows.Forms.Button();
            this.btnLista = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcionesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pilaToolStripMenuItem,
            this.colaToolStripMenuItem,
            this.listaToolStripMenuItem});
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.opcionesToolStripMenuItem.Text = "Opciones";
            // 
            // pilaToolStripMenuItem
            // 
            this.pilaToolStripMenuItem.Name = "pilaToolStripMenuItem";
            this.pilaToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.pilaToolStripMenuItem.Text = "Pila";
            this.pilaToolStripMenuItem.Click += new System.EventHandler(this.pilaToolStripMenuItem_Click);
            // 
            // colaToolStripMenuItem
            // 
            this.colaToolStripMenuItem.Name = "colaToolStripMenuItem";
            this.colaToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.colaToolStripMenuItem.Text = "Cola";
            this.colaToolStripMenuItem.Click += new System.EventHandler(this.colaToolStripMenuItem_Click);
            // 
            // listaToolStripMenuItem
            // 
            this.listaToolStripMenuItem.Name = "listaToolStripMenuItem";
            this.listaToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.listaToolStripMenuItem.Text = "Lista";
            this.listaToolStripMenuItem.Click += new System.EventHandler(this.listaToolStripMenuItem_Click);
            // 
            // btnPila
            // 
            this.btnPila.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnPila.Location = new System.Drawing.Point(188, 75);
            this.btnPila.Name = "btnPila";
            this.btnPila.Size = new System.Drawing.Size(380, 63);
            this.btnPila.TabIndex = 1;
            this.btnPila.Text = "PILA";
            this.btnPila.UseVisualStyleBackColor = false;
            this.btnPila.Click += new System.EventHandler(this.btnPila_Click);
            // 
            // btnCola
            // 
            this.btnCola.BackColor = System.Drawing.Color.Yellow;
            this.btnCola.Location = new System.Drawing.Point(188, 172);
            this.btnCola.Name = "btnCola";
            this.btnCola.Size = new System.Drawing.Size(380, 63);
            this.btnCola.TabIndex = 2;
            this.btnCola.Text = "COLA";
            this.btnCola.UseVisualStyleBackColor = false;
            this.btnCola.Click += new System.EventHandler(this.btnCola_Click);
            // 
            // btnLista
            // 
            this.btnLista.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnLista.Location = new System.Drawing.Point(188, 264);
            this.btnLista.Name = "btnLista";
            this.btnLista.Size = new System.Drawing.Size(380, 63);
            this.btnLista.TabIndex = 3;
            this.btnLista.Text = "LISTA";
            this.btnLista.UseVisualStyleBackColor = false;
            this.btnLista.Click += new System.EventHandler(this.btnLista_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLista);
            this.Controls.Add(this.btnCola);
            this.Controls.Add(this.btnPila);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FormPrincipal";
            this.Text = "FormPrincipal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem opcionesToolStripMenuItem;
        private ToolStripMenuItem pilaToolStripMenuItem;
        private ToolStripMenuItem colaToolStripMenuItem;
        private ToolStripMenuItem listaToolStripMenuItem;
        private Button btnPila;
        private Button btnCola;
        private Button btnLista;
    }
}