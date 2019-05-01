//dados do aluno
var _codigoAluno = $('#CodigoAluno');
var _codigoUsuario = $('#CodigoUsuario');
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

    _dataNascimento.blur(function () {

        if (_dataNascimento.val() === '' || !fIsDate(_dataNascimento.val()))
            return;

        _idade.val(CalcularIdade(_dataNascimento.val()));
    });
});

$('.bt-salvar').click(function () {
    AlterarAluno();
});

function AlterarAluno() {

    if (ValidarDadosDoAluno()) {

        var editarAlunoViewModel = MontarEditarAlunoViewModel();

        ExecutarComandoPost("/Gerenciar-Aluno/Registrar-Edicao-Aluno", MontarEditarAlunoViewModel(),
            function (retorno) {
                if (retorno.erro === 0) {
                    AlertSuccessCallBack(retorno.mensagem, function () { window.history.back(1); });
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

function ValidarDadosDoAluno() {

    //nome
    if ($.trim(_nomeCompleto.val()) === '') {
        AlertWarning("Preencha o nome do aluno");
        _nomeCompleto.focus();
        return false;
    }

    //data de nascimento
    else if (!fIsDate($.trim(_dataNascimento.val()))) {
        AlertWarning("Preencha a data de nascimento do aluno");
        _dataNascimento.focus();
        return false;
    }

    //RG
    else if ($.trim(_rg.val()) === "") {
        AlertWarning("Preencha o RG do aluno");
        _rg.focus();
        return false;
    }

    //CPF
    else if ($.trim(_cpf.val()) === "") {
        AlertWarning("Preencha o cpf do aluno");
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

function MontarEditarAlunoViewModel() {

    return {
        //dados do aluno
        CodigoAluno: _codigoAluno.val(),
        CodigoUsuario: _codigoUsuario.val(),
        NomeCompleto: _nomeCompleto.val(),
        DataNascimento: _dataNascimento.val(),
        Idade: _idade.val(),
        Telefone: _telefone.val(),
        RG: _rg.val(),
        CPF: _cpf.val(),
        DiaVencimento: _diaVencimento.val(),

        //endereço aluno
        CEP: _cep.val(),
        CodigoUF: _codigoUF.val(),
        CodigoCidade: _codigoCidade.val(),
        Logradouro: _logradouro.val(),
        CodigoBairro: _codigoBairro.val()
    };
}