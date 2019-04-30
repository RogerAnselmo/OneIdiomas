﻿//dados do Responsável
var _codigoResponsavel = $('#CodigoResponsavel');
var _codigoUsuario = $('#CodigoUsuario');
var _nomeCompleto = $('#NomeCompleto');
var _dataNascimento = $('#DataNascimento');
var _idade = $('#Idade');
var _telefone = $('#Telefone');
var _rg = $('#RG');
var _cpf = $('#CPF');
var _diaVencimento = $('#DiaVencimento');

//endereço Responsavel
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

    _dataNascimento.blur(function () {

        if (_dataNascimento.val() == '' || !fIsDate(_dataNascimento.val()))
            return;

        _idade.val(CalcularIdade(_dataNascimento.val()));
    });
});

$('.bt-salvar').click(function () {
    AlterarResponsavel();
});

function AlterarResponsavel() {

    if (ValidarDadosDoResponsavel()) {

        var editarResponsavelViewModel = MontarEditarResponsavelViewModel();

        ExecutarComandoPost("/Gerenciar-Responsavel/Registrar-Edicao-Responsavel", MontarEditarResponsavelViewModel(),
            function (retorno) {
                if (retorno.erro === 0) {
                    AlertSuccess(retorno.mensagem);
                }
                else {
                    AlertWarning(retorno.mensagem);
                }
            },
            function (error) {
                console.log(error);
                AlertError(error.mensagem);
            });
    }
}

function ValidarDadosDoResponsavel() {

    //nome
    if ($.trim(_nomeCompleto.val()) === '') {
        AlertWarning("Preencha o nome do Responsavel");
        _nomeCompleto.focus();
        return false;
    }

    //data de nascimento
    else if (!fIsDate($.trim(_dataNascimento.val()))) {
        AlertWarning("Preencha a data de nascimento do Responsavel");
        _dataNascimento.focus();
        return false;
    }

    //RG
    else if ($.trim(_rg.val()) === "") {
        AlertWarning("Preencha o RG do Responsavel");
        _rg.focus();
        return false;
    }

    //CPF
    else if ($.trim(_cpf.val()) === "") {
        AlertWarning("Preencha o cpf do Responsavel");
        _dataNascimento.focus();
        return false;
    }

    //dia de vencimento
    else if (_diaVencimento.val() === "0") {
        AlertWarning("Preencha o dia de vencimento");
        _diaVencimento.focus();
        return false;
    }

    return true;
}

function MontarEditarResponsavelViewModel() {

    return {
        //dados do Responsavel
        CodigoResponsavel: _codigoResponsavel.val(),
        CodigoUsuario: _codigoUsuario.val(),
        NomeCompleto: _nomeCompleto.val(),
        DataNascimento: _dataNascimento.val(),
        Idade: _idade.val(),
        Telefone: _telefone.val(),
        RG: _rg.val(),
        CPF: _cpf.val(),
        DiaVencimento: _diaVencimento.val(),

        //endereço Responsavel
        CEP: _cep.val(),
        CodigoUF: _codigoUF.val(),
        CodigoCidade: _codigoCidade.val(),
        Logradouro: _logradouro.val(),
        CodigoBairro: _codigoBairro.val()
    };
}