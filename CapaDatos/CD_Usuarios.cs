using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Diagnostics;

namespace CapaDatos
{
    public class CD_Usuarios
    {
        //Este metodo  nos muestra todo los usuario en la tabla
        public List<Usuario> Listar()
        {
            List < Usuario > listar = new List<Usuario>();

            try
            {
                using (SqlConnection oconnect = new SqlConnection(Conexion.cn))
                {
                    string query = "select IdUsuario, Nombres, Apellidos, Correo, Clave, Reestablecer, Activo from USUARIO";

                    //Ejecutar el query en la cadena de conexion
                    SqlCommand cmd = new SqlCommand(query, oconnect);
                    //Este le dice al "cmd" que tipo de comando eres
                    cmd.CommandType = CommandType.Text;

                    //Procede a abrir la conexion
                    oconnect.Open();
                    using ( SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            listar.Add
                                (
                                new Usuario()
                            {
                                IdUsuario = Convert.ToInt32(dr["IdUsuario"]),
                                Nombres = dr["Nombres"].ToString(), 
                                Apellidos = dr["Apellidos"].ToString(), 
                                Correo = dr["Correo"].ToString(), 
                                Clave = dr["Clave"].ToString(), 
                                Reestablecer = Convert.ToBoolean(dr["Reestablecer"]), 
                                Activo = Convert.ToBoolean(dr["Activo"])
                            }
                                );
                        }
                    }
                    {

                    }
                }

            }
            catch {
                listar = new List<Usuario>();
            }



            return listar;
        }

    }
}
