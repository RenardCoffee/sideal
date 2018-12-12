namespace Practica_Final
{
    partial class frm5Historial
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
            this.rtbCClave = new System.Windows.Forms.RadioButton();
            this.rtbAccesos = new System.Windows.Forms.RadioButton();
            this.dtgCClave = new System.Windows.Forms.DataGridView();
            this.dtgAccesos = new System.Windows.Forms.DataGridView();
            this.txtID_seq = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtID_usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtFecha_acceso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtID_seq2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtID_usuario2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtClave_ant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAtras = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCClave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAccesos)).BeginInit();
            this.SuspendLayout();
            // 
            // rtbCClave
            // 
            this.rtbCClave.AutoSize = true;
            this.rtbCClave.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbCClave.ForeColor = System.Drawing.Color.White;
            this.rtbCClave.Location = new System.Drawing.Point(59, 29);
            this.rtbCClave.Name = "rtbCClave";
            this.rtbCClave.Size = new System.Drawing.Size(111, 19);
            this.rtbCClave.TabIndex = 0;
            this.rtbCClave.TabStop = true;
            this.rtbCClave.Text = "Cambio de clave";
            this.rtbCClave.UseVisualStyleBackColor = true;
            this.rtbCClave.CheckedChanged += new System.EventHandler(this.rtbCClave_CheckedChanged);
            // 
            // rtbAccesos
            // 
            this.rtbAccesos.AutoSize = true;
            this.rtbAccesos.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbAccesos.ForeColor = System.Drawing.Color.White;
            this.rtbAccesos.Location = new System.Drawing.Point(59, 62);
            this.rtbAccesos.Name = "rtbAccesos";
            this.rtbAccesos.Size = new System.Drawing.Size(70, 19);
            this.rtbAccesos.TabIndex = 1;
            this.rtbAccesos.TabStop = true;
            this.rtbAccesos.Text = "Accesos";
            this.rtbAccesos.UseVisualStyleBackColor = true;
            // 
            // dtgCClave
            // 
            this.dtgCClave.AllowUserToAddRows = false;
            this.dtgCClave.AllowUserToDeleteRows = false;
            this.dtgCClave.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCClave.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtID_seq2,
            this.txtID_usuario2,
            this.txtClave_ant,
            this.txtFecha});
            this.dtgCClave.Location = new System.Drawing.Point(59, 113);
            this.dtgCClave.Name = "dtgCClave";
            this.dtgCClave.ReadOnly = true;
            this.dtgCClave.Size = new System.Drawing.Size(599, 221);
            this.dtgCClave.TabIndex = 2;
            // 
            // dtgAccesos
            // 
            this.dtgAccesos.AllowUserToAddRows = false;
            this.dtgAccesos.AllowUserToDeleteRows = false;
            this.dtgAccesos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgAccesos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtID_seq,
            this.txtID_usuario,
            this.txtFecha_acceso});
            this.dtgAccesos.Location = new System.Drawing.Point(59, 113);
            this.dtgAccesos.Name = "dtgAccesos";
            this.dtgAccesos.ReadOnly = true;
            this.dtgAccesos.Size = new System.Drawing.Size(599, 221);
            this.dtgAccesos.TabIndex = 3;
            // 
            // txtID_seq
            // 
            this.txtID_seq.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txtID_seq.DataPropertyName = "ID_seq";
            this.txtID_seq.HeaderText = "ID";
            this.txtID_seq.Name = "txtID_seq";
            this.txtID_seq.ReadOnly = true;
            // 
            // txtID_usuario
            // 
            this.txtID_usuario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txtID_usuario.DataPropertyName = "ID_usuario";
            this.txtID_usuario.HeaderText = "Usuario";
            this.txtID_usuario.Name = "txtID_usuario";
            this.txtID_usuario.ReadOnly = true;
            // 
            // txtFecha_acceso
            // 
            this.txtFecha_acceso.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txtFecha_acceso.DataPropertyName = "Fecha_acceso";
            this.txtFecha_acceso.HeaderText = "Fecha_acceso";
            this.txtFecha_acceso.Name = "txtFecha_acceso";
            this.txtFecha_acceso.ReadOnly = true;
            // 
            // txtID_seq2
            // 
            this.txtID_seq2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txtID_seq2.DataPropertyName = "ID_seq";
            this.txtID_seq2.HeaderText = "ID";
            this.txtID_seq2.Name = "txtID_seq2";
            this.txtID_seq2.ReadOnly = true;
            // 
            // txtID_usuario2
            // 
            this.txtID_usuario2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txtID_usuario2.DataPropertyName = "ID_usuario";
            this.txtID_usuario2.HeaderText = "Usuario";
            this.txtID_usuario2.Name = "txtID_usuario2";
            this.txtID_usuario2.ReadOnly = true;
            // 
            // txtClave_ant
            // 
            this.txtClave_ant.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txtClave_ant.DataPropertyName = "Clave_ant";
            this.txtClave_ant.HeaderText = "Clave_Anterior";
            this.txtClave_ant.Name = "txtClave_ant";
            this.txtClave_ant.ReadOnly = true;
            // 
            // txtFecha
            // 
            this.txtFecha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txtFecha.DataPropertyName = "Fecha";
            this.txtFecha.HeaderText = "Fecha_Cambio";
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.ReadOnly = true;
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(614, 361);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(85, 31);
            this.btnAtras.TabIndex = 4;
            this.btnAtras.Text = "Atras";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // frm5Historial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(711, 404);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.dtgAccesos);
            this.Controls.Add(this.dtgCClave);
            this.Controls.Add(this.rtbAccesos);
            this.Controls.Add(this.rtbCClave);
            this.Name = "frm5Historial";
            this.Text = "Historial";
            this.Load += new System.EventHandler(this.frm5Historial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgCClave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAccesos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rtbCClave;
        private System.Windows.Forms.RadioButton rtbAccesos;
        private System.Windows.Forms.DataGridView dtgCClave;
        private System.Windows.Forms.DataGridView dtgAccesos;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtID_seq;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtID_usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtFecha_acceso;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtID_seq2;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtID_usuario2;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtClave_ant;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtFecha;
        private System.Windows.Forms.Button btnAtras;
    }
}