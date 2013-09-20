<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="EntityFrameworkExample._Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>
        Listando todos os usuários.
    </h2>
        <fieldset>
            <legend>Filtro</legend>   
            Nome: <asp:TextBox ID="txtFiltroNome" runat="server"></asp:TextBox>
            <asp:Button ID="btnFiltrarNome" runat="server" Text="Filtrar Nome" 
                onclick="btnFiltrarNome_Click"/><br />
            Ativo: <asp:Button ID="btnFiltrarAtivo" runat="server" Text="Somente Ativos" 
                onclick="btnFiltrarAtivo_Click"/>
        </fieldset>
    </p>    
    <p>
        <asp:GridView ID="usuariosGrid" runat="server"
            DataKeyNames="Id"            
            onrowdeleting="usuariosGrid_RowDeleting"
            Width="500">
            <Columns>                
                <asp:CommandField ShowDeleteButton="True" />                
                <asp:HyperLinkField DataNavigateUrlFields="Id" 
                    DataNavigateUrlFormatString="Alterar.aspx?id={0}" Text="Alterar" />
            </Columns>
        </asp:GridView>
    </p>
</asp:Content>
