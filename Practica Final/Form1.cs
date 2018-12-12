using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Librería
using System.Data.SqlClient;


namespace Practica_Final
{
    public partial class frm1 : Form
    {
        //Brandon
        private SqlConnection conexion = new SqlConnection("server=DESKTOP-KS5ITG4\\SQLUWU ; database=PracticaFinal ; integrated security = true");

        public frm1()
        {
            InitializeComponent();
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            //Deshabilitamos el botón de acceso 
            btnAcceder.Enabled = false;
            cbxTipousu.Text = "ADMIN";
            
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {

            //Declaración de variables 
            int usuario;
            string Clave;

            //Si las cajas de texto están vacías se muestra el siguiente mensaje
            if (txtUsuario.Text == "" || txtClave.Text == "")
            {
                MessageBox.Show("Hacen falta campos por llenar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                usuario = int.Parse(txtUsuario.Text);
                Clave = txtClave.Text;
            }


            //Con la Verificacion De tipo
            Usu UsuOBj = new Usu();
            UsuOBj.Us = txtUsuario.Text;
            UsuOBj.Pas = txtClave.Text;
            UsuOBj.Tip = cbxTipousu.SelectedItem.ToString();

            if (UsuOBj.Busco() == true)
            {
                if (cbxTipousu.Text == "ADMIN")
                {
                    MessageBox.Show(UsuOBj.Mensaje, "Administrador");
                    frm2 frm2 = new frm2(cbxTipousu.SelectedItem.ToString());
                    frm2.Show();
                    this.Hide();

                }
                else if (cbxTipousu.Text == "MAESTRO")
                {
                    MessageBox.Show(UsuOBj.Mensaje, "Maestro");
                    frm2 frm2 = new frm2(cbxTipousu.SelectedItem.ToString());
                    frm2.Show();
                    this.Hide();
                }
                else if(cbxTipousu.Text == "ALUMNO")
                {
                   MessageBox.Show(UsuOBj.Mensaje, "Estudiante");
                    frm2 frm2 = new frm2(cbxTipousu.SelectedItem.ToString());
                    frm2.Show();
                    this.Hide();
                }
            }
            else {
                MessageBox.Show(UsuOBj.Mensaje, "Usuario no existe!");
            }

            //

            // Trigger de acceso
            conexion.Open();
            string usu = txtUsuario.Text;
            DateTime miDT = DateTime.Now;
            string fechaReg = miDT.ToString("yyyy-MM-dd HH:mm:ss");

            string cadena = "update T_usuarios set Fecha_acceso ='" + fechaReg + "' where ID_usuario=" + usu;
            SqlCommand comando = new SqlCommand(cadena, conexion);
            int cant;
            cant = comando.ExecuteNonQuery();
            if (cant == 1)
            {

            }
            else
                txtUsuario.Text = "";
            txtClave.Text = "";

            conexion.Close();
            //


        }

        //Creamos un evento con el mismo nombre para caja una de las cajas
        private void textBox_TextChanged(object sender, EventArgs e)
        {
            var bl = !string.IsNullOrEmpty(txtUsuario.Text) &&
                        !string.IsNullOrEmpty(txtClave.Text);
            btnAcceder.Enabled = bl;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            
            
        }

        private void linkCpass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm3 frmCpass = new frm3();
            frmCpass.ShowDialog();
        }
    }
}
