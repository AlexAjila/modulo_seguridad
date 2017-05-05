using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using AA_DATOS;

namespace AA_NEGOCIO
{
    public class vParroquia
    {
        Parroquia datD = new Parroquia();
        public DataSet MostrarParroquia(String[] datos)
        {
            return datD.MostrarParroquia(datos);
        }
        public bool insertar_parroquia(String[] datos)
        {
            return datD.insertar_parroquia(datos);
        }
        public bool eliminar_parroquia(String[] datos)
        {
            return datD.eliminar_parroquia(datos);
        }
    }
}
