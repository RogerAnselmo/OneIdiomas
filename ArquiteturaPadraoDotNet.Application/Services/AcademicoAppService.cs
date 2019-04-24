using System.Collections.Generic;
using One.Application.Adapter;
using One.Application.Extractors;
using One.Application.Interfaces;
using One.Application.UoW;
using One.Application.ViewModels;
using One.Application.ViewModels.ACAlunoVM;
using One.Domain.Entities;
using One.Domain.Interfaces.Service;
using One.Infra.Data.Interface;

namespace One.Application.Services
{
    public class AcademicoAppService : ApplicationServiceTransaction, IAcademicoAppService
    {
        #region Seção: Interface - IoC
        private readonly IACAlunoService _iACAlunoService;
        private readonly IACResponsavelService _iACResponsavelService;
        private readonly IACAlunoResponsavelService _iACAlunoResponsavelService;
        private readonly IGEEnderecoService _iGEEnderecoService;
        private readonly ISEGUsuarioService _iSEGUsuarioService;
        #endregion

        #region Seção: Construtor
        public AcademicoAppService(
            IACAlunoService iACAlunoService,
            IACResponsavelService iACResponsavelService,
            IACAlunoResponsavelService iACAlunoResponsavelService,
            ISEGUsuarioService iSEGUsuarioService,
            IGEEnderecoService iGEEnderecoService,
            IUnitOfWorkTransaction uow) : base(uow)
        {
            _iACAlunoService = iACAlunoService;
            _iACResponsavelService = iACResponsavelService;
            _iACAlunoResponsavelService = iACAlunoResponsavelService;
            _iGEEnderecoService = iGEEnderecoService;
            _iSEGUsuarioService = iSEGUsuarioService;
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
            GEEndereco GEEnderecoAluno = CadastroAlunoExtractor.ExtractGEEnderecoAluno(pCadastroAlunoViewModel);
            _iGEEnderecoService.SalvarEndereco(GEEnderecoAluno);

            GEUsuarioEndereco GEUsuarioEnderecoAluno = new GEUsuarioEndereco
            {
                CodigoEndereco = GEEnderecoAluno.CodigoEndereco,
                CodigoUsuario = SEGUsuarioAluno.CodigoUsuario
            };

            _iGEEnderecoService.SalvarUsuarioEndereco(GEUsuarioEnderecoAluno);
            #endregion

            #region salva o aluno com os dados do usuário e endereço
            ACAluno ACAluno = CadastroAlunoExtractor.ExtractACAluno(pCadastroAlunoViewModel);
            ACAluno.CodigoUsuario = SEGUsuarioAluno.CodigoUsuario;
            _iACAlunoService.SalvarAluno(ACAluno);
            #endregion



            #region Salva o usuário do responsável
            SEGUsuario SEGUsuarioResponsavel = null;

            if (!pCadastroAlunoViewModel.AlunoÉOProprioResponsavel)
            {
                SEGUsuarioResponsavel = new SEGUsuario
                {
                    Login = pCadastroAlunoViewModel.CPF,
                    NomeCompleto = pCadastroAlunoViewModel.NomeCompleto
                };
                _iSEGUsuarioService.SalvarUsuario(SEGUsuarioResponsavel);
            }
            #endregion

            #region salva o endereço do responsável
            if (!pCadastroAlunoViewModel.UsarEnderecoDoAluno)
            {
                GEEndereco GEEnderecoResponsavel = CadastroAlunoExtractor.ExtractGEEnderecoResponsavel(pCadastroAlunoViewModel);
                _iGEEnderecoService.SalvarEndereco(GEEnderecoResponsavel);

            }
            #endregion

            #region salva o responsável
            ACResponsavel ACResponsavel = CadastroAlunoExtractor.ExtractACResponsavel(pCadastroAlunoViewModel);
            ACResponsavel.CodigoUsuario = pCadastroAlunoViewModel.AlunoÉOProprioResponsavel ? SEGUsuarioAluno.CodigoUsuario : SEGUsuarioResponsavel.CodigoUsuario;
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

        public IEnumerable<ACAlunoViewModel> ObterAlunosPorNome(string nome)
        {
            return ACAlunoAdapter.DomainToViewModel(_iACAlunoService.ObterPorNome(nome));
        }

        public EditarAlunoViewModel ObterAlunoParaEdicao(int id)
        {
            return EditarAlunoExtractor.ConvertAcAlunoToEditarAlunoViewModel(_iACAlunoService.ObterAlunoParaEdicao(id));
        }
        #endregion
    }
}
