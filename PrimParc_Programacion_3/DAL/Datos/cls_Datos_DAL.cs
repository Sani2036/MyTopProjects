using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Datos
{
    public class cls_Datos_DAL
    {
        #region VARIABLES PRIVADAS

            private byte _bOrden;

            private int[] _arrNumerosSinOrdenar;

            private Random _rdmGenerador;

            private string _sResultado;

            private int _iNum;

        #endregion

        

        #region VARIABLES PUBLICAS O CONTTRUCTORES

            public byte bOrden { get => _bOrden; set => _bOrden = value; }
            public int[] ArrNumerosSinOrdenar { get => _arrNumerosSinOrdenar; set => _arrNumerosSinOrdenar = value; }
            public string sResultado { get => _sResultado; set => _sResultado = value; }
            public Random rdmGenerador { get => _rdmGenerador; set => _rdmGenerador = value; }
            public int INum { get => _iNum; set => _iNum = value; }

        #endregion
    }
}
