<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Exemplo.aspx.cs" Inherits="UI.WebForms.Exemplo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
    .abas {
    position: relative;
    }
    .aba {
    display: inline;
    }
    .aba > a {
    float: left;
    padding: 0.5em 1em;
    background: linear-gradient(#FFF, #EEE);
    border-width: 1px;
    border-style: solid;
    border-color: #CCC #CCC #FFF;
    border-top-right-radius: 8px;
    border-top-left-radius: 8px;
    }
    .aba:not(:target) a {
    border-bottom: 0 none;
    }
    .aba:target a, a:hover {
    background: white;
    }
    .conteudo {
    position: absolute;
    left: 0;
    top: calc(2em + 4px); /* altura do link + bordas */
    z-index: -2;
    border: 1px solid #CCC;
    background-color: white;
    }
    .aba:target .conteudo {
    z-index: -1;
    }
  </style>
</head>
<body>
      <!-- Criando a listagem -->
<ul class="abas">
    <!-- Aqui, criação da primeira aba -->
    <li class="aba" id="aba-1">
     <a href="#aba-1">Aba1</a>
<section class="conteudo"> Conteúdo da Aba 1 </section></li>
<!-- Aqui, criação da segunda aba -->
    <li class="aba" id="aba-2">
     <a href="#aba-2">Aba 2</a> 
<section class="conteudo"> Conteúdo da Aba 2 </section></li>
<!-- Aqui, criação da terceira aba -->
    <li class="aba" id="aba-3">
     <a href="#aba-3">Aba 3</a> 
<section class="conteudo"> Conteúdo da Aba 3 </section></li>
</ul>
    <form id="form1" runat="server">
        <div>
            <br />
            <br />
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Size="Small" ForeColor="#0033CC" style="z-index: 1; left: 308px; top: 91px; position: absolute" Text="Nome Fantasia"></asp:Label>
            <br />
            <asp:TextBox ID="TextBox1" runat="server" BorderStyle="Dotted" style="z-index: 1; left: 308px; top: 112px; position: absolute; width: 199px"></asp:TextBox>
            <br />
            <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="Large" ForeColor="#CC0000" style="z-index: 1; left: 19px; top: 50px; position: absolute" Text="Dados cadastrais da empresa"></asp:Label>
            <asp:Label ID="Label4" runat="server" Font-Bold="True" Font-Size="Small" ForeColor="#0033CC" style="z-index: 1; left: 10px; top: 93px; position: absolute" Text="Razão social"></asp:Label>
            <br />
            <asp:Label ID="Label3" runat="server" Font-Bold="True" Font-Size="Small" ForeColor="#0033CC" style="z-index: 1; left: 538px; top: 94px; position: absolute; height: 24px" Text="CNPJ"></asp:Label>
            <br />
            <br />
            <asp:TextBox ID="TextBox2" runat="server" BorderStyle="Dotted" MaxLength="50" style="z-index: 1; left: 10px; top: 110px; position: absolute; width: 240px"></asp:TextBox>
            <br />
            <asp:TextBox ID="TextBox3" runat="server" BorderStyle="Dotted" style="z-index: 1; left: 539px; top: 102px; position: absolute; margin-top: 11px"></asp:TextBox>
            <br />
            <asp:Label ID="Label5" runat="server" Font-Bold="True" Font-Size="Large" ForeColor="#CC0000" style="z-index: 1; left: 21px; top: 160px; position: absolute" Text="Cadastro de telefone"></asp:Label>
        </div>
    </form>
</body>
</html>
