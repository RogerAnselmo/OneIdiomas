
var _btPesquisar = $('#btPesquisar');
var _nomeTurma = $('#FiltroTurma');
var _divAluno = $('#divTurma');

$(document).ready(function () {
    ObterTurmaPorNome();

    _btPesquisar.click(function () {
        ObterTurmaPorNome();
    });
});

function ObterTurmaPorNome() {

    ExecutaComandoPostComRetornoHTML('/Gerenciar-Turma/Grid-Turma', _nomeTurma.val(),
        function (retorno) {
            _divAluno.html(retorno);
        },
        function (error) {
            AlertError("Erro ao carregar lista de turmas");
            console.log(error);
        });
}