using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using AA_NEGOCIO;
using System.Data.OleDb;

namespace ModuloSeguridad.Formulario
{
    public partial class Parroquias : System.Web.UI.Page
    {
        vParroquia datM = new vParroquia();

        #region FUNCIONES DE Parroquia
        private void limpiar()
        {
            txtCo.Text = "";
            txtCa.Text = "";
            txtCod.Text = "";
            txtPa.Text = "";
        }
        #endregion
        private void mostrarMensaje(String mensaje)
        {
            Response.Write("<script>window.alert('" + mensaje + "');</script>");
        }
        private void MostrarParroquia(string[] datos)
        {
            try
            {
                DataSet dsDatos = new DataSet();
                dsDatos = datM.MostrarParroquia(datos);
                if (dsDatos.Tables[0].Rows.Count == 0 || dsDatos.Tables[0].Rows.Count == null)
                {
                    mostrarMensaje("No existe informacion");
                }
                else
                {
                    gvDatos1.DataSource = dsDatos.Tables[0];
                    gvDatos1.DataBind();
                }
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
            txtCo.Enabled = true;
            txtCa.Enabled = true;
            txtCod.Enabled = true;
            txtPa.Enabled = true;
            Label1.Visible = true;
            Label1.Text = "Ingrese los nuevos registros";
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string[] dato = {
                                txtCo.Text,    
                                txtCa.Text,
                                txtCod.Text,
                                txtPa.Text
                                };
                datM.insertar_parroquia(dato);
                btnNuevo.Enabled = true;
                btnGuardar.Enabled = false;
                btnEliminar.Enabled = false;
                txtCo.Enabled = false;
                txtCa.Enabled = false;
                txtCod.Enabled = false;
                txtPa.Enabled = false;
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
                datM.eliminar_parroquia(dato);
                btnNuevo.Enabled = true;
                btnGuardar.Enabled = false;
                btnEliminar.Enabled = false;
                txtCo.Enabled = false;
                txtCa.Enabled = false;
                txtCod.Enabled = false;
                txtPa.Enabled = false;
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
            txtCo.Enabled = false;
            txtCa.Enabled = true;
            txtCod.Enabled = true;
            txtPa.Enabled = true;
            Label1.Visible = true;
            Label1.Text = "Modificar los registros";
        }

        protected void chkMostrar_CheckedChanged(object sender, EventArgs e)
        {
            string[] dato = { "*", "dfghj" };
            MostrarParroquia(dato);
        }


        protected void gvDatos1_SelectedIndexChanged1(object sender, EventArgs e)
        {
            try
            {


                int f = gvDatos1.SelectedIndex;

                txtCo.Text = gvDatos1.Rows[f].Cells[0].Text;
                txtCa.Text = gvDatos1.Rows[f].Cells[1].Text;
                txtCod.Text = gvDatos1.Rows[f].Cells[2].Text;
                txtPa.Text = gvDatos1.Rows[f].Cells[3].Text;



            }
            catch (Exception)
            {

            }
            txtCo.Visible = true;
            txtCa.Visible = true;
            txtCod.Visible = true;
            txtPa.Visible = true;
        }
    }
}