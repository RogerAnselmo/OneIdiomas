
var _btPesquisar = $('#btPesquisar');
var _nomeResponsavel = $('#NomeResponsavel');
var _divAluno = $('#divResponsavel');

$(document).ready(function () {
    ObterResponsavelPorNome();

    _btPesquisar.click(function () {
        ObterResponsavelPorNome();
    });
});

function ObterResponsavelPorNome() {

    ExecutaComandoPostComRetornoHTML('/Gerenciar-Responsavel/Grid-Responsavel', _nomeResponsavel.val(),
        function (retorno) {
            _divAluno.html(retorno);
        },
        function (error) {
            AlertError("Erro ao carregar lista de responsável");
            console.log(error);
        });
}