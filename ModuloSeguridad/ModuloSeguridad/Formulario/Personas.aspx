<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Personas.aspx.cs" Inherits="ModuloSeguridad.Formulario.Personas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
<center>
    <asp:Label ID="Label1" runat="server" style="color: #FF0000; " Text="Label" Visible="False"></asp:Label>
    <br />
    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>COD</strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txtCo" runat="server" Width="168px" Enabled="False"></asp:TextBox>
    <br />
    <br /><strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Nombre</strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtNo" runat="server" Width="168px" Enabled="False"></asp:TextBox>
    <br />
    <br /><strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Apellido&nbsp;</strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtAp" runat="server" Width="169px" Enabled="False"></asp:TextBox>
&nbsp;&nbsp;
        <br />
    <br /><strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Cedula</strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtCe" runat="server" Width="170px" Enabled="False"></asp:TextBox>
    <br />
    <br /><strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Telefono&nbsp;</strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtTe" runat="server" Width="171px" Enabled="False" EnableTheming="True"></asp:TextBox>
    <br />
    <br /><strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Direccion</strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtDi" runat="server" Width="169px" Enabled="False"></asp:TextBox>
    <br />
    <br /><strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Parroquia</strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtPa" runat="server" Width="169px" Enabled="False"></asp:TextBox>
    <br />
    <br />
    <asp:Button ID="btnNuevo" runat="server" Text="Nuevo" OnClick="bntNuevo_Click" />
                    &nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btnGuardar" runat="server" Text="Guardar" OnClick="btnGuardar_Click" />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" OnClick="btnEliminar_Click" Enabled="False" />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btnModificar" runat="server" Text="Modificar" OnClick="btnModificar_Click" />
                  &nbsp;<br />
    <br />
    <asp:CheckBox ID="chkMostrar" runat="server" AutoPostBack="True"  Text="Mostrar Registros" OnCheckedChanged="chkMostrar_CheckedChanged" />
    <br />
    <asp:GridView ID="gvDatos1" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanged="gvDatos1_SelectedIndexChanged1">
        <Columns>
            <asp:BoundField DataField="CODPER" HeaderText="Codigo" />
            <asp:BoundField DataField="NOMPER" HeaderText="Nombre" />
            <asp:BoundField DataField="APEPER" HeaderText="Apellido" />
            <asp:BoundField DataField="CEDPER" HeaderText="Cedula" />
            <asp:BoundField DataField="TELPER" HeaderText="Telefono" />
            <asp:BoundField DataField="DIRPER" HeaderText="Direccion" />
            <asp:BoundField DataField="IDPA" HeaderText="Cod Parroquia" />
            <asp:CommandField ButtonType="Button" ShowSelectButton="True" />
        </Columns>
    </asp:GridView>
</center>
</asp:Content>