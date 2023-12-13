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
    public class Cls_Estados_BLL
    {
        #region Variables Globales

            Cls_BD_BLL Obj_BD_BLL = new Cls_BD_BLL();
            Cls_BD_DAL Obj_BD_DAL = new Cls_BD_DAL();

        #endregion

        public void Listar_Filtrar_Estados(ref Cls_Estados_DAL Obj_Estados_DAL)
        {
            Cls_BD_DAL Obj_DB_DAL = new Cls_BD_DAL();
            Cls_BD_BLL Obj_DB_BLL = new Cls_BD_BLL();

            if (Obj_Estados_DAL.sDescripcion == string.Empty)
            {
                Obj_DB_DAL.sNomSp = ConfigurationManager.AppSettings["List_Estados"].ToString();

            }
            else
            {
                Obj_DB_DAL.sNomSp = ConfigurationManager.AppSettings["Filt_Estados"].ToString();
                Obj_DB_BLL.Crear_DT_Parametros(ref Obj_DB_DAL);                                   
                Obj_DB_DAL.dt_PARAMETROS.Rows.Add("@Descripcion", "6", Obj_Estados_DAL.sDescripcion);  
            }
            Obj_DB_DAL.sNomTabla = "Estados";

            Obj_DB_BLL.Exec_DataAdapter(ref Obj_DB_DAL);

            if (Obj_DB_DAL.sMsjError == string.Empty)
            {

                Obj_Estados_DAL.sMsj_Error = string.Empty;
                Obj_Estados_DAL.dtDatos = Obj_DB_DAL.ds.Tables[0];
            }
            else
            {
                Obj_Estados_DAL.sMsj_Error = Obj_DB_DAL.sMsjError;
                Obj_Estados_DAL.dtDatos = null;
            }
        }


        public void Insertar_Estados(ref Cls_Estados_DAL Obj_Estados_DAL)
        {
            Cls_BD_DAL Obj_DB_DAL = new Cls_BD_DAL();
            Cls_BD_BLL Obj_DB_BLL = new Cls_BD_BLL();


            Obj_DB_DAL.sNomSp = ConfigurationManager.AppSettings["Inser_Estados"].ToString();
            Obj_DB_BLL.Crear_DT_Parametros(ref Obj_DB_DAL);                                  
            Obj_DB_DAL.dt_PARAMETROS.Rows.Add("@IdEstado", "4", Obj_Estados_DAL.sIdEstado);  
            Obj_DB_DAL.dt_PARAMETROS.Rows.Add("@Descripcion", "6", Obj_Estados_DAL.sDescripcion);
            Obj_DB_DAL.cAuxiliar = 'M';                             
            
            Obj_DB_BLL.Exec_NonQuery(ref Obj_DB_DAL);
            Obj_Estados_DAL.sMsj_Error = Obj_DB_DAL.sMsjError;


            

        }

        public void Modificar_Estados(ref Cls_Estados_DAL Obj_Estados_DAL)
        {
            Cls_BD_DAL Obj_DB_DAL = new Cls_BD_DAL();
            Cls_BD_BLL Obj_DB_BLL = new Cls_BD_BLL();


            Obj_DB_DAL.sNomSp = ConfigurationManager.AppSettings["Updat_Estados"].ToString();
            Obj_DB_BLL.Crear_DT_Parametros(ref Obj_DB_DAL);                                  
            Obj_DB_DAL.dt_PARAMETROS.Rows.Add("@IdEstado", "4", Obj_Estados_DAL.sIdEstado); 
            Obj_DB_DAL.dt_PARAMETROS.Rows.Add("@Descripcion", "6", Obj_Estados_DAL.sDescripcion);
            Obj_DB_DAL.cAuxiliar = 'M';                             

            Obj_DB_BLL.Exec_NonQuery(ref Obj_DB_DAL);
            Obj_Estados_DAL.sMsj_Error = Obj_DB_DAL.sMsjError;
        }

        public void Eliminar_Estados(ref Cls_Estados_DAL Obj_Estados_DAL)
        {
            Cls_BD_DAL Obj_DB_DAL = new Cls_BD_DAL();
            Cls_BD_BLL Obj_DB_BLL = new Cls_BD_BLL();


            Obj_DB_DAL.sNomSp = ConfigurationManager.AppSettings["Delet_Estados"].ToString();
            Obj_DB_BLL.Crear_DT_Parametros(ref Obj_DB_DAL);                                   
            Obj_DB_DAL.dt_PARAMETROS.Rows.Add("@IdEstado", "4", Obj_Estados_DAL.sIdEstado);  
            Obj_DB_DAL.cAuxiliar = 'M';
            Obj_DB_BLL.Exec_NonQuery(ref Obj_DB_DAL);

            Obj_Estados_DAL.sMsj_Error = Obj_DB_DAL.sMsjError;


        }

    }
}

