var _codigoUsuario = $('#CodigoUsuario');
var _codigoProfessor = $('#CodigoProfessor');
var _nomeProfessor = $('#NomeProfessor');
var _dataNascimento = $('#DataNascimento');
var _rg = $('#RG');
var _cpf = $('#CPF');

$(document).ready(function () {

    $('.bt-salvar').click(function () {
        SalvarProfessor();
    });
});

function SalvarProfessor() {
    if (ValidarCadastroProfessorViewModel()) {
        //ExecutarComandoPost("/Gerenciar-Professor/Registrar-Cadastro-Professor", MontarCadastroProfessorViewModel(),
        //    function (retorno) {
        //        if (retorno.erro === 0) {
        //            AlertSuccessCallBack(retorno.mensagem, function () {
        //                history.back();
        //            });
        //        }
        //        else {
        //            AlertWarning(retorno.mensagem);
        //        }
        //    },
        //    function (error) {
        //        console.log(error); AlertError("Erro ao realizar operação");
        //    });

        ExecutarComandoPost("/Gerenciar-Professor/Registrar-Cadastro-Professor", MontarCadastroProfessorViewModel());
    }
}

function ValidarCadastroProfessorViewModel() {

    if (_nomeProfessor.val() === '') {
        AlertWarning('Informe o nome do professor');
        return false;
    }

    if (_dataNascimento.val() === '' || !fIsDate(_dataNascimento.val())) {
        AlertWarning('Informe uma data de nascimento válida');
        return false;
    }

    if (_rg.val() === '') {
        AlertWarning('Informe o RG do professor');
        return false;
    }

    if (_cpf.val() === '') {
        AlertWarning('Informe o CPF do professor');
        return false;
    }

    return true;
}

function MontarCadastroProfessorViewModel() {

    return {
        CodigoUsuario: _codigoUsuario.val(),
        CodigoProfessor: _codigoProfessor.val(),
        NomeProfessor: _nomeProfessor.val(),
        DataNascimento: _dataNascimento.val(),
        RG: _rg.val(),
        CPF: _cpf.val()
    };

}