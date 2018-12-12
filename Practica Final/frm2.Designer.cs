namespace Practica_Final
{
    partial class frm2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm2));
            this.lblAdmin = new System.Windows.Forms.Label();
            this.lblAlumno = new System.Windows.Forms.Label();
            this.lblMaestro = new System.Windows.Forms.Label();
            this.grbAdmin = new System.Windows.Forms.GroupBox();
            this.btnABCCAdmin = new System.Windows.Forms.Button();
            this.btnPMU = new System.Windows.Forms.Button();
            this.btnHistorial = new System.Windows.Forms.Button();
            this.btnCClaveAdmin = new System.Windows.Forms.Button();
            this.grbMaestro = new System.Windows.Forms.GroupBox();
            this.btnABCMMaestro = new System.Windows.Forms.Button();
            this.btnCClaveMaestro = new System.Windows.Forms.Button();
            this.grbAlumno = new System.Windows.Forms.GroupBox();
            this.btnKardex = new System.Windows.Forms.Button();
            this.btnCambiarClave = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnSalir = new System.Windows.Forms.Button();
            this.grbAdmin.SuspendLayout();
            this.grbMaestro.SuspendLayout();
            this.grbAlumno.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAdmin
            // 
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdmin.ForeColor = System.Drawing.Color.White;
            this.lblAdmin.Location = new System.Drawing.Point(123, 25);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(150, 19);
            this.lblAdmin.TabIndex = 0;
            this.lblAdmin.Text = "ADMINISTRADOR";
            // 
            // lblAlumno
            // 
            this.lblAlumno.AutoSize = true;
            this.lblAlumno.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlumno.ForeColor = System.Drawing.Color.White;
            this.lblAlumno.Location = new System.Drawing.Point(310, 25);
            this.lblAlumno.Name = "lblAlumno";
            this.lblAlumno.Size = new System.Drawing.Size(81, 19);
            this.lblAlumno.TabIndex = 1;
            this.lblAlumno.Text = "ALUMNO";
            // 
            // lblMaestro
            // 
            this.lblMaestro.AutoSize = true;
            this.lblMaestro.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaestro.ForeColor = System.Drawing.Color.White;
            this.lblMaestro.Location = new System.Drawing.Point(446, 25);
            this.lblMaestro.Name = "lblMaestro";
            this.lblMaestro.Size = new System.Drawing.Size(89, 19);
            this.lblMaestro.TabIndex = 2;
            this.lblMaestro.Text = "MAESTRO";
            // 
            // grbAdmin
            // 
            this.grbAdmin.Controls.Add(this.btnABCCAdmin);
            this.grbAdmin.Controls.Add(this.btnPMU);
            this.grbAdmin.Controls.Add(this.btnHistorial);
            this.grbAdmin.Controls.Add(this.btnCClaveAdmin);
            this.grbAdmin.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbAdmin.ForeColor = System.Drawing.Color.White;
            this.grbAdmin.Location = new System.Drawing.Point(61, 274);
            this.grbAdmin.Name = "grbAdmin";
            this.grbAdmin.Size = new System.Drawing.Size(511, 137);
            this.grbAdmin.TabIndex = 3;
            this.grbAdmin.TabStop = false;
            this.grbAdmin.Text = "Pantallas Administrador";
            // 
            // btnABCCAdmin
            // 
            this.btnABCCAdmin.BackColor = System.Drawing.Color.ForestGreen;
            this.btnABCCAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnABCCAdmin.Location = new System.Drawing.Point(356, 31);
            this.btnABCCAdmin.Name = "btnABCCAdmin";
            this.btnABCCAdmin.Size = new System.Drawing.Size(114, 82);
            this.btnABCCAdmin.TabIndex = 5;
            this.btnABCCAdmin.Text = "Altas, Bajas, Cambios, Consultas";
            this.btnABCCAdmin.UseVisualStyleBackColor = false;
            this.btnABCCAdmin.Click += new System.EventHandler(this.btnABCCAdmin_Click);
            // 
            // btnPMU
            // 
            this.btnPMU.BackColor = System.Drawing.Color.ForestGreen;
            this.btnPMU.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPMU.Location = new System.Drawing.Point(217, 31);
            this.btnPMU.Name = "btnPMU";
            this.btnPMU.Size = new System.Drawing.Size(116, 82);
            this.btnPMU.TabIndex = 4;
            this.btnPMU.Text = "Pantalla Maestra Usuarios";
            this.btnPMU.UseVisualStyleBackColor = false;
            this.btnPMU.Click += new System.EventHandler(this.btnPMU_Click);
            // 
            // btnHistorial
            // 
            this.btnHistorial.BackColor = System.Drawing.Color.ForestGreen;
            this.btnHistorial.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHistorial.Location = new System.Drawing.Point(117, 31);
            this.btnHistorial.Name = "btnHistorial";
            this.btnHistorial.Size = new System.Drawing.Size(78, 82);
            this.btnHistorial.TabIndex = 3;
            this.btnHistorial.Text = "Historial";
            this.btnHistorial.UseVisualStyleBackColor = false;
            this.btnHistorial.Click += new System.EventHandler(this.btnHistorial_Click);
            // 
            // btnCClaveAdmin
            // 
            this.btnCClaveAdmin.BackColor = System.Drawing.Color.ForestGreen;
            this.btnCClaveAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCClaveAdmin.Location = new System.Drawing.Point(22, 31);
            this.btnCClaveAdmin.Name = "btnCClaveAdmin";
            this.btnCClaveAdmin.Size = new System.Drawing.Size(78, 82);
            this.btnCClaveAdmin.TabIndex = 2;
            this.btnCClaveAdmin.Text = "Cambio de clave";
            this.btnCClaveAdmin.UseVisualStyleBackColor = false;
            this.btnCClaveAdmin.Click += new System.EventHandler(this.btnCClaveAdmin_Click);
            // 
            // grbMaestro
            // 
            this.grbMaestro.Controls.Add(this.btnABCMMaestro);
            this.grbMaestro.Controls.Add(this.btnCClaveMaestro);
            this.grbMaestro.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbMaestro.ForeColor = System.Drawing.Color.White;
            this.grbMaestro.Location = new System.Drawing.Point(24, 79);
            this.grbMaestro.Name = "grbMaestro";
            this.grbMaestro.Size = new System.Drawing.Size(286, 168);
            this.grbMaestro.TabIndex = 4;
            this.grbMaestro.TabStop = false;
            this.grbMaestro.Text = "Pantallas Maestro";
            // 
            // btnABCMMaestro
            // 
            this.btnABCMMaestro.BackColor = System.Drawing.Color.Red;
            this.btnABCMMaestro.FlatAppearance.BorderSize = 0;
            this.btnABCMMaestro.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnABCMMaestro.Location = new System.Drawing.Point(23, 40);
            this.btnABCMMaestro.Name = "btnABCMMaestro";
            this.btnABCMMaestro.Size = new System.Drawing.Size(114, 82);
            this.btnABCMMaestro.TabIndex = 2;
            this.btnABCMMaestro.Text = "Altas, Bajas, Cambios, Consultas";
            this.btnABCMMaestro.UseVisualStyleBackColor = false;
            this.btnABCMMaestro.Click += new System.EventHandler(this.btnABCMMaestro_Click);
            // 
            // btnCClaveMaestro
            // 
            this.btnCClaveMaestro.BackColor = System.Drawing.Color.Red;
            this.btnCClaveMaestro.FlatAppearance.BorderSize = 0;
            this.btnCClaveMaestro.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCClaveMaestro.Location = new System.Drawing.Point(177, 40);
            this.btnCClaveMaestro.Name = "btnCClaveMaestro";
            this.btnCClaveMaestro.Size = new System.Drawing.Size(78, 82);
            this.btnCClaveMaestro.TabIndex = 1;
            this.btnCClaveMaestro.Text = "Cambio de clave";
            this.btnCClaveMaestro.UseVisualStyleBackColor = false;
            this.btnCClaveMaestro.Click += new System.EventHandler(this.btnCClaveMaestro_Click);
            // 
            // grbAlumno
            // 
            this.grbAlumno.Controls.Add(this.btnKardex);
            this.grbAlumno.Controls.Add(this.btnCambiarClave);
            this.grbAlumno.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbAlumno.ForeColor = System.Drawing.Color.White;
            this.grbAlumno.Location = new System.Drawing.Point(332, 79);
            this.grbAlumno.Name = "grbAlumno";
            this.grbAlumno.Size = new System.Drawing.Size(276, 168);
            this.grbAlumno.TabIndex = 4;
            this.grbAlumno.TabStop = false;
            this.grbAlumno.Text = "Pantallas Alumno";
            // 
            // btnKardex
            // 
            this.btnKardex.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnKardex.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnKardex.Location = new System.Drawing.Point(162, 40);
            this.btnKardex.Name = "btnKardex";
            this.btnKardex.Size = new System.Drawing.Size(78, 82);
            this.btnKardex.TabIndex = 1;
            this.btnKardex.Text = "Kardex";
            this.btnKardex.UseVisualStyleBackColor = false;
            this.btnKardex.Click += new System.EventHandler(this.btnKardex_Click);
            // 
            // btnCambiarClave
            // 
            this.btnCambiarClave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnCambiarClave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCambiarClave.Location = new System.Drawing.Point(48, 40);
            this.btnCambiarClave.Name = "btnCambiarClave";
            this.btnCambiarClave.Size = new System.Drawing.Size(78, 82);
            this.btnCambiarClave.TabIndex = 0;
            this.btnCambiarClave.Text = "Cambio de clave";
            this.btnCambiarClave.UseVisualStyleBackColor = false;
            this.btnCambiarClave.Click += new System.EventHandler(this.btnCambiarClave_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btnSalir
            // 
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalir.Location = new System.Drawing.Point(632, 393);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(102, 38);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(746, 443);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.grbAlumno);
            this.Controls.Add(this.grbMaestro);
            this.Controls.Add(this.grbAdmin);
            this.Controls.Add(this.lblMaestro);
            this.Controls.Add(this.lblAlumno);
            this.Controls.Add(this.lblAdmin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú Principal";
            this.Load += new System.EventHandler(this.frm2_Load);
            this.grbAdmin.ResumeLayout(false);
            this.grbMaestro.ResumeLayout(false);
            this.grbAlumno.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnABCCAdmin;
        private System.Windows.Forms.Button btnPMU;
        private System.Windows.Forms.Button btnHistorial;
        private System.Windows.Forms.Button btnCClaveAdmin;
        private System.Windows.Forms.Button btnABCMMaestro;
        private System.Windows.Forms.Button btnCClaveMaestro;
        private System.Windows.Forms.Button btnKardex;
        private System.Windows.Forms.Button btnCambiarClave;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        public System.Windows.Forms.Label lblAdmin;
        public System.Windows.Forms.Label lblAlumno;
        public System.Windows.Forms.Label lblMaestro;
        public System.Windows.Forms.GroupBox grbAdmin;
        public System.Windows.Forms.GroupBox grbAlumno;
        internal System.Windows.Forms.GroupBox grbMaestro;
        private System.Windows.Forms.Button btnSalir;
    }
}