using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PL.PANTALLAS.CAT_MANT.LISTAR;

namespace PL.PANTALLAS.GENERALES
{
    public partial class Frm_Principal : Form
    {
        public Frm_Principal()
        {
            InitializeComponent();
        }

        private void mniSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mniCat_Estados_Click(object sender, EventArgs e)
        {
            Frm_Listar_Estados Obj_Pant = new Frm_Listar_Estados();
            Obj_Pant.ShowDialog();
        }

        private void mniCat_Marcas_Click(object sender, EventArgs e)
        {
            Frm_Listar_Marcas Obj_Pant = new Frm_Listar_Marcas();
            Obj_Pant.ShowDialog();
        }
    }
}
