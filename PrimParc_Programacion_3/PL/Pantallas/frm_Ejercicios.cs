using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL.Datos;
using BLL.Ordenamiento;
using BLL.Generador;

namespace PL.Pantallas
{
    public partial class frm_Ejercicios : Form
    {
        public frm_Ejercicios()
        {
            InitializeComponent();
        }

        #region VARIABLES GLOBALES

            cls_Datos_DAL Obj_Datos_DAL = new cls_Datos_DAL();

            cls_Generador_BLL Obj_Generador_BLL = new cls_Generador_BLL();
            cls_Ordenamiento_BLL Obj_Ordenamiento_BLL = new cls_Ordenamiento_BLL();        

        #endregion


        #region EVENTOS

            private void frm_Ejercicios_Load(object sender, EventArgs e)
            {

                txt_Resultado.Text = string.Empty;
            }

            private void btn_Generar_Click(object sender, EventArgs e)
            {
            Obj_Generador_BLL.GenerarArregloRandom (ref Obj_Datos_DAL);

                Llenar();
        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
            {
                

                Obj_Datos_DAL = new cls_Datos_DAL();            
                            
                txt_Num_1.Text = "0";
                txt_Num_2.Text = "0";
                txt_Num_3.Text = "0";
                txt_Num_4.Text = "0";
                txt_Num_5.Text = "0";
                txt_Num_6.Text = "0";
                txt_Num_7.Text = "0";
                txt_Num_8.Text = "0";
                txt_Num_9.Text = "0";
                txt_Num_10.Text = "0";                
        }

            private void btn_Ordenar_Click(object sender, EventArgs e)
            {

            if (Obj_Datos_DAL.ArrNumerosSinOrdenar == null)
            {
                MessageBox.Show("El arreglo de numeros esta vacio, debe generar los numeros primero en el Ejercicio 1",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else // Si el arreglo tiene elementos
            {
                
                if (rbt_Asc.Checked == true)
                {
                  Obj_Datos_DAL.bOrden = 1;
                  Obj_Ordenamiento_BLL.OrdenarNumeros(ref Obj_Datos_DAL);
                  txt_Resultado.Text = string.Join(" | ", Obj_Datos_DAL.ArrNumerosSinOrdenar);
                }

                if (rbt_Desc.Checked == true)
                {
                  Obj_Datos_DAL.bOrden = 2;
                  Obj_Ordenamiento_BLL.OrdenarNumeros(ref Obj_Datos_DAL);
                  txt_Resultado.Text = string.Join(" | ", Obj_Datos_DAL.ArrNumerosSinOrdenar);
                }
                txt_Resultado.Text = string.Join(" | ", Obj_Datos_DAL.ArrNumerosSinOrdenar);
                


            }
            

                //Debe hacer la logica del llenado del Textbox
            }

           private void rbt_Asc_CheckedChanged(object sender, EventArgs e)
           {
            if (rbt_Asc.Checked == true)
            {
                rbt_Desc.Checked = false;
            }
           }
           private void rbt_Desc_CheckedChanged(object sender, EventArgs e)
           {
            if (rbt_Desc.Checked == true)
            {
                rbt_Asc.Checked = false;
            }
           }
        #endregion

        #region MÉTODOS     
        
        private void Llenar()
        {
            for (int i = 0; i <= 9; i++) // Logica para ingresar los numeros random en los textbox segun quiere el profe (2,5,8,10,1,4,7,3,6,9)
            {
                switch (i)
                {
                    case 0:
                        txt_Num_2.Text = Obj_Datos_DAL.ArrNumerosSinOrdenar[0].ToString().Trim();

                        break;

                    case 1:
                        txt_Num_5.Text = Obj_Datos_DAL.ArrNumerosSinOrdenar[1].ToString().Trim();

                        break;

                    case 2:
                        txt_Num_8.Text = Obj_Datos_DAL.ArrNumerosSinOrdenar[2].ToString().Trim();

                        break;
                    case 3:
                        txt_Num_10.Text = Obj_Datos_DAL.ArrNumerosSinOrdenar[3].ToString().Trim();

                        break;

                    case 4:
                        txt_Num_1.Text = Obj_Datos_DAL.ArrNumerosSinOrdenar[4].ToString().Trim();

                        break;

                    case 5:
                        txt_Num_4.Text = Obj_Datos_DAL.ArrNumerosSinOrdenar[5].ToString().Trim();

                        break;

                    case 6:
                        txt_Num_7.Text = Obj_Datos_DAL.ArrNumerosSinOrdenar[6].ToString().Trim();

                        break;

                    case 7:
                        txt_Num_3.Text = Obj_Datos_DAL.ArrNumerosSinOrdenar[7].ToString().Trim();

                        break;

                    case 8:
                        txt_Num_6.Text = Obj_Datos_DAL.ArrNumerosSinOrdenar[8].ToString().Trim();

                        break;

                    case 9:
                        txt_Num_9.Text = Obj_Datos_DAL.ArrNumerosSinOrdenar[9].ToString().Trim();

                        break;
                }
            }
        }

        #endregion


    }
}
