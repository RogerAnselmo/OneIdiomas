//dados do Responsável
var _codigoResponsavel = $('#CodigoResponsavel').val();
var _nomeCompletoResponsavel = $('#NomeCompletoResponsavel');
var _dataNascimentoResponsavel = $('#DataNascimentoResponsavel');
var _codigoParentesco = $('#CodigoParentesco');
var _telefoneResponsavel = $('#TelefoneResponsavel');
var _rgResponsavel = $('#RGResponsavel');
var _cpfResponsavel = $('#CPFResponsavel');
var _Aluno_OProprioResponsavel = $('#Aluno_OProprioResponsavel');
var _IdadeResponsavel = $('#IdadeResponsave');

//endereço Responsável
var _cepResponsavel = $('#CEPResponsavel');
var _codigoUFResponsavel = $('#CodigoUFResponsavel');
var _codigoCidadeResponsavel = $('#CodigoCidadeResponsavel');
var _logradouroResponsavel = $('#LogradouroResponsavel');
var _codigoBairroResponsavel = $('#CodigoBairroResponsavel');
var _UsarEnderecoDoAluno = $('#UsarEnderecoDoAluno');

$(document).ready(function () {

    _IdadeResponsavel.attr("disabled", "disabled");

    //configura datas
    ConfiguraDatePicker(_dataNascimentoResponsavel);

    _codigoUFResponsavel.val(5);//Pará
    _codigoCidadeResponsavel.val(1);//Abaetetuba

    _UsarEnderecoDoAluno.click(function () {
        if (_UsarEnderecoDoAluno.is(':checked')) {
            CopiarEnderecoDoAluno();
        }
    });

    _Aluno_OProprioResponsavel.click(function () {
        if (_Aluno_OProprioResponsavel.is(':checked')) {
            CopiarDadosDoAluno();
        }
        else {
            _UsarEnderecoDoAluno.removeAttr("checked");
        }
    });

    _codigoParentesco.change(function () {
        if (_CodigoParentesco.val() === "1") {
            CopiarDadosDoAluno();
        }
    });

    _codigoUFResponsavel.attr("disabled", "true");
    _codigoCidadeResponsavel.attr("disabled", "true");

    _dataNascimento.blur(function () {

        if (_dataNascimento.val() == '' || !fIsDate(_dataNascimento.val()))
            return;

        _idade.val(CalcularIdade(_dataNascimento.val()));
    });
});

function CopiarEnderecoDoAluno() {
    _cepResponsavel.val(_cep.val());
    _codigoUFResponsavel.val(_codigoUF.val());
    _codigoCidadeResponsavel.val(_codigoCidade.val());
    _logradouroResponsavel.val(_logradouro.val());
    _codigoBairroResponsavel.val(_codigoBairro.val());
}

function CopiarDadosDoAluno() {
    _nomeCompletoResponsavel.val(_nomeCompleto.val());
    _dataNascimentoResponsavel.val(_dataNascimento.val());
    _telefoneResponsavel.val(_telefone.val());
    _cpfResponsavel.val(_cpf.val());
    _rgResponsavel.val(_rg.val());
    _codigoParentesco.val(1);//1 == o próprio
    _UsarEnderecoDoAluno.attr("checked", "checked");
    _dataNascimentoResponsavel.val(_dataNascimento.val());
    CopiarEnderecoDoAluno();
}

