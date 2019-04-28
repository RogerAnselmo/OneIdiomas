var _tableAlunos = $('#tableAlunos');

$(document).ready(function () {
    ConfiguraDataTable(_tableAlunos);
});

function ExcluirAluno(id, botao) {
    AlertDelete("Tem certeza que deseja excluir o aluno?", function () {
        ExecutarComandoPost('/Gerenciar-Aluno/Excluir-Aluno', id,
            function (retorno) {
                if (retorno.erro === 0) {
                    $(botao).closest("tr").remove();
                    AlertSuccess(retorno.mensagem);
                }
                else {
                    AlertWarning(retorno.mensagem);
                }
            },
            function (error) {
                AlertError(retorno.mensagem);
                console.log(error);
            });
    });
}