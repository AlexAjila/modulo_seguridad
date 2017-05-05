using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace AA_DATOS
{
    public class Usuario
    {
        Conexion con = new Conexion();
        public DataSet MostrarUsuario(String[] datos)
        {
            SqlConnection cnn = new SqlConnection(con.conexion());
            cnn.Open();
            SqlCommand cmd = new SqlCommand("EXEC mostrar_usuario '" + datos[0] + "','" + datos[1] + "'", cnn);
            SqlDataAdapter daDatos = new SqlDataAdapter(cmd);
            DataSet dsDatos = new DataSet();
            daDatos.Fill(dsDatos);
            cnn.Close();
            return dsDatos;
        }
        public bool insertar_usuario(string[] datos)
        {
            SqlConnection cnn = new SqlConnection(con.conexion());
            cnn.Open();
            SqlCommand cmd = new SqlCommand("insertar_persona", cnn);
            cmd.Parameters.Add("@CODUSU", SqlDbType.Int).Value = Convert.ToInt16(datos[0]);
            cmd.Parameters.Add("@NICKUSU", SqlDbType.UniqueIdentifier).Value = datos[1];
            cmd.Parameters.Add("@PASSUSU", SqlDbType.UniqueIdentifier).Value = datos[2];
            cmd.Parameters.Add("@ESTUSU", SqlDbType.VarChar, 50).Value = datos[3];
            cmd.Parameters.Add("@CODPER", SqlDbType.Int).Value = Convert.ToInt16(datos[4]);
            cmd.Parameters.Add("@CODROL", SqlDbType.Int).Value = Convert.ToInt16(datos[5]);
            
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


        public bool eliminar_usuario(string[] datos)
        {
            SqlConnection cnn = new SqlConnection(con.conexion());
            cnn.Open();
            SqlCommand cmd = new SqlCommand("eliminar_usuario", cnn);
            cmd.Parameters.Add("@CODUSU", SqlDbType.Int).Value = Convert.ToInt16(datos[0]);

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
