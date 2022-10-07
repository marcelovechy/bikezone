<%@ Page Title="" Language="C#" MasterPageFile="~/masterPage.Master" AutoEventWireup="true" CodeBehind="final.aspx.cs" Inherits="bikezone.final" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">






    <p>
    <asp:Label ID="lbl_nome" runat="server" Text="Label"></asp:Label>
</p>
<p>
    <asp:Label ID="lbl_morada" runat="server" Text="Label"></asp:Label>
</p>
<p>
    <asp:Label ID="lbl_email" runat="server" Text="Label"></asp:Label>
</p>
<p>
    <asp:Label ID="lbl_codigoPostal" runat="server" Text="Label"></asp:Label>
</p>
<p>
    <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>
</p>
<p>
    <asp:Label ID="lbl_dataNascimento" runat="server" Text="Label"></asp:Label>
</p>
<p>
    <asp:Label ID="lbl_genero" runat="server" Text="Label"></asp:Label>
</p>
<p>
    <asp:Label ID="lbl_produtos" runat="server" Text="Label"></asp:Label>
</p>
<p>
    <asp:Button ID="btn_pdf" runat="server" OnClick="btn_pdf_Click" Text="PDF" />
&nbsp;<asp:Button ID="btn_excel" runat="server" Text="EXCEL" />
    <asp:Button ID="btn_pdfemail" runat="server" OnClick="btn_pdfemail_Click" style="height: 26px" Text="enviar PDF com email" />
</p>
    <p>
    <asp:Label ID="lbl_mensagem" runat="server" Text="Label"></asp:Label>
        &nbsp;<br />
</p>






</asp:Content>
