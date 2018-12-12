using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Libreria
using System.Data.SqlClient;

namespace Practica_Final
{
    public partial class frm3 : Form
    {   //Brandon
        private SqlConnection conexion = new SqlConnection("server=DESKTOP-KS5ITG4\\SQLUWU ; database=PracticaFinal ; integrated security = true");
        //Priss
        //private SqlConnection conexion = new SqlConnection("server=LAPTOP-QSFU5A2T\\SQLEXPRESS ; database=PracticaFinal ; integrated security = true");
        public frm3()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            conexion.Open();
            string usu = txtCusuario.Text;
            string cadena = "select Clave from T_usuarios where ID_usuario=" + usu;
            SqlCommand comando = new SqlCommand(cadena, conexion);
            SqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                txtClaveActual.Text = registro["Clave"].ToString();
                btnGuardarCambios.Enabled = true;
            }
            else
                MessageBox.Show("No existe el usuario ingresado");
            conexion.Close();
        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            conexion.Open();
            string usu = txtCusuario.Text;
            string cvieja = txtClaveActual.Text;
            string cnueva = txtNClave.Text;
            string cadena = "update T_usuarios set Clave ='" + cnueva + "' where ID_usuario=" + usu;
            SqlCommand comando = new SqlCommand(cadena, conexion);
            int cant;
            cant = comando.ExecuteNonQuery();
            if (cant == 1)
            {
                MessageBox.Show("No se puede cambiar esa clave");
            }
            else
                MessageBox.Show("Se cambio la clave");
            txtClaveActual.Text = "";
            txtCusuario.Text = "";
            txtNClave.Text = "";
            btnConfirmar.Text = "";
            btnGuardarCambios.Enabled = false;

            conexion.Close();
        }
    }
}
