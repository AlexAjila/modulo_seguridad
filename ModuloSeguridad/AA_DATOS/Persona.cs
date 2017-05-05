using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace AA_DATOS
{
    public class Persona
    {
        Conexion con = new Conexion();
        public DataSet MostrarPersona(String[] datos)
        {
            SqlConnection cnn = new SqlConnection(con.conexion());
            cnn.Open();
            SqlCommand cmd = new SqlCommand("EXEC mostra_persona '"+datos[0]+"','"+datos[1]+"'",cnn);
            SqlDataAdapter daDatos = new SqlDataAdapter(cmd);
            DataSet dsDatos = new DataSet();

            daDatos.Fill(dsDatos);
            cnn.Close();
            return dsDatos;
        }
        public bool insertar_persona(string[] datos)
        {
            SqlConnection cnn = new SqlConnection(con.conexion());
            cnn.Open();
            SqlCommand cmd = new SqlCommand("insertar_persona", cnn);
            cmd.Parameters.Add("@CODPER", SqlDbType.Int).Value = Convert.ToInt16( datos[0]);
            cmd.Parameters.Add("@NOMPER", SqlDbType.VarChar, 50).Value = datos[1];
            cmd.Parameters.Add("@APEPER", SqlDbType.VarChar, 50).Value = datos[2];
            cmd.Parameters.Add("@CEDPER", SqlDbType.VarChar, 50).Value = datos[3];
            cmd.Parameters.Add("@TELPER", SqlDbType.VarChar, 50).Value = datos[4];
            cmd.Parameters.Add("@DIRPER", SqlDbType.VarChar, 50).Value = datos[5];
            cmd.Parameters.Add("@IDPA", SqlDbType.Int).Value = Convert.ToInt32(datos[6]);

            cmd.CommandType = CommandType.StoredProcedure;
            int ok = cmd.ExecuteNonQuery();
            if (ok== 1){
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool eliminar_persona(string[] datos)
        {
            SqlConnection cnn = new SqlConnection(con.conexion());
            cnn.Open();
            SqlCommand cmd = new SqlCommand("eliminar_persona", cnn);
            cmd.Parameters.Add("@CODPER", SqlDbType.Int).Value = Convert.ToInt16(datos[0]);
            
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
