<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CriarUsuario.aspx.cs" Inherits="EntityFrameworkExample.CriarUsuario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>
        Criar Usuário.
    </h2>    
    <p>
        Nome: <asp:TextBox ID="txtNome" runat="server"></asp:TextBox><br />
        Sobrenome: <asp:TextBox ID="txtSobrenome" runat="server"></asp:TextBox>
    </p>    
    <p>
        <asp:Button ID="btnSubmit" runat="server" Text="Salvar" onclick="btnSubmit_Click" />        
    </p>
</asp:Content>
