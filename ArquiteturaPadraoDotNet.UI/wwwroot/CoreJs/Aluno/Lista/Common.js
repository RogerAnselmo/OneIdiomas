var _tableAlunos = $('#tableAlunos');
var _btPesquisar = $('#btPesquisar');
var _frm_lista_aluno = $('#frm_lista_aluno');

$(document).ready(function () {
    ConfiguraDataTable(_tableAlunos);

    _btPesquisar.click(function () {
        _frm_lista_aluno.submit();
    });

});

