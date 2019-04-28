function AlertSuccess(mensagem) {
    swal('Atenção', mensagem, 'success');
}

function AlertWarning(mensagem) {
    swal('Atenção', mensagem, 'warning');
}

function AlertError(mensagem) {
    swal('Atenção', mensagem, 'error');
}

function AlertDelete(text, _callback) {
    swal({
        title: "Atenção",
        text: text,
        type: "warning",
        confirmButtonColor: "#DD6B55",
        confirmButtonText: "Sim",
        cancelButtonText: "Não",
        closeOnConfirm: true,
        closeOnCancel: true,
        showCancelButton: true
    },
        function (isConfirm) {
            if (isConfirm) {
                _callback();
            }
            //else {
            //    swal("Cancelled", "Your imaginary file is safe :)", "error");
            //}
        });
}