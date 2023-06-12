
namespace GestionAlmacen.Vistas
{
    partial class FrmCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCliente));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv_ListaClientes = new System.Windows.Forms.DataGridView();
            this.lbl_Buscar = new System.Windows.Forms.Label();
            this.cmb_Buscar = new System.Windows.Forms.ComboBox();
            this.txt_Buscar = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_ErrorMovil = new System.Windows.Forms.Label();
            this.lbl_ErrorNombreCliente = new System.Windows.Forms.Label();
            this.lbl_ErrorCIF = new System.Windows.Forms.Label();
            this.mtb_Cif = new System.Windows.Forms.MaskedTextBox();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_Limpiar = new System.Windows.Forms.Button();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.mtb_Movil = new System.Windows.Forms.MaskedTextBox();
            this.lbl_Movil = new System.Windows.Forms.Label();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.lbl_Nombre = new System.Windows.Forms.Label();
            this.lbl_CIF = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListaClientes)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.dgv_ListaClientes);
            this.groupBox2.Controls.Add(this.lbl_Buscar);
            this.groupBox2.Controls.Add(this.cmb_Buscar);
            this.groupBox2.Controls.Add(this.txt_Buscar);
            this.groupBox2.Location = new System.Drawing.Point(261, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(527, 337);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "LISTA DE CLIENTES";
            // 
            // dgv_ListaClientes
            // 
            this.dgv_ListaClientes.AllowUserToAddRows = false;
            this.dgv_ListaClientes.AllowUserToDeleteRows = false;
            this.dgv_ListaClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ListaClientes.Location = new System.Drawing.Point(9, 50);
            this.dgv_ListaClientes.Name = "dgv_ListaClientes";
            this.dgv_ListaClientes.ReadOnly = true;
            this.dgv_ListaClientes.Size = new System.Drawing.Size(512, 281);
            this.dgv_ListaClientes.TabIndex = 14;
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
            this.cmb_Buscar.Location = new System.Drawing.Point(52, 23);
            this.cmb_Buscar.Name = "cmb_Buscar";
            this.cmb_Buscar.Size = new System.Drawing.Size(121, 21);
            this.cmb_Buscar.TabIndex = 7;
            // 
            // txt_Buscar
            // 
            this.txt_Buscar.Location = new System.Drawing.Point(179, 24);
            this.txt_Buscar.Name = "txt_Buscar";
            this.txt_Buscar.Size = new System.Drawing.Size(225, 20);
            this.txt_Buscar.TabIndex = 8;
            this.txt_Buscar.TextChanged += new System.EventHandler(this.txt_Buscar_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.lbl_ErrorMovil);
            this.groupBox1.Controls.Add(this.lbl_ErrorNombreCliente);
            this.groupBox1.Controls.Add(this.lbl_ErrorCIF);
            this.groupBox1.Controls.Add(this.mtb_Cif);
            this.groupBox1.Controls.Add(this.btn_Eliminar);
            this.groupBox1.Controls.Add(this.btn_Limpiar);
            this.groupBox1.Controls.Add(this.btn_Guardar);
            this.groupBox1.Controls.Add(this.mtb_Movil);
            this.groupBox1.Controls.Add(this.lbl_Movil);
            this.groupBox1.Controls.Add(this.txt_Nombre);
            this.groupBox1.Controls.Add(this.lbl_Nombre);
            this.groupBox1.Controls.Add(this.lbl_CIF);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(243, 337);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DETALLE CLIENTE";
            // 
            // lbl_ErrorMovil
            // 
            this.lbl_ErrorMovil.AutoSize = true;
            this.lbl_ErrorMovil.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ErrorMovil.ForeColor = System.Drawing.Color.Red;
            this.lbl_ErrorMovil.Location = new System.Drawing.Point(97, 131);
            this.lbl_ErrorMovil.Name = "lbl_ErrorMovil";
            this.lbl_ErrorMovil.Size = new System.Drawing.Size(15, 18);
            this.lbl_ErrorMovil.TabIndex = 45;
            this.lbl_ErrorMovil.Text = "*";
            this.lbl_ErrorMovil.Visible = false;
            // 
            // lbl_ErrorNombreCliente
            // 
            this.lbl_ErrorNombreCliente.AutoSize = true;
            this.lbl_ErrorNombreCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ErrorNombreCliente.ForeColor = System.Drawing.Color.Red;
            this.lbl_ErrorNombreCliente.Location = new System.Drawing.Point(91, 76);
            this.lbl_ErrorNombreCliente.Name = "lbl_ErrorNombreCliente";
            this.lbl_ErrorNombreCliente.Size = new System.Drawing.Size(15, 18);
            this.lbl_ErrorNombreCliente.TabIndex = 44;
            this.lbl_ErrorNombreCliente.Text = "*";
            this.lbl_ErrorNombreCliente.Visible = false;
            // 
            // lbl_ErrorCIF
            // 
            this.lbl_ErrorCIF.AutoSize = true;
            this.lbl_ErrorCIF.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ErrorCIF.ForeColor = System.Drawing.Color.Red;
            this.lbl_ErrorCIF.Location = new System.Drawing.Point(35, 22);
            this.lbl_ErrorCIF.Name = "lbl_ErrorCIF";
            this.lbl_ErrorCIF.Size = new System.Drawing.Size(15, 18);
            this.lbl_ErrorCIF.TabIndex = 43;
            this.lbl_ErrorCIF.Text = "*";
            this.lbl_ErrorCIF.Visible = false;
            // 
            // mtb_Cif
            // 
            this.mtb_Cif.Location = new System.Drawing.Point(9, 42);
            this.mtb_Cif.Mask = "A99999999";
            this.mtb_Cif.Name = "mtb_Cif";
            this.mtb_Cif.Size = new System.Drawing.Size(228, 20);
            this.mtb_Cif.TabIndex = 1;
            this.toolTip1.SetToolTip(this.mtb_Cif, "A00000000");
            this.mtb_Cif.ValidatingType = typeof(int);
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Eliminar.BackgroundImage")));
            this.btn_Eliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Eliminar.Location = new System.Drawing.Point(9, 298);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(228, 33);
            this.btn_Eliminar.TabIndex = 5;
            this.toolTip1.SetToolTip(this.btn_Eliminar, "Eliminar");
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // btn_Limpiar
            // 
            this.btn_Limpiar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Limpiar.BackgroundImage")));
            this.btn_Limpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Limpiar.Location = new System.Drawing.Point(10, 251);
            this.btn_Limpiar.Name = "btn_Limpiar";
            this.btn_Limpiar.Size = new System.Drawing.Size(227, 33);
            this.btn_Limpiar.TabIndex = 5;
            this.toolTip1.SetToolTip(this.btn_Limpiar, "Limpiar datos");
            this.btn_Limpiar.UseVisualStyleBackColor = true;
            this.btn_Limpiar.Click += new System.EventHandler(this.btn_Limpiar_Click);
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Guardar.BackgroundImage")));
            this.btn_Guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Guardar.Location = new System.Drawing.Point(9, 204);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(227, 33);
            this.btn_Guardar.TabIndex = 4;
            this.toolTip1.SetToolTip(this.btn_Guardar, "Guardar");
            this.btn_Guardar.UseVisualStyleBackColor = true;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // mtb_Movil
            // 
            this.mtb_Movil.Location = new System.Drawing.Point(9, 152);
            this.mtb_Movil.Mask = "999999999";
            this.mtb_Movil.Name = "mtb_Movil";
            this.mtb_Movil.Size = new System.Drawing.Size(228, 20);
            this.mtb_Movil.TabIndex = 3;
            this.mtb_Movil.ValidatingType = typeof(int);
            // 
            // lbl_Movil
            // 
            this.lbl_Movil.AutoSize = true;
            this.lbl_Movil.Location = new System.Drawing.Point(6, 136);
            this.lbl_Movil.Name = "lbl_Movil";
            this.lbl_Movil.Size = new System.Drawing.Size(85, 13);
            this.lbl_Movil.TabIndex = 4;
            this.lbl_Movil.Text = "Telefono / Movil";
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(9, 97);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(228, 20);
            this.txt_Nombre.TabIndex = 2;
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.AutoSize = true;
            this.lbl_Nombre.Location = new System.Drawing.Point(6, 81);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(79, 13);
            this.lbl_Nombre.TabIndex = 1;
            this.lbl_Nombre.Text = "Nombre Cliente";
            // 
            // lbl_CIF
            // 
            this.lbl_CIF.AutoSize = true;
            this.lbl_CIF.Location = new System.Drawing.Point(6, 26);
            this.lbl_CIF.Name = "lbl_CIF";
            this.lbl_CIF.Size = new System.Drawing.Size(23, 13);
            this.lbl_CIF.TabIndex = 0;
            this.lbl_CIF.Text = "CIF";
            // 
            // FrmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 361);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.FrmCliente_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListaClientes)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv_ListaClientes;
        private System.Windows.Forms.Label lbl_Buscar;
        private System.Windows.Forms.ComboBox cmb_Buscar;
        private System.Windows.Forms.TextBox txt_Buscar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_ErrorMovil;
        private System.Windows.Forms.Label lbl_ErrorNombreCliente;
        private System.Windows.Forms.Label lbl_ErrorCIF;
        private System.Windows.Forms.MaskedTextBox mtb_Cif;
        private System.Windows.Forms.Button btn_Limpiar;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.MaskedTextBox mtb_Movil;
        private System.Windows.Forms.Label lbl_Movil;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.Label lbl_Nombre;
        private System.Windows.Forms.Label lbl_CIF;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}