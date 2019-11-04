<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="EmpresaTelefoneWeb.aspx.cs" Inherits="UI.WebForms.EmpresaTelefoneWeb" %>
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
            border-radius: 0 5px 5px 0;
        }

        #about {
            top: 20px;
            background-color: #4CAF50;
        }

        #blog {
            top: 80px;
            background-color: #2196F3;
        }

        #projects {
            top: 140px;
            background-color: #f44336;
        }

        #contact {
            top: 200px;
            background-color: #555
        }
    </style>
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <div id="mySidenav" class="sidenav">
        <a href="Empresa.aspx" id="about">Cadastro Empresa</a>
       
    </div>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="content" runat="server">
    <p>
        <asp:Label ID="LbCamposTel" runat="server" style="z-index: 1; left: 219px; top: 484px; position: absolute; width: 203px" Text="Telefones Empresa" BackColor="#CCCCCC" BorderColor="Black" Font-Bold="True" Font-Italic="True" Font-Names="Georgia"></asp:Label>
        <asp:GridView ID="gvTelefoneEmpresa" runat="server" AllowPaging="True" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" DataKeyNames="Id" GridLines="Vertical" OnRowDeleting="gvTelefoneEmpresa_RowDeleting" OnRowEditing="gvTelefoneEmpresa_RowEditing" PageSize="5" style="z-index: 1; left: 259px; top: 915px; position: absolute; height: 133px; width: 542px" OnPageIndexChanging="gvTelefoneEmpresa_PageIndexChanging">
            <AlternatingRowStyle BackColor="#DCDCDC" />
            <Columns>
                <asp:BoundField DataFormatString="IdEmpresa" HeaderText="ID" Visible="False" ReadOnly="true" />
                <asp:BoundField DataFormatString="Descricao" HeaderText="Tipo Telefone" Visible="False" ReadOnly="true" />
                <asp:BoundField DataFormatString="Telefone" HeaderText="Número" Visible="False" ReadOnly="true" />
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
        <asp:Label ID="LbTipo" runat="server" style="z-index: 1; left: 351px; top: 784px; position: absolute; height: 18px;" Text="Tipo: " Font-Bold="True" Font-Names="Arial" ForeColor="#0000CC"></asp:Label>
        <asp:Label ID="LbIdTelefone" runat="server" style="z-index: 1; left: 211px; top: 770px; position: absolute; height: 22px;" Text="IdTelefone" Visible="False" Font-Bold="True" Font-Names="Arial" ForeColor="#0000CC"></asp:Label>
        <asp:TextBox ID="txtIdEmpresa" runat="server" style="z-index: 1; left: 206px; top: 800px; position: absolute; width: 51px; height: 15px" TabIndex="11" Visible="False" MaxLength="10"></asp:TextBox>
        <asp:DropDownList ID="ddlTipo" runat="server" AppendDataBoundItems="True" style="z-index: 1; left: 346px; top: 816px; position: absolute" TabIndex="12" Font-Bold="True">
        </asp:DropDownList>
        <asp:Label ID="LbNumero" runat="server" style="z-index: 1; left: 515px; top: 784px; position: absolute; width: 76px;" Text="Telefone :" Font-Bold="True" Font-Names="Arial" ForeColor="#0000CC"></asp:Label>
        <asp:TextBox ID="txtNumeroTelefone" runat="server" style="z-index: 1; left: 509px; top: 817px; position: absolute" TabIndex="13" MaxLength="11"></asp:TextBox>
        <asp:Button ID="btnEditarTelefone" runat="server" OnClick="btnEditarTelefone_Click" style="z-index: 1; left: 499px; top: 866px; position: absolute; height: 26px;" Text="Editar" Font-Names="Arial Black" />
        <asp:Button ID="btnCancelarTelefone" runat="server" OnClick="btnCancelarTelefone_Click" style="z-index: 1; left: 585px; top: 872px; position: absolute; height: 25px;" Text="Cancelar" Font-Names="Arial Black" />
        <asp:Button ID="btnSalvarTelefone" runat="server" OnClick="btnSalvarTelefone_Click" style="z-index: 1; left: 402px; top: 867px; position: absolute" Text="Salvar" Font-Names="Arial Black" />
        <asp:Label ID="LbId" runat="server" Style="z-index: 1; left: 337px; top: 203px; position: absolute" Text="Id" Visible="False" Font-Bold="True" Font-Names="Arial" ForeColor="#0000CC"></asp:Label>
            <asp:TextBox ID="txtId" runat="server" Style="z-index: 1; left: 364px; top: 204px; position: absolute; height: 14px; width: 34px" Visible="False" BorderStyle="Solid" MaxLength="10"></asp:TextBox>
        
    </p>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footer" runat="server">
</asp:Content>
