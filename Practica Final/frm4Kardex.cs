using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_Final
{
    public partial class frm4Kardex : Form
    {
        public frm4Kardex()
        {
            InitializeComponent();
        }

        private void frm4Kardex_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'practicaFinalDataSet.T_CALIFICACIONES' table. You can move, or remove it, as needed.
            this.t_CALIFICACIONESTableAdapter.Fill(this.practicaFinalDataSet.T_CALIFICACIONES);

        }
    }
}
