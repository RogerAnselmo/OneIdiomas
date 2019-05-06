$(document).ready(function () {
    ConfiguraDateFormat();
});

function fIsDate(data) {
    if (data.length === 10) {
        er = /(0[0-9]|[12][0-9]|3[01])[-\.\/](0[0-9]|1[012])[-\.\/][0-9]{4}/;
        if (er.exec(data)) {
            return true;
        } else {
            return false;
        }

    } else {
        return false;
    }
}

function ConfiguraDatePicker(_target) {

    _target.datepicker({
        format: 'dd/mm/yyyy',
        language: 'pt-BR',
        autoclose: true,
        todayHighlight: true
    });

    //DesabilitaDigitacaoNoCampo(_target);

}

function CalcularIdade(data) {

    var ano_aniversario = data.split('/')[2];
    var mes_aniversario = data.split('/')[1];
    var dia_aniversario = data.split('/')[0];


    var d = new Date,
        ano_atual = d.getFullYear(),
        mes_atual = d.getMonth() + 1,
        dia_atual = d.getDate(),

        //ano_aniversario = +ano_aniversario,
        //mes_aniversario = +mes_aniversario,
        //dia_aniversario = +dia_aniversario,

        quantos_anos = ano_atual - ano_aniversario;

    if (mes_atual < mes_aniversario || mes_atual == mes_aniversario && dia_atual < dia_aniversario) {
        quantos_anos--;
    }

    return quantos_anos < 0 ? 0 : quantos_anos;
}

function ConfiguraDateFormat() {

    _ModuloSistema.find('[one-ui="date"]').mask("99/99/9999");

    _ModuloSistema.find('[one-ui="date"]').each(function (i, el) {

        //$(el).mask("99/99/9999");

        $(el).blur(function () {
            if ($(el).val() !== '' && !fIsDate($(el).val())) {
                AlertWarning('Informe uma data válida');
                $(el).focus();
            }
        })
    });
}