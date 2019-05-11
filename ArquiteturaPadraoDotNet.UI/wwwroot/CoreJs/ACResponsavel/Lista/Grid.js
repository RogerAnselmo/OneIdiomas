var _tableResponsaveis = $('#tableResponsaveis');

$(document).ready(function () {
    ConfiguraDataTable(_tableResponsaveis);
});

function ExcluirResponsavel(id, botao) {
    AlertDelete("Tem certeza que deseja excluir o responsável?", function () {
        //ExecutarComandoPost('/Gerenciar-Responsavel/Registrar-Exclusao-Responsavel', id,
        //    function (retorno) {
        //        if (retorno.erro === 0) {
        //            $(botao).closest("tr").remove();
        //            AlertSuccess(retorno.mensagem);
        //        }
        //        else {
        //            AlertWarning(retorno.mensagem);
        //        }
        //    },
        //    function (error) {
        //        AlertError("Erro ao realizar a operação!");
        //        console.log(error);
        //    });

        ExecutarComandoPost('/Gerenciar-Responsavel/Registrar-Exclusao-Responsavel', id);
    });
}