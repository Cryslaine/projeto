
$(document).ready(function () {
    $('.validar').cpfcnpj
        ({
            mask: true, validate: 'cpfcnpj',
            event: 'click', handler: '.btn', ifValid: function
                (input) { input.removeClass("error"); }, ifInvalid: (input) 
            { input.addClass("error"); }
        });
});

$('.cnpj').mask('00.000.000/0000-00', { reverse: true });
$('.cep').mask('00000-000');
$('.phone_with_ddd').mask('(00) 0000-0000');