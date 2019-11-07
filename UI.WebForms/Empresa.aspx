<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Empresa.aspx.cs" Inherits="UI.WebForms.Empresa" %>

<asp:Content ID="Content1" ContentPlaceHolderID="header" runat="server">
    <style>
        #mySidenav a {
            position: relative;
            left: 555px;
            top: 125px;
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
        <a href="EmpresaTelefoneWeb.aspx" id="about">Telefones Empresa</a>
       
    </div>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="content" runat="server">
    <div>
        <!--<p style="height: 855px; margin-left: 400px;">-->
        <p>
           
            <asp:Label ID="LbCnpjPesquisa" runat="server" Style="z-index: 1; left: 603px; top: 196px; position: absolute" Text="Pesquisa:" Font-Bold="True" Font-Names="Arial" ForeColor="#0000CC"></asp:Label>
            <asp:Label ID="LbId" runat="server" Style="z-index: 1; left: 337px; top: 203px; position: absolute" Text="Id" Visible="False" Font-Bold="True" Font-Names="Arial" ForeColor="#0000CC"></asp:Label>
            <asp:TextBox ID="txtId" runat="server" Style="z-index: 1; left: 364px; top: 204px; position: absolute; height: 14px; width: 34px" Visible="False" BorderStyle="Solid" MaxLength="10"></asp:TextBox>
            <asp:Label ID="LbRazaoSocial" runat="server" Style="z-index: 1; left: 240px; top: 288px; position: absolute; margin-bottom: 0px;" Text="Razão Social:" Font-Bold="True" Font-Names="Arial" ForeColor="#0000CC"></asp:Label>
            <asp:TextBox ID="txtRazaoSocial" runat="server" Style="z-index: 1; left: 237px; top: 325px; position: absolute; width: 427px; height: 30px;" TabIndex="1" BorderStyle="Solid" MaxLength="50"></asp:TextBox>
            <asp:Label ID="LbNomeFantasia" runat="server" Style="z-index: 1; left: 698px; top: 291px; position: absolute" Text="NomeFantasia" Font-Bold="True" Font-Names="Arial" ForeColor="#0000CC"></asp:Label>
            <asp:TextBox ID="txtNomeFantasia" runat="server" Style="z-index: 1; left: 695px; top: 320px; position: absolute; width: 314px; height: 30px;" TabIndex="2" BorderStyle="Solid" MaxLength="50"></asp:TextBox>
            <asp:TextBox ID="txtCnpjPesquia" runat="server" Style="z-index: 1; left: 602px; top: 226px;height:30px; position: absolute; width: 161px;" BorderStyle="Solid" MaxLength="14"></asp:TextBox>
            <asp:Label ID="LbCnpj" runat="server" Style="z-index: 1; left: 244px; top: 376px; position: absolute; height: 19px;" Text="CNPJ:" Font-Bold="True" Font-Names="Arial" ForeColor="#0000CC"></asp:Label>
            <asp:TextBox ID="txtCnpj" runat="server" Style="z-index: 1; left: 241px; top: 406px;height:30px; position: absolute; width: 230px" TabIndex="3" BorderStyle="Solid" MaxLength="14"></asp:TextBox>
            <asp:Label ID="LbEndereco" runat="server" Style="z-index: 1; left: 510px; top: 377px; position: absolute" Text="Endereço :" Font-Bold="True" Font-Names="Arial" ForeColor="#0000CC"></asp:Label>
            <asp:TextBox ID="txtEndereco" runat="server" Style="z-index: 1; left: 505px; top: 407px; position: absolute; height: 30px; width: 276px" TabIndex="4" BorderStyle="Solid" MaxLength="30"></asp:TextBox>
            <asp:Label ID="LbNum" runat="server" Style="z-index: 1; left: 249px; top: 450px; position: absolute; height: 17px;" Text="Nº :" Font-Bold="True" Font-Names="Arial" ForeColor="#0000CC"></asp:Label>
            <asp:TextBox ID="txtN" runat="server" Style="z-index: 1; left: 242px; top: 483px; position: absolute; width: 78px; height: 30px;" TabIndex="5" BorderStyle="Solid" MaxLength="5"></asp:TextBox>
            <asp:Label ID="LbBairro" runat="server" Style="z-index: 1; left: 378px; top: 457px; position: absolute" Text="Bairro :" Font-Bold="True" Font-Names="Arial" ForeColor="#0000CC"></asp:Label>
            <asp:TextBox ID="txtBairro" runat="server" Style="z-index: 1; left: 370px; top: 488px;height:30px; position: absolute; width: 227px" TabIndex="6" BorderStyle="Solid" MaxLength="20"></asp:TextBox>
            <asp:Label ID="LbCidade" runat="server" Style="z-index: 1; left: 636px; top: 462px; position: absolute; right: 611px;" Text="Cidade" Font-Bold="True" Font-Names="Arial" ForeColor="#0000CC"></asp:Label>
            <asp:TextBox ID="txtCidade" runat="server" Style="z-index: 1; left: 636px; top: 487px; position: absolute; height: 30px;" TabIndex="7" BorderStyle="Solid" MaxLength="20"></asp:TextBox>
            <asp:Label ID="LbUf" runat="server" Style="z-index: 1; left: 245px; top: 533px; position: absolute" Text="UF :" Font-Bold="True" Font-Names="Arial" ForeColor="#0000CC"></asp:Label>
            <asp:TextBox ID="txtComplemento" runat="server" Style="z-index: 1; left: 470px; top: 572px;height:30px; position: absolute; width: 239px;" TabIndex="10" BorderStyle="Solid" MaxLength="15"></asp:TextBox>
            <asp:TextBox ID="txtUf" runat="server" Style="z-index: 1; left: 243px; top: 567px; position: absolute; width: 48px; height: 30px" TabIndex="8" BorderStyle="Solid" MaxLength="2"></asp:TextBox>
            <asp:Label ID="LbCep" runat="server" Style="z-index: 1; left: 335px; top: 538px; position: absolute; height: 18px;" Text="CEP :" Font-Bold="True" Font-Names="Arial" ForeColor="#0000CC"></asp:Label>
            <asp:TextBox ID="txtCep" runat="server" Style="z-index: 1; left: 332px; top: 569px; position: absolute; width: 101px; height: 20px;" TabIndex="9" BorderStyle="Solid" MaxLength="9"></asp:TextBox>
            <asp:Label ID="LbComplemento" runat="server" Style="z-index: 1; left: 461px; top: 537px; position: absolute; height: 25px" Text="Complemento : " Font-Bold="True" Font-Names="Arial" ForeColor="#0000CC"></asp:Label>

            <asp:Button ID="btnSalvar" runat="server" Style="z-index: 1; left: 358px; top: 650px;height:30px; position: absolute" Text="Salvar" OnClick="btnSalvar_Click" Font-Bold="True" />
            <asp:Button ID="btnLimpar" runat="server" Style="z-index: 1; left: 469px; top: 648px; position: absolute; height: 30px;" Text="Editar" OnClick="btnEditar_Click" Font-Bold="True" />
            <asp:Button ID="btnCancelar" runat="server" Style="z-index: 1; left: 572px; top: 651px;height:30px; position: absolute" Text="Cancelar" OnClick="btnCancelar_Click" Font-Bold="True" />
           <%-- <asp:Label ID="LbCamposTel" runat="server" style="z-index: 1; left: 237px; top: 734px; position: absolute; width: 203px" Text="Telefones Empresa" BackColor="#CCCCCC" BorderColor="Black" Font-Bold="True" Font-Italic="True" Font-Names="Georgia"></asp:Label>
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
        <asp:Button ID="btnPesquisa" runat="server" OnClick="btnPesquisa_Click" style="z-index: 1; left: 799px; top: 221px; position: absolute" Text="Pesquisa" />--%>
        <asp:Label ID="LbEmpresa" runat="server" style="z-index: 1; left: 270px; top: 125px; position: absolute; width: 167px" Text="Cadastro Empresa" BorderColor="Black" Font-Bold="True" Font-Italic="True" Font-Names="Georgia"></asp:Label>
        </p>

    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footer" runat="server">
</asp:Content>
