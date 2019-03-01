
function ConfiguraFileUpload(_target, _render, maximoArquivos, extensoesPermitidas, tamanhoMaximo) {

    _target = '#' + _target;

    $(_target).change(function (e) {
        if (e.target.files.length > 1) {
            swal('Atenção!', 'Favor selecione somente ' + maximoArquivos + ' arquivo(s)!', 'warning');
            $('#FotoForm').val('');
            return;
        };

        var extensao = $(_target).val().substr(($(_target).val().lastIndexOf('.') + 1));
        var extensaoOK = extensoesPermitidas.filter(function (ext) { if (ext === extensao.toUpperCase()) return ext; }).length;

        if (extensaoOK === 0) {
            var texto = "Estensões permitidas: ";
            for (var i = 0; i < extensoesPermitidas.length; i++) {
                texto += ((i === 0) ? " " : ",") + extensoesPermitidas[i];
            }

            swal("Atenção!", texto, "warning");
            $(_target).val('');
            return;
        }

        if (((e.target.files[0].size / 1024) / 1024).toFixed(4) > tamanhoMaximo) {
            swal('Atenção!', 'Favor selecione um arquivo com menos de ' + tamanhoMaximo + 'MB!', 'warning');
            $(_target).val('');
            return;
        }

        var input = document.querySelector(_target);

        var reader = new FileReader();
        reader.onload = function () {
            $("#" + _render).attr("src", reader.result);
        };
        reader.readAsDataURL(input.files[0]);
    });
}