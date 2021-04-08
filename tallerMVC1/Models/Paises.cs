using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;

namespace tallerMVC1.Models
{
    public static class Paises
    {

        public static string msgErr { get; set; }

        public static List<Pais> listadoPaises()
        {
            List<Pais> paises = new List<Pais>();
            msgErr = "";

            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["pruebasDAW"].ConnectionString);

            try
            {
                con.Open();
                SqlCommand sentencia = new SqlCommand();
                sentencia.CommandType = System.Data.CommandType.Text;
                sentencia.Connection = con;
                string sql = " select id, nombre from paises ";
                sentencia.CommandText = sql;

                SqlDataReader rs = sentencia.ExecuteReader();

                if (rs.HasRows)
                {
                    while (rs.Read())
                    {
                        Pais p = new Pais();
                        p.id = Convert.ToInt32(rs["id"].ToString());
                        p.nombre = rs["nombre"].ToString();

                        paises.Add(p);

                    }
                }
                else
                {
                    msgErr = "No he encontrado paises en la BD.";
                    paises = null;
                }


            }
            catch (Exception ex)
            {
                msgErr = "Error al recuperar los paises de la bd, causa: " + ex.Message;
                paises = null;
            }
            finally
            {
                con.Close();
            }

            return paises;

        }

    }
}