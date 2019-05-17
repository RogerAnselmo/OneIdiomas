var _ModuloSistema = $('#ModuloSistema');

$(document).ready(function () {
    ConfiguraBotaoVoltar();
});


function configuraFormulario(_nameform, _success, _error) {
    $(_nameform).on("submit", function (event) {
        event.preventDefault();

        $.ajax({
            url: this.action,
            type: this.method,
            data: $(this).serialize(),
            dataType: "json",
            success: _success,
            error: _error
        });
    });
}

CarregaModulo = function (target, url, parametro) {
    $.ajax({
        type: "GET",
        url: url + parametro,
        data: {},
        success: function (resposta) {
            var div = document.createElement("div");
            div.setAttribute("id", target);
            document.body.appendChild(div);
            $(target).html(resposta);
        }
    });
};

//valida CEP
function IsValidaCep(cep) {
    exp = /\d{2}\.\d{3}\-\d{3}/;

    if (!exp.test(cep)) {
        return false;
    }
    else {
        return true;
    }
}

//valida CPF
function IsValidarCPF2(Objcpf) {
    var cpf = Objcpf;

    exp = /\.|\-/g;
    cpf = cpf.toString().replace(exp, "");

    alert(cpf);
    var digitoDigitado = eval(cpf.charAt(9) + cpf.charAt(10));
    var soma1 = 0, soma2 = 0;
    var vlr = 11;

    for (i = 0; i < 9; i++) {
        soma1 += eval(cpf.charAt(i) * (vlr - 1));
        soma2 += eval(cpf.charAt(i) * vlr);
        vlr--;
    }
    soma1 = (((soma1 * 10) % 11) === 10 ? 0 : ((soma1 * 10) % 11));
    soma2 = (((soma2 + (2 * soma1)) * 10) % 11);

    var digitoGerado = (soma1 * 10) + soma2;
    if (digitoGerado !== digitoDigitado) {
        alert(digitoGerado);
        return false;
    }
    else {
        alert(digitoGerado);

        return true;
    }
}

//valida cpf
function IsValidarCPF(value) {
    value = value.replace('.', '');
    value = value.replace('.', '');
    cpf = value.replace('-', '');
    while (cpf.length < 11) cpf = "0" + cpf;
    var expReg = /^0+$|^1+$|^2+$|^3+$|^4+$|^5+$|^6+$|^7+$|^8+$|^9+$/;
    var a = [];
    var b = new Number;
    var c = 11;
    for (i = 0; i < 11; i++) {
        a[i] = cpf.charAt(i);
        if (i < 9) b += (a[i] * --c);
    }
    if ((x = b % 11) < 2) { a[9] = 0 } else { a[9] = 11 - x }
    b = 0;
    c = 11;
    for (y = 0; y < 10; y++) b += (a[y] * c--);
    if ((x = b % 11) < 2) { a[10] = 0; } else { a[10] = 11 - x; }

    var retorno = true;

    if ((cpf.charAt(9) !== a[9]) || (cpf.charAt(10) !== a[10]) || cpf.match(expReg)) retorno = false;

    return retorno;
}

//valida cpf
function validarCPF(cpf) {
    cpf = cpf.replace(/[^\d]+/g, '');
    if (cpf === '') return false;
    // Elimina CPFs invalidos conhecidos	
    if (cpf.length !== 11 ||
        cpf === "00000000000" ||
        cpf === "11111111111" ||
        cpf === "22222222222" ||
        cpf === "33333333333" ||
        cpf === "44444444444" ||
        cpf === "55555555555" ||
        cpf === "66666666666" ||
        cpf === "77777777777" ||
        cpf === "88888888888" ||
        cpf === "99999999999")
        return false;
    // Valida 1o digito	
    add = 0;
    for (i = 0; i < 9; i++)
        add += parseInt(cpf.charAt(i)) * (10 - i);
    rev = 11 - (add % 11);
    if (rev === 10 || rev === 11)
        rev = 0;
    if (rev !== parseInt(cpf.charAt(9)))
        return false;
    // Valida 2o digito	
    add = 0;
    for (i = 0; i < 10; i++)
        add += parseInt(cpf.charAt(i)) * (11 - i);
    rev = 11 - (add % 11);
    if (rev === 10 || rev === 11)
        rev = 0;
    if (rev !== parseInt(cpf.charAt(10)))
        return false;
    return true;
}

function appendOption(_Value, _Text, _target) {
    var option = document.createElement("option");
    option.value = _Value;
    option.text = _Text;
    _target.append(option);
}

function somenteNumerosDecimais(evt, obj) {

    var charCode = (evt.which) ? evt.which : event.keyCode;
    var value = obj.value;
    var dotcontains = value.indexOf(".") !== -1;
    if (dotcontains)
        if (charCode === 46) return false;
    if (charCode === 46) return true;
    if (charCode > 31 && (charCode < 48 || charCode > 57))
        return false;
    return true;
}

function formatNumber(num) {
    return num
        .toFixed(2) // always two decimal digits
        .replace(".", ",") // replace decimal point character with ,
        .replace(/(\d)(?=(\d{3})+(?!\d))/g, "$1.");
}

function ConfiguraSelect2() {
    var selects = document.getElementsByTagName('select');
    for (var i = 0; i < selects.length; i++) {
        $(selects[i]).select2();
    }
}

function DesabilitaDigitacaoNoCampo(_target) {

    $(_target).keypress(function (e) {
        e = e || window.event;
        var charCode = (typeof e.which === "undefined") ? e.keyCode : e.which;
        var charStr = String.fromCharCode(charCode);
        if (/\d/.test(charStr)) {
            return false;
        }
    });
}

function ConfiguraBotaoVoltar() {

    _ModuloSistema.find('[one-ui="btn-voltar"]').each(function (i, el) {
        $(el).click(function () {
            history.back(1);
        });
    });
}
