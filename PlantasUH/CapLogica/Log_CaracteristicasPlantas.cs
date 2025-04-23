using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using PlantasUH.CapDatos;

namespace PlantasUH.CapLogica
{
    public class Log_CaracteristicasPlantas
    {
        public static List<Cls_CaracteristicasPlantas> caracteristicas = new List<Cls_CaracteristicasPlantas>();
        public static List<Cls_CaracteristicasPlantas> ObtenerCaracteristicas()
        {
            int retorno = 0;
            SqlConnection Conn = new SqlConnection();

            try
            {

                using (Conn =Log_Conexion.obtenerConexion())
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

                            Cls_CaracteristicasPlantas Caracteristicas = new Cls_CaracteristicasPlantas();
                            Caracteristicas.PlantaID = reader.GetInt32(0);
                            Caracteristicas.Nombre = reader.GetString(1);
                            Caracteristicas.Hojas = reader.GetString(2);
                            Caracteristicas.Color = reader.GetString(3);

                            caracteristicas.Add(Caracteristicas);
                        }

                    }
                }
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                return caracteristicas;
            }
            finally
            {
                Conn.Close();
                Conn.Dispose();
            }

            return caracteristicas;
        }
    }
}