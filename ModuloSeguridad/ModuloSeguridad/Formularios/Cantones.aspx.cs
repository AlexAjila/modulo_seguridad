using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using AA_NEGOCIO;
using System.Data.OleDb;

namespace ModuloSeguridad.Formularios
{
    public partial class Cantones : System.Web.UI.Page
    {
        vPersona datM = new vPersona();

        #region FUNCIONES DE Persona
        private void limpiar()
        {
            txtPro.Text = "";
            txtCod.Text = "";
            txtCa.Text = "";
        }
        #endregion
        private void mostrarMensaje(String mensaje)
        {
            Response.Write("<script>window.alert('" + mensaje + "');</script>");
        }
        private void MostrarPersona(string[] datos)
        {
            try
            {
                DataSet dsDatos = new DataSet();
                dsDatos = datM.MostrarPersona(datos);
                if (dsDatos.Tables[0].Rows.Count == 0 || dsDatos.Tables[0].Rows.Count == null)
                {
                    mostrarMensaje("No existe informacion");
                }
                /*else
                {
                    gvDatos.DataSource = dsDatos.Tables[0];
                    gvDatos.DataBind();
                }*/
            }
            catch (Exception ex)
            {
                mostrarMensaje(ex.Message.ToString());
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
            }
        }

        protected void bntNuevo_Click(object sender, EventArgs e)
        {
            btnNuevo.Enabled = false;
            btnGuardar.Enabled = true;
            btnEliminar.Enabled = false;
            txtPro.Enabled = true;
            txtCod.Enabled = true;
            txtCa.Enabled = true;
            Label1.Visible = true;
            Label1.Text = "Ingrese los nuevos registros";
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string[] dato = {txtPro.Text,
                                txtCod.Text,
                                txtCa.Text
                                };
                datM.insertar_persona(dato);
                btnNuevo.Enabled = true;
                btnGuardar.Enabled = false;
                btnEliminar.Enabled = false;
                txtPro.Enabled = false;
                txtCod.Enabled = false;
                txtCa.Enabled = false;
                Label1.Visible = true;
                Label1.Text = "Registro Guardado Exitosamente";
                limpiar();
            }
            catch (Exception ex)
            {
                Label1.Visible = true;
                Label1.Text = ex.Message.ToString();
            }
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                string[] dato = { txtCo.Text };
                datM.eliminar_persona(dato);
                btnNuevo.Enabled = true;
                btnGuardar.Enabled = false;
                btnEliminar.Enabled = false;
                txtCo.Enabled = false;
                txtPro.Enabled = false;
                txtCod.Enabled = false;
                txtCa.Enabled = false;
                Label1.Visible = true;
                Label1.Text = "Registro Eliminado Exitosamente";
                limpiar();
            }
            catch (Exception ex)
            {
                Label1.Visible = true;
                Label1.Text = ex.Message.ToString();
            }
        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            btnNuevo.Enabled = false;
            btnGuardar.Enabled = true;
            btnEliminar.Enabled = true;
            txtPro.Enabled = true;
            txtCod.Enabled = true;
            txtCa.Enabled = true;
            Label1.Visible = true;
            Label1.Text = "Modificar los registros";
        }
    }
}