var _tableProfessores = $('#tableProfessor');

$(document).ready(function () {
    ConfiguraDataTable(_tableProfessores);
});

function ExcluirProfessor(id, botao) {
    AlertDelete("Tem certeza que deseja excluir o professor?", function () {
        //ExecutarComandoPost('/Gerenciar-Professor/Registrar-Exclusao-Professor', id,
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

        ExecutarComandoPost('/Gerenciar-Professor/Registrar-Exclusao-Professor', id);
    });
}