using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;

namespace tallerMVC1.Models
{
    public static class Productos
    {
        public static string msgErr { get; set; }

        public static List<Producto> listadoProductos()
        {
            List<Producto> productos = new List<Producto>();

            msgErr = "";

            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["pruebasDAW"].ConnectionString);

            try
            {
                con.Open();
                SqlCommand sentencia = new SqlCommand();
                sentencia.CommandType = System.Data.CommandType.Text;
                sentencia.Connection = con;
                string sql = " select p.id, p.nombre, p.descripcion, p.precio, p.categoria, c.nombre as nombrecategoria ";
                sql += " from productos p, categorias c where p.categoria=c.id ";
                sentencia.CommandText = sql;

                SqlDataReader rs = sentencia.ExecuteReader();

                if (rs.HasRows)
                {
                    while (rs.Read())
                    {
                        Producto p = new Producto();
                        p.id = Convert.ToInt32(rs["id"].ToString());
                        p.nombre = rs["nombre"].ToString();
                        p.descripcion = rs["descripcion"].ToString();
                        p.precio = Convert.ToDouble(rs["precio"].ToString());
                        p.categoria = Convert.ToInt32(rs["categoria"].ToString());
                        p.nombreCategoria = rs["nombrecategoria"].ToString();

                        productos.Add(p);

                    }
                }
                else
                {
                    msgErr = "No he encontrado productos en la BD.";
                    productos = null;
                }


            }
            catch (Exception ex)
            {
                msgErr = "Error al recuperar los productos de la bd, causa: " + ex.Message;
                productos = null;
            }
            finally
            {
                con.Close();
            }

            return productos;

        }
    }
}