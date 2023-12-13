using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DAL.BD
{
    public class Cls_BD_DAL
    {
        #region VARIABLES PRIVADAS
        private SqlConnection _Obj_Sql_cnx;

        private SqlCommand _Obj_Sql_Cmd;

        private SqlDataAdapter _Obj_Sql_Dap;

        private System.Data.DataSet _Ds = new System.Data.DataSet();

        private System.Data.DataTable _dt_PARAMETROS = new System.Data.DataTable("PARAMETROS");

        private char _cAuxiliar;            
        private string _sNomTabla, _sNomSp, _sValorScalar, _sMsjError;


        #endregion

        #region VARIABLES PUBLICAS
        public SqlConnection obj_Sql_cnx { get => _Obj_Sql_cnx; set => _Obj_Sql_cnx = value; }
        public SqlCommand obj_Sql_Cmd { get => _Obj_Sql_Cmd; set => _Obj_Sql_Cmd = value; }
        public SqlDataAdapter obj_Sql_Dap { get => _Obj_Sql_Dap; set => _Obj_Sql_Dap = value; }
        public DataSet ds { get => _Ds; set => _Ds = value; }
        public DataTable dt_PARAMETROS { get => _dt_PARAMETROS; set => _dt_PARAMETROS = value; }
        public char cAuxiliar { get => _cAuxiliar; set => _cAuxiliar = value; }
        public string sNomTabla { get => _sNomTabla; set => _sNomTabla = value; }
        public string sNomSp { get => _sNomSp; set => _sNomSp = value; }
        public string sValorScalar { get => _sValorScalar; set => _sValorScalar = value; }
        public string sMsjError { get => _sMsjError; set => _sMsjError = value; }
        #endregion


    }
}
