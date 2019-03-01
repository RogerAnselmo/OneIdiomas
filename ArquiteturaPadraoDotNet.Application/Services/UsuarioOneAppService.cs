using One.Application.Adapter;
using One.Application.Extractors;
using One.Application.Interfaces;
using One.Application.UoW;
using One.Application.ViewModels;
using One.Application.ViewModels.ACAlunoVM;
using One.Domain.Interfaces.Service;
using One.Domain.Entities;
using One.Infra.Data.Interface;
using System.Collections.Generic;

namespace One.Application.Services
{
    public class UsuarioOneAppService : ApplicationServiceTransaction, IUsuarioOneAppService
    {
        #region Interface - IoC
        private readonly IGEUFService _iGEUF;
        private readonly IGECidadeService _iGECidadeService;
        private readonly ISEGUsuarioService _iSEGUsuarioService;
        private readonly ISEGUsuarioPerfilService _iSEGUsuarioPerfilService;
        private readonly IGEEnderecoService _iGEEnderecoService;
        private readonly IACAlunoService _iACAlunoService;
        private readonly IACResponsavelService _iACResponsavelService;
        private readonly IACAlunoResponsavelService _iACAlunoResponsavelService;
        #endregion

        #region Construtor
        public UsuarioOneAppService(IGEUFService iGEUF,
            IGECidadeService iGECidadeService,
            ISEGUsuarioService iSEGUsuarioService,
            ISEGUsuarioPerfilService iSEGUsuarioPerfilService,
            IGEEnderecoService iGEEnderecoService,
            IACAlunoService iACAlunoService,
            IACResponsavelService iACResponsavelService,
            IACAlunoResponsavelService iACAlunoResponsavelService,
            IUnitOfWorkTransaction uow) : base(uow)
        {
            _iGEUF = iGEUF;
            _iGECidadeService = iGECidadeService;
            _iSEGUsuarioService = iSEGUsuarioService;
            _iSEGUsuarioPerfilService = iSEGUsuarioPerfilService;
            _iGEEnderecoService = iGEEnderecoService;
            _iACAlunoService = iACAlunoService;
            _iACResponsavelService = iACResponsavelService;
            _iACAlunoResponsavelService = iACAlunoResponsavelService;
        }
        #endregion

        #region Seção: ACAluno
        public void SalvarAluno(CadastroAlunoViewModel pCadastroAlunoViewModel)
        {
            BeginTransaction();
            #region Salva o usuário do aluno
            SEGUsuario SEGUsuarioAluno = new SEGUsuario
            {
                Login = pCadastroAlunoViewModel.CPF,
                NomeCompleto = pCadastroAlunoViewModel.NomeCompleto
            };
            _iSEGUsuarioService.SalvarUsuario(SEGUsuarioAluno);
            #endregion

            #region salva o endereço do aluno
            //GEEndereco GEEnderecoAluno = CadastroAlunoExtractor.ExtractGEEnderecoAluno(pCadastroAlunoViewModel);
            //_iGEEnderecoService.SalvarEndereco(GEEnderecoAluno);
            #endregion

            #region salva o aluno com os dados do usuário e endereço
            ACAluno ACAluno = CadastroAlunoExtractor.ExtractACAluno(pCadastroAlunoViewModel);
            ACAluno.CodigoUsuario = SEGUsuarioAluno.CodigoUsuario;
            _iACAlunoService.SalvarAluno(ACAluno);
            #endregion

            #region Salva o usuário do responsável
            SEGUsuario SEGUsuarioResponsavel = new SEGUsuario
            {
                Login = pCadastroAlunoViewModel.CPF,
                NomeCompleto = pCadastroAlunoViewModel.NomeCompleto
            };

            _iSEGUsuarioService.SalvarUsuario(SEGUsuarioResponsavel);
            #endregion

            #region salva o endereço do responsável
            //GEEndereco GEEnderecoResponsavel = CadastroAlunoExtractor.ExtractGEEnderecoResponsavel(pCadastroAlunoViewModel);
            //_iGEEnderecoService.SalvarEndereco(GEEnderecoResponsavel);
            #endregion            

            #region salva o responsável
            ACResponsavel ACResponsavel = CadastroAlunoExtractor.ExtractACResponsavel(pCadastroAlunoViewModel);

            ACResponsavel.CodigoUsuario = SEGUsuarioResponsavel.CodigoUsuario;
            //ACResponsavel.CodigoEndereco = GEEnderecoResponsavel.CodigoEndereco;

            _iACResponsavelService.SalvarResponsavel(ACResponsavel);
            #endregion

            #region salva o aluno responsavel
            ACAlunoResponsavel ACAlunoResponsavel = new ACAlunoResponsavel
            {
                CodigoAluno = ACAluno.CodigoAluno,
                CodigoResponsavel = ACResponsavel.CodigoResponsavel,
                CodigoParentesco = pCadastroAlunoViewModel.CodigoParentesco
            };

            _iACAlunoResponsavelService.SalvarAlunoReponsavel(ACAlunoResponsavel); 
            #endregion

            SaveChange();
            Commit();
        }
        #endregion

        #region Seção: GEUF
        public IEnumerable<GEUFViewModel> ObterTodasUF()
        {
            return GEUFAdapter.DomainToViewModel(_iGEUF.ObterTodos());
        }
        #endregion

        #region Seção: GECidade
        public IEnumerable<GECidadeViewModel> ObterCidadesPorUF(int pCodigoUF)
        {
            return GECidadeAdapter.DomainToViewModel(_iGECidadeService.ObterPorUF(pCodigoUF));
        }
        #endregion

        #region Seção: SEGUsuario
        public IEnumerable<SEGUsuarioPerfilViewModel> ObterUsuarioPerfilPorCodigoUsuario(int CodigoUsuario)
        {
            return SEGUsuarioPerfilAdapter.DomainToViewModel(_iSEGUsuarioPerfilService.ObterUsuarioPerfilPorCodigoUsuario(CodigoUsuario));
        }

        public SEGUsuarioViewModel ObterUsuarioPorLogin(string login)
        {
            return SEGUsuarioAdapter.DomainToViewModel(_iSEGUsuarioService.ObterUsuarioPorLogin(login));
        }
        #endregion
    }
}
