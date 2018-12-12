using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Practica_Final
{
    public partial class frm6PMU : Form
    {
        string conn = "server=DESKTOP-KS5ITG4\\SQLUWU ; database=PracticaFinal ; integrated security = true";
        public frm6PMU()
        {
            InitializeComponent();
        }

        void PolulateDataGrid()
        {
            using (SqlConnection sqlCon = new SqlConnection(conn))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM T_usuarios ", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                dgvUsuarios.DataSource = dtbl;
            }
        }

        private void frm6PMU_Load(object sender, EventArgs e)
        {
            PolulateDataGrid();
        }

        private void dgvUsuarios_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvUsuarios.CurrentRow != null)
            {
                using (SqlConnection sqlCon = new SqlConnection(conn))
                {
                    sqlCon.Open();
                    DataGridViewRow dgvRow = dgvUsuarios.CurrentRow;
                    SqlCommand sqlCmd = new SqlCommand("UsuariosAddoEdit", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    if (dgvRow.Cells["txtID_usuario"].Value == DBNull.Value) //insertar
                        sqlCmd.Parameters.AddWithValue("@ID_usuario", 0);
                    else//actualiza
                        sqlCmd.Parameters.AddWithValue("@ID_usuario", Convert.ToInt32(dgvRow.Cells["txtID_usuario"].Value));
                    sqlCmd.Parameters.AddWithValue("@Nombre", dgvRow.Cells["txtNombre"].Value == DBNull.Value ? "" : dgvRow.Cells["txtNombre"].Value.ToString());
                    sqlCmd.Parameters.AddWithValue("@Apellido", dgvRow.Cells["txtApellido"].Value == DBNull.Value ? "" : dgvRow.Cells["txtApellido"].Value.ToString());
                    sqlCmd.Parameters.AddWithValue("@Clave ", dgvRow.Cells["txtClave"].Value == DBNull.Value ? "0" : dgvRow.Cells["txtClave"].Value.ToString());
                    sqlCmd.Parameters.AddWithValue("@Sexo", dgvRow.Cells["txtSexo"].Value == DBNull.Value ? "" : dgvRow.Cells["txtSexo"].Value.ToString());
                    sqlCmd.Parameters.AddWithValue("@Rol", dgvRow.Cells["txtRol"].Value == DBNull.Value ? "" : dgvRow.Cells["txtRol"].Value.ToString());
                    sqlCmd.Parameters.AddWithValue("@Fehca_registro", dgvRow.Cells["txtFehca_registro"].Value == DBNull.Value ? "" : dgvRow.Cells["txtFehca_registro"].Value.ToString());
                    sqlCmd.Parameters.AddWithValue("@Fecha_acceso", dgvRow.Cells["txtFecha_acceso"].Value == DBNull.Value ? "" : dgvRow.Cells["txtFecha_acceso"].Value.ToString());
                    sqlCmd.Parameters.AddWithValue("@B_activo", dgvRow.Cells["txtB_activo"].Value == DBNull.Value ? "" : dgvRow.Cells["txtB_activo"].Value.ToString());
                    sqlCmd.ExecuteNonQuery();
                    PolulateDataGrid();
                }

            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void dgvUsuarios_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {   
            if (dgvUsuarios.CurrentRow.Cells["txtID_usuario"].Value != DBNull.Value)
            {
                if (MessageBox.Show("Seguro de borrar al usuario ?", "Usuarios", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (SqlConnection sqlCon = new SqlConnection(conn))
                    {
                        sqlCon.Open();
                        DataGridViewRow dgvRow = dgvUsuarios.CurrentRow;
                        SqlCommand sqlCmd = new SqlCommand(" UsuarioDeleteID", sqlCon);
                        sqlCmd.CommandType = CommandType.StoredProcedure;
                        sqlCmd.Parameters.AddWithValue("@ID_usuario", Convert.ToInt32(dgvUsuarios.CurrentRow.Cells["txtID_usuario"].Value));
                    }

                }
                else
                    e.Cancel = true;
            }
            else
                e.Cancel = true;
        }
    }
}
