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
    public partial class frm5Historial : Form
    {
        string conn = "server=DESKTOP-KS5ITG4\\SQLUWU ; database=PracticaFinal ; integrated security = true";
        public frm5Historial()
        {
            InitializeComponent();
        }

        void PolulateDataGridAcc()
        {
            using (SqlConnection sqlCon = new SqlConnection(conn))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM TH_acceso ", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                dtgAccesos.DataSource = dtbl;
            }
        }

        void PolulateDataGridCla()
        {
            using (SqlConnection sqlCon = new SqlConnection(conn))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM TH_clave ", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                dtgCClave.DataSource = dtbl;
            }
        }

        private void rtbCClave_CheckedChanged(object sender, EventArgs e)
        {
             if(rtbAccesos.Checked == true)
             {
                 dtgAccesos.Visible = true;
                 dtgCClave.Visible = false;
             }
             else if (rtbCClave.Checked == true)
             {
                 dtgAccesos.Visible = false;
                 dtgCClave.Visible = true;
             }
        }

        private void frm5Historial_Load(object sender, EventArgs e)
        {
            PolulateDataGridAcc();
            PolulateDataGridCla();

        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
