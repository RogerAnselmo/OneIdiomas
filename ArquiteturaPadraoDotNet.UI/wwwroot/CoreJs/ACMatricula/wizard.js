var _passoAtual;
var _minimoPassos = 1;
var _totalPassos = 4;
var _progressIndicator = $('.progress-indicator');
var _selecaoAluno = 0;
var _selecaoResponsavel = 0;

$(document).ready(function () {

    CarregarHtmlView('/Gerenciar-Matricula/Selecionar-Aluno', {}, 'tab_1');
    CarregarHtmlView('/Gerenciar-Matricula/Selecionar-Responsavel', {}, 'tab_2');

    _passoAtual = _minimoPassos;

    $('.next').click(function () {

        if (_passoAtual === 1 && !ValidacaoAluno())
            return false;

        if (_passoAtual === 2 && !ValidacaoResponsavel())
            return false;

        _passoAtual = (_passoAtual < _totalPassos) ? _passoAtual + 1 : _totalPassos;
        AtivaNumero();
    });

    $('.previous').click(function () {
        _passoAtual = (_passoAtual > _minimoPassos) ? _passoAtual - 1 : _minimoPassos;
        AtivaNumero(_passoAtual);
    });

});

function AtivaNumero() {

    for (let i = _minimoPassos; i <= _totalPassos; i++) {
        if (i <= _passoAtual) {
            $('#li_' + i).addClass('active');
            $('#tab_' + i).addClass('active');
        }
        else {
            $('#li_' + i).removeClass('active');
            
        }

        if (i == _passoAtual) {
            $('#tab_' + i).addClass('active');
        }
        else {
            $('#tab_' + i).removeClass('active');
        }
    }

    AddWidth();
}

function AddWidth() {
    _progressIndicator.attr("style", "width:" + (33 * (_passoAtual - 1)) + "%");
}

function ClickNumero(passo) {
    _passoAtual = passo;
    AtivaNumero();
}

function ValidacaoAluno() {
    if (_selecaoAluno === 0) {
        AlertWarning("Selecione o Aluno");
        return false;
    }
    else if (_selecaoAluno === 1 && !ValidarCadastroAlunoViewModel()) {
        return false;
    }
    if (_selecaoAluno === 2) {

    }

    return true;
}

function ValidacaoResponsavel() {
    if (_selecaoResponsavel === 0) {
        AlertWarning("Selecione o Responsável");
        return false;
    }
    else if (_selecaoResponsavel === 1 && !(ValidarDadosDoResponsavel() && ValidarEnderecoResponsavel())) {
        return false;
    }

    return true;
}