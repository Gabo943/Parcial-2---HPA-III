using Entidad;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class D_Usuario : D_Conexion
    {
        public static E_Usuarios ObtenerPorUsuario(string strUsuario)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    using (SqlCommand cmd = new SqlCommand("sp_ObtenerUsuarioPorNombre", conexion))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@dsUsuario", strUsuario);

                        using (SqlDataReader fReader = cmd.ExecuteReader())
                        {
                            if (fReader.Read())
                            {
                                return new E_Usuarios
                                {
                                    id = Convert.ToInt32(fReader["id"]),
                                    dsUsuario = fReader["dsUsuario"].ToString(),
                                    dsPassword = fReader["dsPassword"].ToString(), // hash guardado
                                    dsEstado = Convert.ToChar(fReader["dsEstado"])
                                };
                            }
                            return null;
                        }
                    }
                }
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}