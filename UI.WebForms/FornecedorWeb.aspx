<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site1.Master" CodeBehind="FornecedorWeb.aspx.cs" Inherits="UI.WebForms.FornecedorWeb" %>


<asp:Content ID="Content1" ContentPlaceHolderID="header" runat="server">

  <%--  <asp:Label ID="Label2" runat="server" BackColor="#CCCCCC" BorderColor="Black" Font-Bold="True" Font-Italic="True" Font-Names="Georgia" Style="z-index: 1; left: 270px; top: 835px; position: absolute; width: 188px; right: 548px;" Text="Endereço Fornecedor"></asp:Label>--%>
    <%-- <div _designerregion="0">
    </div>--%>
</asp:Content>


<asp:Content ID="BodyContent" ContentPlaceHolderID="content" runat="server">
    <style>
     

        #mySidenav a {
            position: relative;
            left: 555px;
            top:-380px;
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

        #endereco {
            top: 200px;
            background-color: #555
        }
    </style>
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <div id="mySidenav" class="sidenav">
        <a href="FornecedorTelefoneWeb.aspx" id="telefone">Telefone Fornecedor</a>
        <a href="#" id="endereco">Endereço Fornecedor</a>
    </div>
    <p <%--class style="height: 11px"--%>>
       <%-- <div id:"Fornecedor" style="background-color:#0000CD; margin-top: 0px; left: -3px; width: 1118px; height: 125px;"height: 11px" aria-atomic="False">--%>
        <%--<asp:Label ID="LbN" runat="server" Style="z-index: 1; left: 550px; top: 952px; position: absolute" Text="Nº" Font-Bold="False" Font-Names="Arial" ForeColor="#0000CC"></asp:Label>
        <asp:TextBox ID="txtCidade" runat="server" Style="z-index: 1; left: 270px; top: 1051px; position: absolute; width: 198px" TabIndex="12" BorderStyle="Inset"></asp:TextBox>--%>
        <%--<asp:TextBox ID="txtIdEndereco" runat="server" Style="z-index: 1; left: 208px; top: 856px; position: absolute; width: 33px" Visible="False" BorderStyle="Inset" MaxLength="10"></asp:TextBox>--%>

        <asp:Button ID="btnCancelar" runat="server" Style="z-index: 1; left: 549px; top: -57px; position: absolute; width: 82px;" Text="Excluir" OnClick="btnCancelar_Click" Font-Names="Arial Black" />
        <br />

        <asp:Button ID="PesquisaCnpj" runat="server" Style="z-index: 1; left: 784px; top: 187px; height:30px; position: absolute" Text="Pesquisar" OnClick="PesquisaCnpj_Click" Font-Bold="False" Font-Names="Arial Black" Font-Overline="False" />
        <%--<asp:Button ID="btnSalvarTel" runat="server" Style="z-index: 1; left: 500px; top: 605px; position: absolute; height: 26px;" Text="Salvar" OnClick="btnSalvarTel_Click" Font-Bold="True" Font-Names="Arial Black" />--%>
        <asp:Button ID="btnSalvar" runat="server" Style="z-index: 1; left: 618px; top: 382px;height:30px; position: absolute" Text="Salvar" OnClick="btnSalvar_Click" Font-Bold="False" Font-Names="Arial Black" />
        <%--<asp:Button ID="btnEditarTel" runat="server" Style="z-index: 1; left: 593px; top: 603px; position: absolute; height: 21px;" Text="Editar" OnClick="btnEditarTel_Click" Font-Names="Arial Black" />--%>
        <asp:Button ID="btnEditar" runat="server" Style="z-index: 1; left: 703px; top: 382px;height:30px; position: absolute" Text="Editar" OnClick="btnEditar_Click" Font-Names="Arial Black" />
       <%-- <asp:Button ID="btnCancelarTel" runat="server" Style="z-index: 1; left: 673px; top: 600px; position: absolute; height: 24px;" Text="Cancelar" OnClick="btnCancelarTel_Click" Font-Names="Arial Black" />--%>
        <asp:TextBox ID="txtCnpjPesquisa" runat="server" Style="z-index: 1; left: 497px; top: 185px; height:30px; position: absolute; width: 253px;" BorderStyle="Inset" MaxLength="14"></asp:TextBox>
        <%--<asp:TextBox ID="txtTelefone" runat="server" Style="z-index: 1; left: 670px; top: 557px; position: absolute" TabIndex="7" BorderStyle="Inset" MaxLength="11" TextMode="Phone" AutoCompleteType="HomePhone"></asp:TextBox>--%>
        <%--<asp:Label ID="LbBairro" runat="server" Style="z-index: 1; left: 650px; top: 949px; position: absolute" Text="Bairro:" Font-Bold="True" Font-Names="Arial" ForeColor="#0000CC"></asp:Label>--%>
        <asp:TextBox ID="txtRazaoSocial" runat="server" Style="z-index: 1; left: 270px; top: 275px; height:30px;position: absolute; width: 376px" TabIndex="1" BorderStyle="Inset" Font-Names="Arial" MaxLength="50"></asp:TextBox>
        <%--<asp:TextBox ID="txtIdTel" runat="server" Style="z-index: 1; left: 290px; top: 508px; position: absolute; width: 57px; height: 17px;" Enabled="False" TabIndex="4" Visible="False" BorderStyle="Inset" MaxLength="10"></asp:TextBox>--%>
        <asp:TextBox ID="txtNomefantasia" runat="server" Style="z-index: 1; left: 700px; top: 275px;height:30px; position: absolute; width: 338px" TabIndex="2" BorderStyle="Inset" MaxLength="50"></asp:TextBox>
        <asp:TextBox ID="txtCnpj" runat="server" Style="z-index: 1; left: 270px; top: 346px;height:30px;position: absolute; width: 238px" TabIndex="3" BorderStyle="Inset" MaxLength="18"></asp:TextBox>
        <asp:TextBox ID="txtId" runat="server" Style="z-index: 1; left: 204px; top: 211px; position: absolute; width: 49px; height: 16px;" Visible="False" BackColor="White" BorderStyle="Inset" EnableTheming="False" MaxLength="10"></asp:TextBox>
        <asp:Label ID="LbCnpj" runat="server" Style="z-index: 1; left: 270px; top: 315px; position: absolute" Text="CNPJ:" Font-Bold="True" Font-Names="Arial" ForeColor="#0000CC"></asp:Label>
        <asp:Label ID="LbNomeFantasia" runat="server" Style="z-index: 1; left: 700px; top: 242px; position: absolute; height: 17px" Text="Nome Fantasia:" Font-Bold="True" Font-Italic="True" Font-Names="Arial" ForeColor="#0000CC"></asp:Label>
        <asp:Label ID="LbRazaoSocial" runat="server" Style="z-index: 1; left: 270px; top: 243px; position: absolute" Text="Razão Social:" Font-Bold="True" Font-Italic="True" Font-Names="Arial" Font-Strikeout="False" Font-Underline="False" ForeColor="#0000CC"></asp:Label>


        <%--<asp:Label ID="lbIdTel" runat="server" Style="z-index: 1; left: 213px; top: 511px; position: absolute;" Text="Id Telef:" Font-Bold="True" Font-Names="Arial" ForeColor="#0000CC" Visible="False"></asp:Label>
        <asp:Label ID="LbTelefone" runat="server" Style="z-index: 1; left: 670px; top: 528px; position: absolute" Text="Telefone:" Font-Bold="True" Font-Names="Arial" ForeColor="#0000CC"></asp:Label>
        <asp:Label ID="LbFTipo" runat="server" Style="z-index: 1; left: 270px; top: 530px; position: absolute; height: 19px; width: 50px;" Text="Tipo:" Font-Bold="True" Font-Names="Arial" ForeColor="#0000CC"></asp:Label>--%>
        <asp:Label ID="LbIdFornecedor" runat="server" Style="z-index: 1; left: 204px; top: 187px; position: absolute; width: 13px;" Text="Id:" Font-Bold="True" Font-Italic="True" Font-Names="Arial" ForeColor="#0000CC" Visible="False"></asp:Label>
       <%-- <asp:TextBox ID="txtUf" runat="server" Style="z-index: 1; left: 550px; top: 1053px; position: absolute; width: 43px; height: 19px;" TabIndex="13" BorderStyle="Inset" MaxLength="2"></asp:TextBox>--%>

      <%--  <asp:DropDownList ID="ddlTipo" runat="server" Style="z-index: 1; left: 331px; top: 412px; position: absolute" TabIndex="5" Font-Bold="True">
        </asp:DropDownList>--%>
        <%--<asp:Label ID="LbIdEnd" runat="server" Style="z-index: 1; left: 207px; top: 836px; position: absolute; height: 21px; width: 61px" Text="Id End" Font-Bold="True" Font-Names="Arial" ForeColor="#0000CC" Visible="False"></asp:Label>--%>
       <%-- <asp:Label ID="LbCep" runat="server" Style="z-index: 1; left: 650px; top: 1026px; position: absolute" Text="CEP:" Font-Bold="True" Font-Names="Arial" ForeColor="#0000CC"></asp:Label>--%>
        <%--<asp:Label ID="LbEndereco" runat="server" Style="z-index: 1; left: 270px; top: 951px; position: absolute" Text="Endereço:" Font-Bold="True" Font-Names="Arial" ForeColor="#0000CC"></asp:Label>--%>
       <%-- <asp:Label ID="LbUf" runat="server" Style="z-index: 1; left: 550px; top: 1029px; position: absolute" Text="UF:" Font-Bold="True" Font-Names="Arial" ForeColor="#0000CC"></asp:Label>
        <asp:Label ID="LbCpmplemento" runat="server" Style="z-index: 1; left: 270px; top: 1100px; position: absolute; width: 121px" Text="Complemento:" Font-Bold="True" Font-Names="Arial" ForeColor="#0000CC"></asp:Label>
        <asp:Label ID="LbCidade" runat="server" Style="z-index: 1; left: 270px; top: 1024px; position: absolute; height: 23px; width: 48px" Text="Cidade" Font-Bold="True" Font-Names="Arial" ForeColor="#0000CC"></asp:Label>--%>
        <%--<asp:Label ID="LbFornecedorEnd" runat="server" Style="z-index: 1; left: 270px; top: 881px; position: absolute" Text="Fornecedor:" Font-Bold="True" Font-Names="Arial" ForeColor="#0000CC"></asp:Label>--%>
        <%--<asp:TextBox ID="txtCep" runat="server" Style="z-index: 1; left: 650px; top: 1057px; position: absolute; height: 16px" TabIndex="14" BorderStyle="Inset" MaxLength="9"></asp:TextBox>
        <asp:TextBox ID="txtComplemento" runat="server" Style="z-index: 1; left: 270px; top: 1129px; position: absolute; width: 220px" TabIndex="15" BorderStyle="Inset" MaxLength="15"></asp:TextBox>--%>
       <%-- <asp:TextBox ID="txtEndereco" runat="server" Style="z-index: 1; left: 270px; top: 983px; position: absolute; width: 226px" TabIndex="9" BorderStyle="Inset" MaxLength="30"></asp:TextBox>--%>
       <%-- <asp:TextBox ID="txtNumero" runat="server" Style="z-index: 1; left: 550px; top: 981px; position: absolute; width: 44px; height: 19px;" TabIndex="10" BorderStyle="Inset" MaxLength="5"></asp:TextBox>
        <asp:TextBox ID="txtBairro" runat="server" Style="z-index: 1; left: 650px; top: 978px; position: absolute; width: 263px" TabIndex="11" BorderStyle="Inset" MaxLength="20"></asp:TextBox>--%>
       <%-- <asp:DropDownList ID="ddlFornecedorEmpresa" runat="server" Style="z-index: 1; left: 270px; top: 907px; position: absolute" TabIndex="8" Font-Bold="True">
        </asp:DropDownList>--%>
        <%--<asp:GridView ID="gvEnderecoFornecedor" runat="server" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Vertical" Style="z-index: 1; left: 230px; top: 1214px; position: absolute; height: 133px; width: 813px" AllowPaging="True" DataKeyNames="Id" OnRowEditing="gvEnderecoFornecedor_RowEditing" OnRowDeleting="gvEnderecoFornecedor_RowDeleting" PageSize="5" OnPageIndexChanging="gvEnderecoFornecedor_PageIndexChanging">--%>
            <%--<AlternatingRowStyle BackColor="#DCDCDC" />
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
        </asp:GridView>--%>
        <%--<asp:Button ID="btnCancelarEndereco" runat="server" OnClick="btnCancelarEndereco_Click" Style="z-index: 1; left: 746px; top: 1166px; position: absolute" Text="Cancelar" Font-Names="Arial Black" />--%>
        <asp:Label ID="Label1" runat="server" Style="z-index: 1; left: 206px; top: 905px; position: absolute; height: 17px;" Text="Label" Visible="False"></asp:Label>
        <%--<asp:Button ID="btnSalvarEndereco" runat="server" OnClick="txtSalvarEndereco_Click" Style="z-index: 1; left: 535px; top: 1166px; position: absolute; height: 28px;" Text="Salvar" Font-Names="Arial Black" />
        <asp:Button ID="btnEditarEndereco" runat="server" OnClick="btnEditarEndereco_Click" Style="z-index: 1; left: 651px; top: 1167px; position: absolute" Text="Editar" Font-Names="Arial Black" />--%>
        <%--<asp:DropDownList ID="ddlFornecedoTel" runat="server" Style="z-index: 1; left: 450px; top: 562px; position: absolute" AppendDataBoundItems="True" CausesValidation="True" TabIndex="6" Font-Bold="True">
        </asp:DropDownList>
        <asp:Label ID="Fornecedor" runat="server" Style="z-index: 1; left: 450px; top: 532px; position: absolute; height: 19px;" Text="Fornecedor:" Font-Bold="True" Font-Names="Arial" ForeColor="#0000CC"></asp:Label>--%>

<%--        <asp:GridView ID="gvTelefoneFornecedor" runat="server" BackColor="White" BorderColor="#999999" BorderStyle="None"
            BorderWidth="1px" CellPadding="3" GridLines="Vertical" Style="z-index: 1; left: 270px; top: 643px; position: absolute; width: 606px" AllowPaging="True" DataKeyNames="Id" PageSize="3" OnRowDeleting="gvTelefoneFornecedor_RowDeleting1" OnRowEditing="gvTelefoneFornecedor_RowEditing2" OnPageIndexChanging="gvTelefoneFornecedor_PageIndexChanging" OnSelectedIndexChanged="gvTelefoneFornecedor_SelectedIndexChanged">

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
        </asp:GridView>--%>
       <%-- <asp:Label ID="LbFornCadastro" runat="server" BackColor="#CCCCCC" BorderColor="Black" Font-Bold="True" Font-Italic="True" Font-Names="Georgia" Style="z-index: 1; left: 270px; top: 466px; position: absolute; width: 187px; height: 18px" Text="Telefones Fornecedor"></asp:Label>--%>
        <asp:Label ID="LbFornCadastro0" runat="server" BorderColor="Black" Font-Bold="True" Font-Italic="True" Font-Names="Georgia" Style="z-index: 1; left: 270px; top: 100px; position: absolute; width: 187px; height: 18px; bottom: 113px;" Text="Cadastro Fornecedor"></asp:Label>
    </p>



   <%-- </div>--%>
</asp:Content>
