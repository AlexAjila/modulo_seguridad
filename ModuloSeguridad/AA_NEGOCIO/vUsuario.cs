using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using AA_DATOS;

namespace AA_NEGOCIO
{
    public class vUsuario
    {
        Usuario datD = new Usuario();
        public DataSet MostrarUsuario(String[] datos)
        {
            return datD.MostrarUsuario(datos);
        }
        public bool insertar_usuario(String[] datos)
        {
            return datD.insertar_usuario(datos);
        }
        public bool eliminar_usuario(String[] datos)
        {
            return datD.eliminar_usuario(datos);
        }
    }
}
