//dados do Responsável
var _codigoResponsavel = $('#CodigoResponsavel');
var _codigoUsuarioResponsavel = $('#CodigoUsuarioResponsavel');
var _nomeResponsavel = $('#NomeResponsavel');
var _dataNascimentoResponsavel = $('#DataNascimentoResponsavel');
var _idadeResponsavel = $('#IdadeResponsavel');
var _rgResponsavel = $('#RGResponsavel');
var _cpfResponsavel = $('#CPFResponsavel');
var _diaVencimentoResponsavel = $('#DiaVencimentoResponsavel');
var _codigoParentesco = $('#CodigoParentesco');


//endereço Responsavel
var _codigoUFResponsavel = $('#CodigoUFResponsavel');
var _codigoCidadeResponsavel = $('#CodigoCidadeResponsavel');
var _codigoEnderecoResponsavel = $('#CodigoEnderecoResponsavel');
var _logradouroResponsavel = $('#LogradouroResponsavel');
var _codigoBairroResponsavel = $('#CodigoBairroResponsavel');
var _numeroResponsavel = $("#NumeroResponsavel");

//telefone
var _codigoTelefoneResponsavel = $('#CodigoTelefoneResponsavel');
var _telefoneResponsavel = $('#TelefoneResponsavel');

$(document).ready(function () {

    _dataNascimentoResponsavel.blur(function () {
        _idadeResponsavel.val(CalcularIdade(_dataNascimentoResponsavel.val()));
    });

    _codigoParentesco.change(function () {
        if ($(this).val() === "1")
            CopiarDadosAluno();
    });

    $('.bt-salvar').click(function () {
        SalvarResponsavel();
    });
});

function SalvarResponsavel() {

    if (ValidarDadosDoResponsavel() && ValidarEnderecoResponsavel()) {
        ExecutarComandoPost("/Gerenciar-Responsavel/Registrar-Cadastro-Responsavel", MontarCadastroResponsavelViewModel());
    }
}

function ValidarDadosDoResponsavel() {

    //nome
    if ($.trim(_nomeResponsavel.val()) === '') {
        AlertWarning("Preencha o nome do Responsavel");
        _nomeResponsavel.focus();
        return false;
    }

    //data de nascimento
    else if (!fIsDate($.trim(_dataNascimentoResponsavel.val()))) {
        AlertWarning("Preencha a data de nascimento do Responsavel");
        _dataNascimentoResponsavel.focus();
        return false;
    }

    //RG
    else if ($.trim(_rgResponsavel.val()) === "") {
        AlertWarning("Preencha o RG do Responsavel");
        _rgResponsavel.focus();
        return false;
    }

    //CPF
    else if ($.trim(_cpfResponsavel.val()) === "") {
        AlertWarning("Preencha o cpf do Responsavel");
        _dataNascimentoResponsavel.focus();
        return false;
    }

    //Parentesco
    if (_codigoParentesco.val() === "0") {
        AlertWarning('Informe o parentestco entre aluno e responsável');
        return false;
    }

   return true;
}

function ValidarEnderecoResponsavel() {

    if (_logradouroResponsavel.val() === "") {
        AlertWarning('Informe o endereço do responsavel');
        return false;
    }
    if (_codigoUFResponsavel.val() === "0") {
        AlertWarning('Informe o Estado do Responsável')
        return false;
    }
    if (_codigoCidadeResponsavel.val() === "0") {
        AlertWarning('Informe o Estado do Responsável')
        return false;
    }
    if (_logradouroResponsavel.val() === "") {
        AlertWarning('Informe o Endereço do Responsável')
        return false;
    }
    if (_codigoBairroResponsavel.val() === "0") {
        AlertWarning('Informe o Bairro do Responsável')
        return false;
    }

    return true;
}

function MontarCadastroResponsavelViewModel() {

    return {
        //dados do Responsavel
        CodigoResponsavel: _codigoResponsavel.val(),
        CodigoUsuarioResponsavel: _codigoUsuarioResponsavel.val(),
        NomeResponsavel: _nomeResponsavel.val(),
        DataNascimento: _dataNascimentoResponsavel.val(),
        Idade: _idadeResponsavel.val(),
        RG: _rgResponsavel.val(),
        CPF: _cpfResponsavel.val(),
        DiaVencimentoResponsavel: _diaVencimentoResponsavel.val(),

        //endereço Responsavel
        CodigoEnderecoResponsavel: _codigoEnderecoResponsavel.val(),
        CodigoUFResponsavel: _codigoUFResponsavel.val(),
        CodigoCidadeResponsavel: _codigoCidadeResponsavel.val(),
        LogradouroResponsavel: _logradouroResponsavel.val(),
        CodigoBairroResponsavel: _codigoBairroResponsavel.val(),

        //telefone
        CodigoTelefoneResponsavel: _codigoTelefoneResponsavel.val(),
        Telefone: _telefoneResponsavel.val(),

        CodigoParentesco : _codigoParentesco.val()
    };
}

function CopiarDadosAluno() {

    //dados do aluno
    _nomeResponsavel.val(_nomeCompleto.val());
    _dataNascimentoResponsavel.val(_dataNascimento.val());
    _idadeResponsavel.val(_idade.val());
    _rgResponsavel.val(_rg.val());
    _cpfResponsavel.val(_cpf.val());
    _codigoUFResponsavel.val(_codigoUF.val());
    _codigoCidadeResponsavel.val(_codigoCidade.val());
    _logradouroResponsavel.val(_logradouro.val());
    _codigoBairroResponsavel.val(_codigoBairro.val())
    _numeroResponsavel.val(_numero.val());
    _telefoneResponsavel.val(_telefone.val());
}