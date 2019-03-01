
function ExecutarComandoConsulta(_controller, _parametros, _sucesso, _erro) {
    var _url;


    if (_parametros !== undefined)
        _url = _controller + _parametros;
    else
        _url = _controller;


    $.ajax({
        type: 'GET',
        url: _url,
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

function ExecutarComandoSalvar(_controller, _parametros, _sucesso, _erro) {
    $.ajax({
        type: 'POST',
        url: _controller,
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

function ExecutarComandoPost(_controller, _parametros, _sucesso, _erro) {
    $.ajax({
        type: 'POST',
        url: _controller,
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

function ExecutarComandoDelete(_controller, _parametros, _sucesso, _erro) {
    $.ajax({
        type: 'GET',
        url: _controller + _parametros,
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
    $.ajax({
        type: 'GET',
        url: _controller,
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

function ExecutaComandoPostHTML(_controller, _parametros, _sucesso, _erro) {
    $.ajax({
        type: 'POST',
        url: _controller,
        data: JSON.stringify(_parametros),
        contentType: 'application/json; charset=utf-8',
        dataType: 'html',
        sync: false,
        success: _sucesso,
        error: _erro
    });
}