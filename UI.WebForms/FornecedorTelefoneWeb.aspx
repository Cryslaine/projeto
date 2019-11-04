<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="FornecedorTelefoneWeb.aspx.cs" Inherits="UI.WebForms.TelefoneFornecedorWeb" %>

<asp:Content ID="Content1" ContentPlaceHolderID="header" runat="server">
    <style>
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

        #endereco {
            top: 200px;
            background-color: #555
        }
    </style>
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <div id="mySidenav" class="sidenav">
        <a href="#" id="cadastro">Cadastro Fornecedor</a>
        <a href="FornecedorEnderecoWeb.aspx" id="endereco">Endereço Fornecedor</a>
        


    </div>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="content" runat="server">

    <asp:Button ID="btnCancelarTel" runat="server" Style="z-index: 1; left: 581px; top: 280px; position: absolute; height: 30px;" Text="Cancelar" OnClick="btnCancelarTel_Click" Font-Names="Arial Black" />
    <asp:Button ID="btnEditarTel" runat="server" Style="z-index: 1; left: 488px; top: 280px; position: absolute; height: 30px;" Text="Editar" OnClick="btnEditarTel_Click" Font-Names="Arial Black" />
    <asp:Button ID="btnSalvarTel" runat="server" Style="z-index: 1; left: 391px; top: 280px; position: absolute; height: 30px;" Text="Salvar" OnClick="btnSalvarTel_Click" Font-Bold="True" Font-Names="Arial Black" />
    <asp:TextBox ID="txtTelefone" runat="server" Style="z-index: 1; left: 670px; top: 210px; height: 30px;position: absolute" TabIndex="7" BorderStyle="Inset" MaxLength="11" TextMode="Phone" AutoCompleteType="HomePhone"></asp:TextBox>
    <asp:TextBox ID="txtIdTel" runat="server" Style="z-index: 1; left: 171px; top: 196px;height: 30px; position: absolute; width: 31px; height: 17px;" Enabled="False" TabIndex="4" Visible="False" BorderStyle="Inset" MaxLength="10"></asp:TextBox>
    <asp:DropDownList ID="ddlFornecedoTel" runat="server" Style="z-index: 1; left: 450px; top: 210px;height: 30px; position: absolute" AppendDataBoundItems="True" CausesValidation="True" TabIndex="6" Font-Bold="True">
    </asp:DropDownList>
    <asp:DropDownList ID="ddlTipo" runat="server" Style="z-index: 1; left: 275px; top: 210px; height: 30px; position: absolute" TabIndex="5" Font-Bold="True">
    </asp:DropDownList>
    <asp:Label ID="Fornecedor" runat="server" Style="z-index: 1; left: 450px; top: 180px; position: absolute; height: 19px;" Text="Fornecedor:" Font-Bold="True" Font-Names="Arial" ForeColor="#0000CC"></asp:Label>
    <asp:Label ID="lbIdTel" runat="server" Style="z-index: 1; left: 172px; top: 168px; position: absolute;" Text="Id Telef:" Font-Bold="True" Font-Names="Arial" ForeColor="#0000CC" Visible="False"></asp:Label>
    <asp:Label ID="LbTelefone" runat="server" Style="z-index: 1; left: 670px; top: 180px; position: absolute" Text="Telefone:" Font-Bold="True" Font-Names="Arial" ForeColor="#0000CC"></asp:Label>
    <asp:Label ID="LbFTipo" runat="server" Style="z-index: 1; left: 275px; top: 180px; position: absolute; height: 19px; width: 50px;" Text="Tipo:" Font-Bold="True" Font-Names="Arial" ForeColor="#0000CC"></asp:Label>
    <asp:Label ID="LbFornCadastro" runat="server" BackColor="#CCCCCC" BorderColor="Black" Font-Bold="True" Font-Italic="True" Font-Names="Georgia" Style="z-index: 1; left: 275px; top: 120px; position: absolute; width: 187px; height: 18px" Text="Telefones Fornecedor"></asp:Label>
    <asp:GridView ID="gvTelefoneFornecedor" runat="server" BackColor="White" BorderColor="#999999" BorderStyle="None"
        BorderWidth="1px" CellPadding="3" GridLines="Vertical" Style="z-index: 1; left: 275px; top: 320px; position: absolute; width: 606px" AllowPaging="True" DataKeyNames="Id" PageSize="3" OnRowDeleting="gvTelefoneFornecedor_RowDeleting1" OnRowEditing="gvTelefoneFornecedor_RowEditing2" OnPageIndexChanging="gvTelefoneFornecedor_PageIndexChanging">

        <AlternatingRowStyle BackColor="#DCDCDC" />
        <Columns>
            <asp:BoundField HeaderText="ID" Visible="False" DataFormatString="IdFornecedor" ReadOnly="True" />
            <asp:BoundField HeaderText="Fornecedor" Visible="False" DataFormatString="Fornecedor" ReadOnly="True" />
            <asp:BoundField HeaderText="Telefone" Visible="False" DataFormatString="Telefone" ReadOnly="True" />
            <asp:BoundField HeaderText="Tipo Telefone" Visible="False" DataFormatString="Descricao" ReadOnly="True" />
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
