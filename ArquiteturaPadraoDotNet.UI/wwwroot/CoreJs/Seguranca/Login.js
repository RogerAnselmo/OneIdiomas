var _login = $('#Login');
var _senha = $('#Senha');

$(document).ready(function () {

    sessionStorage.removeItem('usr');
    $('#btnEntrar').click(function () {
        AutenticarUsuario();
    });
});

function AutenticarUsuario() {
    var usuario = {
        Login: _login.val(),
        Senha: _senha.val()
    };

    ExecutarComandoPost('/Gerenciar-Seguranca/Autenticar-Usuario', usuario,
        function (retorno) {
            if (retorno.erro == 0) {
                sessionStorage.setItem("usr", JSON.stringify(retorno.data));
                redirectToUrl(_defaulUrl);
            }
            else {
                AlertWarning(retorno.mensagem)
            }
        },
        function (error) {
            AlertError(error.mensagem);
            console.log(error)
        });
}
