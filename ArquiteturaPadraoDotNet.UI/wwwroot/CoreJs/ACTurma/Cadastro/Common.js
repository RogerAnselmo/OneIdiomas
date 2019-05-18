var _codigoTurma = $('#CodigoTurma');
var _codigoProfessor = $('#CodigoProfessor');
var _codigoNivel = $('#CodigoNivel');
var _codigoIdentificador = $('#CodigoIdentificador ');
var _dataInicio = $('#DataInicio');
var _dataFim = $('#DataFim');
var _valorBase = $('#ValorBase');
var _descricao = $('#Descricao');
var _horaInicio = $('#HoraInicio');
var _horaFim = $('#HoraFim');
var _diasDaSemana = $('#DiasDaSemana');

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
        ValorBase: _valorBase.val().replace(".", "").replace(",","."),
        Descricao: _descricao.val(),
        CodigoIdentificador: _codigoIdentificador.val(),
        HoraInicio: _horaInicio.val(),
        HoraFim: _horaFim.val(),
        DiasDaSemana: _diasDaSemana.val()
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

    if (!fIsTime($.trim(_horaInicio.val()))) {
        AlertWarning('Informe uma hora inicial válida');
        return false;
    }

    if (!fIsTime($.trim(_horaFim.val()))) {
        AlertWarning('Informe uma hora final válida');
        return false;
    }

    if (_diasDaSemana.val() == "0") {
        AlertWarning('Informe os dias de aula na semana');
        return false;
    }

    return true;
}

function AdicionarRemoverDiaDaSemana(campo, valor) {

    var dias = parseInt(_diasDaSemana.val());

    if ($(campo).is(":checked"))
        dias += valor;
    else
        dias -= valor;

    _diasDaSemana.val(dias);
}