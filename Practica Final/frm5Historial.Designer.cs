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
            this.components = new System.ComponentModel.Container();
            this.rtbCClave = new System.Windows.Forms.RadioButton();
            this.rtbAccesos = new System.Windows.Forms.RadioButton();
            this.dtgCClave = new System.Windows.Forms.DataGridView();
            this.dtgAccesos = new System.Windows.Forms.DataGridView();
            this.practicaFinalDataSet = new Practica_Final.PracticaFinalDataSet();
            this.practicaFinalDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tHclaveBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tH_claveTableAdapter = new Practica_Final.PracticaFinalDataSetTableAdapters.TH_claveTableAdapter();
            this.iDseqDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDusuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.claveantDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tHaccesoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tH_accesoTableAdapter = new Practica_Final.PracticaFinalDataSetTableAdapters.TH_accesoTableAdapter();
            this.iDseqDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDusuarioDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaaccesoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCClave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAccesos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.practicaFinalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.practicaFinalDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tHclaveBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tHaccesoBindingSource)).BeginInit();
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
            this.dtgCClave.AutoGenerateColumns = false;
            this.dtgCClave.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCClave.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDseqDataGridViewTextBoxColumn,
            this.iDusuarioDataGridViewTextBoxColumn,
            this.claveantDataGridViewTextBoxColumn,
            this.fechaDataGridViewTextBoxColumn});
            this.dtgCClave.DataSource = this.tHclaveBindingSource;
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
            this.dtgAccesos.AutoGenerateColumns = false;
            this.dtgAccesos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgAccesos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDseqDataGridViewTextBoxColumn1,
            this.iDusuarioDataGridViewTextBoxColumn1,
            this.fechaaccesoDataGridViewTextBoxColumn});
            this.dtgAccesos.DataSource = this.tHaccesoBindingSource;
            this.dtgAccesos.Location = new System.Drawing.Point(59, 113);
            this.dtgAccesos.Name = "dtgAccesos";
            this.dtgAccesos.ReadOnly = true;
            this.dtgAccesos.Size = new System.Drawing.Size(599, 221);
            this.dtgAccesos.TabIndex = 3;
            // 
            // practicaFinalDataSet
            // 
            this.practicaFinalDataSet.DataSetName = "PracticaFinalDataSet";
            this.practicaFinalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // practicaFinalDataSetBindingSource
            // 
            this.practicaFinalDataSetBindingSource.DataSource = this.practicaFinalDataSet;
            this.practicaFinalDataSetBindingSource.Position = 0;
            // 
            // tHclaveBindingSource
            // 
            this.tHclaveBindingSource.DataMember = "TH_clave";
            this.tHclaveBindingSource.DataSource = this.practicaFinalDataSetBindingSource;
            // 
            // tH_claveTableAdapter
            // 
            this.tH_claveTableAdapter.ClearBeforeFill = true;
            // 
            // iDseqDataGridViewTextBoxColumn
            // 
            this.iDseqDataGridViewTextBoxColumn.DataPropertyName = "ID_seq";
            this.iDseqDataGridViewTextBoxColumn.HeaderText = "ID_seq";
            this.iDseqDataGridViewTextBoxColumn.Name = "iDseqDataGridViewTextBoxColumn";
            this.iDseqDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDusuarioDataGridViewTextBoxColumn
            // 
            this.iDusuarioDataGridViewTextBoxColumn.DataPropertyName = "ID_usuario";
            this.iDusuarioDataGridViewTextBoxColumn.HeaderText = "ID_usuario";
            this.iDusuarioDataGridViewTextBoxColumn.Name = "iDusuarioDataGridViewTextBoxColumn";
            // 
            // claveantDataGridViewTextBoxColumn
            // 
            this.claveantDataGridViewTextBoxColumn.DataPropertyName = "Clave_ant";
            this.claveantDataGridViewTextBoxColumn.HeaderText = "Clave_ant";
            this.claveantDataGridViewTextBoxColumn.Name = "claveantDataGridViewTextBoxColumn";
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha";
            this.fechaDataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            // 
            // tHaccesoBindingSource
            // 
            this.tHaccesoBindingSource.DataMember = "TH_acceso";
            this.tHaccesoBindingSource.DataSource = this.practicaFinalDataSetBindingSource;
            // 
            // tH_accesoTableAdapter
            // 
            this.tH_accesoTableAdapter.ClearBeforeFill = true;
            // 
            // iDseqDataGridViewTextBoxColumn1
            // 
            this.iDseqDataGridViewTextBoxColumn1.DataPropertyName = "ID_seq";
            this.iDseqDataGridViewTextBoxColumn1.HeaderText = "ID_seq";
            this.iDseqDataGridViewTextBoxColumn1.Name = "iDseqDataGridViewTextBoxColumn1";
            this.iDseqDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // iDusuarioDataGridViewTextBoxColumn1
            // 
            this.iDusuarioDataGridViewTextBoxColumn1.DataPropertyName = "ID_usuario";
            this.iDusuarioDataGridViewTextBoxColumn1.HeaderText = "ID_usuario";
            this.iDusuarioDataGridViewTextBoxColumn1.Name = "iDusuarioDataGridViewTextBoxColumn1";
            this.iDusuarioDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // fechaaccesoDataGridViewTextBoxColumn
            // 
            this.fechaaccesoDataGridViewTextBoxColumn.DataPropertyName = "Fecha_acceso";
            this.fechaaccesoDataGridViewTextBoxColumn.HeaderText = "Fecha_acceso";
            this.fechaaccesoDataGridViewTextBoxColumn.Name = "fechaaccesoDataGridViewTextBoxColumn";
            this.fechaaccesoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // frm5Historial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(711, 404);
            this.Controls.Add(this.dtgAccesos);
            this.Controls.Add(this.dtgCClave);
            this.Controls.Add(this.rtbAccesos);
            this.Controls.Add(this.rtbCClave);
            this.Name = "frm5Historial";
            this.Text = "Historial";
            this.Load += new System.EventHandler(this.frm5Historial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgCClave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAccesos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.practicaFinalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.practicaFinalDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tHclaveBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tHaccesoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rtbCClave;
        private System.Windows.Forms.RadioButton rtbAccesos;
        private System.Windows.Forms.DataGridView dtgCClave;
        private System.Windows.Forms.DataGridView dtgAccesos;
        private System.Windows.Forms.BindingSource practicaFinalDataSetBindingSource;
        private PracticaFinalDataSet practicaFinalDataSet;
        private System.Windows.Forms.BindingSource tHclaveBindingSource;
        private PracticaFinalDataSetTableAdapters.TH_claveTableAdapter tH_claveTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDseqDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDusuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn claveantDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tHaccesoBindingSource;
        private PracticaFinalDataSetTableAdapters.TH_accesoTableAdapter tH_accesoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDseqDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDusuarioDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaaccesoDataGridViewTextBoxColumn;
    }
}