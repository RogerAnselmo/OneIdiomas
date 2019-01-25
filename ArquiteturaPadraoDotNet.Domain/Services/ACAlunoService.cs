using System.Collections.Generic;
using One.Domain.Entities;
using One.Domain.Interfaces.Repository;
using One.Domain.Interfaces.Service;

namespace One.Domain.Services
{
    public class ACAlunoService : IACAlunoService
    {
        #region Interface - IoC
        private readonly IACAlunoRepository _iACAlunoRepository; 
        #endregion

        #region Construtor
        public ACAlunoService(IACAlunoRepository iACAlunoRepository)
        {
            _iACAlunoRepository = iACAlunoRepository;
        }
        #endregion

        #region Serviços
        public void Dispose()
        {
        }

        public void AlterarAluno(ACAluno pACAluno)
        {
            _iACAlunoRepository.Alterar(pACAluno);
        }

        public void ExcluirAluno(ACAluno pACAluno)
        {
            throw new System.NotImplementedException();
        }

        public ACAluno ObterPoId(int CodigoAluno)
        {
            return _iACAlunoRepository.ObterPorId(CodigoAluno);
        }

        public IEnumerable<ACAluno> ObterPorNome(string nome)
        {
            return _iACAlunoRepository.ObterPorNome(nome);
        }

        public IEnumerable<ACAluno> ObterTodos()
        {
            return _iACAlunoRepository.ObterTodos();
        }

        public void SalvarAluno(ACAluno pACAluno)
        {
            _iACAlunoRepository.Salvar(pACAluno);
        } 
        #endregion
    }
}
