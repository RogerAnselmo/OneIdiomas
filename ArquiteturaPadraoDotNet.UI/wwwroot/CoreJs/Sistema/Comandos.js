
function ExecutarComandoConsulta(_controller, _parametros, _sucesso, _erro) {
    var _url;


    if (_parametros !== undefined)
        _url = _controller + _parametros;
    else
        _url = _controller;


    $.ajax({
        type: 'GET',
        url: '/' + $('#tbBaseUrl').val() +_url,
        data: {},
        contentType: 'application/json; charset=utf-8',
        dataType: 'json',
        sync: false,
        success: _sucesso,
        beforeSend: function () {
            ShowWaitMe();
        },
        complete: function () {
            HideWaitMe();
        },
        error: _erro
    });
}

function ExecutarComandoSalvar(_controller, _parametros, _sucesso, _erro) {
    $.ajax({
        type: 'POST',
        url: '/' + $('#tbBaseUrl').val() + _controller,
        data: JSON.stringify(_parametros),
        contentType: 'application/json; charset=utf-8',
        dataType: 'json',
        sync: false,
        beforeSend: function () {
            ShowWaitMe();
        },
        success: _sucesso,
        complete: function () {
            HideWaitMe();
        },
        error: _erro
    });
}

function ExecutarComandoPostCallBack(_controller, _parametros, _sucesso, _erro) {
    $.ajax({
        type: 'POST',
        url: '/' + $('#tbBaseUrl').val() + _controller,
        data: JSON.stringify(_parametros),
        contentType: 'application/json; charset=utf-8',
        dataType: 'json',
        sync: false,
        beforeSend: function () {
            ShowWaitMe();
        },
        success: _sucesso,
        complete: function () {
            HideWaitMe();
        },
        error: _erro
    });
}

function ExecutarComandoPost(_controller, _parametros) {
    $.ajax({
        type: 'POST',
        url: '/' + $('#tbBaseUrl').val() + _controller,
        data: JSON.stringify(_parametros),
        contentType: 'application/json; charset=utf-8',
        dataType: 'json',
        sync: false,
        beforeSend: function () {
            ShowWaitMe();
        },
        success: function (retorno) {
            if (retorno.erro === 0) {
                AlertSuccessCallBack(retorno.mensagem, function () {
                    history.back(1);
                });
            }
            else {
                AlertWarning(retorno.mensagem);
            }
        },
        complete: function () {
            HideWaitMe();
        },
        error: function (error) {
            console.log(error);
            AlertError("Erro ao realizar operação");
        }
    });
}


function ExecutarComandoDelete(_controller, _parametros, _sucesso, _erro) {
    $.ajax({
        type: 'GET',
        url: '/' + $('#tbBaseUrl').val() +_controller + _parametros,
        data: {},
        contentType: 'application/json; charset=utf-8',
        dataType: 'json',
        sync: false,
        beforeSend: function () {
            ShowWaitMe();
        },
        success: _sucesso,
        complete: function () {
            HideWaitMe();
        },
        error: _erro
    });
}

function ExecutarComandoGet(_controller, _sucesso, _erro) {

    console.log('/' + $('#tbBaseUrl').val() + _controller);

    $.ajax({
        type: 'GET',
        url: '/' + $('#tbBaseUrl').val() +_controller,
        data: {},
        contentType: 'application/json; charset=utf-8',
        dataType: 'json',
        sync: false,
        beforeSend: function () {
            ShowWaitMe();
        },
        success: _sucesso,
        complete: function () {
            HideWaitMe();
        },
        error: _erro
    });
}

function ExecutaComandoPostComRetornoHTML(_controller, _parametros, _sucesso, _erro) {
    $.ajax({
        type: 'POST',
        url: '/' + $('#tbBaseUrl').val() +_controller,
        data: JSON.stringify(_parametros),
        contentType: 'application/json; charset=utf-8',
        dataType: 'html',
        sync: false,
        success: _sucesso,
        error: _erro,
        beforeSend: function () {
            ShowWaitMe();
        },
        complete: function () {
            HideWaitMe();
        }
    });
}

function CarregarHtmlView(_controller, _parametros, _target) {
    $.ajax({
        type: 'POST',
        url: '/' + $('#tbBaseUrl').val() + _controller,
        data: JSON.stringify(_parametros),
        contentType: 'application/json; charset=utf-8',
        dataType: 'html',
        sync: false,
        success: function (retorno) {
            $('#' + _target).html(retorno);
        },
        error: function () {
            AlertError('Erro ao realizar operação');
        },
        beforeSend: function () {
            ShowWaitMe();
        },
        complete: function () {
            HideWaitMe();
        }
    });
}
