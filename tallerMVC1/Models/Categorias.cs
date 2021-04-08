using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;

namespace tallerMVC1.Models
{
    public static class Categorias
    {

        public static string msgErr { get; set; }

        public static List<Categoria> listadoCategorias()
        {
            List<Categoria> listado = new List<Categoria>();
            msgErr = "";

            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["pruebasDAW"].ConnectionString);

            try
            {
                con.Open();
                SqlCommand sentencia = new SqlCommand();
                sentencia.CommandType = System.Data.CommandType.Text;
                sentencia.Connection = con;
                string sql = " select id, nombre from categorias ";
                sentencia.CommandText = sql;

                SqlDataReader rs = sentencia.ExecuteReader();

                if (rs.HasRows)
                {
                    while (rs.Read())
                    {
                        Categoria p = new Categoria();
                        p.id = Convert.ToInt32(rs["id"].ToString());
                        p.nombre = rs["nombre"].ToString();

                        listado.Add(p);

                    }
                }
                else
                {
                    msgErr = "No he encontrado categorías en la BD.";
                    listado = null;
                }


            }
            catch (Exception ex)
            {
                msgErr = "Error al recuperar las categorías de la bd, causa: " + ex.Message;
                listado = null;
            }
            finally
            {
                con.Close();
            }

            return listado;

        }

    }
}