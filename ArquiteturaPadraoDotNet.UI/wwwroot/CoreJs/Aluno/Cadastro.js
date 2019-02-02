//dados do aluno
var _codigoAluno = $('#CodigoAluno')
var _nomeCompleto = $('#NomeCompleto');
var _dataNascimento = $('#DataNascimento');
var _idade = $('#Idade');
var _telefone = $('#Telefone');
var _rg = $('#RG');
var _cpf = $('#CPF');
var _diaVencimento = $('#DiaVencimento');

//endereço aluno
var _cep = $('#CEP');
var _codigoUF = $('#CodigoUF');
var _codigoCidade = $('#CodigoCidade');
var _logradouro = $('#Logradouro');
var _codigoBairro = $('#CodigoBairro');

//dados do Responsável
var _codigoResponsavel = $('#CodigoResponsavel').val();
var _nomeCompletoResponsavel = $('#NomeCompletoResponsavel');
var _dataNascimentoResponsavel = $('#DataNascimentoResponsavel');
var _codigoParentesco = $('#CodigoParentesco');
var _telefoneResponsavel = $('#TelefoneResponsavel');
var _rgResponsavel = $('#RGResponsavel');
var _cpfResponsavel = $('#CPFResponsavel');

//endereço Responsável
var _cepResponsavel = $('#CEPResponsavel');
var _codigoUFResponsavel = $('#CodigoUFResponsavel');
var _codigoCidadeResponsavel = $('#CodigoCidadeResponsavel');
var _logradouroResponsavel = $('#LogradouroResponsavel');
var _codigoBairroResponsavel = $('#CodigoBairroResponsavel');

$(document).ready(function () {

    _idade.attr("disabled", "disabled");

    //configura datas
    //ConfiguraDatePicker(_dataNascimento);
    //ConfiguraDatePicker(_dataNascimentoResponsavel);

    $('.bt-salvar').click(function () {
        SalvarAluno();
    });

    _codigoUF.change(function () {
        ObterCidadesPorUF(_codigoUF.val(), _codigoCidade);
    });

    _codigoUFResponsavel.change(function () {
        ObterCidadesPorUF($(this).val(), function (data) {

            $(this).empty();
            appendOption(0, "Selecione a Cidade", $(this));

            $.forEach(data, function (item) {
                appendOption(item.CodigoCidade, item.Descricao, $(this));
            });

            $(this).val(0);

        });
    });

});

function SalvarAluno() {
    //var CadastroAlunoViewModel = ObterCadastroAlunoViewModel();

    if (ValidarDadosDoAluno() && ValidarEnderecoDoAluno && ValidarDadosDoResponsavel() && ValidarEnderecoDoResponsavel()) {
        AlertSuccess("Aluno salvo com sucesso", function () { window.location.reload(); })
    }

    AlertSuccess("Aluno salvo com sucesso!");
}

function ObterCidadesPorUF(CodigoUF, _target) {

    ExecutarComandoPost("/Gerenciar-Cidade/Obter-Cidades-Por-UF", {CodigoUF: CodigoUF},
        function (retorno) {

            if (retorno.erro === 0) {

                _target.empty();
                appendOption(0, "Selecione a Cidade", _target);

                $.each(retorno.data, function (i, item) {
                    appendOption(item.CodigoCidade, item.Descricao, _target)
                });


                _target.val(0);

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



//Validações
function ValidarCadastroAlunoViewModel() {

    //valida dados do aluno


};

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
    else if ($.trim(_cpf.val())) {
        AlertWarning("Preencha a data de nascimento do aluno");
        _dataNascimento.focus();
        return false;
    }

    //dia de vencimento
    else if (_diaVencimento.val() === "0") {
        AlertWarning("Preencha a data de nascimento do aluno");
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

function ObterCadastroAlunoViewModel() {

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