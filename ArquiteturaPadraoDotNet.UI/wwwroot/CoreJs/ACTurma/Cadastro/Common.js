var _codigoTurma = $('#CodigoTurma');
var _codigoProfessor = $('#CodigoProfessor');
var _codigoNivel = $('#CodigoNivel');
var _codigoIdentificador = $('#CodigoIdentificador ');
var _dataInicio = $('#DataInicio');
var _dataFim = $('#DataFim');
var _valorBase = $('#ValorBase');
var _descricao = $('#Descricao');

$(document).ready(function () {
    $('.bt-salvar').click(function () {
        SalvarTurma();
    });
});

function SalvarTurma() {
    if (!ValidarCadastroTurmaViewModel())
        return;

    ExecutarComandoPost('/Gerenciar-Turma/Registrar-Cadastro-Turma', MontarCadastroTurma());
}

function MontarCadastroTurma() {
    return {
        CodigoTurma: _codigoTurma.val(),
        CodigoProfessor: _codigoProfessor.val(),
        codigoNivel: _codigoNivel.val(),
        DataInicio: _dataInicio.val(),
        DataFim: _dataFim.val(),
        ValorBase: _valorBase.val(),
        Descricao: _descricao.val(),
        CodigoIdentificador: _codigoIdentificador.val()
    };
}

function ValidarCadastroTurmaViewModel() {

    if (_codigoProfessor.val() === "0" || _codigoProfessor.val() === '') {
        AlertWarning('Selecione um professor');
        return false;
    }

    if (_codigoNivel.val() === "0" || _codigoNivel.val() === '') {
        AlertWarning('Selecione um Nível');
        return false;
    }

    if (_dataInicio.val() === '' || !fIsDate(_dataInicio.val())) {
        AlertWarning('Selecione uma data de início válida');
        return false;
    }

    if (_dataInicio.val() === '' || !fIsDate(_dataInicio.val())) {
        AlertWarning('Selecione uma data de início válida');
        return false;
    } if (_dataFim.val() === '' || !fIsDate(_dataFim.val())) {
        AlertWarning('Selecione uma data final válida');
        return false;
    }

    if (_valorBase.val() === '') {
        AlertWarning('Informe o valor Base');
        return false;
    }

    if ($.trim(_descricao.val()) === '') {
        AlertWarning('Informe a descricao');
        return false;
    }

    return true;
}