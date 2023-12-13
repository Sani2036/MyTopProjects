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
    public partial class Frm_Editar_Marcas : Form
    {

       


        public Frm_Editar_Marcas()
        {
            InitializeComponent();
        }

        #region VARIABLES GLOBALES

        public Cls_Marcas_DAL Obj_Marcas_Recibe_DAL;
        Cls_Marcas_BLL Obj_Marcas_BLL = new Cls_Marcas_BLL();
        Cls_Marcas_DAL Obj_Marcas_DAL = new Cls_Marcas_DAL();

        public Cls_Estados_DAL Obj_Estados_DAL = new Cls_Estados_DAL();
        public Cls_Estados_BLL Obj_Estados_BLL = new Cls_Estados_BLL();

        #endregion

        #region EVENTOS
        private void Frm_Editar_Marcas_Load(object sender, EventArgs e)
        {
            CargarDatosPantallaListar();
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
            CargarCombos();

            if (Obj_Marcas_Recibe_DAL.cAxn == 'N')
            {
                Txt_IdMarca.Text = string.Empty;
                Txt_DescripcionMarca.Text = string.Empty;
                Cmb_Estados.SelectedValue = "0";

            }
            else
            {
                Txt_IdMarca.Text = Convert.ToString(Obj_Marcas_Recibe_DAL.iIdMarca).Trim();
                Txt_DescripcionMarca.Text = Obj_Marcas_Recibe_DAL.sMarca.Trim();
                Cmb_Estados.SelectedValue = Obj_Marcas_Recibe_DAL.sIdEstado.ToString().Trim();
            }
        }

        private void Save()
        {
            Obj_Marcas_DAL.iIdMarca = Convert.ToInt32(Txt_IdMarca.Text.ToString().Trim());
            Obj_Marcas_DAL.sMarca = Txt_DescripcionMarca.Text.ToString().Trim();
            Obj_Marcas_DAL.sIdEstado = Cmb_Estados.SelectedValue.ToString().Trim();

            if (Obj_Marcas_Recibe_DAL.cAxn == 'N')
            {
              
                Obj_Marcas_BLL.Insertar_Marcas(ref Obj_Marcas_DAL);
                if (Obj_Marcas_Recibe_DAL.sMsj_Error == string.Empty)
                {
                    Obj_Marcas_Recibe_DAL.cAxn = 'U';
                    MessageBox.Show("La nueva marca fue insertada exitosamente", "Proceso Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    Obj_Marcas_Recibe_DAL.cAxn = 'N';
                    MessageBox.Show("La nueva marca NO se pudo guardar debido al siguiente Error [ - " + Obj_Marcas_Recibe_DAL.sMsj_Error + "- ]", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                
                Obj_Marcas_BLL.Modificar_Marcas(ref Obj_Marcas_DAL);
                if (Obj_Marcas_DAL.sMsj_Error == string.Empty)
                {

                    MessageBox.Show("La nueva marca fue modificada exitosamente", "Proceso Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {

                    MessageBox.Show("La nueva marca no se pudo modificar debido al siguiente Error [ - " + Obj_Marcas_DAL.sMsj_Error + "- ]", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

            Obj_Marcas_Recibe_DAL.iIdMarca = Obj_Marcas_DAL.iIdMarca;
            Obj_Marcas_Recibe_DAL.sMarca = Obj_Marcas_DAL.sMarca;
            Obj_Marcas_Recibe_DAL.sIdEstado = Obj_Marcas_DAL.sIdEstado;
            CargarDatosPantallaListar();

        }
        private void CargarCombos()
        {               

            Obj_Marcas_BLL.Listar__Estados(ref Obj_Marcas_DAL); 

            Obj_Marcas_DAL.dtDatos.Rows.Add("0", "--- Seleccione un Estado ---");



            Cmb_Estados.DataSource = null;     

            Cmb_Estados.DataSource = Obj_Marcas_DAL.dtDatos;

            Cmb_Estados.DisplayMember = "Descripcion";       

            Cmb_Estados.ValueMember = "IdEstado";      
        }
        #endregion

    }
}
