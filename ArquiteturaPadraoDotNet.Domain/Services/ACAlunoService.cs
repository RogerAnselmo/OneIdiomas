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
        private readonly IGEEnderecoRepository _iGEEnderecoRepository;
        private readonly IGETelefoneRepository _iGETelefoneRepository;
        #endregion

        #region Construtor
        public ACAlunoService(IACAlunoRepository iACAlunoRepository, 
            IGEEnderecoRepository iGEEnderecoRepository,
            IGETelefoneRepository iGETelefoneRepository
            )
        {
            _iACAlunoRepository = iACAlunoRepository;
            _iGEEnderecoRepository = iGEEnderecoRepository;
            _iGETelefoneRepository = iGETelefoneRepository;
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

        public void ExcluirAluno(int id)
        {
            ACAluno ACAluno = _iACAlunoRepository.ObterPorId(id);
            ACAluno.flAtivo = "I";
            _iACAlunoRepository.Alterar(ACAluno);
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

        public ACAluno ObterAlunoParaEdicao(int id)
        {
            ACAluno ACAluno = _iACAlunoRepository.ObterAlunoParaEdicao(id);
            ACAluno.SEGUsuario.GEUsuarioEndereco = _iGEEnderecoRepository.ObterEnderecosPorCodigoUsuario(ACAluno.CodigoUsuario);
            ACAluno.SEGUsuario.GETelefone = _iGETelefoneRepository.ObterTelefonesPorUsuario(ACAluno.SEGUsuario.CodigoUsuario);

            return ACAluno;
        }
        #endregion
    }
}
