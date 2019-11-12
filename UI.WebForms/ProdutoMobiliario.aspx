<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="ProdutoMobiliario.aspx.cs" Inherits="UI.WebForms.ProdutoMobiliario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="header" runat="server">
   
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="content" runat="server">
    <p style="width: 877px;">
        <br />
        <asp:Label ID="LbProduto" runat="server" Style="z-index: 1; left: 270px; top: 460px; position: absolute; width: 165px" Text="Pesquisa Produto:" Font-Bold="True" Font-Names="Arial" ForeColor="#0000CC"></asp:Label>
        <asp:Label ID="LbFornecedor" runat="server" Style="z-index: 1; left: 270px; top: 200px; position: absolute" Text="Fornecedor :" Font-Bold="True" Font-Names="Arial" ForeColor="#0000CC"></asp:Label>
        <asp:DropDownList ID="ddlFornecedo" runat="server" Style="z-index: 1; left: 270px; top: 235px; position: absolute; height: 31px; width: 108px;" AppendDataBoundItems="True" DataTextField="Nome" DataValueField="IdFornecedor" Font-Bold="True">
        </asp:DropDownList>
        <asp:Label ID="LbNomeProduto" runat="server" Style="z-index: 1; left: 450px; top: 200px; position: absolute" Text="Nome do Produto:" Font-Bold="True" Font-Names="Arial" ForeColor="#0000CC"></asp:Label>
        <asp:DropDownList ID="ddlQuantidade" runat="server" Style="z-index: 1; left: 755px; top: 230px;height:31px; position: absolute" Font-Bold="True" Font-Italic="False">
            <asp:ListItem>Selecione..</asp:ListItem>
            <asp:ListItem>01</asp:ListItem>
            <asp:ListItem>02</asp:ListItem>
            <asp:ListItem>03</asp:ListItem>
            <asp:ListItem>04</asp:ListItem>
            <asp:ListItem>05</asp:ListItem>
            <asp:ListItem>06</asp:ListItem>
            <asp:ListItem>07</asp:ListItem>
            <asp:ListItem>08</asp:ListItem>
            <asp:ListItem>09</asp:ListItem>
            <asp:ListItem>10</asp:ListItem>
            <asp:ListItem>11</asp:ListItem>
            <asp:ListItem>12</asp:ListItem>
            <asp:ListItem>13</asp:ListItem>
            <asp:ListItem>14</asp:ListItem>
            <asp:ListItem>15</asp:ListItem>
            <asp:ListItem>16</asp:ListItem>
            <asp:ListItem>17</asp:ListItem>
            <asp:ListItem>18</asp:ListItem>
            <asp:ListItem>19</asp:ListItem>
            <asp:ListItem>20</asp:ListItem>
            <asp:ListItem>21</asp:ListItem>
            <asp:ListItem>22</asp:ListItem>
            <asp:ListItem>23</asp:ListItem>
            <asp:ListItem>24</asp:ListItem>
            <asp:ListItem>25</asp:ListItem>
            <asp:ListItem>26</asp:ListItem>
            <asp:ListItem>27</asp:ListItem>
            <asp:ListItem>28</asp:ListItem>
            <asp:ListItem>29</asp:ListItem>
            <asp:ListItem>30</asp:ListItem>
            <asp:ListItem>31</asp:ListItem>
            <asp:ListItem>32</asp:ListItem>
            <asp:ListItem>33</asp:ListItem>
            <asp:ListItem>34</asp:ListItem>
            <asp:ListItem>35</asp:ListItem>
            <asp:ListItem>36</asp:ListItem>
            <asp:ListItem>37</asp:ListItem>
            <asp:ListItem>38</asp:ListItem>
            <asp:ListItem>39</asp:ListItem>
            <asp:ListItem>40</asp:ListItem>
            <asp:ListItem>41</asp:ListItem>
            <asp:ListItem>42</asp:ListItem>
            <asp:ListItem>43</asp:ListItem>
            <asp:ListItem>44</asp:ListItem>
            <asp:ListItem>45</asp:ListItem>
            <asp:ListItem>46</asp:ListItem>
            <asp:ListItem>47</asp:ListItem>
            <asp:ListItem>48</asp:ListItem>
            <asp:ListItem>49</asp:ListItem>
            <asp:ListItem>50</asp:ListItem>

        </asp:DropDownList>
        <asp:Label ID="LbPreco" runat="server" Style="z-index: 1; left: 275px; top: 280px; position: absolute; height: 21px;" Text="Preço :" Font-Bold="True" Font-Italic="False" Font-Names="Arial" ForeColor="#0000CC"></asp:Label>
        <asp:TextBox ID="txtPreco" runat="server" Style="z-index: 1; left: 275px; top: 310px; position: absolute; height: 30px; width: 102px" TabIndex="3" BorderStyle="Solid" Font-Bold="False" MaxLength="10"></asp:TextBox>
        <asp:Label ID="LbTamanho" runat="server" Style="z-index: 1; left: 450px; top: 280px; position: absolute; height: 20px" Text="Tamanho : " Font-Bold="True" Font-Italic="False" Font-Names="Arial" ForeColor="#0000CC"></asp:Label>
        <asp:TextBox ID="txtTamanho" runat="server" Style="z-index: 1; left: 450px; top: 310px;height:30px; position: absolute" TabIndex="4" BorderStyle="Solid" TextMode="Number"></asp:TextBox>
        <asp:Label ID="LbPeso" runat="server" Style="z-index: 1; left: 633px; top: 280px; position: absolute; height: 17px; width: 66px;" Text="Peso : " Font-Bold="True" Font-Names="Arial" ForeColor="#0000CC"></asp:Label>
        <asp:Label ID="LbCor" runat="server" Style="z-index: 1; left: 810px; top: 280px; position: absolute; height: 19px; width: 45px;" Text="Cor : " Font-Bold="True" Font-Italic="True" Font-Names="Arial" ForeColor="#0000CC"></asp:Label>
        <asp:DropDownList ID="ddlCor" runat="server" Style="z-index: 1; left: 810px; top: 310px; height:30px;position: absolute; margin-bottom: 0px;" TabIndex="6" Font-Bold="True">
            <asp:ListItem>Selecione..</asp:ListItem>
            <asp:ListItem>Abóbora</asp:ListItem>
            <asp:ListItem>Açafrão</asp:ListItem>
            <asp:ListItem>Azul</asp:ListItem>
            <asp:ListItem>Bege</asp:ListItem>
            <asp:ListItem>Bordô</asp:ListItem>
            <asp:ListItem>Branco</asp:ListItem>
            <asp:ListItem>Bronze</asp:ListItem>
            <asp:ListItem>Carmesim</asp:ListItem>
            <asp:ListItem>Ciano</asp:ListItem>
            <asp:ListItem>Cinza</asp:ListItem>
            <asp:ListItem>Creme</asp:ListItem>
            <asp:ListItem>Preto</asp:ListItem>
            <asp:ListItem>Amarelo</asp:ListItem>
            <asp:ListItem>Verde</asp:ListItem>

        </asp:DropDownList>
        <asp:TextBox ID="txtPeso" runat="server" Style="z-index: 1; left: 630px; position: absolute; top: 310px;height:30px;" TabIndex="5" BorderStyle="Solid" MaxLength="10"></asp:TextBox>
        <asp:TextBox ID="txtNome" runat="server" Style="z-index: 1; left: 450px; top: 235px; height:30px;position: absolute; width: 274px" TabIndex="1" BorderStyle="Solid" MaxLength="30"></asp:TextBox>
        <asp:Label ID="LbQuantidade" runat="server" Style="z-index: 1; left: 755px; top: 200px; position: absolute; width: 98px;" Text="Quantidade : " TabIndex="2" Font-Bold="True" Font-Names="Arial" ForeColor="#0000CC"></asp:Label>
        <asp:Button ID="btnSalvar" runat="server" OnClick="btnSalvar_Click" Style="z-index: 1; left: 479px; top: 360px;height:30px; position: absolute" Text="Salvar" Font-Names="Arial Black" />
        <asp:Button ID="btnEditar" runat="server" OnClick="btnEditar_Click" Style="z-index: 1; left: 580px; top: 360px;height:30px; position: absolute; height: 26px" Text="Editar" Font-Names="Arial Black" />
        <asp:Button ID="btnCancelar" runat="server" OnClick="btnCancelar_Click" Style="z-index: 1; left: 677px; top: 360px;height:30px; position: absolute" Text="Cancelar" Font-Names="Arial Black" />
        <asp:GridView ID="gvProduto" runat="server" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Vertical"   DataKeyNames="Id" Style="z-index: 1; left: 270px; top: 514px; position: absolute; height: 153px; width: 738px" OnRowEditing="gvProduto_RowEditing1" AllowPaging="True" OnPageIndexChanging="gvProduto_PageIndexChanging" OnRowDeleting="gvProduto_RowDeleting" PageSize="5">
            <AlternatingRowStyle BackColor="#DCDCDC" />
            <Columns>
                <asp:BoundField DataFormatString="Id" HeaderText="Id" ReadOnly="True" Visible="False" />
                <asp:BoundField DataFormatString="IdFornecedor" HeaderText="Fornecedor" ReadOnly="True" Visible="False" DataField="IdFornecedor" >
                <HeaderStyle Width="250px" />
                <ItemStyle BorderWidth="250px" Width="250px" />
                </asp:BoundField>
                <asp:BoundField DataFormatString="Nome" HeaderText="Nome Do Produto" ReadOnly="True" Visible="False" />
                <asp:BoundField DataFormatString="Quantidade" HeaderText="Quantidade" ReadOnly="True" Visible="False" />
                <asp:BoundField DataFormatString="Preco" HeaderText="Preço" ReadOnly="True" Visible="False" />
                <asp:BoundField DataFormatString="Peso" HeaderText="Peso" ReadOnly="True" Visible="False" />
                <asp:BoundField DataFormatString="Tamanho" HeaderText="Tamanho" ReadOnly="True" Visible="False" />
                <asp:BoundField DataFormatString="Cor" HeaderText="Cor" ReadOnly="True" Visible="False" />
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
        <asp:TextBox ID="txtPesquisa" runat="server" Style="z-index: 1; left: 430px; top: 460px;height:30px; position: absolute; width: 189px" TabIndex="7"  BorderStyle="Solid" MaxLength="30"></asp:TextBox>
        <asp:TextBox ID="txtId" runat="server" Style="z-index: 1; left: 198px; top: 184px; position: absolute; height: 17px; width: 36px" Visible="False" BorderStyle="Solid" MaxLength="10"></asp:TextBox>
        <asp:Button ID="btnPesquiasr" runat="server" OnClick="btnPesquiasr_Click" Style="z-index: 1; left: 650px; top: 460px;height:30px; position: absolute; margin-bottom: 0px;" Text="Pesquisar " Font-Names="Arial Black" />
        <asp:Label ID="LbProduto0" runat="server" Style="z-index: 1; left:270px; top: 100px; position: absolute; width: 192px" Text="Cadastro Produto Mobiliario" BorderColor="Black" Font-Bold="True" Font-Italic="True" Font-Names="Georgia" ForeColor="Black"></asp:Label>
    </p>
    </asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footer" runat="server">
</asp:Content>