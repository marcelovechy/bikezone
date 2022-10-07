<%@ Page Title="" Language="C#" MasterPageFile="~/masterPage.Master" AutoEventWireup="true" CodeBehind="loja.aspx.cs" Inherits="bikezone.loja" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


            Nome:<asp:TextBox ID="tb_nome" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="tb_nome" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
            <br />
            <br />
            Morada:<asp:TextBox ID="tb_morada" runat="server" TextMode="MultiLine"></asp:TextBox>
            <br />
            <br />
            Email:<asp:TextBox ID="tb_email" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="tb_email" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="tb_email" ErrorMessage="*" ForeColor="Lime" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
            <br />
            <br />
            Código Postal:<asp:TextBox ID="tb_codigoPostal" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="tb_codigoPostal" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="tb_codigoPostal" ErrorMessage="*" ForeColor="#00CC00" ValidationExpression="^\d{4}(-\d{3})?$"></asp:RegularExpressionValidator>
            <br />
            <br />
            Data de Nascimento:<asp:TextBox ID="tb_data" runat="server" TextMode="Date"></asp:TextBox>
            <br />
            <br />
            Genero:<br />
            <asp:CheckBoxList ID="cbl_genero" runat="server" AutoPostBack="True" OnSelectedIndexChanged="cbl_genero_SelectedIndexChanged">
                <asp:ListItem>Feminino</asp:ListItem>
                <asp:ListItem>Masculino</asp:ListItem>
            </asp:CheckBoxList>
            <br />
            Tipo de Artigo:
            <asp:DropDownList ID="ddl_tipoArtigo" runat="server" AutoPostBack="True" OnSelectedIndexChanged="dll_tipoArtigo_SelectedIndexChanged">
                <asp:ListItem>---</asp:ListItem>
                <asp:ListItem>BTT</asp:ListItem>
                <asp:ListItem>BMX</asp:ListItem>
                <asp:ListItem>Elétricas</asp:ListItem>
                <asp:ListItem>Trotinetes</asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            <br />
            Marca de Bicicleta:
            
            <asp:DropDownList ID="ddl_marca" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddl_marca_SelectedIndexChanged">
            </asp:DropDownList>
            
            <br />
            <br />
            <br />
            Modelo de Bicicleta: <asp:DropDownList ID="ddl_bike" runat="server">
            </asp:DropDownList>
            <br />
            <br />
            <asp:Button ID="btn_enviar1" runat="server" OnClick="btn_enviar1_Click" Text="Enviar" />
            <br />
                    






</asp:Content>
