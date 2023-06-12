
namespace GestionAlmacen.Vistas.Entradas
{
    partial class FrmListaEntradas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListaEntradas));
            this.dgv_Lista = new System.Windows.Forms.DataGridView();
            this.grb_Registro = new System.Windows.Forms.GroupBox();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.dtp_FechaFin = new System.Windows.Forms.DateTimePicker();
            this.lbl_FechaFin = new System.Windows.Forms.Label();
            this.dtp_FechaInicio = new System.Windows.Forms.DateTimePicker();
            this.lbl_FechaRegistro = new System.Windows.Forms.Label();
            this.btn_Refrescar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Descargar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Lista)).BeginInit();
            this.grb_Registro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Lista
            // 
            this.dgv_Lista.AllowUserToAddRows = false;
            this.dgv_Lista.AllowUserToDeleteRows = false;
            this.dgv_Lista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Lista.Location = new System.Drawing.Point(12, 105);
            this.dgv_Lista.Name = "dgv_Lista";
            this.dgv_Lista.ReadOnly = true;
            this.dgv_Lista.Size = new System.Drawing.Size(776, 333);
            this.dgv_Lista.TabIndex = 5;
            // 
            // grb_Registro
            // 
            this.grb_Registro.Controls.Add(this.btn_Buscar);
            this.grb_Registro.Controls.Add(this.dtp_FechaFin);
            this.grb_Registro.Controls.Add(this.lbl_FechaFin);
            this.grb_Registro.Controls.Add(this.dtp_FechaInicio);
            this.grb_Registro.Controls.Add(this.lbl_FechaRegistro);
            this.grb_Registro.Location = new System.Drawing.Point(12, 12);
            this.grb_Registro.Name = "grb_Registro";
            this.grb_Registro.Size = new System.Drawing.Size(775, 38);
            this.grb_Registro.TabIndex = 4;
            this.grb_Registro.TabStop = false;
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Location = new System.Drawing.Point(606, 10);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(75, 23);
            this.btn_Buscar.TabIndex = 3;
            this.btn_Buscar.Text = "Buscar";
            this.btn_Buscar.UseVisualStyleBackColor = true;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // dtp_FechaFin
            // 
            this.dtp_FechaFin.Location = new System.Drawing.Point(364, 10);
            this.dtp_FechaFin.Name = "dtp_FechaFin";
            this.dtp_FechaFin.Size = new System.Drawing.Size(200, 20);
            this.dtp_FechaFin.TabIndex = 2;
            this.dtp_FechaFin.Value = new System.DateTime(2023, 6, 5, 0, 0, 0, 0);
            // 
            // lbl_FechaFin
            // 
            this.lbl_FechaFin.AutoSize = true;
            this.lbl_FechaFin.Location = new System.Drawing.Point(307, 16);
            this.lbl_FechaFin.Name = "lbl_FechaFin";
            this.lbl_FechaFin.Size = new System.Drawing.Size(51, 13);
            this.lbl_FechaFin.TabIndex = 5;
            this.lbl_FechaFin.Text = "Fecha fin";
            // 
            // dtp_FechaInicio
            // 
            this.dtp_FechaInicio.CustomFormat = "dd/mm/yyyy";
            this.dtp_FechaInicio.Location = new System.Drawing.Point(76, 10);
            this.dtp_FechaInicio.MaxDate = new System.DateTime(4999, 1, 1, 0, 0, 0, 0);
            this.dtp_FechaInicio.Name = "dtp_FechaInicio";
            this.dtp_FechaInicio.Size = new System.Drawing.Size(200, 20);
            this.dtp_FechaInicio.TabIndex = 1;
            this.dtp_FechaInicio.Value = new System.DateTime(2023, 6, 5, 0, 0, 0, 0);
            // 
            // lbl_FechaRegistro
            // 
            this.lbl_FechaRegistro.AutoSize = true;
            this.lbl_FechaRegistro.Location = new System.Drawing.Point(6, 16);
            this.lbl_FechaRegistro.Name = "lbl_FechaRegistro";
            this.lbl_FechaRegistro.Size = new System.Drawing.Size(64, 13);
            this.lbl_FechaRegistro.TabIndex = 3;
            this.lbl_FechaRegistro.Text = "Fecha inicio";
            // 
            // btn_Refrescar
            // 
            this.btn_Refrescar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Refrescar.BackgroundImage")));
            this.btn_Refrescar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Refrescar.Location = new System.Drawing.Point(12, 76);
            this.btn_Refrescar.Name = "btn_Refrescar";
            this.btn_Refrescar.Size = new System.Drawing.Size(25, 23);
            this.btn_Refrescar.TabIndex = 4;
            this.btn_Refrescar.UseVisualStyleBackColor = true;
            this.btn_Refrescar.Click += new System.EventHandler(this.btn_Refrescar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(692, 76);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 23);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // btn_Descargar
            // 
            this.btn_Descargar.Location = new System.Drawing.Point(718, 76);
            this.btn_Descargar.Name = "btn_Descargar";
            this.btn_Descargar.Size = new System.Drawing.Size(69, 23);
            this.btn_Descargar.TabIndex = 8;
            this.btn_Descargar.Text = "Descargar";
            this.btn_Descargar.UseVisualStyleBackColor = true;
            this.btn_Descargar.Click += new System.EventHandler(this.btn_Descargar_Click);
            // 
            // FrmListaEntradas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_Descargar);
            this.Controls.Add(this.btn_Refrescar);
            this.Controls.Add(this.dgv_Lista);
            this.Controls.Add(this.grb_Registro);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmListaEntradas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista Entradas";
            this.Load += new System.EventHandler(this.FrmListaEntradas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Lista)).EndInit();
            this.grb_Registro.ResumeLayout(false);
            this.grb_Registro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_Lista;
        private System.Windows.Forms.GroupBox grb_Registro;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.DateTimePicker dtp_FechaFin;
        private System.Windows.Forms.Label lbl_FechaFin;
        private System.Windows.Forms.DateTimePicker dtp_FechaInicio;
        private System.Windows.Forms.Label lbl_FechaRegistro;
        private System.Windows.Forms.Button btn_Refrescar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_Descargar;
    }
}