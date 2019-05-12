var _tableTurmas = $('#tableTurmas');

$(document).ready(function () {
    ConfiguraDataTable(_tableTurmas);
});

function ExcluirTurma(id) {
    AlertDelete("Tem certeza que deseja excluir a turma?", function () {
        ExecutarComandoPost('/Gerenciar-Turma/Registrar-Exclusao-Turma', id);
    });
}