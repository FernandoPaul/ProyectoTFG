
namespace GestionAlmacen.Vistas.Productos
{
    partial class FrmCargarProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCargarProductos));
            this.btn_DescargarPlantilla = new System.Windows.Forms.Button();
            this.dgv_Add = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Subir = new System.Windows.Forms.Button();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.lbl_NomArchivo = new System.Windows.Forms.Label();
            this.txt_NomArchivo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Add)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_DescargarPlantilla
            // 
            this.btn_DescargarPlantilla.Location = new System.Drawing.Point(638, 16);
            this.btn_DescargarPlantilla.Name = "btn_DescargarPlantilla";
            this.btn_DescargarPlantilla.Size = new System.Drawing.Size(132, 23);
            this.btn_DescargarPlantilla.TabIndex = 4;
            this.btn_DescargarPlantilla.Text = "Descargar Plantilla";
            this.btn_DescargarPlantilla.UseVisualStyleBackColor = true;
            this.btn_DescargarPlantilla.Click += new System.EventHandler(this.btn_DescargarPlantilla_Click);
            // 
            // dgv_Add
            // 
            this.dgv_Add.AllowUserToAddRows = false;
            this.dgv_Add.AllowUserToDeleteRows = false;
            this.dgv_Add.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Add.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nombre,
            this.Descripcion,
            this.Categoria,
            this.Marca});
            this.dgv_Add.Enabled = false;
            this.dgv_Add.Location = new System.Drawing.Point(6, 48);
            this.dgv_Add.Name = "dgv_Add";
            this.dgv_Add.ReadOnly = true;
            this.dgv_Add.Size = new System.Drawing.Size(764, 295);
            this.dgv_Add.TabIndex = 3;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // Categoria
            // 
            this.Categoria.HeaderText = "Categoria";
            this.Categoria.Name = "Categoria";
            this.Categoria.ReadOnly = true;
            // 
            // Marca
            // 
            this.Marca.HeaderText = "Marca";
            this.Marca.Name = "Marca";
            this.Marca.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btn_DescargarPlantilla);
            this.groupBox2.Controls.Add(this.dgv_Add);
            this.groupBox2.Location = new System.Drawing.Point(12, 89);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(776, 349);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(612, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 23);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Datos cargados";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.btn_Subir);
            this.groupBox1.Controls.Add(this.btn_Buscar);
            this.groupBox1.Controls.Add(this.lbl_NomArchivo);
            this.groupBox1.Controls.Add(this.txt_NomArchivo);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 71);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // btn_Subir
            // 
            this.btn_Subir.Location = new System.Drawing.Point(695, 20);
            this.btn_Subir.Name = "btn_Subir";
            this.btn_Subir.Size = new System.Drawing.Size(75, 23);
            this.btn_Subir.TabIndex = 3;
            this.btn_Subir.Text = "Subir";
            this.btn_Subir.UseVisualStyleBackColor = true;
            this.btn_Subir.Click += new System.EventHandler(this.btn_Subir_Click);
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Location = new System.Drawing.Point(313, 20);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(75, 23);
            this.btn_Buscar.TabIndex = 0;
            this.btn_Buscar.Text = "Buscar";
            this.btn_Buscar.UseVisualStyleBackColor = true;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // lbl_NomArchivo
            // 
            this.lbl_NomArchivo.AutoSize = true;
            this.lbl_NomArchivo.Location = new System.Drawing.Point(9, 25);
            this.lbl_NomArchivo.Name = "lbl_NomArchivo";
            this.lbl_NomArchivo.Size = new System.Drawing.Size(83, 13);
            this.lbl_NomArchivo.TabIndex = 1;
            this.lbl_NomArchivo.Text = "Nombre Archivo";
            // 
            // txt_NomArchivo
            // 
            this.txt_NomArchivo.Enabled = false;
            this.txt_NomArchivo.Location = new System.Drawing.Point(98, 22);
            this.txt_NomArchivo.Name = "txt_NomArchivo";
            this.txt_NomArchivo.Size = new System.Drawing.Size(209, 20);
            this.txt_NomArchivo.TabIndex = 2;
            // 
            // FrmCargarProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCargarProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cargar Productos";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Add)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_DescargarPlantilla;
        private System.Windows.Forms.DataGridView dgv_Add;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Subir;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.Label lbl_NomArchivo;
        private System.Windows.Forms.TextBox txt_NomArchivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}