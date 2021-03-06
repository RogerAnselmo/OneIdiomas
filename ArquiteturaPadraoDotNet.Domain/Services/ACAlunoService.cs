﻿using System;
using System.Collections.Generic;
using One.Domain.Entities;
using One.Domain.Interfaces.Repository;
using One.Domain.Interfaces.Service;
using One.Domain.Validation;

namespace One.Domain.Services
{
    public class ACAlunoService : IACAlunoService
    {
        #region Interface - IoC
        private readonly IACAlunoRepository _iACAlunoRepository;
        private readonly IGEEnderecoRepository _iGEEnderecoRepository;
        private readonly IGETelefoneRepository _iGETelefoneRepository;
        #endregion

        #region S~ção: Construtor
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

        #region Seção: Dispose
        public void Dispose()
        {
        }
        #endregion

        #region Seção: Serviços
        public ACAluno Salvar(ACAluno ACAluno)
        {
            if (ACAluno.IsValid())
                _iACAlunoRepository.Salvar(ACAluno);

            return ACAluno;
        }

        public ACAluno Alterar(ACAluno ACAluno)
        {
            if (ACAluno.IsValid())
                _iACAlunoRepository.Alterar(ACAluno);

            return ACAluno;
        }

        public ACAluno Excluir(int id)
        {
            ACAluno ACAluno = _iACAlunoRepository.ObterPorId(id);

            if (ACAluno != null)
            {
                ACAluno.flAtivo = "I";
                _iACAlunoRepository.Alterar(ACAluno);
                ACAluno.ValidationResult = new ValidationResults(true, "Aluno excluído com sucesso");

                return ACAluno;
            }
            
            return new ACAluno(0, 0, "", "", DateTime.MinValue, 0)
            {
                ValidationResult = new ValidationResults(false, "Aluno não encontrado")
            };
        }

        public ACAluno ObterPoId(int CodigoAluno) => _iACAlunoRepository.ObterPorId(CodigoAluno);

        public IEnumerable<ACAluno> ObterPorNome(string nome) => _iACAlunoRepository.ObterPorNome(nome);

        public IEnumerable<ACAluno> ObterTodos() => _iACAlunoRepository.ObterTodos();

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
