using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Datos;

namespace BLL.Ordenamiento
{
    public class cls_Ordenamiento_BLL
    {

        public void OrdenarNumeros( ref cls_Datos_DAL Obj_Datos_DAL )
        {

            if (Obj_Datos_DAL.bOrden == 1)
            {
                Array.Sort(Obj_Datos_DAL.ArrNumerosSinOrdenar);

                // Hace el ordenamiento ascendente ( de menor a mayor)
            }
            if (Obj_Datos_DAL.bOrden == 2)
            {
                Array.Sort(Obj_Datos_DAL.ArrNumerosSinOrdenar);
                Array.Reverse(Obj_Datos_DAL.ArrNumerosSinOrdenar);
                // Hace el ordenamiento descendente ( de mayor a menor)
            }
        }
    }
}
