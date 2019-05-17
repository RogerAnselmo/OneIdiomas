var _passoAtual;
var _minimoPassos = 1;
var _totalPassos = 4;
var _progressIndicator = $('.progress-indicator');

$(document).ready(function () {

    CarregarHtmlView('/Gerenciar-Matricula/Selecionar-Aluno', {}, 'tab_1');
    CarregarHtmlView('/Gerenciar-Aluno/Selecionar-Responsavel', {}, 'tab_2');

    _passoAtual = _minimoPassos;

    $('.next').click(function () {
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

function ShowTab() {

}