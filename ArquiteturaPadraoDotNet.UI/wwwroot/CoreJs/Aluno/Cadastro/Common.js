
$(document).ready(function () {
    $('.bt-salvar').click(function () {
        SalvarAluno();
    });
});

function ObterCidadesPorUF(CodigoUF, _target) {

    ExecutarComandoPost("/Gerenciar-Cidade/Obter-Cidades-Por-UF", { CodigoUF: CodigoUF },
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
        ExecutarComandoPost("/Gerenciar-Aluno/Registrar-Cadastro-Aluno", MontarCadastroAlunoViewModel(),
            function (retorno) {
                if (retorno.erro === 0) {
                    AlertSuccess(retorno.mensagem);
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

function MontarCadastroAlunoViewModel() {

    return {
        //dados do aluno
        NomeCompleto: _nomeCompleto.val(),
        DataNascimento: _dataNascimento.val(),
        Idade: _idade.val(),
        Telefone: _telefone.val(),
        RG: _rg.val(),
        CPF: _cpf.val(),
        DiaVencimento: _diaVencimento.val(),

        //endereço aluno
        CEP: _cep.val(),
        CodigoUF: _codigoUF.val(),
        CodigoCidade: _codigoCidade.val(),
        Logradouro: _logradouro.val(),
        CodigoBairro: _codigoBairro.val(),

        //dados do responsável
        NomeCompletoResponsavel: _nomeCompletoResponsavel.val(),
        DataNascimentoResponsavel: _dataNascimentoResponsavel.val(),
        CodigoParentesco: _codigoParentesco.val(),
        TelefoneResponsavel: _telefoneResponsavel.val(),
        RGResponsavel: _rgResponsavel.val(),
        CPFResponsavel: _cpfResponsavel.val(),

        //endereço Responsável
        CEPResponsavel: _cepResponsavel.val(),
        CodigoUFResponsavel: _codigoUFResponsavel.val(),
        CodigoCidadeResponsavel: _codigoCidadeResponsavel.val(),
        LogradouroResponsavel: _logradouroResponsavel.val(),
        CodigoBairroResponsavel: _codigoBairroResponsavel.val()
    };
}

function ValidarCadastroAlunoViewModel() {

    return ValidarDadosDoAluno() && ValidarEnderecoDoAluno && ValidarEnderecoDoResponsavel();
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
        AlertWarning("Preencha o cep do aluno")
        _cep.focus()
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

function ValidarDadosDoResponsavel() {
    //nome
    if ($.trim(_nomeCompletoResponsavel.val()) === '') {
        AlertWarning("Preencha o nome do Responsável");
        _nomeCompletoResponsavel.focus();
        return false;
    }

    //data de nascimento
    else if (!fIsDate($.trim(_dataNascimentoResponsavel.val()))) {
        AlertWarning("Preencha a data de nascimento do Responsavel");
        _dataNascimentoResponsavel.focus();
        return false;
    }

    //RG
    else if ($.trim(_rgResponsavel.val()) === "") {
        AlertWarning("Preencha o RG do Responsável");
        _rgResponsavel.focus();
        return false;
    }

    //CPF
    else if ($.trim(_cpfResponsavel.val()) === "") {
        AlertWarning("Preencha o CPF do Responsável");
        _cpfResponsavel.focus();
        return false;
    }

    return true;
}

function ValidarEnderecoDoResponsavel() {

    //cep
    if ($.trim(_cepResponsavel.val()) === "") {
        AlertWarning("Preencha o cep do responsável")
        _cepResponsavel.focus()
        return false;
    }

    //Estado
    else if (_codigoUFResponsavel.val() === "0") {
        AlertWarning("Preencha o estado do responsável");
        _codigoUFResponsavel.focus();
        return false;
    }

    //Cidade
    else if (_codigoCidadeResponsavel.val() === "0") {
        AlertWarning("Preencha a cidade do responsável");
        _codigoCidadeResponsavel.focus();
        return false;
    }

    //Logradouro
    else if ($.trim(_logradouroResponsavel.val()) === "") {
        AlertWarning("Preencha o endereço do responsável");
        _logradouroResponsavel.focus();
        return false;
    }

    //Bairro
    else if (_codigoBairroResponsavel.val() === "0") {

        AlertWarning("Preencha o bairro do responsável");
        _codigoBairroResponsavel.focus();
        return false;
    }

    return true;
}