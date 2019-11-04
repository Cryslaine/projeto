

                /*Conter todas os comandos de instruções javaScript*/
                <script language="">
                    /* Definição de Variaveis*/
                    /*entrada e saida de dados*/

                    <script src="Scripts/jquery-2.1.1.min.js"></script>
                    <script src="Scripts/jquery.maskedinput.min.js"></script>
                    <script type="text/javascript" src="jquery.js"></script>
                    <script type="text/javascript" src="jquery.maskedinput.js"></script>

                    <imput id="txtId" name="txtId" type="text" />
                    <imput id="txtCnpjPesquia" name="txtCnpjPesquia" type="text" />
                    <imput id="txtxtRazaoSocialtId" name="txtRazaoSocial" type="text" />
                    <imput id="txtNomeFantasia" name="txtNomeFantasia" type="text" />
                    <imput id="txtCnpj" name="txtCnpj" type="text" />
                    <imput id="txtEndereco" name="txtEndereco" type="text" />
                    <imput id="txtN" name="txtN" type="text" />
                    <imput id="txtBairro" name="txtBairro" type="text" />
                    <imput id="txtCidade" name="txtCidade" type="text" />
                    <imput id="txtUf" name="txtUf" type="text" />
                    <imput id="txtCep" name="txtCep" type="text" />
                    <imput id="txtComplemento" name="txtComplemento" type="text" />


              
                    jQuery(function ($){
                    $('#txtCnpjPesquia').mask('99.999.999/9999-99'); //Máscara para cjpj
	                $('#telefone').mask('(99)9999-9999'{completed :function(){alert("Telefone: "+this.val())}}); //Máscara para telefone

                    $('#txtCnpj').mask("99.999.999/9999-99');//Máscara para cjpj
                    });
        </script>
