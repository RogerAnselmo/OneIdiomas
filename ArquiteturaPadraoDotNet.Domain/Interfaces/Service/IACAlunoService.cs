using One.Domain.Entities;
using System;
using System.Collections.Generic;

namespace One.Domain.Interfaces.Service
{
    public interface IACAlunoService: IDisposable
    {
        void SalvarAluno(ACAluno pACAluno);
        void AlterarAluno(ACAluno pACAluno);
        void ExcluirAluno(int id);
        ACAluno ObterPoId(int CodigoAluno);
        IEnumerable<ACAluno> ObterTodos();
        IEnumerable<ACAluno> ObterPorNome(string nome);
        ACAluno ObterAlunoParaEdicao(int id);

    }
}
