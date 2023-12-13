using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Datos;

namespace BLL.Generador
{
    public class cls_Generador_BLL
    {
        public void GenerarArregloRandom(ref cls_Datos_DAL Obj_Datos_DAL)
        {
            Obj_Datos_DAL.rdmGenerador = new Random();
            Obj_Datos_DAL.ArrNumerosSinOrdenar = new int[10];

            for (int i = 0; i <= 9; i++)
            {
                Obj_Datos_DAL.INum = Obj_Datos_DAL.rdmGenerador.Next(7, 286);

               if (Obj_Datos_DAL.ArrNumerosSinOrdenar.Contains(Obj_Datos_DAL.INum))
                {
                    i--;
                }
                else
                {
                  Obj_Datos_DAL.ArrNumerosSinOrdenar[i] = Obj_Datos_DAL.INum;
                }
                
            }

        }
    }
}