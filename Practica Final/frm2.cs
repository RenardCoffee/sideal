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
    public partial class frm2 : Form
    {   //Computadora Brandon
        private SqlConnection conexion = new SqlConnection("server=DESKTOP-KS5ITG4\\SQLUWU ; database=PracticaFinal ; integrated security = true");
        //Computadora Priss
        //private SqlConnection conexion = new SqlConnection("server=LAPTOP-QSFU5A2T\\SQLEXPRESS ; database=PracticaFinal ; integrated security = true");
        
        public frm2(string tipo)
        {
            InitializeComponent();


            if (tipo == "ADMIN")
            {
                lblAdmin.ForeColor = Color.ForestGreen;
                grbAlumno.Visible = false;
                grbMaestro.Visible = false;
            }
            else if (tipo == "ALUMNO")
            {
                lblAlumno.ForeColor = Color.FromArgb(255, 0, 192, 192);
                grbAdmin.Visible = false;
                grbMaestro.Visible = false;
            }
            else if (tipo == "MAESTRO")
            {
                lblMaestro.ForeColor = Color.Red;
                grbAdmin.Visible = false;
                grbAlumno.Visible = false;
            }
        }
       
        private void frm2_Load(object sender, EventArgs e)
        {
                
            
        }

        //Boton para cambiar la clave: Maestro
        private void btnCClaveMaestro_Click(object sender, EventArgs e)
        {
            frm3 frm3 = new frm3();
            frm3.ShowDialog();
            
        }

        //Boton para cambiar la clave: Alumno
        private void btnCambiarClave_Click(object sender, EventArgs e)
        {
            frm3 frm3 = new frm3();
            frm3.ShowDialog();
            
        }

        //Boton para cambiar la clave: Administrador
        private void btnCClaveAdmin_Click(object sender, EventArgs e)
        {
            frm3 frm3 = new frm3();
            frm3.ShowDialog();
        
        }

        //Boton para acceder al Kardex: Alumno
        private void btnKardex_Click(object sender, EventArgs e)
        {
            frm4Kardex frm4 = new frm4Kardex();
            frm4.ShowDialog();
            
        }

        //Administrador
        private void btnHistorial_Click(object sender, EventArgs e)
        {
            frm5Historial frm5 = new frm5Historial();
            frm5.ShowDialog();
            
        }

        //Administrador
        private void btnPMU_Click(object sender, EventArgs e)
        {
            frm6PMU frm6 = new frm6PMU();
            frm6.ShowDialog();
        }

        private void btnABCCAdmin_Click(object sender, EventArgs e)
        {
            frm7MAdmin frm7 = new frm7MAdmin();
            frm7.ShowDialog();
        }

        private void btnABCMMaestro_Click(object sender, EventArgs e)
        {
            frm8MMtro frm8 = new frm8MMtro();
            frm8.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
