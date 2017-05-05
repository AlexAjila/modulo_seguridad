using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using AA_DATOS;

namespace AA_NEGOCIO
{
    public class vProvincia
    {
        Provincia datD = new Provincia();
        public DataSet MostrarProvincia(String[] datos)
        {
            return datD.MostrarProvincia(datos);
        }
        public bool insertar_provincia(String[] datos)
        {
            return datD.insertar_provincia(datos);
        }
        public bool eliminar_provincia(String[] datos)
        {
            return datD.eliminar_provincia(datos);
        }
    }
}
