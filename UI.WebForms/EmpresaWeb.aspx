﻿<%@ Page Language="C#" AutoEventWireup="true" MasterPagefile="~/Site1.Master" CodeBehind="Default2.aspx.cs" Inherits="Empresa" %>

<script runat="server">

    protected void BtnSalvar_Click(object sender, EventArgs e)
    {

    }
</script>


<asp:Content ID ="BodyContent" ContentPlaceHolderID="content" runat="server">

        <div style="height: 864px">
        <asp:GridView ID="GvtelefoneEmpresa1" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" style="z-index: 1; left: 29px; top: 639px; position: absolute; height: 133px; width: 441px" OnSelectedIndexChanged="GvtelefoneEmpresa1_SelectedIndexChanged" >
            <Columns>
                <asp:BoundField HeaderText="Id" />
                <asp:BoundField HeaderText="Tipo" />
                <asp:BoundField HeaderText="Telefone" />
                <asp:CommandField ShowDeleteButton="True" />
                <asp:CommandField ShowEditButton="True" />
            </Columns>
            <FooterStyle BackColor="White" ForeColor="#000066" />
            <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
            <RowStyle ForeColor="#000066" />
            <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#007DBB" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#00547E" />

            
        </asp:GridView>
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 194px; top: 40px; position: absolute; width: 41px;" Text="CNPJ:"></asp:Label>
        <asp:TextBox ID="TxtCnpjPesquisar" runat="server" style="z-index: 1; left: 261px; top: 40px; position: absolute; height: 22px;" OnTextChanged="TxtCnpjPesquisar_TextChanged"></asp:TextBox>
      
        <asp:TextBox ID="txtCnpj" runat="server" style="z-index: 1; left: 54px; top: 255px; position: absolute; width: 239px"></asp:TextBox>
        <asp:TextBox ID="txtEndereco" runat="server" style="z-index: 1; left: 54px; top: 339px; position: absolute; width: 282px; height: 20px; "></asp:TextBox>
        <asp:TextBox ID="txtN" runat="server" style="z-index: 1; top: 331px; position: absolute; width: 48px; height: 18px; bottom: 184px; left: 423px; right: 399px;"></asp:TextBox>
        <asp:TextBox ID="txtBairro" runat="server" style="z-index: 1; top: 335px; position: absolute; width: 290px; left: 597px"></asp:TextBox>
        <asp:Label ID="Label9" runat="server" style="z-index: 1; left: 57px; top: 390px; position: absolute; bottom: 130px" Text="Cidade:"></asp:Label>
        <asp:Label ID="Label10" runat="server" style="z-index: 1; left: 293px; top: 392px; position: absolute" Text="UF:"></asp:Label>
        <asp:Label ID="Label11" runat="server" style="z-index: 1; left: 429px; top: 391px; position: absolute" Text="Cep:"></asp:Label>
        <asp:Label ID="Label12" runat="server" style="z-index: 1; left: 639px; top: 391px; position: absolute" Text="Complemento:"></asp:Label>
        <asp:TextBox ID="txtCidade" runat="server" style="z-index: 1; left: 52px; top: 425px; position: absolute; width: 148px; margin-top: 0px"></asp:TextBox>
        <asp:TextBox ID="txtUf" runat="server" style="z-index: 1; left: 291px; top: 421px; position: absolute; width: 38px; height: 14px; right: 634px"></asp:TextBox>
        <asp:TextBox ID="txtComplemento" runat="server" style="z-index: 1; left: 636px; top: 423px; position: absolute"></asp:TextBox>
        <asp:Label ID="Label13" runat="server" style="z-index: 1; left: 58px; top: 569px; position: absolute; height: 11px" Text="ID:"></asp:Label>
        <asp:Label ID="Label15" runat="server" style="z-index: 1; left: 278px; top: 563px; position: absolute; right: 651px" Text="Telefone:"></asp:Label>
        <asp:TextBox ID="txtIdEmp" runat="server" style="z-index: 1; left: 55px; top: 591px; position: absolute; width: 30px; height: 16px; right: 993px"></asp:TextBox>
        <asp:TextBox ID="txtNumeroTelefone" runat="server" style="z-index: 1; left: 278px; top: 594px; position: absolute; right: 565px"></asp:TextBox>
        <asp:Button ID="BtnSalvarTelefone" runat="server" OnClick="BtnSalvarTelefone_Click" style="z-index: 1; left: 491px; top: 593px; position: absolute; height: 24px; " Text="Salvar" />
        <asp:Button ID="BtnCancelarTelefone" runat="server" OnClick="BtnCancelarTelefone_Click" style="z-index: 1; left: 656px; top: 592px; position: absolute; height: 24px;" Text="Cancelar" />
        <asp:DropDownList ID="ddlTipo" runat="server" style="z-index: 1; left: 126px; top: 592px; position: absolute; height: 18px; width: 104px; right: 761px;">
            
            <asp:ListItem Selected="True"></asp:ListItem>
            <asp:ListItem></asp:ListItem>
            <asp:ListItem></asp:ListItem>
            <asp:ListItem></asp:ListItem>
        </asp:DropDownList>
        <asp:Button ID="BtnEditarTelefone" runat="server" style="z-index: 1; left: 573px; top: 591px; position: absolute; height: 25px;" Text="Editar" OnClick="BtnEditarTelefeone_Click" />
         <asp:Button ID="BtnSalvar" runat="server" OnClick="BtnSalvar_Click" style="z-index: 1; left: 299px; top: 478px; position: absolute; height: 26px; right: 508px;" Text="Salvar" />
         <asp:Button ID="BtnSalvar0" runat="server" OnClick="BtnSalvar_Click" style="z-index: 1; left: 299px; top: 478px; position: absolute; height: 26px; right: 508px;" Text="Salvar" />
         <asp:Button ID="BtnEditar" runat="server" OnClick="BtnEditar_Click" style="z-index: 1; left: 378px; top: 477px; position: absolute; right: 432px;" Text="Editar" />
         <asp:Button ID="BtnCancelar" runat="server" OnClick="BtnCancelar_Click" style="z-index: 1; left: 465px; top: 478px; position: absolute" Text="Cancelar" />
        <asp:TextBox ID="txtCep" runat="server" style="z-index: 1; left: 427px; top: 421px; position: absolute; height: 22px; width: 128px;"></asp:TextBox>
        <asp:Label ID="Label6" runat="server" style="z-index: 1; left: 55px; top: 305px; position: absolute" Text="Endereço:"></asp:Label>
        <asp:Label ID="Label7" runat="server" style="z-index: 1; left: 426px; top: 297px; position: absolute; height: 17px; width: 23px" Text="Nª:"></asp:Label>
        <asp:Label ID="Label8" runat="server" style="z-index: 1; left: 599px; top: 294px; position: absolute" Text="Bairro:"></asp:Label>
      
        <asp:Label ID="Label5" runat="server" style="z-index: 1; left: 56px; position: absolute; height: 19px; top: 223px" Text="Cnpj:"></asp:Label>
        <asp:TextBox ID="txtRazaoSocial" runat="server" style="z-index: 1; left: 53px; top: 179px; position: absolute; width: 405px; margin-top: 0px;"></asp:TextBox>
        <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 54px; top: 135px; position: absolute; margin-bottom: 526px;" Text="Razão Social:"></asp:Label>
        <asp:TextBox ID="txtNomeFantasia" runat="server" style="z-index: 1; left: 599px; top: 172px; position: absolute; width: 296px"></asp:TextBox>
        <asp:Label ID="Label4" runat="server" style="z-index: 1; left: 597px; top: 138px; position: absolute" Text="Nome Fantasia:"></asp:Label>
        <asp:TextBox ID="txtId" runat="server" style="z-index: 1; left: 116px; top: 86px; position: absolute; width: 23px"></asp:TextBox>
        <asp:Label ID="Label3" runat="server" style="z-index: 1; left: 69px; top: 90px; position: absolute" Text="ID:"></asp:Label>
        </div>
        <asp:GridView ID="GvtelefoneEmpresa" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" style="z-index: 1; left: 29px; top: 639px; position: absolute; height: 133px; width: 441px" >
            <Columns>
                <asp:BoundField HeaderText="Id" />
                <asp:BoundField HeaderText="Tipo" />
                <asp:BoundField HeaderText="Telefone" />
                <asp:CommandField ShowDeleteButton="True" />
                <asp:CommandField ShowEditButton="True" />
            </Columns>
            <FooterStyle BackColor="White" ForeColor="#000066" />
            <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
            <RowStyle ForeColor="#000066" />
            <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#007DBB" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#00547E" />

            
        </asp:GridView>
        <asp:GridView ID="GvtelefoneEmpresa0" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" style="z-index: 1; left: 29px; top: 639px; position: absolute; height: 133px; width: 441px"  >
            <Columns>
                <asp:BoundField HeaderText="Id" />
                <asp:BoundField HeaderText="Tipo" />
                <asp:BoundField HeaderText="Telefone" />
                <asp:CommandField ShowDeleteButton="True" />
                <asp:CommandField ShowEditButton="True" />
            </Columns>
            <FooterStyle BackColor="White" ForeColor="#000066" />
            <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
            <RowStyle ForeColor="#000066" />
            <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#007DBB" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#00547E" />

            
        </asp:GridView>



</asp:Content>
