<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="NotaFiscalWeb.aspx.cs" Inherits="UI.WebForms.NotaFiscalWeb" %>

<asp:Content ID="Content1" ContentPlaceHolderID="header" runat="server">
    <style>
     

        #mySidenav a {
            position: relative;
            left: 555px;
            top:125px;
            transition: 0.3s;
            padding: 15px;
            width: 100px;
            text-decoration: none;
            font-size: 20px;
            color: white;
            border-radius: 5px 5px 5px 5px;
        }

        #item {
            top: 20px;
            background-color: #4CAF50;
        }

    </style>
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <div id="mySidenav" class="sidenav">
        <a href="ItemNotaFiscalWeb.aspx" id="item">Item da Nota</a>
        
    </div>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="content" runat="server">
  

    <p style="margin-top: -1000px;">
        <br />
        <asp:Label ID="LbNotaFiscal" runat="server" Style="z-index: 1; left: 270px; top: 125px; position: absolute; width: 180px;" Text="Cadastro Nota Fiscal" Font-Bold="True" Font-Names="Georgia"></asp:Label>
        <asp:Label ID="LbPesquisa" runat="server" Style="z-index: 1; left: 425px; top: 180px; position: absolute; height: 18px;" Text="Pesquisa:" Font-Bold="True" Font-Italic="True" Font-Names="Arial" ForeColor="#0000CC"></asp:Label>
        <asp:TextBox ID="txtPesquias" runat="server" Style="z-index: 1; left: 510px; top: 180px; position: absolute; height: 30px; width: 188px;" MaxLength="14" BorderStyle="Solid"></asp:TextBox>
        <asp:TextBox ID="txtId" runat="server" Style="z-index: 1; left: 202px; top: 186px; position: absolute; width: 36px" Visible="False" MaxLength="10"></asp:TextBox>
        <asp:Button ID="btnPesquisa" runat="server" OnClick="btnPesquisa_Click" Style="z-index: 1; left: 710px; top: 180px;height:30px; position: absolute" Text="Pesquisa" Font-Names="Arial Black" />
        <asp:Label ID="LbId" runat="server" Style="z-index: 1; left: 168px; top: 185px; position: absolute" Text="Id :" Visible="False" Font-Bold="True" Font-Italic="True" Font-Names="Arial" ForeColor="#0000CC"></asp:Label>
        <asp:Label ID="LbNumero" runat="server" Style="z-index: 1; left: 270px; top: 250px; position: absolute" Text="Número:" Font-Bold="True" Font-Italic="True" Font-Names="Arial" ForeColor="#0000CC"></asp:Label>
        <asp:Label ID="LbProduto" runat="server" Style="z-index: 1; left: 490px; top: 250px; position: absolute" Text="Produto:" ForeColor="#0000CC" Font-Bold="True" Font-Names="Arial"></asp:Label>
        <asp:Label ID="LbValor" runat="server" Style="z-index: 1; left: 270px; top: 350px; position: absolute; height: 21px;" Text="Valor:" Font-Bold="True" Font-Italic="True" Font-Names="Arial" ForeColor="#0000CC"></asp:Label>
        <asp:Label ID="LbRazaoSocial" runat="server" Style="z-index: 1; left: 490px; top: 350px; position: absolute; height: 17px" Text="Razão Social:" Font-Bold="True" Font-Italic="True" Font-Names="Arial" ForeColor="#0000CC"></asp:Label>
        <asp:TextBox ID="txtNumeroDaNota" runat="server" Style="z-index: 1; left: 270px; top: 290px;height:30px; position: absolute" MaxLength="10" TextMode="Number" BorderStyle="Solid"></asp:TextBox>
        <asp:DropDownList ID="ddlProduto" runat="server" Style="z-index: 1; left: 490px; top: 290px; position: absolute; height: 31px;" Font-Bold="True">
        </asp:DropDownList>
        <asp:TextBox ID="txtValor" runat="server" Style="z-index: 1; left: 270px; top: 390px; height:30px;position: absolute" MaxLength="10" BorderStyle="Solid">R$</asp:TextBox>
        <asp:DropDownList ID="ddlRazaoSocial" runat="server" Style="z-index: 1; left: 490px; top: 390px; position: absolute; height: 31px;" Font-Bold="True">
        </asp:DropDownList>
        <asp:Button ID="btnSalvar" runat="server" OnClick="btnSalvar_Click" Style="z-index: 1; left: 400px; top: 450px;height:30px; position: absolute" Text="Salvar" Font-Names="Arial Black" />
        <asp:Button ID="btnEditar" runat="server" OnClick="btnEditar_Click" Style="z-index: 1; left: 490px; top: 450px;height:30px; position: absolute" Text="Editar" Font-Names="Arial Black" />
        <asp:Button ID="btnExclui" runat="server" OnClick="btnExclui_Click" Style="z-index: 1; left: 580px; top: 450px;height:30px; position: absolute" Text="Excluir" Font-Names="Arial Black" />
       
    </p>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footer" runat="server">
</asp:Content>
