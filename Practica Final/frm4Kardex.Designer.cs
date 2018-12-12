namespace Practica_Final
{
    partial class frm4Kardex
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.practicaFinalDataSet = new Practica_Final.PracticaFinalDataSet();
            this.practicaFinalDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tCALIFICACIONESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.t_CALIFICACIONESTableAdapter = new Practica_Final.PracticaFinalDataSetTableAdapters.T_CALIFICACIONESTableAdapter();
            this.ID_alumno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDmaestroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calificacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.practicaFinalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.practicaFinalDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tCALIFICACIONESBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(175, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "CALIFICACIONES DEL SEMESTRE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(44, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "ALUMNO:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(44, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "# CONTROL:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_alumno,
            this.iDmaestroDataGridViewTextBoxColumn,
            this.calificacionDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tCALIFICACIONESBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(48, 143);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(537, 178);
            this.dataGridView1.TabIndex = 3;
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
            // tCALIFICACIONESBindingSource
            // 
            this.tCALIFICACIONESBindingSource.DataMember = "T_CALIFICACIONES";
            this.tCALIFICACIONESBindingSource.DataSource = this.practicaFinalDataSetBindingSource;
            // 
            // t_CALIFICACIONESTableAdapter
            // 
            this.t_CALIFICACIONESTableAdapter.ClearBeforeFill = true;
            // 
            // ID_alumno
            // 
            this.ID_alumno.DataPropertyName = "ID_alumno";
            this.ID_alumno.HeaderText = "ID_alumno";
            this.ID_alumno.Name = "ID_alumno";
            this.ID_alumno.ReadOnly = true;
            // 
            // iDmaestroDataGridViewTextBoxColumn
            // 
            this.iDmaestroDataGridViewTextBoxColumn.DataPropertyName = "ID_maestro";
            this.iDmaestroDataGridViewTextBoxColumn.HeaderText = "ID_maestro";
            this.iDmaestroDataGridViewTextBoxColumn.Name = "iDmaestroDataGridViewTextBoxColumn";
            this.iDmaestroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // calificacionDataGridViewTextBoxColumn
            // 
            this.calificacionDataGridViewTextBoxColumn.DataPropertyName = "Calificacion";
            this.calificacionDataGridViewTextBoxColumn.HeaderText = "Calificacion";
            this.calificacionDataGridViewTextBoxColumn.Name = "calificacionDataGridViewTextBoxColumn";
            this.calificacionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(137, 75);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(448, 20);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(155, 106);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(115, 20);
            this.textBox2.TabIndex = 5;
            // 
            // frm4Kardex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(620, 356);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm4Kardex";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kardex";
            this.Load += new System.EventHandler(this.frm4Kardex_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.practicaFinalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.practicaFinalDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tCALIFICACIONESBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource practicaFinalDataSetBindingSource;
        private PracticaFinalDataSet practicaFinalDataSet;
        private System.Windows.Forms.BindingSource tCALIFICACIONESBindingSource;
        private PracticaFinalDataSetTableAdapters.T_CALIFICACIONESTableAdapter t_CALIFICACIONESTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_alumno;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDmaestroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn calificacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}