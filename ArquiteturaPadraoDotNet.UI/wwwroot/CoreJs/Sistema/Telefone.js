//valida Celular
function IsValidaCelular(cel) {
    exp = /\(\d{2}\)\ \d{5}\-\d{4}/;

    if (!exp.test(cel)) {
        return false;
    }
    else {
        return true;
    }
}

function IsValidaTelefone(tel) {
    exp = /\(\d{2}\)\ \d{4}\-\d{4}/;

    if (!exp.test(tel)) {
        return false;
    }
    else {
        return true;
    }
}