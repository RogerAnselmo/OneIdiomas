using One.Domain.Entities;
using System;
using System.Collections.Generic;

namespace One.Domain.Interfaces.Service
{
    public interface IACAlunoService: IDisposable
    {
        ACAluno Salvar(ACAluno ACAluno);
        ACAluno Alterar(ACAluno ACAluno);
        ACAluno Excluir(int id);
        ACAluno ObterPoId(int CodigoResponsavel);
        IEnumerable<ACAluno> ObterTodos();
        IEnumerable<ACAluno> ObterPorNome(string nome);
        ACAluno ObterAlunoParaEdicao(int id);

    }
}
