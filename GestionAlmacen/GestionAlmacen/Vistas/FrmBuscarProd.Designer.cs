
namespace GestionAlmacen.Vistas
{
    partial class FrmBuscarProd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBuscarProd));
            this.btn_Aceptar = new System.Windows.Forms.Button();
            this.dgv_ListaProductos = new System.Windows.Forms.DataGridView();
            this.lbl_Buscar = new System.Windows.Forms.Label();
            this.cmb_Buscar = new System.Windows.Forms.ComboBox();
            this.txt_Buscar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListaProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.Location = new System.Drawing.Point(175, 247);
            this.btn_Aceptar.Name = "btn_Aceptar";
            this.btn_Aceptar.Size = new System.Drawing.Size(75, 23);
            this.btn_Aceptar.TabIndex = 26;
            this.btn_Aceptar.Text = "Aceptar";
            this.btn_Aceptar.UseVisualStyleBackColor = true;
            this.btn_Aceptar.Click += new System.EventHandler(this.btn_Aceptar_Click);
            // 
            // dgv_ListaProductos
            // 
            this.dgv_ListaProductos.AllowUserToAddRows = false;
            this.dgv_ListaProductos.AllowUserToDeleteRows = false;
            this.dgv_ListaProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ListaProductos.Location = new System.Drawing.Point(15, 37);
            this.dgv_ListaProductos.Name = "dgv_ListaProductos";
            this.dgv_ListaProductos.Size = new System.Drawing.Size(395, 204);
            this.dgv_ListaProductos.TabIndex = 25;
            // 
            // lbl_Buscar
            // 
            this.lbl_Buscar.AutoSize = true;
            this.lbl_Buscar.Location = new System.Drawing.Point(12, 12);
            this.lbl_Buscar.Name = "lbl_Buscar";
            this.lbl_Buscar.Size = new System.Drawing.Size(40, 13);
            this.lbl_Buscar.TabIndex = 24;
            this.lbl_Buscar.Text = "Buscar";
            // 
            // cmb_Buscar
            // 
            this.cmb_Buscar.FormattingEnabled = true;
            this.cmb_Buscar.Location = new System.Drawing.Point(58, 9);
            this.cmb_Buscar.Name = "cmb_Buscar";
            this.cmb_Buscar.Size = new System.Drawing.Size(121, 21);
            this.cmb_Buscar.TabIndex = 22;
            // 
            // txt_Buscar
            // 
            this.txt_Buscar.Location = new System.Drawing.Point(185, 10);
            this.txt_Buscar.Name = "txt_Buscar";
            this.txt_Buscar.Size = new System.Drawing.Size(225, 20);
            this.txt_Buscar.TabIndex = 23;
            this.txt_Buscar.TextChanged += new System.EventHandler(this.txt_Buscar_TextChanged);
            // 
            // FrmBuscarProd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 279);
            this.Controls.Add(this.btn_Aceptar);
            this.Controls.Add(this.dgv_ListaProductos);
            this.Controls.Add(this.lbl_Buscar);
            this.Controls.Add(this.cmb_Buscar);
            this.Controls.Add(this.txt_Buscar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmBuscarProd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Producto";
            this.Load += new System.EventHandler(this.FrmBuscarProd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListaProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Aceptar;
        private System.Windows.Forms.DataGridView dgv_ListaProductos;
        public System.Windows.Forms.Label lbl_Buscar;
        public System.Windows.Forms.ComboBox cmb_Buscar;
        public System.Windows.Forms.TextBox txt_Buscar;
    }
}