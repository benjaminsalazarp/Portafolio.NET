<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EnvioEmail.aspx.cs" Inherits="WebOnT.EnvioEmail" %>

<form id="form1" runat="server">
    Email :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="txtEmail" runat="server" Width="173px" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
    <br />
    Nombre:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
    <br />
    Apellido Paterno:&nbsp;&nbsp;
    <asp:TextBox ID="txtApellidoP" runat="server"></asp:TextBox>
    <br />
    Apellido Materno:&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txtApellidoM" runat="server"></asp:TextBox>
    <br />
    Rut:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txtRut" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
    <br />
    Fono:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txtFono" runat="server"></asp:TextBox>
    <br />
    Colegio:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txtColegio" runat="server"></asp:TextBox>
    <br />
    Curso :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txtCurso" runat="server"></asp:TextBox>
    <br />
    <br />
    <br />
    <asp:Button ID="btnEnviar" runat="server" OnClick="btnEnviar_Click" Text="Enviar" />
    <br />
    </form>


