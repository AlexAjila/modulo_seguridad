<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Cantones.aspx.cs" Inherits="ModuloSeguridad.Formulario.Cantones" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <br />
                        <br />
              <center><asp:Label ID="Label1" runat="server" style="color: #FF0000; " Text="Label" Visible="False"></asp:Label>
        <br />
                  <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>COD</strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
             <asp:TextBox ID="txtCo" runat="server" Width="168px" Enabled="False"></asp:TextBox>
                  <br />
        <br />
        <strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Provincia</strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtPro" runat="server" Width="168px" Enabled="False"></asp:TextBox>
        <br />
        <br />
        <strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Codigo&nbsp;</strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtCod" runat="server" Width="169px" Enabled="False"></asp:TextBox>
&nbsp;&nbsp;
        <br />
        <br />
        <strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Canton</strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtCa" runat="server" Width="170px" Enabled="False"></asp:TextBox>
        <br />
        <br />
                    <asp:Button ID="btnNuevo" runat="server" Text="Nuevo" OnClick="bntNuevo_Click" />
                    &nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btnGuardar" runat="server" Text="Guardar" OnClick="btnGuardar_Click" />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" OnClick="btnEliminar_Click" Enabled="False" />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btnModificar" runat="server" Text="Modificar" OnClick="btnModificar_Click" />
                  <br />
                  <br />
    <asp:CheckBox ID="chkMostrar" runat="server" AutoPostBack="True"  Text="Mostrar Registros" OnCheckedChanged="chkMostrar_CheckedChanged" />
                  <br />
                  <br />
    <asp:GridView ID="gvDatos1" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanged="gvDatos1_SelectedIndexChanged1">
        <Columns>
            <asp:BoundField DataField="IDCAN" HeaderText="Codigo" />
            <asp:BoundField DataField="IDPRO" HeaderText="Cod Provincia" />
            <asp:BoundField DataField="CODCAN" HeaderText="Cod Canton" />
            <asp:BoundField DataField="NOMCAN" HeaderText="Canton" />
            <asp:CommandField ButtonType="Button" ShowSelectButton="True" />
        </Columns>
    </asp:GridView>
        </center>
             <br />
             <br />
</asp:Content>
