<%@ Page Title="" Language="C#" MasterPageFile="~/masterPage.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="bikezone.login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <p>
    Utilizador:<asp:TextBox ID="tb_utilizador" runat="server"></asp:TextBox>
</p>
<p>
    &nbsp;</p>
<p>
    Palavra-passe:<asp:TextBox ID="tb_palavraPasse" runat="server" TextMode="Password"></asp:TextBox>
</p>
<p>
    &nbsp;</p>
<asp:Button ID="btn_enviar" runat="server" OnClick="btn_enviar_Click" Text="Enviar" />
<br />
<br />
<p>
    <asp:Label ID="lbl_mensagem" runat="server" ForeColor="Red" Text="Erro! Utilizador ou PW Incorretos" Visible="False"></asp:Label>
    <br />
</p>
<p>
</p>



</asp:Content>
