using System.Collections.Generic;
using One.Domain.Entities;
using One.Domain.Interfaces.Repository;
using One.Domain.Interfaces.Service;

namespace One.Domain.Services
{
    public class ACNivelService : IACNivelService
    {
        private readonly IACNivelRepository _iACNivelRepository;

        public ACNivelService(IACNivelRepository iACNivelRepository) 
            => _iACNivelRepository = iACNivelRepository;

        public void Dispose()
        {
        }

        public IEnumerable<ACNivel> ObterTodosAtivos() => _iACNivelRepository.ObterTodosAtivos();
    }
}
