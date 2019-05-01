var _nome = $('#NomeCompleto');
var _login = $('#Login');
var _email = $('#Email');
var _senha = $('#Senha');
var _cpf = $('#CPF');
var _confirmaSenha = $('#ConfirmacaoSenha');

$(document).ready(function () {
    $('.btnSalvar').click(function () {
        SalvarNovoUsuario();
    });

    _nome.val("Carlos Rogério Campos Anselmo");
    _login.val("cranselmo");
    _senha.val("123456");
    _confirmaSenha.val("123456");
});

function SalvarNovoUsuario() {

    var usuario = {
        NomeCompleto: _nome.val(),
        Login: _login.val(),
        Senha: _senha.val(),
        CodigoUsuario: 0
    };

    ExecutarComandoPost("/Seguranca/SalvarUsuarioAsync", usuario,
        function (retorno) {

            if (retorno.erro === 0) {
                AlertSuccessCallBack("Usuário cadastrado com sucesso", function () { window.history.back(1);});
            }
            else {
                AlertWarning(retorno.mensagem);
            }
        },
        function (erro) {
            AlertError('Erro ao salvar usuário');
        });

}

function ValidarUsuario() {

    if (_nome.val() === '') {
        AlertWarning('Informe o nome do usuário');
        return false;
    }
    else if (_login.val() === '') {
        AlertWarning('Informe o Login do Usuário');
        return false;
    }
    else if (_senha.val() === '') {
        AlertWarning('Informe uma senha do Usuário');
        return false;
    }
    else if (_senha.val() === '') {
        AlertWarning('Informe uma senha do Usuário');
        return false;
    }
    else if (_senha.val() !== _confirmaSenha.val()) {
        AlertWarning('Erro ao confirmar senha');
        return false;
    }
    else if (_slcFornecedor.val() === 0 || _slcFornecedor.val() === '') {
        AlertWarning('Selecione um Fornecedor');
        return false;
    }

    return true;
}