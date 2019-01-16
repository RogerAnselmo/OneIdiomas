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

    //if (!ValidarUsuario()) {
    //    return;
    //}

    var usuario = {        
        NomeCompleto: _nome.val(),
        Login: _login.val(),
        //Email: _email.val(),
        Senha: _senha.val(),
        //ConfirmacaoSenha: _confirmaSenha.val(),
        //CPF: _cpf.val(),
        CodigoUsuario: 0
    };

    ExecutarComandoPost("/Seguranca/SalvarUsuarioAsync", usuario,
        function (retorno) {

            if (retorno.erro == 0) {
                AlertSuccess("Usuário cadastrado com sucesso", function () { location.reload(); });
            }
            else {
                AlertWarning(retorno.data.mensagem);
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
    else if (_slcFornecedor.val() == 0 || _slcFornecedor.val() == '') {
        AlertWarning('Selecione um Fornecedor');
        return false;
    }

    return true;
}