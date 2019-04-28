
var _btPesquisar = $('#btPesquisar');
var _nomeAluno = $('#NomeAluno');
var _divAluno = $('#divAluno');

$(document).ready(function () {

    ObterAlunosPorNome();

    _btPesquisar.click(function () {
        ObterAlunosPorNome();
    });

});

function ObterAlunosPorNome() {

    ExecutaComandoPostComRetornoHTML('/Gerenciar-Aluno/Grid-Aluno', _nomeAluno.val(),
        function (retorno) {
            _divAluno.html(retorno);
        },
        function (error) {
            AlertError("Erro ao carregar lista de alunos");
            console.log(error);
        });

    
}