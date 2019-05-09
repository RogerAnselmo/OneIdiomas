var _btPesquisar = $('#btPesquisar');
var _nomeProfessor = $('#NomeProfessor');
var _divProfessor = $('#divProfessor');

$(document).ready(function () {
    ObterProfessorPorNome();

    _btPesquisar.click(function () {
        ObterProfessorPorNome();
    });
});

function ObterProfessorPorNome() {

    ExecutaComandoPostComRetornoHTML('/Gerenciar-Professor/Grid-Professor', _nomeProfessor.val(),
        function (retorno) {
            _divProfessor.html(retorno);
        },
        function (error) {
            AlertError("Erro ao carregar lista de professores");
            console.log(error);
        });
}