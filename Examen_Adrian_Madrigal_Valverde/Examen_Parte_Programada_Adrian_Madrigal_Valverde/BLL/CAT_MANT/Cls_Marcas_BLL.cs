using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using BLL.BD;
using DAL.BD;
using DAL.CAT_MANT;


namespace BLL.CAT_MANT
{
    public class Cls_Marcas_BLL
    {
        #region Variables Globales

            Cls_BD_BLL Obj_BD_BLL = new Cls_BD_BLL();
            Cls_BD_DAL Obj_BD_DAL = new Cls_BD_DAL();

        #endregion

        public void Listar_Filtrar_Marcas(ref Cls_Marcas_DAL Obj_Marcas_DAL)
        {
            Cls_BD_DAL Obj_DB_DAL = new Cls_BD_DAL();
            Cls_BD_BLL Obj_DB_BLL = new Cls_BD_BLL();

            if (Obj_Marcas_DAL.sMarca == string.Empty)
            {
                Obj_DB_DAL.sNomSp = ConfigurationManager.AppSettings["List_Marcas"].ToString();

            }
            else
            {
                Obj_DB_DAL.sNomSp = ConfigurationManager.AppSettings["Filt_Marcas"].ToString();
                Obj_DB_BLL.Crear_DT_Parametros(ref Obj_DB_DAL);                                   
                Obj_DB_DAL.dt_PARAMETROS.Rows.Add("@Marca", "6", Obj_Marcas_DAL.sMarca);  
            }
            Obj_DB_DAL.sNomTabla = "Marcas";

            Obj_DB_BLL.Exec_DataAdapter(ref Obj_DB_DAL);

            if (Obj_DB_DAL.sMsjError == string.Empty)
            {

                Obj_Marcas_DAL.sMsj_Error = string.Empty;
                Obj_Marcas_DAL.dtDatos = Obj_DB_DAL.ds.Tables[0];
            }
            else
            {
                Obj_Marcas_DAL.sMsj_Error = Obj_DB_DAL.sMsjError;
                Obj_Marcas_DAL.dtDatos = null;
            }
        }

        public void Insertar_Marcas(ref Cls_Marcas_DAL Obj_Marcas_DAL)
        {
            Cls_BD_DAL Obj_DB_DAL = new Cls_BD_DAL();
            Cls_BD_BLL Obj_DB_BLL = new Cls_BD_BLL();


            Obj_DB_DAL.sNomSp = ConfigurationManager.AppSettings["Inser_Marcas"].ToString();
            Obj_DB_BLL.Crear_DT_Parametros(ref Obj_DB_DAL);                                   
            Obj_DB_DAL.dt_PARAMETROS.Rows.Add("@IdMarca", "1", Obj_Marcas_DAL.iIdMarca);
            Obj_DB_DAL.dt_PARAMETROS.Rows.Add("@Marca", "6", Obj_Marcas_DAL.sMarca); 
            Obj_DB_DAL.dt_PARAMETROS.Rows.Add("@IdEstado", "4", Obj_Marcas_DAL.sIdEstado);
            Obj_DB_DAL.cAuxiliar = 'M';                          

            Obj_DB_BLL.Exec_NonQuery(ref Obj_DB_DAL);
            Obj_Marcas_DAL.sMsj_Error = Obj_DB_DAL.sMsjError;

            if (Obj_Marcas_DAL.sMsj_Error == string.Empty)
            {
                Obj_Marcas_DAL.iIdMarca = Convert.ToInt32(Obj_DB_DAL.sValorScalar);
            }                                                                    
            else
            {
                Obj_Marcas_DAL.iIdMarca = 0;
            }

        }

        public void Modificar_Marcas(ref Cls_Marcas_DAL Obj_Marcas_DAL)
        {
            Cls_BD_DAL Obj_DB_DAL = new Cls_BD_DAL();
            Cls_BD_BLL Obj_DB_BLL = new Cls_BD_BLL();


            Obj_DB_DAL.sNomSp = ConfigurationManager.AppSettings["Updat_Marcas"].ToString();
            Obj_DB_BLL.Crear_DT_Parametros(ref Obj_DB_DAL);                                   
           Obj_DB_DAL.dt_PARAMETROS.Rows.Add("@IdMarca", "1", Obj_Marcas_DAL.iIdMarca);
            Obj_DB_DAL.dt_PARAMETROS.Rows.Add("@Marca", "6", Obj_Marcas_DAL.sMarca);  
            Obj_DB_DAL.dt_PARAMETROS.Rows.Add("@IdEstado", "4", Obj_Marcas_DAL.sIdEstado);
            Obj_DB_DAL.cAuxiliar = 'M';                            

            Obj_DB_BLL.Exec_NonQuery(ref Obj_DB_DAL);
            Obj_Marcas_DAL.sMsj_Error = Obj_DB_DAL.sMsjError;
        }

        public void Eliminar_Marcas(ref Cls_Marcas_DAL Obj_Marcas_DAL)
        {
            Cls_BD_DAL Obj_DB_DAL = new Cls_BD_DAL();
            Cls_BD_BLL Obj_DB_BLL = new Cls_BD_BLL();


            Obj_DB_DAL.sNomSp = ConfigurationManager.AppSettings["Delet_Marcas"].ToString();
            Obj_DB_BLL.Crear_DT_Parametros(ref Obj_DB_DAL);                                  
            Obj_DB_DAL.dt_PARAMETROS.Rows.Add("@IdMarca", "1", Obj_Marcas_DAL.iIdMarca);  
            Obj_DB_DAL.cAuxiliar = 'M';
            Obj_DB_BLL.Exec_NonQuery(ref Obj_DB_DAL);

            Obj_Marcas_DAL.sMsj_Error = Obj_DB_DAL.sMsjError;
        }
        public void Listar__Estados(ref Cls_Marcas_DAL Obj_Marcas_DAL)
        {

            Cls_BD_DAL Obj_DB_DAL = new Cls_BD_DAL();
            Cls_BD_BLL Obj_DB_BLL = new Cls_BD_BLL();


            Obj_DB_DAL.sNomSp = ConfigurationManager.AppSettings["List_Estados"].ToString();

            Obj_DB_DAL.sNomTabla = "Estados";

            Obj_DB_BLL.Exec_DataAdapter(ref Obj_DB_DAL);

            if (Obj_DB_DAL.sMsjError == string.Empty)
            {

                Obj_Marcas_DAL.sMsj_Error = string.Empty;
                Obj_Marcas_DAL.dtDatos = Obj_DB_DAL.ds.Tables[0];
            }
            else
            {
                Obj_Marcas_DAL.sMsj_Error = Obj_DB_DAL.sMsjError;
                Obj_Marcas_DAL.dtDatos = null;
            }
        }
    }
}
