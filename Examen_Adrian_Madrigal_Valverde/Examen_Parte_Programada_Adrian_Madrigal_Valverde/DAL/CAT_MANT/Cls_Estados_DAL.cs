using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DAL.CAT_MANT
{
    public class Cls_Estados_DAL
    {
        #region VARIABLES PRIVADAS

           
            private string _sDescripcion,
                           _sAX,
                           _sIdEstado, 
                           _sCadena, 
                           _sMsj_Error,  
                           _sNombreTabla;

            private char _cAxn;

            private DataTable _dtDatos;

            private Boolean _bEstAX;


        #endregion

        #region VARIABLES PÚBLICAS

            public string sIdEstado
            {
                get
                {
                    return _sIdEstado;
                }

                set
                {
                    _sIdEstado = value;
                }
            }

            public string sDescripcion
            {
                get
                {
                    return _sDescripcion;
                }

                set
                {
                    _sDescripcion = value;
                }
            }

            public string sAX
            {
                get
                {
                    return _sAX;
                }

                set
                {
                    _sAX = value;
                }
            }

            public bool bEstAX
            {
                get
                {
                    return _bEstAX;
                }

                set
                {
                    _bEstAX = value;
                }
            }

            public string sCadena
            {
                get
                {
                    return _sCadena;
                }

                set
                {
                    _sCadena = value;
                }
            }

            public string sMsj_Error
            {
                get
                {
                    return _sMsj_Error;
                }

                set
                {
                    _sMsj_Error = value;
                }
            }

            

            public string sNombreTabla
            {
                get
                {
                    return _sNombreTabla;
                }

                set
                {
                    _sNombreTabla = value;
                }
            }

        public char cAxn { 
            get => _cAxn; 
            set => _cAxn = value; 
                        }
        public DataTable dtDatos { 
            get => _dtDatos; 
            set => _dtDatos = value; 
                                 }



        #endregion
    }
}
