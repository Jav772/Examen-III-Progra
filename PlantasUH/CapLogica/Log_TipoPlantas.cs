using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using PlantasUH.CapDatos;

namespace PlantasUH.CapLogica
{
    public class Log_TipoPlantas
    {
        public static List<Cls_TipoPlantas> tipo = new List<Cls_TipoPlantas>();
        public static List<Cls_TipoPlantas> ObtenerTipo()
        {
            int retorno = 0;
            SqlConnection Conn = new SqlConnection();

            try
            {

                using (Conn = Log_Conexion.obtenerConexion())
                {
                    SqlCommand cmd = new SqlCommand("listarcaracteristicas", Conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    retorno = cmd.ExecuteNonQuery();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {

                        while (reader.Read())
                        {

                            Cls_TipoPlantas Tipo = new Cls_TipoPlantas();
                            Tipo.TipoID = reader.GetInt32(0);
                            Tipo.Nombre = reader.GetString(1);
                            Tipo.Tipo = reader.GetString(2);
                            Tipo.PlantaID = reader.GetInt32(3);

                            tipo.Add(Tipo);
                        }

                    }
                }
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                return tipo;
            }
            finally
            {
                Conn.Close();
                Conn.Dispose();
            }

            return tipo;
        }
    }
}