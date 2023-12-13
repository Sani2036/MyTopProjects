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

namespace PL.PANTALLAS.CAT_MANT.LISTAR
{
    public partial class Frm_Listar_Marcas : Form
    {
        #region VARIABLES GLOGALES
        Cls_Marcas_BLL Obj_Marcas_BLL = new Cls_Marcas_BLL();
        Cls_Marcas_DAL Obj_Marcas_DAL = new Cls_Marcas_DAL();

        #endregion


        public Frm_Listar_Marcas()
        {
            InitializeComponent();
        }
        #region EVENTOS
        private void tsbtn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbtn_Nuevo_Click(object sender, EventArgs e)
        {
            EditarDatos('N');
        }

        private void tsbtn_Modificar_Click(object sender, EventArgs e)
        {
            EditarDatos('U');
        }

        private void tsbtn_Eliminar_Click(object sender, EventArgs e)
        {
            EliminarDatos();
        }

        private void tsbtn_Filtrar_Click(object sender, EventArgs e)
        {

        }

        private void tstxt_Filtro_TextChanged(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void Frm_Listar_Marcas_Load(object sender, EventArgs e)
        {
            tstxt_Filtro.Text = string.Empty;
            CargarDatos();

        }

        private void dgv_Estados_DoubleClick(object sender, EventArgs e)
        {
            EditarDatos('U');
        }

        private void Frm_Listar_Estados_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Desea realmente salir de esta pantalla", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        private void tsbtn_Refrescar_Click(object sender, EventArgs e)
        {
            tstxt_Filtro.Text = string.Empty;
            CargarDatos();
        }
        #endregion

        #region METODOS
        private void CargarDatos()
        {
            Obj_Marcas_DAL.sMarca = tstxt_Filtro.Text.Trim();

            Obj_Marcas_BLL.Listar_Filtrar_Marcas(ref Obj_Marcas_DAL);

            if (Obj_Marcas_DAL.sMsj_Error == string.Empty)
            {
                dgv_Marcas.DataSource = null;
                dgv_Marcas.DataSource = Obj_Marcas_DAL.dtDatos;
            }
            else
            {
                MessageBox.Show("Se presentó un error al listar los estados. \n\nERROR = [ " + Obj_Marcas_DAL.sMsj_Error + " ].",
                                "ERROR",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void EliminarDatos()
        {
            if (dgv_Marcas.Rows.Count >= 1)
            {
                if (MessageBox.Show("Confirma que desea eliminar realmente el estado \n[ " + dgv_Marcas.SelectedRows[0].Cells[0].Value.ToString() + " - "
                                                                                        + dgv_Marcas.SelectedRows[0].Cells[1].Value.ToString().Trim() + " ]...???",
                                                                                        "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Obj_Marcas_DAL.sMarca = dgv_Marcas.SelectedRows[0].Cells[0].Value.ToString();  

                    Obj_Marcas_BLL.Eliminar_Marcas(ref Obj_Marcas_DAL);

                    if (Obj_Marcas_DAL.sMsj_Error == string.Empty)
                    {
                        MessageBox.Show("La región \n[ " + dgv_Marcas.SelectedRows[0].Cells[0].Value.ToString() + " - "
                                                                                             + dgv_Marcas.SelectedRows[0].Cells[1].Value.ToString().Trim() + " ], fue eliminada exitosamente",
                                                                                        "Proceso Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        CargarDatos();
                    }
                    else
                    {
                        MessageBox.Show("Se ha presentado un error al momento de eliminar el estado [ " + dgv_Marcas.SelectedRows[0].Cells[0].Value.ToString() + "]. \n\n Error : ["
                            + Obj_Marcas_DAL.sMsj_Error, "Error eliminando la región", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            else
            {
                MessageBox.Show("No tiene estados para poder eliminar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            Obj_Marcas_BLL.Listar_Filtrar_Marcas(ref Obj_Marcas_DAL);
            if (Obj_Marcas_DAL.sMsj_Error == string.Empty)
            {
                dgv_Marcas.DataSource = null;   
                dgv_Marcas.DataSource = Obj_Marcas_DAL.dtDatos;
            }
            else
            {
                MessageBox.Show("Se ha presentado un error al cargar los datos" + Obj_Marcas_DAL.sMsj_Error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EditarDatos(char cOpcion)
        {

            EDITAR.Frm_Editar_Marcas Forma_Editar = new EDITAR.Frm_Editar_Marcas();

            Obj_Marcas_DAL.cAxn = cOpcion;

            if (cOpcion == 'U')
            {
                if (dgv_Marcas.Rows.Count >= 1)
                {
                    if (MessageBox.Show("Confirma que desea editar o modificar realmente el Estado [ " + dgv_Marcas.SelectedRows[0].Cells[0].Value.ToString() +
                        " - " + dgv_Marcas.SelectedRows[0].Cells[1].Value.ToString().Trim() + " ]...???", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Obj_Marcas_DAL.iIdMarca = Convert.ToInt32(dgv_Marcas.SelectedRows[0].Cells[0].Value.ToString().Trim());
                        Obj_Marcas_DAL.sMarca = dgv_Marcas.SelectedRows[0].Cells[1].Value.ToString().Trim();
                        Obj_Marcas_DAL.sIdEstado = dgv_Marcas.SelectedRows[0].Cells[2].Value.ToString().Trim();


                        Forma_Editar.Obj_Marcas_Recibe_DAL = Obj_Marcas_DAL;

                        Forma_Editar.ShowDialog();
                    }

                }
                else
                {
                    MessageBox.Show("No tiene estados para poder eliminar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }


            }
            else
            {
                Forma_Editar.Obj_Marcas_Recibe_DAL = Obj_Marcas_DAL;

                Forma_Editar.ShowDialog();
            }


        }



        #endregion

       
    }
}
