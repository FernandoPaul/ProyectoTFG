
namespace GestionAlmacen.Controles
{
    partial class Filtro
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        public System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        public void InitializeComponent()
        {
            this.lbl_Buscar = new System.Windows.Forms.Label();
            this.cmb_Buscar = new System.Windows.Forms.ComboBox();
            this.txt_Buscar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_Buscar
            // 
            this.lbl_Buscar.AutoSize = true;
            this.lbl_Buscar.Location = new System.Drawing.Point(9, 6);
            this.lbl_Buscar.Name = "lbl_Buscar";
            this.lbl_Buscar.Size = new System.Drawing.Size(40, 13);
            this.lbl_Buscar.TabIndex = 16;
            this.lbl_Buscar.Text = "Buscar";
            // 
            // cmb_Buscar
            // 
            this.cmb_Buscar.FormattingEnabled = true;
            this.cmb_Buscar.Location = new System.Drawing.Point(55, 3);
            this.cmb_Buscar.Name = "cmb_Buscar";
            this.cmb_Buscar.Size = new System.Drawing.Size(121, 21);
            this.cmb_Buscar.TabIndex = 14;
            // 
            // txt_Buscar
            // 
            this.txt_Buscar.Location = new System.Drawing.Point(182, 4);
            this.txt_Buscar.Name = "txt_Buscar";
            this.txt_Buscar.Size = new System.Drawing.Size(225, 20);
            this.txt_Buscar.TabIndex = 15;
            // 
            // Filtro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl_Buscar);
            this.Controls.Add(this.cmb_Buscar);
            this.Controls.Add(this.txt_Buscar);
            this.Name = "Filtro";
            this.Size = new System.Drawing.Size(417, 28);
            this.Load += new System.EventHandler(this.Filtro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lbl_Buscar;
        public System.Windows.Forms.ComboBox cmb_Buscar;
        public System.Windows.Forms.TextBox txt_Buscar;
    }
}
