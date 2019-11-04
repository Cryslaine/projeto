<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="ItemNotaFiscalWeb.aspx.cs" Inherits="UI.WebForms.tester" %>

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
        <a href="NotaFiscalWeb.aspx" id="about">Nota Fiscal</a>

    </div>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="content" runat="server">
    <p>
        <asp:Label ID="LbItemNota" runat="server" Style="z-index: 1; left: 270px; top: 125px; position: absolute; width: 187px; height: 26px; right: 923px;" Text="Item Da Nota Fiscal " BackColor="#CCCCCC" BorderColor="Black" Font-Bold="True" Font-Italic="True" Font-Names="Georgia"></asp:Label>
        <asp:DropDownList ID="ddlQuantidade" runat="server" Style="z-index: 1; left: 558px; top: 210px; position: absolute; height: 31px;" Font-Bold="True">
            <asp:ListItem>Selecione..</asp:ListItem>
            <asp:ListItem>1</asp:ListItem>
            <asp:ListItem>2</asp:ListItem>
            <asp:ListItem>3</asp:ListItem>
            <asp:ListItem>4</asp:ListItem>
            <asp:ListItem>5</asp:ListItem>
            <asp:ListItem>6</asp:ListItem>
            <asp:ListItem>7</asp:ListItem>
            <asp:ListItem>8</asp:ListItem>
            <asp:ListItem>9</asp:ListItem>
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
        <asp:Label ID="LbIdNota" runat="server" Style="z-index: 1; left: 270px; top: 180px; position: absolute; height: 18px;" Text="Id Nota Fiscal:" Font-Bold="True" Font-Names="Arial" ForeColor="#0000CC"></asp:Label>
        <asp:TextBox ID="txtValorItem" runat="server" Style="z-index: 1; left: 700px; top: 210px; position: absolute" MaxLength="10" BorderStyle="Solid">R$</asp:TextBox>
        <asp:Label ID="LbQuantidadeItem" runat="server" Style="z-index: 1; left: 560px; top: 180px; position: absolute" Text="Quantidade:" Font-Bold="True" Font-Names="Arial" ForeColor="#0000CC"></asp:Label>
        <asp:Label ID="LbIdItemDaNota" runat="server" Style="z-index: 1; left: 176px; top: 190px; position: absolute; width: 32px; height: 38px;" Text="Id Item:" Visible="False" Font-Bold="True" Font-Names="Arial" ForeColor="#0000CC"></asp:Label>
        <asp:TextBox ID="txtIdItemNotaFiscal" runat="server" Style="z-index: 1; left: 173px; top: 233px; position: absolute; width: 17px; height: 16px;" MaxLength="10" Visible="False"></asp:TextBox>
        <asp:Button ID="btnSalvarItem" runat="server" OnClick="btnSalvarItem_Click" Style="z-index: 1; left: 400px; top: 290px; position: absolute; height: 28px;" Text="Salvar" Font-Bold="False" Font-Names="Arial Black" />
        <asp:Button ID="btnEditarItem" runat="server" OnClick="btnEditarItem_Click" Style="z-index: 1; left: 490px; top: 290px; position: absolute" Text="Editar" Font-Names="Arial Black" />
        <asp:Label ID="LbValorItem" runat="server" Style="z-index: 1; left: 700px; top: 180px; position: absolute" Text="Valor do Item:" Font-Bold="True" Font-Names="Arial" ForeColor="#0000CC"></asp:Label>
        <asp:GridView ID="gvItemdaNota" runat="server" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Vertical" OnRowDeleting="gvItemdaNota_RowDeleting" OnRowEditing="gvItemdaNota_RowEditing" DataKeyNames="Id" Style="z-index: 1; left: 270px; top: 350px; position: absolute; height: 133px; width: 670px" AllowPaging="True" PageSize="5" OnPageIndexChanging="gvItemdaNota_PageIndexChanging1">
            <AlternatingRowStyle BackColor="#DCDCDC" />
            <Columns>
                <asp:BoundField DataFormatString="Id" HeaderText="Id" ReadOnly="True" Visible="False" />
                <asp:BoundField DataFormatString="IdNotaFiscal" HeaderText="Id Nota Fical" ReadOnly="True" Visible="False" />
                <asp:BoundField DataFormatString="produto.Nome" HeaderText="Produto" ReadOnly="True" Visible="False" />
                <asp:BoundField DataFormatString="Quantidade" HeaderText="Quantidade" ReadOnly="True" Visible="False" />
                <asp:BoundField DataFormatString="Valor" HeaderText="Valor" ReadOnly="True" Visible="False" />
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
        <asp:DropDownList ID="ddlIdNotaFiscal" runat="server" Style="z-index: 1; left: 270px; top: 210px; position: absolute; height: 31px;" Font-Bold="True">
        </asp:DropDownList>
        <asp:Label ID="LbProdutoNota" runat="server" Style="z-index: 1; left: 420px; top: 180px; position: absolute" Text="Produto:" Font-Bold="True" Font-Names="Arial" ForeColor="#0000CC"></asp:Label>
        <asp:DropDownList ID="ddlItemProduto" runat="server" Style="z-index: 1; left: 420px; top: 210px; position: absolute; height: 31px;" Font-Bold="True">
        </asp:DropDownList>
        <asp:Button ID="btnCancelar" runat="server" OnClick="btnExcluirItem_Click" Style="z-index: 1; left: 580px; top: 290px; position: absolute; height: 26px;" Text="Cancelar" Font-Names="Arial Black" />

    </p>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footer" runat="server">
</asp:Content>
