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
    public partial class Personas : System.Web.UI.Page
    {
        vPersona datM = new vPersona();

        #region FUNCIONES DE Persona
        private void limpiar()
        {
            txtCo.Text = "";
            txtNo.Text = "";
            txtAp.Text = "";
            txtCe.Text = "";
            txtTe.Text = "";
            txtDi.Text = "";
            txtPa.Text = "";
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
            txtNo.Enabled = true;
            txtAp.Enabled = true;
            txtCe.Enabled = true;
            txtTe.Enabled = true;
            txtDi.Enabled = true;
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
                                txtNo.Text,
                                txtAp.Text,
                                txtCe.Text,
                                txtTe.Text,
                                txtDi.Text,
                                txtPa.Text
                                };
                datM.insertar_persona(dato);
                btnNuevo.Enabled = true;
                btnGuardar.Enabled = false;
                btnEliminar.Enabled = false;
                txtCo.Enabled = false;
                txtNo.Enabled = false;
                txtAp.Enabled = false;
                txtCe.Enabled = false;
                txtTe.Enabled = false;
                txtDi.Enabled = false;
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
                datM.eliminar_persona(dato);
                btnNuevo.Enabled = true;
                btnGuardar.Enabled = false;
                btnEliminar.Enabled = false;
                txtCo.Enabled = false;
                txtNo.Enabled = false;
                txtAp.Enabled = false;
                txtCe.Enabled = false;
                txtTe.Enabled = false;
                txtDi.Enabled = false;
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
            txtCo.Enabled = true;
            txtNo.Enabled = true;
            txtAp.Enabled = true;
            txtCe.Enabled = true;
            txtTe.Enabled = true;
            txtDi.Enabled = true;
            txtPa.Enabled = true;
            Label1.Visible = true;
            Label1.Text = "Modificar los registros";
        }

        protected void chkMostrar_CheckedChanged(object sender, EventArgs e)
        {
            string[] dato = { "*", "dfghj" };
            MostrarPersona(dato);
        }
        protected void gvDatos1_SelectedIndexChanged1(object sender, EventArgs e)
        {
            try
            {


                int f = gvDatos1.SelectedIndex;

                txtCo.Text = gvDatos1.Rows[f].Cells[0].Text;
                txtNo.Text = gvDatos1.Rows[f].Cells[1].Text;
                txtAp.Text = gvDatos1.Rows[f].Cells[2].Text;
                txtCe.Text = gvDatos1.Rows[f].Cells[3].Text;
                txtTe.Text = gvDatos1.Rows[f].Cells[4].Text;
                txtDi.Text = gvDatos1.Rows[f].Cells[5].Text;
                txtPa.Text = gvDatos1.Rows[f].Cells[6].Text;



            }
            catch (Exception)
            {

            }
            txtCo.Visible = true;
            txtNo.Visible = true;
            txtAp.Visible = true;
            txtCe.Visible = true;
            txtTe.Visible = true;
            txtDi.Visible = true;
            txtPa.Visible = true;
        }

    }
}