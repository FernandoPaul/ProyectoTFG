
namespace GestionAlmacen.Vistas.Productos
{
    partial class FrmAddProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddProductos));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv_ListaProductos = new System.Windows.Forms.DataGridView();
            this.lbl_Buscar = new System.Windows.Forms.Label();
            this.cmb_Buscar = new System.Windows.Forms.ComboBox();
            this.txt_Buscar = new System.Windows.Forms.TextBox();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mtb_Codigo = new System.Windows.Forms.MaskedTextBox();
            this.lbl_ErrorMarca = new System.Windows.Forms.Label();
            this.lbl_ErrorCategoria = new System.Windows.Forms.Label();
            this.lbl_ErrorDescripcion = new System.Windows.Forms.Label();
            this.lbl_ErrorNombre = new System.Windows.Forms.Label();
            this.lbl_ErrorCodigo = new System.Windows.Forms.Label();
            this.btn_GenerarCodigo = new System.Windows.Forms.Button();
            this.txt_Marca = new System.Windows.Forms.TextBox();
            this.lbl_Marca = new System.Windows.Forms.Label();
            this.txt_Categoria = new System.Windows.Forms.TextBox();
            this.lbl_Categoria = new System.Windows.Forms.Label();
            this.txt_Descripcion = new System.Windows.Forms.TextBox();
            this.btn_Limpiar = new System.Windows.Forms.Button();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.lbl_Descripcion = new System.Windows.Forms.Label();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.lbl_Nombre = new System.Windows.Forms.Label();
            this.lbl_Codigo = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListaProductos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.dgv_ListaProductos);
            this.groupBox2.Controls.Add(this.lbl_Buscar);
            this.groupBox2.Controls.Add(this.cmb_Buscar);
            this.groupBox2.Controls.Add(this.txt_Buscar);
            this.groupBox2.Location = new System.Drawing.Point(261, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(527, 422);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "LISTA DE PRODUCTOS";
            // 
            // dgv_ListaProductos
            // 
            this.dgv_ListaProductos.AllowUserToAddRows = false;
            this.dgv_ListaProductos.AllowUserToDeleteRows = false;
            this.dgv_ListaProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ListaProductos.Location = new System.Drawing.Point(9, 50);
            this.dgv_ListaProductos.Name = "dgv_ListaProductos";
            this.dgv_ListaProductos.ReadOnly = true;
            this.dgv_ListaProductos.Size = new System.Drawing.Size(512, 366);
            this.dgv_ListaProductos.TabIndex = 14;
            // 
            // lbl_Buscar
            // 
            this.lbl_Buscar.AutoSize = true;
            this.lbl_Buscar.Location = new System.Drawing.Point(6, 26);
            this.lbl_Buscar.Name = "lbl_Buscar";
            this.lbl_Buscar.Size = new System.Drawing.Size(40, 13);
            this.lbl_Buscar.TabIndex = 13;
            this.lbl_Buscar.Text = "Buscar";
            // 
            // cmb_Buscar
            // 
            this.cmb_Buscar.FormattingEnabled = true;
            this.cmb_Buscar.ItemHeight = 13;
            this.cmb_Buscar.Location = new System.Drawing.Point(52, 23);
            this.cmb_Buscar.Name = "cmb_Buscar";
            this.cmb_Buscar.Size = new System.Drawing.Size(121, 21);
            this.cmb_Buscar.TabIndex = 9;
            // 
            // txt_Buscar
            // 
            this.txt_Buscar.Location = new System.Drawing.Point(179, 24);
            this.txt_Buscar.Name = "txt_Buscar";
            this.txt_Buscar.Size = new System.Drawing.Size(225, 20);
            this.txt_Buscar.TabIndex = 10;
            this.txt_Buscar.TextChanged += new System.EventHandler(this.txt_Buscar_TextChanged);
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Eliminar.BackgroundImage")));
            this.btn_Eliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Eliminar.Location = new System.Drawing.Point(9, 378);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(228, 33);
            this.btn_Eliminar.TabIndex = 11;
            this.toolTip1.SetToolTip(this.btn_Eliminar, "Eliminar");
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.mtb_Codigo);
            this.groupBox1.Controls.Add(this.lbl_ErrorMarca);
            this.groupBox1.Controls.Add(this.lbl_ErrorCategoria);
            this.groupBox1.Controls.Add(this.lbl_ErrorDescripcion);
            this.groupBox1.Controls.Add(this.btn_Eliminar);
            this.groupBox1.Controls.Add(this.lbl_ErrorNombre);
            this.groupBox1.Controls.Add(this.lbl_ErrorCodigo);
            this.groupBox1.Controls.Add(this.btn_GenerarCodigo);
            this.groupBox1.Controls.Add(this.txt_Marca);
            this.groupBox1.Controls.Add(this.lbl_Marca);
            this.groupBox1.Controls.Add(this.txt_Categoria);
            this.groupBox1.Controls.Add(this.lbl_Categoria);
            this.groupBox1.Controls.Add(this.txt_Descripcion);
            this.groupBox1.Controls.Add(this.btn_Limpiar);
            this.groupBox1.Controls.Add(this.btn_Guardar);
            this.groupBox1.Controls.Add(this.lbl_Descripcion);
            this.groupBox1.Controls.Add(this.txt_Nombre);
            this.groupBox1.Controls.Add(this.lbl_Nombre);
            this.groupBox1.Controls.Add(this.lbl_Codigo);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(243, 417);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DETALLE PRODUCTO";
            // 
            // mtb_Codigo
            // 
            this.mtb_Codigo.Location = new System.Drawing.Point(9, 42);
            this.mtb_Codigo.Mask = "99999999";
            this.mtb_Codigo.Name = "mtb_Codigo";
            this.mtb_Codigo.Size = new System.Drawing.Size(228, 20);
            this.mtb_Codigo.TabIndex = 1;
            this.toolTip1.SetToolTip(this.mtb_Codigo, "10000001");
            this.mtb_Codigo.ValidatingType = typeof(int);
            // 
            // lbl_ErrorMarca
            // 
            this.lbl_ErrorMarca.AutoSize = true;
            this.lbl_ErrorMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ErrorMarca.ForeColor = System.Drawing.Color.Red;
            this.lbl_ErrorMarca.Location = new System.Drawing.Point(45, 206);
            this.lbl_ErrorMarca.Name = "lbl_ErrorMarca";
            this.lbl_ErrorMarca.Size = new System.Drawing.Size(15, 18);
            this.lbl_ErrorMarca.TabIndex = 48;
            this.lbl_ErrorMarca.Text = "*";
            this.lbl_ErrorMarca.Visible = false;
            // 
            // lbl_ErrorCategoria
            // 
            this.lbl_ErrorCategoria.AutoSize = true;
            this.lbl_ErrorCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ErrorCategoria.ForeColor = System.Drawing.Color.Red;
            this.lbl_ErrorCategoria.Location = new System.Drawing.Point(66, 160);
            this.lbl_ErrorCategoria.Name = "lbl_ErrorCategoria";
            this.lbl_ErrorCategoria.Size = new System.Drawing.Size(15, 18);
            this.lbl_ErrorCategoria.TabIndex = 47;
            this.lbl_ErrorCategoria.Text = "*";
            this.lbl_ErrorCategoria.Visible = false;
            // 
            // lbl_ErrorDescripcion
            // 
            this.lbl_ErrorDescripcion.AutoSize = true;
            this.lbl_ErrorDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ErrorDescripcion.ForeColor = System.Drawing.Color.Red;
            this.lbl_ErrorDescripcion.Location = new System.Drawing.Point(75, 114);
            this.lbl_ErrorDescripcion.Name = "lbl_ErrorDescripcion";
            this.lbl_ErrorDescripcion.Size = new System.Drawing.Size(15, 18);
            this.lbl_ErrorDescripcion.TabIndex = 46;
            this.lbl_ErrorDescripcion.Text = "*";
            this.lbl_ErrorDescripcion.Visible = false;
            // 
            // lbl_ErrorNombre
            // 
            this.lbl_ErrorNombre.AutoSize = true;
            this.lbl_ErrorNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ErrorNombre.ForeColor = System.Drawing.Color.Red;
            this.lbl_ErrorNombre.Location = new System.Drawing.Point(54, 68);
            this.lbl_ErrorNombre.Name = "lbl_ErrorNombre";
            this.lbl_ErrorNombre.Size = new System.Drawing.Size(15, 18);
            this.lbl_ErrorNombre.TabIndex = 45;
            this.lbl_ErrorNombre.Text = "*";
            this.lbl_ErrorNombre.Visible = false;
            // 
            // lbl_ErrorCodigo
            // 
            this.lbl_ErrorCodigo.AutoSize = true;
            this.lbl_ErrorCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ErrorCodigo.ForeColor = System.Drawing.Color.Red;
            this.lbl_ErrorCodigo.Location = new System.Drawing.Point(45, 23);
            this.lbl_ErrorCodigo.Name = "lbl_ErrorCodigo";
            this.lbl_ErrorCodigo.Size = new System.Drawing.Size(15, 18);
            this.lbl_ErrorCodigo.TabIndex = 44;
            this.lbl_ErrorCodigo.Text = "*";
            this.lbl_ErrorCodigo.Visible = false;
            // 
            // btn_GenerarCodigo
            // 
            this.btn_GenerarCodigo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_GenerarCodigo.BackgroundImage")));
            this.btn_GenerarCodigo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_GenerarCodigo.Location = new System.Drawing.Point(9, 300);
            this.btn_GenerarCodigo.Name = "btn_GenerarCodigo";
            this.btn_GenerarCodigo.Size = new System.Drawing.Size(228, 33);
            this.btn_GenerarCodigo.TabIndex = 7;
            this.toolTip1.SetToolTip(this.btn_GenerarCodigo, "Generar Codigo");
            this.btn_GenerarCodigo.UseVisualStyleBackColor = true;
            this.btn_GenerarCodigo.Click += new System.EventHandler(this.btn_GenerarCodigo_Click);
            // 
            // txt_Marca
            // 
            this.txt_Marca.Location = new System.Drawing.Point(9, 226);
            this.txt_Marca.Name = "txt_Marca";
            this.txt_Marca.Size = new System.Drawing.Size(228, 20);
            this.txt_Marca.TabIndex = 5;
            // 
            // lbl_Marca
            // 
            this.lbl_Marca.AutoSize = true;
            this.lbl_Marca.Location = new System.Drawing.Point(6, 210);
            this.lbl_Marca.Name = "lbl_Marca";
            this.lbl_Marca.Size = new System.Drawing.Size(37, 13);
            this.lbl_Marca.TabIndex = 13;
            this.lbl_Marca.Text = "Marca";
            // 
            // txt_Categoria
            // 
            this.txt_Categoria.Location = new System.Drawing.Point(9, 180);
            this.txt_Categoria.Name = "txt_Categoria";
            this.txt_Categoria.Size = new System.Drawing.Size(228, 20);
            this.txt_Categoria.TabIndex = 4;
            // 
            // lbl_Categoria
            // 
            this.lbl_Categoria.AutoSize = true;
            this.lbl_Categoria.Location = new System.Drawing.Point(6, 164);
            this.lbl_Categoria.Name = "lbl_Categoria";
            this.lbl_Categoria.Size = new System.Drawing.Size(54, 13);
            this.lbl_Categoria.TabIndex = 11;
            this.lbl_Categoria.Text = "Categoría";
            // 
            // txt_Descripcion
            // 
            this.txt_Descripcion.Location = new System.Drawing.Point(9, 134);
            this.txt_Descripcion.Name = "txt_Descripcion";
            this.txt_Descripcion.Size = new System.Drawing.Size(228, 20);
            this.txt_Descripcion.TabIndex = 3;
            // 
            // btn_Limpiar
            // 
            this.btn_Limpiar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Limpiar.BackgroundImage")));
            this.btn_Limpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Limpiar.Location = new System.Drawing.Point(9, 339);
            this.btn_Limpiar.Name = "btn_Limpiar";
            this.btn_Limpiar.Size = new System.Drawing.Size(228, 33);
            this.btn_Limpiar.TabIndex = 8;
            this.toolTip1.SetToolTip(this.btn_Limpiar, "Limpiar datos");
            this.btn_Limpiar.UseVisualStyleBackColor = true;
            this.btn_Limpiar.Click += new System.EventHandler(this.btn_Limpiar_Click);
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Guardar.BackgroundImage")));
            this.btn_Guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Guardar.Location = new System.Drawing.Point(9, 261);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(228, 33);
            this.btn_Guardar.TabIndex = 6;
            this.toolTip1.SetToolTip(this.btn_Guardar, "Guardar");
            this.btn_Guardar.UseVisualStyleBackColor = true;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // lbl_Descripcion
            // 
            this.lbl_Descripcion.AutoSize = true;
            this.lbl_Descripcion.Location = new System.Drawing.Point(6, 118);
            this.lbl_Descripcion.Name = "lbl_Descripcion";
            this.lbl_Descripcion.Size = new System.Drawing.Size(63, 13);
            this.lbl_Descripcion.TabIndex = 4;
            this.lbl_Descripcion.Text = "Descripción";
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(9, 88);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(228, 20);
            this.txt_Nombre.TabIndex = 2;
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.AutoSize = true;
            this.lbl_Nombre.Location = new System.Drawing.Point(6, 72);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(44, 13);
            this.lbl_Nombre.TabIndex = 1;
            this.lbl_Nombre.Text = "Nombre";
            // 
            // lbl_Codigo
            // 
            this.lbl_Codigo.AutoSize = true;
            this.lbl_Codigo.Location = new System.Drawing.Point(6, 26);
            this.lbl_Codigo.Name = "lbl_Codigo";
            this.lbl_Codigo.Size = new System.Drawing.Size(40, 13);
            this.lbl_Codigo.TabIndex = 0;
            this.lbl_Codigo.Text = "Codigo";
            // 
            // FrmAddProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 441);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmAddProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.FrmAddProductos_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListaProductos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv_ListaProductos;
        private System.Windows.Forms.Label lbl_Buscar;
        private System.Windows.Forms.ComboBox cmb_Buscar;
        private System.Windows.Forms.TextBox txt_Buscar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_GenerarCodigo;
        private System.Windows.Forms.TextBox txt_Marca;
        private System.Windows.Forms.Label lbl_Marca;
        private System.Windows.Forms.TextBox txt_Categoria;
        private System.Windows.Forms.Label lbl_Categoria;
        private System.Windows.Forms.TextBox txt_Descripcion;
        private System.Windows.Forms.Button btn_Limpiar;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.Label lbl_Descripcion;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.Label lbl_Nombre;
        private System.Windows.Forms.Label lbl_Codigo;
        private System.Windows.Forms.Label lbl_ErrorMarca;
        private System.Windows.Forms.Label lbl_ErrorCategoria;
        private System.Windows.Forms.Label lbl_ErrorDescripcion;
        private System.Windows.Forms.Label lbl_ErrorNombre;
        private System.Windows.Forms.Label lbl_ErrorCodigo;
        private System.Windows.Forms.MaskedTextBox mtb_Codigo;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}