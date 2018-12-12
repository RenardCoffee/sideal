namespace Practica_Final
{
    partial class frm6PMU
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm6PMU));
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.txtID_usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtClave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtRol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtFehca_registro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtFecha_acceso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtB_activo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAtras = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtID_usuario,
            this.txtNombre,
            this.txtApellido,
            this.txtClave,
            this.txtSexo,
            this.txtRol,
            this.txtFehca_registro,
            this.txtFecha_acceso,
            this.txtB_activo});
            this.dgvUsuarios.Location = new System.Drawing.Point(12, 12);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.Size = new System.Drawing.Size(844, 337);
            this.dgvUsuarios.TabIndex = 0;
            this.dgvUsuarios.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuarios_CellValueChanged);
            this.dgvUsuarios.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dgvUsuarios_UserDeletingRow);
            // 
            // txtID_usuario
            // 
            this.txtID_usuario.DataPropertyName = "ID_usuario";
            this.txtID_usuario.HeaderText = "ID";
            this.txtID_usuario.Name = "txtID_usuario";
            this.txtID_usuario.Visible = false;
            // 
            // txtNombre
            // 
            this.txtNombre.DataPropertyName = "Nombre";
            this.txtNombre.HeaderText = "Nombre";
            this.txtNombre.Name = "txtNombre";
            // 
            // txtApellido
            // 
            this.txtApellido.DataPropertyName = "Apellido";
            this.txtApellido.HeaderText = "Apellido";
            this.txtApellido.Name = "txtApellido";
            // 
            // txtClave
            // 
            this.txtClave.DataPropertyName = "Clave";
            this.txtClave.HeaderText = "Clave";
            this.txtClave.Name = "txtClave";
            // 
            // txtSexo
            // 
            this.txtSexo.DataPropertyName = "Sexo";
            this.txtSexo.HeaderText = "Genero";
            this.txtSexo.Name = "txtSexo";
            // 
            // txtRol
            // 
            this.txtRol.DataPropertyName = "Rol";
            this.txtRol.HeaderText = "Rol";
            this.txtRol.Name = "txtRol";
            // 
            // txtFehca_registro
            // 
            this.txtFehca_registro.DataPropertyName = "Fehca_registro";
            this.txtFehca_registro.HeaderText = "Fehca_registro";
            this.txtFehca_registro.Name = "txtFehca_registro";
            // 
            // txtFecha_acceso
            // 
            this.txtFecha_acceso.DataPropertyName = "Fecha_acceso";
            this.txtFecha_acceso.HeaderText = "Fecha_acceso";
            this.txtFecha_acceso.Name = "txtFecha_acceso";
            // 
            // txtB_activo
            // 
            this.txtB_activo.DataPropertyName = "B_activo";
            this.txtB_activo.HeaderText = "B_activo";
            this.txtB_activo.Name = "txtB_activo";
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(772, 372);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(83, 27);
            this.btnAtras.TabIndex = 1;
            this.btnAtras.Text = "Atras";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // frm6PMU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(874, 411);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.dgvUsuarios);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm6PMU";
            this.Text = "Pantalla Maestra Usuarios";
            this.Load += new System.EventHandler(this.frm6PMU_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtID_usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtClave;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtSexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtRol;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtFehca_registro;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtFecha_acceso;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtB_activo;
        private System.Windows.Forms.Button btnAtras;
    }
}