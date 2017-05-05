using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AA_DATOS
{
    class Conexion
    {
        public string conexion()
        {
            string cadena = "DATA SOURCE = ALEX\\SQLEXPRESS; INITIAL CATALOG = AJAMSeguridad; INTEGRATED SECURITY = TRUE";
            return cadena;
        }
    }
}
