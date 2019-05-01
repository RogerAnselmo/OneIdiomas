use one;

delete from ACAlunoResponsavel

delete from ACAluno;

delete from ACResponsavel

delete from SEGUsuarioPerfil
where CodigoUsuario in (select codigousuario from SEGUsuario where CodigoUsuario > 3)

delete from GEUsuarioEndereco
where CodigoUsuario in (select codigousuario from SEGUsuario where CodigoUsuario > 3)

delete from GETelefone
where CodigoUsuario in (select codigousuario from SEGUsuario where CodigoUsuario > 3)

delete from GEEndereco

delete from SEGUsuario where CodigoUsuario > 3
