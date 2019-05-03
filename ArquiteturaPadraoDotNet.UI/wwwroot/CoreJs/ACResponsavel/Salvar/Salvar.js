$(document).ready(function () {

    $('.bt-salvar').click(function () {
        SalvarAluno();
    });

});


function SalvarResponsavel() {

    if (ValidarDadosDoResponsavel()) {

        ExecutarComandoPost("/Gerenciar-Responsavel/Registrar-Cadastro-Responsavel", MontarCadastroResponsavelViewModel(),
            function (retorno) {
                if (retorno.erro === 0) {
                    AlertSuccessCallBack(retorno.mensagem, function () { history.back(1); });
                }
                else {
                    AlertWarning(retorno.mensagem);
                }
            },
            function (error) {
                console.log(error);
                AlertError(error.mensagem);
            });
    }
}