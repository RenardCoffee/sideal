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
        //Computadora Brandon
        //string con = "server=DESKTOP-KS5ITG4\\SQLUWU ; database=PracticaFinal ; integrated security = true";
        //Computadora Priss
        private SqlConnection conexion = new SqlConnection("server=server=DESKTOP-KS5ITG4\\SQLUWU ; database=PracticaFinal ; integrated security = true");

        public frm1()
        {
            InitializeComponent();
        }

        public void logins()
        {
            try
            {
                using (conexion)
                {
                    conexion.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT ID_usuario, clave FROM aux_Acceso WHERE ID_usuario= '" + txtUsuario.Text + "' AND clave='" + txtClave.Text + "'", conexion))
                    {
                        SqlDataReader dr = cmd.ExecuteReader();
                        if (dr.Read())
                        {
                            //MessageBox.Show("Login Correcto");
                            //Se crea una nueva forma para dirigirnos al menú principal
                           
                        }
                        else
                        {
                            MessageBox.Show("Usuario no esta registrado");
                        }
                    }
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Deshabilitamos el botón de acceso 
            btnAcceder.Enabled = false;
            cbxTipousu.Text = "ADMIN";
            
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            
            //logins();

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
                    //frm2 frm2 = new frm2();
                    //frm2.Show();
                    //this.Hide();
                }
                else if (cbxTipousu.Text == "MAESTRO")
                {
                    MessageBox.Show(UsuOBj.Mensaje, "Maestro");
                }
                else if(cbxTipousu.Text == "ALUMNO") { MessageBox.Show(UsuOBj.Mensaje, "Estudiante"); }
            }
            else {
                MessageBox.Show(UsuOBj.Mensaje, "Usuario no existe!");
            }

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
    }
}
