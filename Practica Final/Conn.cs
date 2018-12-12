using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Practica_Final
{
    class Conn
    {
        public string con;
        protected string sql;
        protected int resultado;
        protected SqlConnection cnn;
        protected SqlCommand cmdsql;
        protected string mens;

        public Conn()
        {
            this.con = "server=DESKTOP-KS5ITG4\\SQLUWU ; database=PracticaFinal ; integrated security = true";
            this.cnn = new SqlConnection(this.con);
        }

        public string Mensaje {
            get {
                return this.mens;
            }
        }
    }
}
