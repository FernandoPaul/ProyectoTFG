
namespace GestionAlmacen.Vistas.Salidas
{
    partial class FrmNuevaSalida
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNuevaSalida));
            this.btn_GuardarSalidas = new System.Windows.Forms.Button();
            this.dgv_Lista = new System.Windows.Forms.DataGridView();
            this.NumDoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaSalida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CifCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantridadProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grb_Registro = new System.Windows.Forms.GroupBox();
            this.dtp_FechaRegistro = new System.Windows.Forms.DateTimePicker();
            this.lbl_FechaRegistro = new System.Windows.Forms.Label();
            this.txt_NDocumento = new System.Windows.Forms.TextBox();
            this.lbl_NDocumento = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_Stock = new System.Windows.Forms.TextBox();
            this.txt_Descripcion = new System.Windows.Forms.TextBox();
            this.lbl_Stock = new System.Windows.Forms.Label();
            this.lbl_Descripcion = new System.Windows.Forms.Label();
            this.mtb_CodProd = new System.Windows.Forms.MaskedTextBox();
            this.btn_Anadir = new System.Windows.Forms.Button();
            this.nud_Cantidad = new System.Windows.Forms.NumericUpDown();
            this.lbl_CodProd = new System.Windows.Forms.Label();
            this.lbl_Cantidad = new System.Windows.Forms.Label();
            this.txt_NomProd = new System.Windows.Forms.TextBox();
            this.btn_BuscarProd = new System.Windows.Forms.Button();
            this.lbl_NomProd = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mtb_CifCliente = new System.Windows.Forms.MaskedTextBox();
            this.txt_NomCliente = new System.Windows.Forms.TextBox();
            this.btn_BuscarCliente = new System.Windows.Forms.Button();
            this.lbl_NomCliente = new System.Windows.Forms.Label();
            this.lbl_CifCliente = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Lista)).BeginInit();
            this.grb_Registro.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Cantidad)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_GuardarSalidas
            // 
            this.btn_GuardarSalidas.Location = new System.Drawing.Point(350, 417);
            this.btn_GuardarSalidas.Name = "btn_GuardarSalidas";
            this.btn_GuardarSalidas.Size = new System.Drawing.Size(101, 23);
            this.btn_GuardarSalidas.TabIndex = 13;
            this.btn_GuardarSalidas.Text = "Guardar Salidas";
            this.btn_GuardarSalidas.UseVisualStyleBackColor = true;
            this.btn_GuardarSalidas.Click += new System.EventHandler(this.btn_GuardarSalidas_Click);
            // 
            // dgv_Lista
            // 
            this.dgv_Lista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Lista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumDoc,
            this.FechaSalida,
            this.CifCliente,
            this.NombreCliente,
            this.CodProd,
            this.NombreProd,
            this.Descripcion,
            this.CantridadProd});
            this.dgv_Lista.Location = new System.Drawing.Point(13, 150);
            this.dgv_Lista.Name = "dgv_Lista";
            this.dgv_Lista.Size = new System.Drawing.Size(775, 261);
            this.dgv_Lista.TabIndex = 12;
            // 
            // NumDoc
            // 
            this.NumDoc.HeaderText = "NumDoc";
            this.NumDoc.Name = "NumDoc";
            this.NumDoc.Width = 60;
            // 
            // FechaSalida
            // 
            this.FechaSalida.HeaderText = "FechaSalida";
            this.FechaSalida.Name = "FechaSalida";
            // 
            // CifCliente
            // 
            this.CifCliente.HeaderText = "CifCliente";
            this.CifCliente.Name = "CifCliente";
            this.CifCliente.Width = 70;
            // 
            // NombreCliente
            // 
            this.NombreCliente.HeaderText = "NombreCliente";
            this.NombreCliente.Name = "NombreCliente";
            // 
            // CodProd
            // 
            this.CodProd.HeaderText = "CodProd";
            this.CodProd.Name = "CodProd";
            this.CodProd.Width = 70;
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
            // CantridadProd
            // 
            this.CantridadProd.HeaderText = "CantidadProd";
            this.CantridadProd.Name = "CantridadProd";
            // 
            // grb_Registro
            // 
            this.grb_Registro.Controls.Add(this.dtp_FechaRegistro);
            this.grb_Registro.Controls.Add(this.lbl_FechaRegistro);
            this.grb_Registro.Controls.Add(this.txt_NDocumento);
            this.grb_Registro.Controls.Add(this.lbl_NDocumento);
            this.grb_Registro.Location = new System.Drawing.Point(13, 11);
            this.grb_Registro.Name = "grb_Registro";
            this.grb_Registro.Size = new System.Drawing.Size(775, 44);
            this.grb_Registro.TabIndex = 9;
            this.grb_Registro.TabStop = false;
            // 
            // dtp_FechaRegistro
            // 
            this.dtp_FechaRegistro.Enabled = false;
            this.dtp_FechaRegistro.Location = new System.Drawing.Point(295, 13);
            this.dtp_FechaRegistro.Name = "dtp_FechaRegistro";
            this.dtp_FechaRegistro.Size = new System.Drawing.Size(200, 20);
            this.dtp_FechaRegistro.TabIndex = 1;
            this.dtp_FechaRegistro.Value = new System.DateTime(2023, 5, 9, 15, 54, 15, 0);
            // 
            // lbl_FechaRegistro
            // 
            this.lbl_FechaRegistro.AutoSize = true;
            this.lbl_FechaRegistro.Location = new System.Drawing.Point(215, 16);
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
            this.txt_NDocumento.TabIndex = 2;
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_Stock);
            this.groupBox2.Controls.Add(this.txt_Descripcion);
            this.groupBox2.Controls.Add(this.lbl_Stock);
            this.groupBox2.Controls.Add(this.lbl_Descripcion);
            this.groupBox2.Controls.Add(this.mtb_CodProd);
            this.groupBox2.Controls.Add(this.btn_Anadir);
            this.groupBox2.Controls.Add(this.nud_Cantidad);
            this.groupBox2.Controls.Add(this.lbl_CodProd);
            this.groupBox2.Controls.Add(this.lbl_Cantidad);
            this.groupBox2.Controls.Add(this.txt_NomProd);
            this.groupBox2.Controls.Add(this.btn_BuscarProd);
            this.groupBox2.Controls.Add(this.lbl_NomProd);
            this.groupBox2.Location = new System.Drawing.Point(248, 61);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(540, 83);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Producto";
            // 
            // txt_Stock
            // 
            this.txt_Stock.Enabled = false;
            this.txt_Stock.Location = new System.Drawing.Point(266, 50);
            this.txt_Stock.Name = "txt_Stock";
            this.txt_Stock.Size = new System.Drawing.Size(75, 20);
            this.txt_Stock.TabIndex = 15;
            // 
            // txt_Descripcion
            // 
            this.txt_Descripcion.Enabled = false;
            this.txt_Descripcion.Location = new System.Drawing.Point(294, 23);
            this.txt_Descripcion.Name = "txt_Descripcion";
            this.txt_Descripcion.Size = new System.Drawing.Size(192, 20);
            this.txt_Descripcion.TabIndex = 13;
            // 
            // lbl_Stock
            // 
            this.lbl_Stock.AutoSize = true;
            this.lbl_Stock.Location = new System.Drawing.Point(225, 55);
            this.lbl_Stock.Name = "lbl_Stock";
            this.lbl_Stock.Size = new System.Drawing.Size(35, 13);
            this.lbl_Stock.TabIndex = 14;
            this.lbl_Stock.Text = "Stock";
            // 
            // lbl_Descripcion
            // 
            this.lbl_Descripcion.AutoSize = true;
            this.lbl_Descripcion.Location = new System.Drawing.Point(225, 26);
            this.lbl_Descripcion.Name = "lbl_Descripcion";
            this.lbl_Descripcion.Size = new System.Drawing.Size(63, 13);
            this.lbl_Descripcion.TabIndex = 12;
            this.lbl_Descripcion.Text = "Descripcion";
            // 
            // mtb_CodProd
            // 
            this.mtb_CodProd.Enabled = false;
            this.mtb_CodProd.Location = new System.Drawing.Point(145, 22);
            this.mtb_CodProd.Mask = "A9999999";
            this.mtb_CodProd.Name = "mtb_CodProd";
            this.mtb_CodProd.Size = new System.Drawing.Size(66, 20);
            this.mtb_CodProd.TabIndex = 9;
            this.mtb_CodProd.ValidatingType = typeof(int);
            // 
            // btn_Anadir
            // 
            this.btn_Anadir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Anadir.BackgroundImage")));
            this.btn_Anadir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Anadir.Location = new System.Drawing.Point(502, 50);
            this.btn_Anadir.Name = "btn_Anadir";
            this.btn_Anadir.Size = new System.Drawing.Size(23, 23);
            this.btn_Anadir.TabIndex = 8;
            this.toolTip1.SetToolTip(this.btn_Anadir, "Añadir");
            this.btn_Anadir.UseVisualStyleBackColor = true;
            this.btn_Anadir.Click += new System.EventHandler(this.btn_Anadir_Click);
            // 
            // nud_Cantidad
            // 
            this.nud_Cantidad.Location = new System.Drawing.Point(411, 52);
            this.nud_Cantidad.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nud_Cantidad.Name = "nud_Cantidad";
            this.nud_Cantidad.Size = new System.Drawing.Size(75, 20);
            this.nud_Cantidad.TabIndex = 7;
            // 
            // lbl_CodProd
            // 
            this.lbl_CodProd.AutoSize = true;
            this.lbl_CodProd.Location = new System.Drawing.Point(99, 25);
            this.lbl_CodProd.Name = "lbl_CodProd";
            this.lbl_CodProd.Size = new System.Drawing.Size(40, 13);
            this.lbl_CodProd.TabIndex = 1;
            this.lbl_CodProd.Text = "Codigo";
            // 
            // lbl_Cantidad
            // 
            this.lbl_Cantidad.AutoSize = true;
            this.lbl_Cantidad.Location = new System.Drawing.Point(356, 55);
            this.lbl_Cantidad.Name = "lbl_Cantidad";
            this.lbl_Cantidad.Size = new System.Drawing.Size(49, 13);
            this.lbl_Cantidad.TabIndex = 6;
            this.lbl_Cantidad.Text = "Cantidad";
            // 
            // txt_NomProd
            // 
            this.txt_NomProd.Enabled = false;
            this.txt_NomProd.Location = new System.Drawing.Point(64, 50);
            this.txt_NomProd.Name = "txt_NomProd";
            this.txt_NomProd.Size = new System.Drawing.Size(147, 20);
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
            this.lbl_NomProd.Location = new System.Drawing.Point(20, 55);
            this.lbl_NomProd.Name = "lbl_NomProd";
            this.lbl_NomProd.Size = new System.Drawing.Size(44, 13);
            this.lbl_NomProd.TabIndex = 3;
            this.lbl_NomProd.Text = "Nombre";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mtb_CifCliente);
            this.groupBox1.Controls.Add(this.txt_NomCliente);
            this.groupBox1.Controls.Add(this.btn_BuscarCliente);
            this.groupBox1.Controls.Add(this.lbl_NomCliente);
            this.groupBox1.Controls.Add(this.lbl_CifCliente);
            this.groupBox1.Location = new System.Drawing.Point(13, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(229, 83);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cliente";
            // 
            // mtb_CifCliente
            // 
            this.mtb_CifCliente.Enabled = false;
            this.mtb_CifCliente.Location = new System.Drawing.Point(59, 22);
            this.mtb_CifCliente.Mask = "A99999999";
            this.mtb_CifCliente.Name = "mtb_CifCliente";
            this.mtb_CifCliente.Size = new System.Drawing.Size(66, 20);
            this.mtb_CifCliente.TabIndex = 4;
            this.mtb_CifCliente.ValidatingType = typeof(int);
            // 
            // txt_NomCliente
            // 
            this.txt_NomCliente.Enabled = false;
            this.txt_NomCliente.Location = new System.Drawing.Point(59, 52);
            this.txt_NomCliente.Name = "txt_NomCliente";
            this.txt_NomCliente.Size = new System.Drawing.Size(160, 20);
            this.txt_NomCliente.TabIndex = 2;
            // 
            // btn_BuscarCliente
            // 
            this.btn_BuscarCliente.Location = new System.Drawing.Point(144, 20);
            this.btn_BuscarCliente.Name = "btn_BuscarCliente";
            this.btn_BuscarCliente.Size = new System.Drawing.Size(75, 23);
            this.btn_BuscarCliente.TabIndex = 3;
            this.btn_BuscarCliente.Text = "Buscar";
            this.btn_BuscarCliente.UseVisualStyleBackColor = true;
            this.btn_BuscarCliente.Click += new System.EventHandler(this.btn_BuscarCliente_Click);
            // 
            // lbl_NomCliente
            // 
            this.lbl_NomCliente.AutoSize = true;
            this.lbl_NomCliente.Location = new System.Drawing.Point(9, 55);
            this.lbl_NomCliente.Name = "lbl_NomCliente";
            this.lbl_NomCliente.Size = new System.Drawing.Size(44, 13);
            this.lbl_NomCliente.TabIndex = 3;
            this.lbl_NomCliente.Text = "Nombre";
            // 
            // lbl_CifCliente
            // 
            this.lbl_CifCliente.AutoSize = true;
            this.lbl_CifCliente.Location = new System.Drawing.Point(9, 25);
            this.lbl_CifCliente.Name = "lbl_CifCliente";
            this.lbl_CifCliente.Size = new System.Drawing.Size(23, 13);
            this.lbl_CifCliente.TabIndex = 1;
            this.lbl_CifCliente.Text = "CIF";
            // 
            // FrmNuevaSalida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_GuardarSalidas);
            this.Controls.Add(this.dgv_Lista);
            this.Controls.Add(this.grb_Registro);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmNuevaSalida";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nueva Salida";
            this.Load += new System.EventHandler(this.FrmNuevaSalida_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Lista)).EndInit();
            this.grb_Registro.ResumeLayout(false);
            this.grb_Registro.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Cantidad)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_GuardarSalidas;
        private System.Windows.Forms.DataGridView dgv_Lista;
        private System.Windows.Forms.GroupBox grb_Registro;
        private System.Windows.Forms.DateTimePicker dtp_FechaRegistro;
        private System.Windows.Forms.Label lbl_FechaRegistro;
        private System.Windows.Forms.TextBox txt_NDocumento;
        private System.Windows.Forms.Label lbl_NDocumento;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MaskedTextBox mtb_CodProd;
        private System.Windows.Forms.Button btn_Anadir;
        private System.Windows.Forms.NumericUpDown nud_Cantidad;
        private System.Windows.Forms.Label lbl_Cantidad;
        private System.Windows.Forms.TextBox txt_NomProd;
        private System.Windows.Forms.Button btn_BuscarProd;
        private System.Windows.Forms.Label lbl_NomProd;
        private System.Windows.Forms.Label lbl_CodProd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox mtb_CifCliente;
        private System.Windows.Forms.TextBox txt_NomCliente;
        private System.Windows.Forms.Button btn_BuscarCliente;
        private System.Windows.Forms.Label lbl_NomCliente;
        private System.Windows.Forms.Label lbl_CifCliente;
        private System.Windows.Forms.TextBox txt_Descripcion;
        private System.Windows.Forms.Label lbl_Descripcion;
        private System.Windows.Forms.TextBox txt_Stock;
        private System.Windows.Forms.Label lbl_Stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumDoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaSalida;
        private System.Windows.Forms.DataGridViewTextBoxColumn CifCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantridadProd;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}