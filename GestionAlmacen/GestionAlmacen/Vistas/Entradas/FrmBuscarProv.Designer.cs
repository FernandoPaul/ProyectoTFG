
namespace GestionAlmacen.Vistas.Entradas
{
    partial class FrmBuscarProv
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBuscarProv));
            this.lbl_Buscar = new System.Windows.Forms.Label();
            this.cmb_Buscar = new System.Windows.Forms.ComboBox();
            this.txt_Buscar = new System.Windows.Forms.TextBox();
            this.dgv_ListaProveedores = new System.Windows.Forms.DataGridView();
            this.btn_Aceptar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListaProveedores)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Buscar
            // 
            this.lbl_Buscar.AutoSize = true;
            this.lbl_Buscar.Location = new System.Drawing.Point(12, 14);
            this.lbl_Buscar.Name = "lbl_Buscar";
            this.lbl_Buscar.Size = new System.Drawing.Size(40, 13);
            this.lbl_Buscar.TabIndex = 19;
            this.lbl_Buscar.Text = "Buscar";
            // 
            // cmb_Buscar
            // 
            this.cmb_Buscar.FormattingEnabled = true;
            this.cmb_Buscar.Location = new System.Drawing.Point(58, 11);
            this.cmb_Buscar.Name = "cmb_Buscar";
            this.cmb_Buscar.Size = new System.Drawing.Size(121, 21);
            this.cmb_Buscar.TabIndex = 17;
            // 
            // txt_Buscar
            // 
            this.txt_Buscar.Location = new System.Drawing.Point(185, 12);
            this.txt_Buscar.Name = "txt_Buscar";
            this.txt_Buscar.Size = new System.Drawing.Size(225, 20);
            this.txt_Buscar.TabIndex = 18;
            this.txt_Buscar.TextChanged += new System.EventHandler(this.txt_Buscar_TextChanged);
            // 
            // dgv_ListaProveedores
            // 
            this.dgv_ListaProveedores.AllowUserToAddRows = false;
            this.dgv_ListaProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ListaProveedores.Location = new System.Drawing.Point(15, 39);
            this.dgv_ListaProveedores.Name = "dgv_ListaProveedores";
            this.dgv_ListaProveedores.Size = new System.Drawing.Size(395, 204);
            this.dgv_ListaProveedores.TabIndex = 20;
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.Location = new System.Drawing.Point(175, 249);
            this.btn_Aceptar.Name = "btn_Aceptar";
            this.btn_Aceptar.Size = new System.Drawing.Size(75, 23);
            this.btn_Aceptar.TabIndex = 21;
            this.btn_Aceptar.Text = "Aceptar";
            this.btn_Aceptar.UseVisualStyleBackColor = true;
            this.btn_Aceptar.Click += new System.EventHandler(this.btn_Aceptar_Click);
            // 
            // FrmBuscarProv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 279);
            this.Controls.Add(this.btn_Aceptar);
            this.Controls.Add(this.dgv_ListaProveedores);
            this.Controls.Add(this.lbl_Buscar);
            this.Controls.Add(this.cmb_Buscar);
            this.Controls.Add(this.txt_Buscar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmBuscarProv";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Proveedor";
            this.Load += new System.EventHandler(this.FrmBuscarProv_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListaProveedores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lbl_Buscar;
        public System.Windows.Forms.ComboBox cmb_Buscar;
        public System.Windows.Forms.TextBox txt_Buscar;
        private System.Windows.Forms.DataGridView dgv_ListaProveedores;
        private System.Windows.Forms.Button btn_Aceptar;
    }
}