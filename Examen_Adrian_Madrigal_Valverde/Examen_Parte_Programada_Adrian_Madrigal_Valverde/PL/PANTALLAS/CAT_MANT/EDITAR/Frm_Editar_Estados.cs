using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL.BD;
using BLL.CAT_MANT;
using DAL.BD;
using DAL.CAT_MANT;

namespace PL.PANTALLAS.CAT_MANT.EDITAR
{
    public partial class Frm_Editar_Estados : Form
    {
        public Frm_Editar_Estados()
        {
            InitializeComponent();
        }

        #region VARIABLES GLOBALES

            public Cls_Estados_DAL Obj_Estados_Recibe_DAL;
            Cls_Estados_BLL Obj_Estados_BLL = new Cls_Estados_BLL();
            Cls_Estados_DAL Obj_Estados_DAL = new Cls_Estados_DAL();


        #endregion

        #region EVENTOS
        private void Frm_Editar_Estados_Load(object sender, EventArgs e)
        {
            CargarDatosPantallaListar();
        }

        private void Frm_Editar_Estados_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Desea realmente salir de esta pantalla?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }

        }

        private void tsbtn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbtn_Guardar_Click(object sender, EventArgs e)
        {
            Save();
        }
        #endregion
        #region METODOS
        private void CargarDatosPantallaListar()
        {

            if (Obj_Estados_Recibe_DAL.cAxn == 'N')
            {
                Txt_IdEstado.Text = string.Empty;
                Txt_DescripcionEstado.Text = string.Empty;

            }
            else
            {
                Txt_IdEstado.Text = Obj_Estados_Recibe_DAL.sIdEstado.Trim();
                Txt_DescripcionEstado.Text = Obj_Estados_Recibe_DAL.sDescripcion.Trim();
            }
        }

        private void Save()
        {
            Obj_Estados_DAL.sIdEstado = Txt_IdEstado.Text.ToString().Trim();
            Obj_Estados_DAL.sDescripcion = Txt_DescripcionEstado.Text.ToString().Trim();

            if (Obj_Estados_Recibe_DAL.cAxn == 'N')
            {
              
                Obj_Estados_BLL.Insertar_Estados(ref Obj_Estados_DAL);
                if (Obj_Estados_Recibe_DAL.sMsj_Error == string.Empty)
                {
                    Obj_Estados_Recibe_DAL.cAxn = 'U';
                    MessageBox.Show("La nueva región fue insertada exitosamente", "Proceso Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    Obj_Estados_Recibe_DAL.cAxn = 'N';
                    MessageBox.Show("La nueva región NO se pudo guardar debido al siguiente Error [ - " + Obj_Estados_Recibe_DAL.sMsj_Error + "- ]", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                
                Obj_Estados_BLL.Modificar_Estados(ref Obj_Estados_DAL);
                if (Obj_Estados_DAL.sMsj_Error == string.Empty)
                {

                    MessageBox.Show("La nueva región fue modificada exitosamente", "Proceso Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {

                    MessageBox.Show("La nueva región no se pudo modificar debido al siguiente Error [ - " + Obj_Estados_DAL.sMsj_Error + "- ]", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

            Obj_Estados_Recibe_DAL.sIdEstado = Obj_Estados_DAL.sIdEstado;
            Obj_Estados_Recibe_DAL.sDescripcion = Obj_Estados_DAL.sDescripcion;
            CargarDatosPantallaListar();

        }

        #endregion

    }
}
