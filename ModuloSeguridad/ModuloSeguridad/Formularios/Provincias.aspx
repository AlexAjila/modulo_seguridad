<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Provincias.aspx.cs" Inherits="ModuloSeguridad.Formularios.Provincias" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
     <style>
                nav {
                    display: block;
                    text-align: center;
                }
                nav ul {
                        margin: 0;
                        padding: 0;
                        list-style: none;
                }

                .nav a {
                    display: block;
                    background: #111;
                    color: #fff;
                    text-decoration: none;
                    padding: .8em 1.8em;
                    text-transform: uppercase;
                    font-size: 80%; letter-spacing: 2px;
                    text-shadow: 0 -1px 0 #000;
                    position: relative;
                }

            .nav {
                vertical-align: top;
                display: inline-block;
                box-shadow: 1px -1px -px 1px #000, -1px 1px -1px 1px #fff, 0 0 6px 3px #fff;
                border-radius: 6px;
            }
            .nav li {
                position: relative;
            }
            .nav > li {
                float: left;
                border-bottom: 4px #aaa solid;
                margin-right: 1px;
            }
            .nav > li > a{
                margin-bottom: 1px;
                box-shadow: inset 0 2em .33em -.5em #555;
            }
            .nav > li:hover, .nav > li:hover > a {
                border-bottom-color: orange;
            }
            .nav li:hover > a {
                color: orange;
            }           
            .nav > li:first-child {
                border-radius: 4px 0 0 4px;
            }
            .nav > li:first-child > a {
                border-radius: 4px 0 0 0;
            }
            .nav > li:last-child {
                border-radius: 0 0 4px 0;
                margin-right: 0;
            }
            .nav > li:last-child > a {
                border-radius: 0 4px 0 0;
            }
            .nav li li a{
                margin-top: 1px;
            }
            .nav li a:first-child:nth-last-child(2):before{
                content:"";
                position: absolute;
                height: 0;
                width: 0;
                border: 5px solid transparent;
                top: 5px;
                right: 5px;
            }

            .nav ul{
                position: absolute;
                white-space: nowrap;
                border-bottom: 5px solid orange;
                z-index: 1;
                left: -99999em;
            }
            .nav > li:hover >ul{
                left: auto;
                padding-top: 5px;
                min-width: 100%;
            }
            .nav > li li ul{
                border-left: 1px solid #fff;
            }
            .nav > li li:hover > ul{
                left: 100%;
                top: -1px;
            }
            .nav > li > a:first-child:nth-last-child(2):before{
                border-top-color: #aaa;
            }
            .nav > li:hover > a:first-child:nth-last-child(2):before{
                border: 5px solid transparent;
                border-bottom-color: orange;
                margin-top: -5px
            }
            .nav li li > a:first-child:nth-last-child(2):before{
                border-left-color: #aaa;
                margin-top: -5px;
            }
            .nav li li:hover > a:first-child:nth-last-child(2):before{
                border: 5px solid transparent;
                border-right-color: orange;
                right: 10px;
            }
            </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
         <nav>
                        <div>
                            <asp:Image ID="Image1" runat="server" Height="181px" Width="802px" ImageUrl="~/Imagenes/im.jpg" />
                         </div>
                        <ul class="nav">
                            <li><a href="#">Inicio</a></li>
                            <li><a href="#">Datos</a>
                            <ul>
                                <li><a href="/Formularios/Personas.aspx">Registro Personas</a></li>
                            </ul>
                            </li>
                            <li><a href="#">Configuracion</a> 
                                <ul>
                                    <li><a href="#">Usuario</a></li>
                                    <li><a href="#">Roles</a>
                                        <ul>
                                            <li><a href="#">Registro Rol</a></li>
                                        </ul>
                                    </li>
                                </ul>
                            </li>
                            <li><a href="#">Regionalidad</a>
                                <ul>
                                    <li><a href="#">Registro de Provincias</a></li>
                                    <li><a href="#">Registro de Canton</a></li>
                                    <li><a href="#">Registro de Parroquia</a></li>
                                </ul>
                            </li>
                            <li><a href="#">contactos</a></li>
                        </ul>
                        <br />
                        <br />
             <asp:TextBox ID="txtCo" runat="server" Width="168px" Visible="False"></asp:TextBox>
              <center><asp:Label ID="Label1" runat="server" style="color: #FF0000; " Text="Label" Visible="False"></asp:Label>
        <br />
        <br />
        <strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Codigo</strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtCod" runat="server" Width="168px"></asp:TextBox>
        <br />
        <br />
        <strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Nombre&nbsp;</strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtNo" runat="server" Width="169px"></asp:TextBox>
&nbsp;&nbsp;
        <br />
        <br />
                    <asp:Button ID="btnNuevo" runat="server" Text="Nuevo" OnClick="bntNuevo_Click" />
                    &nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btnGuardar" runat="server" Text="Guardar" OnClick="btnGuardar_Click" />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" OnClick="btnEliminar_Click" />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btnModificar" runat="server" Text="Modificar" OnClick="btnModificar_Click" />
        </center>
             <br />
             <br />
            <div>
                <font size="6">AJAM COMPANY DERECHOS RESERVADOS</font>
            </div>
            COPYPRINT 2017
          </nav>
    </div>
    </form>
</body>
</html>
