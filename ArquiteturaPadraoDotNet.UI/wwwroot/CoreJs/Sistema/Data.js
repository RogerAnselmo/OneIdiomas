//valida data
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

//Datepicker
function ConfiguraDatePicker(_target) {

    _target.datepicker({
        format: 'dd/mm/yyyy',
        language: 'pt-BR',
        autoclose: true,
        todayHighlight: true
    });

    //DesabilitaDigitacaoNoCampo(_target);
    
}