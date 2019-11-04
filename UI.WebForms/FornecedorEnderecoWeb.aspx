<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="FornecedorEnderecoWeb.aspx.cs" Inherits="UI.WebForms.FornecedorEnderecoWeb" %>

<asp:Content ID="Content1" ContentPlaceHolderID="header" runat="server">
    <style type="text/css">
        #mySidenav a {
            position: relative;
            left: 555px;
            top: 120px;
            transition: 0.3s;
            padding: 15px;
            width: 100px;
            text-decoration: none;
            font-size: 20px;
            color: white;
            border-radius: 5px 5px 5px 5px;
        }

        #telefone {
            top: 20px;
            background-color: #4CAF50;
        }


        #cadastro {
            top: 140px;
            background-color: #f44336;
        }

    </style>
     <meta name="viewport" content="width=device-width, initial-scale=1">
    <div id="mySidenav" class="sidenav">
        <a href="FornecedorWeb.aspx" id="cadastro">Cadastro Fornecedor</a>
        <a href="FornecedorTelefoneWeb.aspx" id="telefone">Telefone Fornecedor</a>
        
    </div> 
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="content" runat="server">
      <asp:Label ID="Label2" runat="server" BackColor="#CCCCCC" BorderColor="Black" Font-Bold="True" Font-Italic="True" Font-Names="Georgia" Style="z-index: 1; left: 270px; top: 125px; position: absolute; width: 188px; right: 548px;" Text="Endereço Fornecedor"></asp:Label>
    <asp:TextBox ID="txtIdEndereco" runat="server" Style="z-index: 1; left: 174px; top: 230px; position: absolute; width: 33px" Visible="False" BorderStyle="Inset" MaxLength="10"></asp:TextBox>
    <asp:Label ID="LbEndereco" runat="server" Style="z-index: 1; left: 270px; top: 230px; position: absolute" Text="Endereço:" Font-Bold="True" Font-Names="Arial" ForeColor="#0000CC"></asp:Label>
     <asp:TextBox ID="txtEndereco" runat="server" Style="z-index: 1; left: 270px; top: 250px; position: absolute; width: 226px" TabIndex="9" BorderStyle="Inset" MaxLength="30"></asp:TextBox>
     <asp:Label ID="LbIdEnd" runat="server" Style="z-index: 1; left: 174px; top: 195px; position: absolute; height: 21px; width: 61px" Text="Id End" Font-Bold="True" Font-Names="Arial" ForeColor="#0000CC" Visible="False"></asp:Label>
    <asp:Label ID="LbFornecedorEnd" runat="server" Style="z-index: 1; left: 270px; top: 170px; position: absolute" Text="Fornecedor:" Font-Bold="True" Font-Names="Arial" ForeColor="#0000CC"></asp:Label>
    <asp:DropDownList ID="ddlFornecedorEmpresa" runat="server" Style="z-index: 1; left: 270px; top: 200px; position: absolute" TabIndex="8" Font-Bold="True">
        </asp:DropDownList>
    <asp:Label ID="LbN" runat="server" Style="z-index: 1; left: 550px; top: 230px; position: absolute" Text="Nº" Font-Bold="False" Font-Names="Arial" ForeColor="#0000CC"></asp:Label>
        <asp:TextBox ID="txtCidade" runat="server" Style="z-index: 1; left: 270px; top: 310px; position: absolute; width: 198px" TabIndex="12" BorderStyle="Inset"></asp:TextBox>
     <asp:TextBox ID="txtNumero" runat="server" Style="z-index: 1; left: 550px; top: 250px; position: absolute; width: 44px; height: 19px;" TabIndex="10" BorderStyle="Inset" MaxLength="5"></asp:TextBox>
        <asp:TextBox ID="txtBairro" runat="server" Style="z-index: 1; left: 650px; top: 250px; position: absolute; width: 263px" TabIndex="11" BorderStyle="Inset" MaxLength="20"></asp:TextBox>
    <asp:TextBox ID="txtCep" runat="server" Style="z-index: 1; left: 650px; top: 310px; position: absolute; height: 16px" TabIndex="14" BorderStyle="Inset" MaxLength="9"></asp:TextBox>
        <asp:TextBox ID="txtComplemento" runat="server" Style="z-index: 1; left: 270px; top: 380px; position: absolute; width: 220px" TabIndex="15" BorderStyle="Inset" MaxLength="15"></asp:TextBox>
     <asp:Label ID="LbUf" runat="server" Style="z-index: 1; left: 550px; top: 285px; position: absolute" Text="UF:" Font-Bold="True" Font-Names="Arial" ForeColor="#0000CC"></asp:Label>
     <asp:Label ID="LbCep" runat="server" Style="z-index: 1; left: 650px; top: 285px; position: absolute" Text="CEP:" Font-Bold="True" Font-Names="Arial" ForeColor="#0000CC"></asp:Label>
        <asp:Label ID="LbCpmplemento" runat="server" Style="z-index: 1; left: 270px; top: 350px; position: absolute; width: 121px" Text="Complemento:" Font-Bold="True" Font-Names="Arial" ForeColor="#0000CC"></asp:Label>
        <asp:Label ID="LbCidade" runat="server" Style="z-index: 1; left: 270px; top: 285px; position: absolute; height: 23px; width: 48px" Text="Cidade" Font-Bold="True" Font-Names="Arial" ForeColor="#0000CC"></asp:Label>
    <asp:Label ID="LbBairro" runat="server" Style="z-index: 1; left: 650px; top: 230px; position: absolute" Text="Bairro:" Font-Bold="True" Font-Names="Arial" ForeColor="#0000CC"></asp:Label>
     <asp:TextBox ID="txtUf" runat="server" Style="z-index: 1; left: 550px; top: 310px; position: absolute; width: 43px; height: 19px;" TabIndex="13" BorderStyle="Inset" MaxLength="2"></asp:TextBox>
    <asp:Button ID="btnSalvarEndereco" runat="server" OnClick="txtSalvarEndereco_Click" Style="z-index: 1; left: 541px; top: 400px; position: absolute; height: 28px;" Text="Salvar" Font-Names="Arial Black" />
        <asp:Button ID="btnEditarEndereco" runat="server" OnClick="btnEditarEndereco_Click" Style="z-index: 1; left: 651px; top: 400px; position: absolute" Text="Editar" Font-Names="Arial Black" />
    <asp:Button ID="btnCancelarEndereco" runat="server" OnClick="btnCancelarEndereco_Click" Style="z-index: 1; left: 746px; top: 400px; position: absolute" Text="Cancelar" Font-Names="Arial Black" />
    <asp:GridView ID="gvEnderecoFornecedor" runat="server" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Vertical" Style="z-index: 1; left: 230px; top: 450px; position: absolute; height: 133px; width: 813px" AllowPaging="True" DataKeyNames="Id" OnRowEditing="gvEnderecoFornecedor_RowEditing" OnRowDeleting="gvEnderecoFornecedor_RowDeleting" PageSize="5" OnPageIndexChanging="gvEnderecoFornecedor_PageIndexChanging">
        <AlternatingRowStyle BackColor="#DCDCDC" />
            <Columns>
                <asp:BoundField DataFormatString="Id" HeaderText="ID" Visible="False" ReadOnly="True" />
                <asp:BoundField DataFormatString="IdFornecedor" HeaderText="Id Forncedor" Visible="False" ReadOnly="True" />
                <asp:BoundField DataFormatString="Endereco" HeaderText="Endereço" Visible="False" ReadOnly="True" />
                <asp:BoundField DataFormatString="Numero" HeaderText="Nº" Visible="False" ReadOnly="True" />
                <asp:BoundField DataFormatString="Bairro" HeaderText="Bairro" Visible="False" ReadOnly="True" />
                <asp:BoundField DataFormatString="Cidade" HeaderText="Cidade" Visible="False" ReadOnly="True" />
                <asp:BoundField DataFormatString="UF" HeaderText="UF" Visible="False" ReadOnly="True" />
                <asp:BoundField DataFormatString="CEP" HeaderText="CEP" Visible="False" ReadOnly="True" />
                <asp:BoundField DataFormatString="Complemento" HeaderText="Complemento" Visible="False" ReadOnly="True" />
                <asp:ButtonField ButtonType="Button" CommandName="Edit" Text="Editar" />
                <asp:ButtonField ButtonType="Button" CommandName="Delete" Text="Excluir" />
            </Columns>
            <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
            <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
            <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
            <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#0000A9" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#000065" />
        </asp:GridView>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footer" runat="server">
</asp:Content>
