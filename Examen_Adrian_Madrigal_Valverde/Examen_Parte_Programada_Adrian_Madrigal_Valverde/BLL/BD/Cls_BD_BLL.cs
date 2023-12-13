using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using DAL.BD;

namespace BLL.BD
{
    public class Cls_BD_BLL
    {
        public void Crear_DT_Parametros(ref Cls_BD_DAL Obj_BD_DAL)
        {
            Obj_BD_DAL.dt_PARAMETROS = new DataTable("parametros");
            Obj_BD_DAL.dt_PARAMETROS.Columns.Add("Nom_Param");
            Obj_BD_DAL.dt_PARAMETROS.Columns.Add("Tipo_Dato");
            Obj_BD_DAL.dt_PARAMETROS.Columns.Add("Valor");
        }

        public void Exec_DataAdapter(ref Cls_BD_DAL Obj_BD_DAL)
        {
            try
            {
                Obj_BD_DAL.obj_Sql_cnx = new SqlConnection(ConfigurationManager.ConnectionStrings["WIN_AUT"].ToString());

                if (Obj_BD_DAL.obj_Sql_cnx.State == ConnectionState.Closed)
                {
                    Obj_BD_DAL.obj_Sql_cnx.Open();
                }

                Obj_BD_DAL.obj_Sql_Dap = new SqlDataAdapter(Obj_BD_DAL.sNomSp,   
                                                        Obj_BD_DAL.obj_Sql_cnx); 
                                                                               
                Obj_BD_DAL.obj_Sql_Dap.SelectCommand.CommandType = CommandType.StoredProcedure;  
                                                                                                
                #region AGREGAR PARÁMETROS

                if (Obj_BD_DAL.dt_PARAMETROS != null)
                {
                    SqlDbType TipoDatoSQL = SqlDbType.VarChar;

                    foreach (DataRow dr in Obj_BD_DAL.dt_PARAMETROS.Rows)
                    {
                        #region Definición de tipos de Datos del SQL

                        switch (dr[1])
                        {
                            case "1":
                                {
                                    TipoDatoSQL = SqlDbType.Int;
                                    break;
                                }
                            case "2":
                                {
                                    TipoDatoSQL = SqlDbType.Decimal;
                                    break;
                                }
                            case "3":
                                {
                                    TipoDatoSQL = SqlDbType.Float;
                                    break;
                                }
                            case "4":
                                {
                                    TipoDatoSQL = SqlDbType.Char;
                                    break;
                                }
                            case "5":
                                {
                                    TipoDatoSQL = SqlDbType.NChar;
                                    break;
                                }
                            case "6":
                                {
                                    TipoDatoSQL = SqlDbType.VarChar;
                                    break;
                                }
                            case "7":
                                {
                                    TipoDatoSQL = SqlDbType.NVarChar;
                                    break;
                                }
                            case "8":
                                {
                                    TipoDatoSQL = SqlDbType.DateTime;
                                    break;
                                }
                            case "9":
                                {
                                    TipoDatoSQL = SqlDbType.Bit;
                                    break;
                                }
                            case "10":
                                {
                                    TipoDatoSQL = SqlDbType.Money;
                                    break;
                                }
                            case "11":
                                {
                                    TipoDatoSQL = SqlDbType.TinyInt;
                                    break;
                                }

                            default:
                                break;
                        }

                        #endregion

                        Obj_BD_DAL.obj_Sql_Dap.SelectCommand.Parameters.Add(dr[0].ToString(),            
                                                                        TipoDatoSQL                 
                                                                        ).Value = dr[2].ToString(); 

                    }
                }

                #endregion

                Obj_BD_DAL.ds = new DataSet();
                Obj_BD_DAL.obj_Sql_Dap.Fill(Obj_BD_DAL.ds,       
                                        Obj_BD_DAL.sNomTabla);      

                Obj_BD_DAL.sMsjError = string.Empty;
            }
            catch (SqlException ex)
            {
                Obj_BD_DAL.sMsjError = ex.Message.ToString();
            }
            finally  
            {
                if (Obj_BD_DAL.obj_Sql_cnx.State == ConnectionState.Open)
                {
                    Obj_BD_DAL.obj_Sql_cnx.Close();      
                }

                Obj_BD_DAL.obj_Sql_cnx.Dispose();      
            }
        }


        public void Exec_NonQuery(ref Cls_BD_DAL Obj_BD_DAL)
        {
            try
            {
                Obj_BD_DAL.obj_Sql_cnx = new SqlConnection(ConfigurationManager.ConnectionStrings["SQL_AUT"].ToString());

                if (Obj_BD_DAL.obj_Sql_cnx.State == ConnectionState.Closed)
                {
                    Obj_BD_DAL.obj_Sql_cnx.Open();
                }

                Obj_BD_DAL.obj_Sql_Cmd = new SqlCommand(Obj_BD_DAL.sNomSp,   
                                                        Obj_BD_DAL.obj_Sql_cnx); 
                                                                               
                Obj_BD_DAL.obj_Sql_Cmd.CommandType = CommandType.StoredProcedure; 
                                                                                  
                #region AGREGAR PARÁMETROS

                if (Obj_BD_DAL.dt_PARAMETROS != null)  
                {
                    SqlDbType TipoDatoSQL = SqlDbType.VarChar;

                    foreach (DataRow dr in Obj_BD_DAL.dt_PARAMETROS.Rows)
                    {
                        #region Definición de tipos de Datos del SQL

                        switch (dr[1])
                        {
                            case "1":
                                {
                                    TipoDatoSQL = SqlDbType.Int;
                                    break;
                                }
                            case "2":
                                {
                                    TipoDatoSQL = SqlDbType.Decimal;
                                    break;
                                }
                            case "3":
                                {
                                    TipoDatoSQL = SqlDbType.Float;
                                    break;
                                }
                            case "4":
                                {
                                    TipoDatoSQL = SqlDbType.Char;
                                    break;
                                }
                            case "5":
                                {
                                    TipoDatoSQL = SqlDbType.NChar;
                                    break;
                                }
                            case "6":
                                {
                                    TipoDatoSQL = SqlDbType.VarChar;
                                    break;
                                }
                            case "7":
                                {
                                    TipoDatoSQL = SqlDbType.NVarChar;
                                    break;
                                }
                            case "8":
                                {
                                    TipoDatoSQL = SqlDbType.DateTime;
                                    break;
                                }
                            case "9":
                                {
                                    TipoDatoSQL = SqlDbType.Bit;
                                    break;
                                }
                            case "10":
                                {
                                    TipoDatoSQL = SqlDbType.Money;
                                    break;
                                }
                            case "11":
                                {
                                    TipoDatoSQL = SqlDbType.TinyInt;
                                    break;
                                }

                            default:
                                break;
                        }

                        #endregion

                        Obj_BD_DAL.obj_Sql_Cmd.Parameters.Add(dr[0].ToString(),             
                                                                        TipoDatoSQL                  
                                                                        ).Value = dr[2].ToString(); 

                    }
                }

                #endregion
                if (Obj_BD_DAL.cAuxiliar == 'M')
                {
                    Obj_BD_DAL.obj_Sql_Cmd.ExecuteNonQuery(); 
                }
                else
                {
                    Obj_BD_DAL.sValorScalar = Obj_BD_DAL.obj_Sql_Cmd.ExecuteScalar().ToString().Trim();  
                }

                Obj_BD_DAL.sMsjError = string.Empty;
            }
            catch (SqlException ex)
            {
                Obj_BD_DAL.sMsjError = ex.Message.ToString();
            }
            finally  
            {
                if (Obj_BD_DAL.obj_Sql_cnx.State == ConnectionState.Open)
                {
                    Obj_BD_DAL.obj_Sql_cnx.Close();      
                }

                Obj_BD_DAL.obj_Sql_cnx.Dispose();     
            }
        }


    }
}
