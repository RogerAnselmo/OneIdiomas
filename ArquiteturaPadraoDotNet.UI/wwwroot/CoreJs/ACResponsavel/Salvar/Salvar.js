$(document).ready(function () {

    $('.bt-salvar').click(function () {
        SalvarAluno();
    });

});


function SalvarResponsavel() {

    if (ValidarDadosDoResponsavel()) {

        ExecutarComandoPost("/Gerenciar-Responsavel/Registrar-Cadastro-Responsavel", MontarCadastroResponsavelViewModel());
    }
}