$(document).ready(function () {
    ConfiguraTimeFormat();
});

function ConfiguraTimeFormat() {

    _ModuloSistema.find('[one-ui="hora"]').mask("99:99");

    _ModuloSistema.find('[one-ui="hora"]').each(function (i, el) {
        $(el).blur(function () {
            if ($(el).val() !== '' && !fIsTime($(el).val())) {
                AlertWarning('Informe uma hora válida');
                $(el).focus();
            }
        });
    });
}

function fIsTime(valor) {
    if (valor.indexOf(':') === -1)
        return false;

    var horas = parseInt(valor.split(':')[0]);
    var minutos = parseInt(valor.split(':')[1]);

    if (!(horas >= 0 && horas <= 23) || !(minutos >= 0 && minutos <= 59))
        return false;

    return true;
}