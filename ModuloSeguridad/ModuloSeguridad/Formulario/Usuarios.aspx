<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Usuarios.aspx.cs" Inherits="ModuloSeguridad.Formulario.Usuarios" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <br />
                        <br />
              <center><asp:Label ID="Label1" runat="server" style="color: #FF0000; " Text="Label" Visible="False"></asp:Label>
                  <br />
                  <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>COD</strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
             <asp:TextBox ID="txtCo" runat="server" Width="168px" Enabled="False"></asp:TextBox>
        <br />
        <br />
        <strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;User</strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtUs" runat="server" Width="168px" Enabled="False"></asp:TextBox>
        <br />
        <br />
        <strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Password</strong>&nbsp;
        <asp:TextBox ID="txtPa" runat="server" Width="168px" Enabled="False"></asp:TextBox>
        <br />
        <br />
        <strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Estado&nbsp;</strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:TextBox ID="txtEs" runat="server" Width="169px" Enabled="False"></asp:TextBox>
&nbsp;&nbsp;
        <br />
        <br />
        <strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Persona</strong>&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtPe" runat="server" Width="170px" Enabled="False"></asp:TextBox>
        <br />
        <br />
        <strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Rol&nbsp;</strong>&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtRol" runat="server" Width="171px" Enabled="False"></asp:TextBox>
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
            <asp:BoundField DataField="CODUSU" HeaderText="Codigo" />
            <asp:BoundField DataField="NICKUSU" HeaderText="Usuario" />
            <asp:BoundField DataField="PASSUSU" HeaderText="Password" />
            <asp:BoundField DataField="ESTUSU" HeaderText="Estado" />
            <asp:BoundField DataField="CODPER" HeaderText="Cod Persona" />
            <asp:BoundField DataField="CODROL" HeaderText="Cod Rol" />
            <asp:CommandField ButtonType="Button" ShowSelectButton="True" />
        </Columns>
    </asp:GridView>
        </center>
             <br />
             <br />
</asp:Content>
