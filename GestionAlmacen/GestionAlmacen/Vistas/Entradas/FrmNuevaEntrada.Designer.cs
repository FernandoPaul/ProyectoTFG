
namespace GestionAlmacen.Vistas.Entradas
{
    partial class FrmNuevaEntrada
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNuevaEntrada));
            this.btn_GuardarEntradas = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_Descripcion = new System.Windows.Forms.TextBox();
            this.btn_Anadir = new System.Windows.Forms.Button();
            this.lbl_Descripcion = new System.Windows.Forms.Label();
            this.mtb_CodProd = new System.Windows.Forms.MaskedTextBox();
            this.nud_Cantidad = new System.Windows.Forms.NumericUpDown();
            this.lbl_CodProd = new System.Windows.Forms.Label();
            this.lbl_Cantidad = new System.Windows.Forms.Label();
            this.txt_NomProd = new System.Windows.Forms.TextBox();
            this.btn_BuscarProd = new System.Windows.Forms.Button();
            this.lbl_NomProd = new System.Windows.Forms.Label();
            this.dgv_Lista = new System.Windows.Forms.DataGridView();
            this.NumDoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaEntrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CifProv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreProv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mtb_CifProv = new System.Windows.Forms.MaskedTextBox();
            this.txt_NomProv = new System.Windows.Forms.TextBox();
            this.btn_BuscarProv = new System.Windows.Forms.Button();
            this.lbl_NomProv = new System.Windows.Forms.Label();
            this.lbl_CifProv = new System.Windows.Forms.Label();
            this.grb_Registro = new System.Windows.Forms.GroupBox();
            this.dtp_FechaRegistro = new System.Windows.Forms.DateTimePicker();
            this.lbl_FechaRegistro = new System.Windows.Forms.Label();
            this.txt_NDocumento = new System.Windows.Forms.TextBox();
            this.lbl_NDocumento = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Cantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Lista)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.grb_Registro.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_GuardarEntradas
            // 
            this.btn_GuardarEntradas.Location = new System.Drawing.Point(350, 416);
            this.btn_GuardarEntradas.Name = "btn_GuardarEntradas";
            this.btn_GuardarEntradas.Size = new System.Drawing.Size(101, 23);
            this.btn_GuardarEntradas.TabIndex = 9;
            this.btn_GuardarEntradas.Text = "Guardar Entradas";
            this.btn_GuardarEntradas.UseVisualStyleBackColor = true;
            this.btn_GuardarEntradas.Click += new System.EventHandler(this.btn_GuardarEntradas_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_Descripcion);
            this.groupBox2.Controls.Add(this.btn_Anadir);
            this.groupBox2.Controls.Add(this.lbl_Descripcion);
            this.groupBox2.Controls.Add(this.mtb_CodProd);
            this.groupBox2.Controls.Add(this.nud_Cantidad);
            this.groupBox2.Controls.Add(this.lbl_CodProd);
            this.groupBox2.Controls.Add(this.lbl_Cantidad);
            this.groupBox2.Controls.Add(this.txt_NomProd);
            this.groupBox2.Controls.Add(this.btn_BuscarProd);
            this.groupBox2.Controls.Add(this.lbl_NomProd);
            this.groupBox2.Location = new System.Drawing.Point(291, 51);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(505, 83);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Producto";
            // 
            // txt_Descripcion
            // 
            this.txt_Descripcion.Enabled = false;
            this.txt_Descripcion.Location = new System.Drawing.Point(319, 22);
            this.txt_Descripcion.Name = "txt_Descripcion";
            this.txt_Descripcion.Size = new System.Drawing.Size(178, 20);
            this.txt_Descripcion.TabIndex = 11;
            // 
            // btn_Anadir
            // 
            this.btn_Anadir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Anadir.BackgroundImage")));
            this.btn_Anadir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Anadir.Location = new System.Drawing.Point(474, 49);
            this.btn_Anadir.Name = "btn_Anadir";
            this.btn_Anadir.Size = new System.Drawing.Size(23, 24);
            this.btn_Anadir.TabIndex = 8;
            this.toolTip1.SetToolTip(this.btn_Anadir, "Añadir");
            this.btn_Anadir.UseVisualStyleBackColor = true;
            this.btn_Anadir.Click += new System.EventHandler(this.btn_Anadir_Click);
            // 
            // lbl_Descripcion
            // 
            this.lbl_Descripcion.AutoSize = true;
            this.lbl_Descripcion.Location = new System.Drawing.Point(250, 25);
            this.lbl_Descripcion.Name = "lbl_Descripcion";
            this.lbl_Descripcion.Size = new System.Drawing.Size(63, 13);
            this.lbl_Descripcion.TabIndex = 10;
            this.lbl_Descripcion.Text = "Descripcion";
            // 
            // mtb_CodProd
            // 
            this.mtb_CodProd.Enabled = false;
            this.mtb_CodProd.Location = new System.Drawing.Point(172, 22);
            this.mtb_CodProd.Mask = "A9999999";
            this.mtb_CodProd.Name = "mtb_CodProd";
            this.mtb_CodProd.Size = new System.Drawing.Size(66, 20);
            this.mtb_CodProd.TabIndex = 9;
            this.mtb_CodProd.ValidatingType = typeof(int);
            // 
            // nud_Cantidad
            // 
            this.nud_Cantidad.Location = new System.Drawing.Point(319, 52);
            this.nud_Cantidad.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nud_Cantidad.Name = "nud_Cantidad";
            this.nud_Cantidad.Size = new System.Drawing.Size(111, 20);
            this.nud_Cantidad.TabIndex = 7;
            // 
            // lbl_CodProd
            // 
            this.lbl_CodProd.AutoSize = true;
            this.lbl_CodProd.Location = new System.Drawing.Point(122, 25);
            this.lbl_CodProd.Name = "lbl_CodProd";
            this.lbl_CodProd.Size = new System.Drawing.Size(40, 13);
            this.lbl_CodProd.TabIndex = 1;
            this.lbl_CodProd.Text = "Codigo";
            // 
            // lbl_Cantidad
            // 
            this.lbl_Cantidad.AutoSize = true;
            this.lbl_Cantidad.Location = new System.Drawing.Point(250, 55);
            this.lbl_Cantidad.Name = "lbl_Cantidad";
            this.lbl_Cantidad.Size = new System.Drawing.Size(49, 13);
            this.lbl_Cantidad.TabIndex = 6;
            this.lbl_Cantidad.Text = "Cantidad";
            // 
            // txt_NomProd
            // 
            this.txt_NomProd.Enabled = false;
            this.txt_NomProd.Location = new System.Drawing.Point(60, 52);
            this.txt_NomProd.Name = "txt_NomProd";
            this.txt_NomProd.Size = new System.Drawing.Size(178, 20);
            this.txt_NomProd.TabIndex = 5;
            // 
            // btn_BuscarProd
            // 
            this.btn_BuscarProd.Location = new System.Drawing.Point(13, 20);
            this.btn_BuscarProd.Name = "btn_BuscarProd";
            this.btn_BuscarProd.Size = new System.Drawing.Size(75, 23);
            this.btn_BuscarProd.TabIndex = 6;
            this.btn_BuscarProd.Text = "Buscar";
            this.btn_BuscarProd.UseVisualStyleBackColor = true;
            this.btn_BuscarProd.Click += new System.EventHandler(this.btn_BuscarProd_Click);
            // 
            // lbl_NomProd
            // 
            this.lbl_NomProd.AutoSize = true;
            this.lbl_NomProd.Location = new System.Drawing.Point(10, 55);
            this.lbl_NomProd.Name = "lbl_NomProd";
            this.lbl_NomProd.Size = new System.Drawing.Size(44, 13);
            this.lbl_NomProd.TabIndex = 3;
            this.lbl_NomProd.Text = "Nombre";
            // 
            // dgv_Lista
            // 
            this.dgv_Lista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Lista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumDoc,
            this.FechaEntrada,
            this.CifProv,
            this.NombreProv,
            this.CodProd,
            this.NombreProd,
            this.Descripcion,
            this.Cantidad});
            this.dgv_Lista.Location = new System.Drawing.Point(7, 140);
            this.dgv_Lista.Name = "dgv_Lista";
            this.dgv_Lista.Size = new System.Drawing.Size(789, 270);
            this.dgv_Lista.TabIndex = 14;
            // 
            // NumDoc
            // 
            this.NumDoc.HeaderText = "NumDoc";
            this.NumDoc.Name = "NumDoc";
            this.NumDoc.Width = 70;
            // 
            // FechaEntrada
            // 
            this.FechaEntrada.HeaderText = "FechaEntrada";
            this.FechaEntrada.Name = "FechaEntrada";
            // 
            // CifProv
            // 
            this.CifProv.HeaderText = "CifProv";
            this.CifProv.Name = "CifProv";
            // 
            // NombreProv
            // 
            this.NombreProv.HeaderText = "NombreProv";
            this.NombreProv.Name = "NombreProv";
            // 
            // CodProd
            // 
            this.CodProd.HeaderText = "CodProd";
            this.CodProd.Name = "CodProd";
            // 
            // NombreProd
            // 
            this.NombreProd.HeaderText = "NombreProd";
            this.NombreProd.Name = "NombreProd";
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mtb_CifProv);
            this.groupBox1.Controls.Add(this.txt_NomProv);
            this.groupBox1.Controls.Add(this.btn_BuscarProv);
            this.groupBox1.Controls.Add(this.lbl_NomProv);
            this.groupBox1.Controls.Add(this.lbl_CifProv);
            this.groupBox1.Location = new System.Drawing.Point(7, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(278, 83);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Proveedor";
            // 
            // mtb_CifProv
            // 
            this.mtb_CifProv.Enabled = false;
            this.mtb_CifProv.Location = new System.Drawing.Point(59, 22);
            this.mtb_CifProv.Mask = "A99999999";
            this.mtb_CifProv.Name = "mtb_CifProv";
            this.mtb_CifProv.Size = new System.Drawing.Size(66, 20);
            this.mtb_CifProv.TabIndex = 4;
            this.mtb_CifProv.ValidatingType = typeof(int);
            // 
            // txt_NomProv
            // 
            this.txt_NomProv.Enabled = false;
            this.txt_NomProv.Location = new System.Drawing.Point(59, 52);
            this.txt_NomProv.Name = "txt_NomProv";
            this.txt_NomProv.Size = new System.Drawing.Size(178, 20);
            this.txt_NomProv.TabIndex = 2;
            // 
            // btn_BuscarProv
            // 
            this.btn_BuscarProv.Location = new System.Drawing.Point(162, 19);
            this.btn_BuscarProv.Name = "btn_BuscarProv";
            this.btn_BuscarProv.Size = new System.Drawing.Size(75, 23);
            this.btn_BuscarProv.TabIndex = 3;
            this.btn_BuscarProv.Text = "Buscar";
            this.btn_BuscarProv.UseVisualStyleBackColor = true;
            this.btn_BuscarProv.Click += new System.EventHandler(this.btn_BuscarProv_Click);
            // 
            // lbl_NomProv
            // 
            this.lbl_NomProv.AutoSize = true;
            this.lbl_NomProv.Location = new System.Drawing.Point(9, 55);
            this.lbl_NomProv.Name = "lbl_NomProv";
            this.lbl_NomProv.Size = new System.Drawing.Size(44, 13);
            this.lbl_NomProv.TabIndex = 3;
            this.lbl_NomProv.Text = "Nombre";
            // 
            // lbl_CifProv
            // 
            this.lbl_CifProv.AutoSize = true;
            this.lbl_CifProv.Location = new System.Drawing.Point(9, 25);
            this.lbl_CifProv.Name = "lbl_CifProv";
            this.lbl_CifProv.Size = new System.Drawing.Size(23, 13);
            this.lbl_CifProv.TabIndex = 1;
            this.lbl_CifProv.Text = "CIF";
            // 
            // grb_Registro
            // 
            this.grb_Registro.Controls.Add(this.dtp_FechaRegistro);
            this.grb_Registro.Controls.Add(this.lbl_FechaRegistro);
            this.grb_Registro.Controls.Add(this.txt_NDocumento);
            this.grb_Registro.Controls.Add(this.lbl_NDocumento);
            this.grb_Registro.Location = new System.Drawing.Point(7, 1);
            this.grb_Registro.Name = "grb_Registro";
            this.grb_Registro.Size = new System.Drawing.Size(789, 44);
            this.grb_Registro.TabIndex = 11;
            this.grb_Registro.TabStop = false;
            // 
            // dtp_FechaRegistro
            // 
            this.dtp_FechaRegistro.Enabled = false;
            this.dtp_FechaRegistro.Location = new System.Drawing.Point(284, 13);
            this.dtp_FechaRegistro.Name = "dtp_FechaRegistro";
            this.dtp_FechaRegistro.Size = new System.Drawing.Size(200, 20);
            this.dtp_FechaRegistro.TabIndex = 11;
            this.dtp_FechaRegistro.Value = new System.DateTime(2023, 6, 2, 0, 0, 0, 0);
            // 
            // lbl_FechaRegistro
            // 
            this.lbl_FechaRegistro.AutoSize = true;
            this.lbl_FechaRegistro.Location = new System.Drawing.Point(204, 16);
            this.lbl_FechaRegistro.Name = "lbl_FechaRegistro";
            this.lbl_FechaRegistro.Size = new System.Drawing.Size(74, 13);
            this.lbl_FechaRegistro.TabIndex = 3;
            this.lbl_FechaRegistro.Text = "Fecha registro";
            // 
            // txt_NDocumento
            // 
            this.txt_NDocumento.Enabled = false;
            this.txt_NDocumento.Location = new System.Drawing.Point(89, 13);
            this.txt_NDocumento.Name = "txt_NDocumento";
            this.txt_NDocumento.Size = new System.Drawing.Size(100, 20);
            this.txt_NDocumento.TabIndex = 10;
            // 
            // lbl_NDocumento
            // 
            this.lbl_NDocumento.AutoSize = true;
            this.lbl_NDocumento.Location = new System.Drawing.Point(6, 16);
            this.lbl_NDocumento.Name = "lbl_NDocumento";
            this.lbl_NDocumento.Size = new System.Drawing.Size(77, 13);
            this.lbl_NDocumento.TabIndex = 1;
            this.lbl_NDocumento.Text = "Nº Documento";
            // 
            // FrmNuevaEntrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_GuardarEntradas);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgv_Lista);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grb_Registro);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmNuevaEntrada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nueva Entrada";
            this.Load += new System.EventHandler(this.FrmNuevaEntrada_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Cantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Lista)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grb_Registro.ResumeLayout(false);
            this.grb_Registro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_GuardarEntradas;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_Anadir;
        private System.Windows.Forms.NumericUpDown nud_Cantidad;
        private System.Windows.Forms.Label lbl_Cantidad;
        private System.Windows.Forms.TextBox txt_NomProd;
        private System.Windows.Forms.Button btn_BuscarProd;
        private System.Windows.Forms.Label lbl_NomProd;
        private System.Windows.Forms.Label lbl_CodProd;
        private System.Windows.Forms.DataGridView dgv_Lista;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_NomProv;
        private System.Windows.Forms.Button btn_BuscarProv;
        private System.Windows.Forms.Label lbl_NomProv;
        private System.Windows.Forms.Label lbl_CifProv;
        private System.Windows.Forms.GroupBox grb_Registro;
        private System.Windows.Forms.DateTimePicker dtp_FechaRegistro;
        private System.Windows.Forms.Label lbl_FechaRegistro;
        private System.Windows.Forms.TextBox txt_NDocumento;
        private System.Windows.Forms.Label lbl_NDocumento;
        private System.Windows.Forms.MaskedTextBox mtb_CodProd;
        private System.Windows.Forms.MaskedTextBox mtb_CifProv;
        private System.Windows.Forms.TextBox txt_Descripcion;
        private System.Windows.Forms.Label lbl_Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumDoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaEntrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn CifProv;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreProv;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}