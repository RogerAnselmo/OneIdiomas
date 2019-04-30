using One.Domain.Entities;
using System;
using System.Collections.Generic;

namespace One.Domain.Interfaces.Service
{
    public interface IACAlunoService: IDisposable
    {
        ACAluno SalvarAluno(ACAluno pACAluno);
        ACAluno AlterarAluno(ACAluno pACAluno);
        ACAluno ExcluirAluno(int id);
        ACAluno ObterPoId(int CodigoAluno);
        IEnumerable<ACAluno> ObterTodos();
        IEnumerable<ACAluno> ObterPorNome(string nome);
        ACAluno ObterAlunoParaEdicao(int id);

    }
}
