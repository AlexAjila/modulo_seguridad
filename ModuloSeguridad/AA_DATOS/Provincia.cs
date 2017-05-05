using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace AA_DATOS
{
    public class Provincia
    {
        Conexion con = new Conexion();
        public DataSet MostrarProvincia(String[] datos)
        {
            SqlConnection cnn = new SqlConnection(con.conexion());
            cnn.Open();
            SqlCommand cmd = new SqlCommand("EXEC mostrar_provincia '" + datos[0] + "','" + datos[1] + "'", cnn);
            SqlDataAdapter daDatos = new SqlDataAdapter(cmd);
            DataSet dsDatos = new DataSet();
            daDatos.Fill(dsDatos);
            cnn.Close();
            return dsDatos;
        }
        public bool insertar_provincia(string[] datos)
        {
            SqlConnection cnn = new SqlConnection(con.conexion());
            cnn.Open();
            SqlCommand cmd = new SqlCommand("insertar_provincia", cnn);
            cmd.Parameters.Add("@IDPRO", SqlDbType.Int).Value = Convert.ToInt16(datos[0]);
            cmd.Parameters.Add("@CODPRO", SqlDbType.Int).Value = Convert.ToInt16(datos[1]);
            cmd.Parameters.Add("@NOMPRO", SqlDbType.VarChar, 50).Value = datos[2];

            cmd.CommandType = CommandType.StoredProcedure;
            int ok = cmd.ExecuteNonQuery();
            if (ok == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        
        public bool eliminar_provincia(string[] datos)
        {
            SqlConnection cnn = new SqlConnection(con.conexion());
            cnn.Open();
            SqlCommand cmd = new SqlCommand("eliminar_provincia", cnn);
            cmd.Parameters.Add("@IDPRO", SqlDbType.Int).Value = Convert.ToInt16(datos[0]);

            cmd.CommandType = CommandType.StoredProcedure;
            int ok = cmd.ExecuteNonQuery();
            if (ok == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
