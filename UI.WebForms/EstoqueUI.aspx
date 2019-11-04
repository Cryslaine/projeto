<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="UI.WebForms.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Menu ID="Menu1" runat="server" style="z-index: 1; left: 10px; top: 34px; position: absolute; height: 95px; width: 40px">
            <Items>
                <asp:MenuItem Text="Empresa" Value="Empresa"></asp:MenuItem>
                <asp:MenuItem Text="Fornecedor" Value="Fornecedor"></asp:MenuItem>
                <asp:MenuItem Text="Produto" Value="Produto"></asp:MenuItem>
                <asp:MenuItem Text="Nota Fiscal" Value="Nota Fiscal"></asp:MenuItem>
            </Items>
        </asp:Menu>
    </form>
</body>
</html>
