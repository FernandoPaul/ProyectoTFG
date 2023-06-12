
namespace GestionAlmacen.Vistas
{
    partial class FrmNuevoUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNuevoUsuario));
            this.txt_RepetirClave = new System.Windows.Forms.TextBox();
            this.lbl_RepetirClave = new System.Windows.Forms.Label();
            this.txt_Clave = new System.Windows.Forms.TextBox();
            this.lbl_Clave = new System.Windows.Forms.Label();
            this.txt_Id = new System.Windows.Forms.TextBox();
            this.lbl_Id = new System.Windows.Forms.Label();
            this.txt_NombreCompleto = new System.Windows.Forms.TextBox();
            this.cb_Administrador = new System.Windows.Forms.CheckBox();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.lbl_NombreCompleto = new System.Windows.Forms.Label();
            this.lbl_Error = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_RepetirClave
            // 
            this.txt_RepetirClave.Location = new System.Drawing.Point(133, 116);
            this.txt_RepetirClave.Name = "txt_RepetirClave";
            this.txt_RepetirClave.PasswordChar = '*';
            this.txt_RepetirClave.Size = new System.Drawing.Size(157, 20);
            this.txt_RepetirClave.TabIndex = 4;
            // 
            // lbl_RepetirClave
            // 
            this.lbl_RepetirClave.AutoSize = true;
            this.lbl_RepetirClave.Location = new System.Drawing.Point(29, 119);
            this.lbl_RepetirClave.Name = "lbl_RepetirClave";
            this.lbl_RepetirClave.Size = new System.Drawing.Size(98, 13);
            this.lbl_RepetirClave.TabIndex = 31;
            this.lbl_RepetirClave.Text = "Repetir Contraseña";
            // 
            // txt_Clave
            // 
            this.txt_Clave.Location = new System.Drawing.Point(133, 90);
            this.txt_Clave.Name = "txt_Clave";
            this.txt_Clave.PasswordChar = '*';
            this.txt_Clave.Size = new System.Drawing.Size(157, 20);
            this.txt_Clave.TabIndex = 3;
            // 
            // lbl_Clave
            // 
            this.lbl_Clave.AutoSize = true;
            this.lbl_Clave.Location = new System.Drawing.Point(29, 93);
            this.lbl_Clave.Name = "lbl_Clave";
            this.lbl_Clave.Size = new System.Drawing.Size(61, 13);
            this.lbl_Clave.TabIndex = 29;
            this.lbl_Clave.Text = "Contraseña";
            // 
            // txt_Id
            // 
            this.txt_Id.Location = new System.Drawing.Point(133, 64);
            this.txt_Id.Name = "txt_Id";
            this.txt_Id.Size = new System.Drawing.Size(157, 20);
            this.txt_Id.TabIndex = 2;
            // 
            // lbl_Id
            // 
            this.lbl_Id.AutoSize = true;
            this.lbl_Id.Location = new System.Drawing.Point(29, 67);
            this.lbl_Id.Name = "lbl_Id";
            this.lbl_Id.Size = new System.Drawing.Size(18, 13);
            this.lbl_Id.TabIndex = 27;
            this.lbl_Id.Text = "ID";
            // 
            // txt_NombreCompleto
            // 
            this.txt_NombreCompleto.Location = new System.Drawing.Point(133, 38);
            this.txt_NombreCompleto.Name = "txt_NombreCompleto";
            this.txt_NombreCompleto.Size = new System.Drawing.Size(157, 20);
            this.txt_NombreCompleto.TabIndex = 1;
            // 
            // cb_Administrador
            // 
            this.cb_Administrador.AutoSize = true;
            this.cb_Administrador.Location = new System.Drawing.Point(89, 157);
            this.cb_Administrador.Name = "cb_Administrador";
            this.cb_Administrador.Size = new System.Drawing.Size(151, 17);
            this.cb_Administrador.TabIndex = 5;
            this.cb_Administrador.Tag = "Y";
            this.cb_Administrador.Text = "El usuario es administrador";
            this.cb_Administrador.UseVisualStyleBackColor = true;
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancelar.Location = new System.Drawing.Point(183, 203);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancelar.TabIndex = 7;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Location = new System.Drawing.Point(70, 203);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(75, 23);
            this.btn_Guardar.TabIndex = 6;
            this.btn_Guardar.Text = "Guardar";
            this.btn_Guardar.UseVisualStyleBackColor = true;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // lbl_NombreCompleto
            // 
            this.lbl_NombreCompleto.AutoSize = true;
            this.lbl_NombreCompleto.Location = new System.Drawing.Point(29, 41);
            this.lbl_NombreCompleto.Name = "lbl_NombreCompleto";
            this.lbl_NombreCompleto.Size = new System.Drawing.Size(91, 13);
            this.lbl_NombreCompleto.TabIndex = 22;
            this.lbl_NombreCompleto.Text = "Nombre Completo";
            // 
            // lbl_Error
            // 
            this.lbl_Error.AutoSize = true;
            this.lbl_Error.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_Error.ForeColor = System.Drawing.Color.Red;
            this.lbl_Error.Location = new System.Drawing.Point(101, 177);
            this.lbl_Error.Name = "lbl_Error";
            this.lbl_Error.Size = new System.Drawing.Size(130, 13);
            this.lbl_Error.TabIndex = 33;
            this.lbl_Error.Text = "Contraseñas no coinciden";
            this.lbl_Error.Visible = false;
            // 
            // FrmNuevoUsuario
            // 
            this.AcceptButton = this.btn_Guardar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_Cancelar;
            this.ClientSize = new System.Drawing.Size(313, 238);
            this.ControlBox = false;
            this.Controls.Add(this.lbl_Error);
            this.Controls.Add(this.txt_RepetirClave);
            this.Controls.Add(this.lbl_RepetirClave);
            this.Controls.Add(this.txt_Clave);
            this.Controls.Add(this.lbl_Clave);
            this.Controls.Add(this.txt_Id);
            this.Controls.Add(this.lbl_Id);
            this.Controls.Add(this.txt_NombreCompleto);
            this.Controls.Add(this.cb_Administrador);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Guardar);
            this.Controls.Add(this.lbl_NombreCompleto);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmNuevoUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo Usuario";
            this.Load += new System.EventHandler(this.FrmNuevoUsuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_RepetirClave;
        private System.Windows.Forms.Label lbl_RepetirClave;
        private System.Windows.Forms.TextBox txt_Clave;
        private System.Windows.Forms.Label lbl_Clave;
        private System.Windows.Forms.TextBox txt_Id;
        private System.Windows.Forms.Label lbl_Id;
        private System.Windows.Forms.TextBox txt_NombreCompleto;
        private System.Windows.Forms.CheckBox cb_Administrador;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.Label lbl_NombreCompleto;
        private System.Windows.Forms.Label lbl_Error;
    }
}