<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Alterar.aspx.cs" Inherits="EntityFrameworkExample.Alterar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>
        Alterar Usuário.
    </h2>    
    <p>
        <asp:HiddenField ID="hiddenId" runat="server" />
        Nome: <asp:TextBox ID="txtNome" runat="server"></asp:TextBox><br />
        Sobrenome: <asp:TextBox ID="txtSobrenome" runat="server"></asp:TextBox><br />
        Ativo: <asp:CheckBox ID="chkAtivo" runat="server"></asp:CheckBox>
    </p>
    <p>
        <asp:Button ID="btnSubmit" runat="server" Text="Salvar" onclick="btnSubmit_Click" />        
    </p>
</asp:Content>
