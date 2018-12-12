using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Practica_Final
{
    class Usu:Conn
    {
        private string usu;
        private string pass;
        private string tipo;

        public Usu() {
            usu = string.Empty;
            pass = string.Empty;
            this.sql = string.Empty;

        }

        public string Us {
            get { return this.usu; }
            set { this.usu = value; }
        }

        public string Pas
        {
            get { return this.pass; }
            set { this.pass = value; }
        }

        public string Tip
        {
            get { return this.tipo; }
            set { this.tipo = value; }
        }

        public bool Busco()
        {
            bool res = false;
            this.sql = string.Format(@"SELECT ID_usuario FROM aux_Acceso WHERE ID_usuario='{0}' AND clave='{1}' AND Tipo='{2}'",this.Us, this.Pas,this.tipo);
            this.cmdsql = new SqlCommand(this.sql, this.cnn);
            this.cnn.Open();
            SqlDataReader Reg = null;
            Reg = this.cmdsql.ExecuteReader();
            if (Reg.Read())
            {
                res = true;
                this.mens = "Bienvenido a SiDeAl";
            }
            else {
                this.mens = "Datos malos, verifique!";
            }
            this.cnn.Close();
            return res;
        }
            
    }
}
