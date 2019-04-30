var _tableResponsaveis = $('#tableResponsaveis');

$(document).ready(function () {
    ConfiguraDataTable(_tableResponsaveis);
});

function ExcluirAluno(id, botao) {
    AlertDelete("Tem certeza que deseja excluir o responsável?", function () {
        ExecutarComandoPost('/Gerenciar-Responsavel/Excluir-Responsavel', id,
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