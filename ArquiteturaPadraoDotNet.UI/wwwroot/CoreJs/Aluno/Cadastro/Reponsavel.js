//dados do Responsável
var _codigoResponsavel = $('#CodigoResponsavel').val();
var _nomeCompletoResponsavel = $('#NomeCompletoResponsavel');
var _dataNascimentoResponsavel = $('#DataNascimentoResponsavel');
var _codigoParentesco = $('#CodigoParentesco');
var _telefoneResponsavel = $('#TelefoneResponsavel');
var _rgResponsavel = $('#RGResponsavel');
var _cpfResponsavel = $('#CPFResponsavel');
var _Aluno_OProprioResponsavel = $('#Aluno_OProprioResponsavel');

//endereço Responsável
var _cepResponsavel = $('#CEPResponsavel');
var _codigoUFResponsavel = $('#CodigoUFResponsavel');
var _codigoCidadeResponsavel = $('#CodigoCidadeResponsavel');
var _logradouroResponsavel = $('#LogradouroResponsavel');
var _codigoBairroResponsavel = $('#CodigoBairroResponsavel');
var _UsarEnderecoDoAluno = $('#UsarEnderecoDoAluno');

$(document).ready(function () {

    _idade.attr("disabled", "disabled");

    //configura datas
    ConfiguraDatePicker(_dataNascimentoResponsavel);

    _codigoUFResponsavel.val(0);

    _codigoUFResponsavel.change(function () {
        ObterCidadesPorUF(_codigoUFResponsavel.val(), _codigoCidadeResponsavel);
    });

    _codigoUFResponsavel.val(5);//Pará

    ObterCidadesPorUF(_codigoUFResponsavel.val(), _codigoCidadeResponsavel);

    _UsarEnderecoDoAluno.click(function () {
        if (_UsarEnderecoDoAluno.is(':checked')) {
            AlertSuccess("meu pau");
        }
    });

    _Aluno_OProprioResponsavel.click(function () {
        if (_Aluno_OProprioResponsavel.is(':checked')) {
            AlertSuccess("no teu cu");
        }
    });

    _codigoUFResponsavel.attr("disabled", "true");
    _codigoCidadeResponsavel.attr("disabled", "true");

});

