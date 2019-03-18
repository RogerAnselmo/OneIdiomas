var _login = $('#Login');
var _senha = $('#Senha');
var _frm = $('#frmLogin');

$(document).ready(function () {

    sessionStorage.removeItem('usr');

    $('.btnEntrar').click(function () {

        if (ValidarLogin())
            _frm.submit();

    });
});

function ValidarLogin() {

    if ($.trim(_login.val()) === '') {
        AlertWarning('Preencha o Login')
        return false;
    }
    else if ($.trim(_senha.val()) === '') {
        AlertWarning('Preencha a senha')
        return false;
    }

    return true;
}

