
$(document).ready(function () {
    $('.bt-salvar').click(function () {
        SalvarAluno();
    });

//    CarregarHtmlSelecaoResponsavel();
});

function ObterCidadesPorUF(CodigoUF, _target) {

    ExecutarComandoPostCallBack("/Gerenciar-Cidade/Obter-Cidades-Por-UF", { CodigoUF: CodigoUF },
        function (retorno) {

            if (retorno.erro === 0) {

                _target.empty();
                appendOption(0, "Selecione a Cidade", _target);

                $.each(retorno.data, function (i, item) {
                    appendOption(item.CodigoCidade, item.Descricao, _target);
                });

                //_target.val(_codigoCidade.val());
                _target.val(1);//abaetetuaba
            }
            else {
                AlertWarning(retorno.mensagem);
            }

        },
        function (error) {
            console.log(error);
            AlertError("Erro ao carregar Cidades");
        });

}

function ObterBairrosPorCidade(CodigoCidade, _target) {

    ExecutarComandoGet("/Gerenciar-Bairro/Obter-Bairros-Por-Cidade/" + CodigoCidade,
        function (retorno) {

            if (retorno.erro === 0) {

                _target.empty();
                appendOption(0, "Selecione o Bairro", _target);

                $.each(retorno.data, function (i, item) {
                    appendOption(item.CodigoBairro, item.Descricao, _target);
                });

                _target.val(_codigoBairro.val());
            }
            else {
                AlertWarning(retorno.mensagem);
            }

        },
        function (error) {
            console.log(error);
            AlertError("Erro ao carregar Bairros");
        });

}

function SalvarAluno() {

    if (ValidarCadastroAlunoViewModel()) {
        //ExecutarComandoPost("/Gerenciar-Aluno/Registrar-Cadastro-Aluno", MontarCadastroAlunoViewModel(),
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
        //        console.log(error);
        //        AlertError(error.mensagem);
        //    });

        ExecutarComandoPost("/Gerenciar-Aluno/Registrar-Cadastro-Aluno", MontarCadastroAlunoViewModel());
    }
}

function MontarCadastroAlunoViewModel() {

    return {

        CodigoUsuario: _codigoUsuario.val(),
        CodigoAluno: _codigoAluno.val(),

        //dados do aluno
        NomeCompleto: _nomeCompleto.val(),
        DataNascimento: _dataNascimento.val(),
        Idade: _idade.val(),
        RG: _rg.val(),
        CPF: _cpf.val(),
        DiaVencimento: _diaVencimento.val(),

        //endereço aluno
        CEP: _cep.val(),
        CodigoUF: _codigoUF.val(),
        CodigoCidade: _codigoCidade.val(),
        Logradouro: _logradouro.val(),
        CodigoBairro: _codigoBairro.val(),
        Numero: _numero.val(),

        //telefone
        CodigoTelefone: _codigoTelefone.val(),
        Telefone: _telefone.val()
    };
}

function ValidarCadastroAlunoViewModel() {

    return ValidarDadosDoAluno() && ValidarEnderecoDoAluno();
}

function ValidarDadosDoAluno() {

    //nome
    if ($.trim(_nomeCompleto.val()) === '') {
        AlertWarning("Preencha o nome do aluno");
        _nomeCompleto.focus();
        return false;
    }

    //data de nascimento
    else if (!fIsDate($.trim(_dataNascimento.val()))) {
        AlertWarning("Preencha a data de nascimento do aluno");
        _dataNascimento.focus();
        return false;
    }

    //RG
    else if ($.trim(_rg.val()) === "") {
        AlertWarning("Preencha o RG do aluno");
        _rg.focus();
        return false;
    }

    //CPF
    else if ($.trim(_cpf.val()) === "") {
        AlertWarning("Preencha o cpf do aluno");
        _dataNascimento.focus();
        return false;
    }

    //dia de vencimento
    else if (_diaVencimento.val() === "0") {
        AlertWarning("Preencha o dia de vencimento");
        _diaVencimento.focus();
        return false;
    }

    return true;
}

function ValidarEnderecoDoAluno() {

    //cep
    if ($.trim(_cep.val()) === "") {
        AlertWarning("Preencha o cep do aluno");
        _cep.focus();
        return false;
    }

    //Estado
    else if (_codigoUF.val() === "0") {
        AlertWarning("Preencha o estado do aluno");
        _codigoUF.focus();
        return false;
    }

    //Cidade
    else if (_codigoCidade.val() === "0") {
        AlertWarning("Preencha a cidade do aluno");
        _codigoCidade.focus();
        return false;
    }

    //Logradouro
    else if ($.trim(_logradouro.val()) === "") {
        AlertWarning("Preencha o endereço do aluno");
        _logradouro.focus();
        return false;
    }

    //Bairro
    else if (_codigoBairro.val() === "0") {

        AlertWarning("Preencha o bairro do aluno");
        _codigoBairro.focus();
        return false;
    }

    return true;
}

function CarregarHtmlSelecaoResponsavel() {
    CarregarHtmlView('/Gerenciar-Aluno/Selecionar-Responsavel', {}, 'tab-responsavel');
}