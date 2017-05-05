using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using AA_DATOS;

namespace AA_NEGOCIO
{
    public class vPersona
    {
        Persona datD = new Persona();
        public DataSet MostrarPersona(String[] datos)
        {
            return datD.MostrarPersona(datos);
        }
        public bool insertar_persona(String[] datos)
        {
            return datD.insertar_persona(datos);
        }
        public bool eliminar_persona(String[] datos)
        {
            return datD.eliminar_persona(datos);
        }
    }
}
