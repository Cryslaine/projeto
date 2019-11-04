<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Header.ascx.cs" Inherits="UI.WebForms.ascx.Header" %>
<asp:Menu ID="Menu1" runat="server" BackColor="#B5C7DE" DynamicHorizontalOffset="2" Font-Names="Verdana" Font-Size="0.8em" ForeColor="#284E98" StaticSubMenuIndent="10px">
    <DynamicHoverStyle BackColor="#284E98" ForeColor="White" />
    <DynamicMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
    <DynamicMenuStyle BackColor="#B5C7DE" />
    <DynamicSelectedStyle BackColor="#507CD1" />
    <Items>
        <asp:MenuItem Text="Empresa" Value="Empresa">
            <asp:MenuItem Text="Cadastro" Value="Cadastro"></asp:MenuItem>
        </asp:MenuItem>
        <asp:MenuItem Text="Fornecedor" Value="Fornecedor">
            <asp:MenuItem Text="Cadastro" Value="Cadastro"></asp:MenuItem>
        </asp:MenuItem>
        <asp:MenuItem Text="Produto" Value="Produto">
            <asp:MenuItem Text="Cadastro" Value="Cadastro"></asp:MenuItem>
        </asp:MenuItem>
        <asp:MenuItem Text="Nota Fiscal" Value="Nota Fiscal">
            <asp:MenuItem Text="Cadastro" Value="Cadastro"></asp:MenuItem>
        </asp:MenuItem>
    </Items>
    <StaticHoverStyle BackColor="#284E98" ForeColor="White" />
    <StaticMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
    <StaticSelectedStyle BackColor="#507CD1" />
</asp:Menu>
