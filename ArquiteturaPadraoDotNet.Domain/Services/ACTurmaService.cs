using One.Domain.Entities;
using One.Domain.Interfaces.Repository;
using One.Domain.Interfaces.Service;
using One.Domain.Validation;
using System;
using System.Collections.Generic;
using System.Text;

namespace One.Domain.Services
{
    public class ACTurmaService : IACTurmaService
    {
        private readonly IACTurmaRepository _iACTurmaRepository;

        public ACTurmaService(IACTurmaRepository iACTurmaRepository) => _iACTurmaRepository = iACTurmaRepository;

        public void Dispose()
        {
        }

        public ACTurma Alterar(ACTurma aCTurma)
        {
            if (aCTurma.IsValid())
                _iACTurmaRepository.Alterar(aCTurma);

            return aCTurma;
        }

        public ACTurma Salvar(ACTurma aCTurma)
        {
            if (aCTurma.IsValid())
                _iACTurmaRepository.Salvar(aCTurma);

            return aCTurma;
        }

        public ACTurma Excluir(int id)
        {
            ACTurma ACTurma = _iACTurmaRepository.ObterPorId(id);
            ACTurma.flAtivo = "I";
            _iACTurmaRepository.Alterar(ACTurma);
            ACTurma.ValidationResult = new ValidationResults(true, "Turma excluída com sucesso");
            return ACTurma;
        }

        public IEnumerable<ACTurma> ObterTodos() => _iACTurmaRepository.ObterTodos();

        public ACTurma ObterPorId(int id) => _iACTurmaRepository.ObterPorId(id);

        public IEnumerable<ACTurma> ObterPorDescicaoNivelCategoria(string filtro) => _iACTurmaRepository.ObterPorDescicaoNivelCategoria(filtro);
    }
}
