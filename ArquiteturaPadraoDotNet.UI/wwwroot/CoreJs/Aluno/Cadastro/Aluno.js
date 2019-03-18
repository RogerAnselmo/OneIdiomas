﻿//dados do aluno
var _codigoAluno = $('#CodigoAluno');
var _nomeCompleto = $('#NomeCompleto');
var _dataNascimento = $('#DataNascimento');
var _idade = $('#Idade');
var _telefone = $('#Telefone');
var _rg = $('#RG');
var _cpf = $('#CPF');
var _diaVencimento = $('#DiaVencimento');

//endereço aluno
var _cep = $('#CEP');
var _codigoUF = $('#CodigoUF');
var _codigoCidade = $('#CodigoCidade');
var _logradouro = $('#Logradouro');
var _codigoBairro = $('#CodigoBairro');

$(document).ready(function () {

    _idade.attr("disabled", "disabled");

    //configura datas
    ConfiguraDatePicker(_dataNascimento);

    _codigoUF.val(5);//Pará
    _codigoCidade.val(1);//Abaetetuba

    _codigoUF.attr("disabled", "true");
    _codigoCidade.attr("disabled", "true");

    _dataNascimentoResponsavel.blur(function () {

        if (_dataNascimentoResponsavel.val() == '' || !fIsDate(_dataNascimentoResponsavel.val()))
            return;

        _idade.val(CalcularIdade(_dataNascimentoResponsavel.val()));
    });
});

