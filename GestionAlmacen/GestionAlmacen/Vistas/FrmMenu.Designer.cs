
namespace GestionAlmacen.Vistas
{
    partial class FrmMenu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsl_Usuario = new System.Windows.Forms.ToolStripLabel();
            this.tst_Usuario = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tst_Hora = new System.Windows.Forms.ToolStripTextBox();
            this.btn_Inventario = new System.Windows.Forms.Button();
            this.btn_Proveedores = new System.Windows.Forms.Button();
            this.Btn_Clientes = new System.Windows.Forms.Button();
            this.btn_Productos = new System.Windows.Forms.Button();
            this.btn_Salidas = new System.Windows.Forms.Button();
            this.btn_Entrada = new System.Windows.Forms.Button();
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.btn_NuevoUsuario = new System.Windows.Forms.Button();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lbl_Clientes = new System.Windows.Forms.Label();
            this.lbl_Productos = new System.Windows.Forms.Label();
            this.lbl_Proveedores = new System.Windows.Forms.Label();
            this.lbl_Entradas = new System.Windows.Forms.Label();
            this.lbl_Salidas = new System.Windows.Forms.Label();
            this.lbl_Inventario = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsl_Usuario,
            this.tst_Usuario,
            this.toolStripLabel1,
            this.tst_Hora});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 9;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsl_Usuario
            // 
            this.tsl_Usuario.Name = "tsl_Usuario";
            this.tsl_Usuario.Size = new System.Drawing.Size(97, 22);
            this.tsl_Usuario.Text = "Nombre Usuario:";
            // 
            // tst_Usuario
            // 
            this.tst_Usuario.Enabled = false;
            this.tst_Usuario.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tst_Usuario.Name = "tst_Usuario";
            this.tst_Usuario.Size = new System.Drawing.Size(100, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(137, 22);
            this.toolStripLabel1.Text = "Fecha / Hora de entrada:";
            // 
            // tst_Hora
            // 
            this.tst_Hora.Enabled = false;
            this.tst_Hora.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tst_Hora.Name = "tst_Hora";
            this.tst_Hora.Size = new System.Drawing.Size(150, 25);
            // 
            // btn_Inventario
            // 
            this.btn_Inventario.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Inventario.BackgroundImage")));
            this.btn_Inventario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Inventario.Location = new System.Drawing.Point(494, 274);
            this.btn_Inventario.Name = "btn_Inventario";
            this.btn_Inventario.Size = new System.Drawing.Size(95, 72);
            this.btn_Inventario.TabIndex = 6;
            this.toolTip1.SetToolTip(this.btn_Inventario, "Inventario");
            this.btn_Inventario.UseVisualStyleBackColor = true;
            this.btn_Inventario.Click += new System.EventHandler(this.btn_Inventario_Click);
            // 
            // btn_Proveedores
            // 
            this.btn_Proveedores.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Proveedores.BackgroundImage")));
            this.btn_Proveedores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Proveedores.Location = new System.Drawing.Point(494, 140);
            this.btn_Proveedores.Name = "btn_Proveedores";
            this.btn_Proveedores.Size = new System.Drawing.Size(95, 72);
            this.btn_Proveedores.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btn_Proveedores, "Proveedores");
            this.btn_Proveedores.UseVisualStyleBackColor = true;
            this.btn_Proveedores.Click += new System.EventHandler(this.btn_Proveedores_Click);
            // 
            // Btn_Clientes
            // 
            this.Btn_Clientes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_Clientes.BackgroundImage")));
            this.Btn_Clientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_Clientes.Location = new System.Drawing.Point(244, 140);
            this.Btn_Clientes.Name = "Btn_Clientes";
            this.Btn_Clientes.Size = new System.Drawing.Size(95, 72);
            this.Btn_Clientes.TabIndex = 1;
            this.toolTip1.SetToolTip(this.Btn_Clientes, "Clientes");
            this.Btn_Clientes.UseVisualStyleBackColor = true;
            this.Btn_Clientes.Click += new System.EventHandler(this.Btn_Clientes_Click);
            // 
            // btn_Productos
            // 
            this.btn_Productos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Productos.BackgroundImage")));
            this.btn_Productos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Productos.Location = new System.Drawing.Point(369, 140);
            this.btn_Productos.Name = "btn_Productos";
            this.btn_Productos.Size = new System.Drawing.Size(95, 72);
            this.btn_Productos.TabIndex = 2;
            this.toolTip1.SetToolTip(this.btn_Productos, "Productos");
            this.btn_Productos.UseVisualStyleBackColor = true;
            this.btn_Productos.Click += new System.EventHandler(this.btn_Productos_Click);
            // 
            // btn_Salidas
            // 
            this.btn_Salidas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Salidas.BackgroundImage")));
            this.btn_Salidas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Salidas.Location = new System.Drawing.Point(369, 274);
            this.btn_Salidas.Name = "btn_Salidas";
            this.btn_Salidas.Size = new System.Drawing.Size(95, 72);
            this.btn_Salidas.TabIndex = 5;
            this.toolTip1.SetToolTip(this.btn_Salidas, "Salida");
            this.btn_Salidas.UseVisualStyleBackColor = true;
            this.btn_Salidas.Click += new System.EventHandler(this.btn_Salidas_Click);
            // 
            // btn_Entrada
            // 
            this.btn_Entrada.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Entrada.BackgroundImage")));
            this.btn_Entrada.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Entrada.Location = new System.Drawing.Point(244, 274);
            this.btn_Entrada.Name = "btn_Entrada";
            this.btn_Entrada.Size = new System.Drawing.Size(95, 72);
            this.btn_Entrada.TabIndex = 4;
            this.toolTip1.SetToolTip(this.btn_Entrada, "Entradas");
            this.btn_Entrada.UseVisualStyleBackColor = true;
            this.btn_Entrada.Click += new System.EventHandler(this.btn_Entrada_Click);
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_Titulo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbl_Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo.Location = new System.Drawing.Point(0, 450);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(800, 111);
            this.lbl_Titulo.TabIndex = 16;
            this.lbl_Titulo.Text = "Software Almacen";
            this.lbl_Titulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_NuevoUsuario
            // 
            this.btn_NuevoUsuario.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_NuevoUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_NuevoUsuario.Location = new System.Drawing.Point(578, 491);
            this.btn_NuevoUsuario.Name = "btn_NuevoUsuario";
            this.btn_NuevoUsuario.Size = new System.Drawing.Size(89, 41);
            this.btn_NuevoUsuario.TabIndex = 7;
            this.btn_NuevoUsuario.Text = "Nuevo Usuario";
            this.btn_NuevoUsuario.UseVisualStyleBackColor = false;
            this.btn_NuevoUsuario.Visible = false;
            this.btn_NuevoUsuario.Click += new System.EventHandler(this.btn_NuevoUsuario_Click);
            // 
            // btn_Salir
            // 
            this.btn_Salir.AutoSize = true;
            this.btn_Salir.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Salir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Salir.BackgroundImage")));
            this.btn_Salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Salir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Salir.FlatAppearance.BorderSize = 0;
            this.btn_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Salir.Location = new System.Drawing.Point(724, 488);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(48, 47);
            this.btn_Salir.TabIndex = 9;
            this.btn_Salir.UseVisualStyleBackColor = false;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // lbl_Clientes
            // 
            this.lbl_Clientes.AutoSize = true;
            this.lbl_Clientes.Location = new System.Drawing.Point(268, 124);
            this.lbl_Clientes.Name = "lbl_Clientes";
            this.lbl_Clientes.Size = new System.Drawing.Size(44, 13);
            this.lbl_Clientes.TabIndex = 17;
            this.lbl_Clientes.Text = "Clientes";
            // 
            // lbl_Productos
            // 
            this.lbl_Productos.AutoSize = true;
            this.lbl_Productos.Location = new System.Drawing.Point(389, 124);
            this.lbl_Productos.Name = "lbl_Productos";
            this.lbl_Productos.Size = new System.Drawing.Size(55, 13);
            this.lbl_Productos.TabIndex = 18;
            this.lbl_Productos.Text = "Productos";
            // 
            // lbl_Proveedores
            // 
            this.lbl_Proveedores.AutoSize = true;
            this.lbl_Proveedores.Location = new System.Drawing.Point(508, 124);
            this.lbl_Proveedores.Name = "lbl_Proveedores";
            this.lbl_Proveedores.Size = new System.Drawing.Size(67, 13);
            this.lbl_Proveedores.TabIndex = 19;
            this.lbl_Proveedores.Text = "Proveedores";
            // 
            // lbl_Entradas
            // 
            this.lbl_Entradas.AutoSize = true;
            this.lbl_Entradas.Location = new System.Drawing.Point(267, 258);
            this.lbl_Entradas.Name = "lbl_Entradas";
            this.lbl_Entradas.Size = new System.Drawing.Size(49, 13);
            this.lbl_Entradas.TabIndex = 20;
            this.lbl_Entradas.Text = "Entradas";
            // 
            // lbl_Salidas
            // 
            this.lbl_Salidas.AutoSize = true;
            this.lbl_Salidas.Location = new System.Drawing.Point(396, 258);
            this.lbl_Salidas.Name = "lbl_Salidas";
            this.lbl_Salidas.Size = new System.Drawing.Size(41, 13);
            this.lbl_Salidas.TabIndex = 21;
            this.lbl_Salidas.Text = "Salidas";
            // 
            // lbl_Inventario
            // 
            this.lbl_Inventario.AutoSize = true;
            this.lbl_Inventario.Location = new System.Drawing.Point(514, 258);
            this.lbl_Inventario.Name = "lbl_Inventario";
            this.lbl_Inventario.Size = new System.Drawing.Size(54, 13);
            this.lbl_Inventario.TabIndex = 22;
            this.lbl_Inventario.Text = "Inventario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(309, 534);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 18);
            this.label1.TabIndex = 23;
            this.label1.Text = "Paul Quillupangui Sánchez";
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 561);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_Inventario);
            this.Controls.Add(this.lbl_Salidas);
            this.Controls.Add(this.lbl_Entradas);
            this.Controls.Add(this.lbl_Proveedores);
            this.Controls.Add(this.lbl_Productos);
            this.Controls.Add(this.lbl_Clientes);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.btn_NuevoUsuario);
            this.Controls.Add(this.lbl_Titulo);
            this.Controls.Add(this.btn_Inventario);
            this.Controls.Add(this.btn_Proveedores);
            this.Controls.Add(this.Btn_Clientes);
            this.Controls.Add(this.btn_Productos);
            this.Controls.Add(this.btn_Salidas);
            this.Controls.Add(this.btn_Entrada);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Almacen";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel tsl_Usuario;
        private System.Windows.Forms.ToolStripTextBox tst_Usuario;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox tst_Hora;
        private System.Windows.Forms.Button btn_Inventario;
        private System.Windows.Forms.Button btn_Proveedores;
        private System.Windows.Forms.Button Btn_Clientes;
        private System.Windows.Forms.Button btn_Productos;
        private System.Windows.Forms.Button btn_Salidas;
        private System.Windows.Forms.Button btn_Entrada;
        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.Button btn_NuevoUsuario;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lbl_Clientes;
        private System.Windows.Forms.Label lbl_Productos;
        private System.Windows.Forms.Label lbl_Proveedores;
        private System.Windows.Forms.Label lbl_Entradas;
        private System.Windows.Forms.Label lbl_Salidas;
        private System.Windows.Forms.Label lbl_Inventario;
        private System.Windows.Forms.Label label1;
    }
}