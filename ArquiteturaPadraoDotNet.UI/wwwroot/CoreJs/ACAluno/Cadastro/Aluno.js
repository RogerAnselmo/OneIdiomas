//dados do aluno
var _codigoUsuario = $('#CodigoUsuario');
var _codigoAluno = $('#CodigoAluno');
var _nomeCompleto = $('#NomeCompleto');
var _dataNascimento = $('#DataNascimento');
var _idade = $('#Idade');
var _rg = $('#RG');
var _cpf = $('#CPF');
var _diaVencimento = $('#DiaVencimento');

//endereço aluno
var _numero = $('#Numero');
var _cep = $('#CEP');
var _codigoUF = $('#CodigoUF');
var _codigoCidade = $('#CodigoCidade');
var _logradouro = $('#Logradouro');
var _codigoBairro = $('#CodigoBairro');
var _codigoEndereco = $('#CodigoEndereco');

//telefone
var _codigoTelefone = $('#CodigoTelefone');
var _telefone = $('#Telefone');


$(document).ready(function () {

    _idade.attr("disabled", "disabled");

    _codigoUF.val(5);//Pará
    _codigoCidade.val(1);//Abaetetuba

    _codigoUF.attr("disabled", "true");
    _codigoCidade.attr("disabled", "true");

    _dataNascimento.blur(function () {

        if (_dataNascimento.val() === '' || !fIsDate(_dataNascimento.val()))
            return;

        _idade.val(CalcularIdade(_dataNascimento.val()));
    });
});

