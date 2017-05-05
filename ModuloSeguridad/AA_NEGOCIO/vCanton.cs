using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using AA_DATOS;

namespace AA_NEGOCIO
{
    public class vCanton
    {
        Canton datD = new Canton();
        public DataSet MostrarCanton(String[] datos)
        {
            return datD.MostrarCanton(datos);
        }
        public bool insertar_canton(String[] datos)
        {
            return datD.insertar_canton(datos);
        }
        public bool eliminar_canton(String[] datos)
        {
            return datD.eliminar_canton(datos);
        }
    }
}
