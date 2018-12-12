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
    public partial class frm5Historial : Form
    {
        public frm5Historial()
        {
            InitializeComponent();
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
            // TODO: This line of code loads data into the 'practicaFinalDataSet.TH_acceso' table. You can move, or remove it, as needed.
            this.tH_accesoTableAdapter.Fill(this.practicaFinalDataSet.TH_acceso);
            // TODO: This line of code loads data into the 'practicaFinalDataSet.TH_clave' table. You can move, or remove it, as needed.
            this.tH_claveTableAdapter.Fill(this.practicaFinalDataSet.TH_clave);

        }
    }
}
