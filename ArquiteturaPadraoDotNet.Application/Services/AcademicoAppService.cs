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
        private readonly IGETelefoneService _iGETelefoneService;
        #endregion

        #region Seção: Construtor
        public AcademicoAppService(
            IACAlunoService iACAlunoService,
            IACResponsavelService iACResponsavelService,
            IACAlunoResponsavelService iACAlunoResponsavelService,
            ISEGUsuarioService iSEGUsuarioService,
            IGEEnderecoService iGEEnderecoService,
            IGETelefoneService iGETelefoneService,
            IUnitOfWorkTransaction uow) : base(uow)
        {
            _iACAlunoService = iACAlunoService;
            _iACResponsavelService = iACResponsavelService;
            _iACAlunoResponsavelService = iACAlunoResponsavelService;
            _iGEEnderecoService = iGEEnderecoService;
            _iSEGUsuarioService = iSEGUsuarioService;
            _iGETelefoneService = iGETelefoneService;
        }
        #endregion

        #region Seção: ACAluno
        public void SalvarAluno(CadastroAlunoViewModel CadastroAlunoViewModel)
        {
            BeginTransaction();

            #region Salva o usuário do aluno
            SEGUsuario SEGUsuarioAluno = new SEGUsuario
            {
                Login = CadastroAlunoViewModel.CPF,
                NomeCompleto = CadastroAlunoViewModel.NomeCompleto
            };
            _iSEGUsuarioService.SalvarUsuario(SEGUsuarioAluno);
            #endregion

            #region salva o endereço do aluno
            GEEndereco GEEnderecoAluno = CadastroAlunoExtractor.ExtractGEEnderecoAluno(CadastroAlunoViewModel);
            _iGEEnderecoService.SalvarEndereco(GEEnderecoAluno);

            GEUsuarioEndereco GEUsuarioEnderecoAluno = new GEUsuarioEndereco
            {
                CodigoEndereco = GEEnderecoAluno.CodigoEndereco,
                CodigoUsuario = SEGUsuarioAluno.CodigoUsuario
            };

            _iGEEnderecoService.SalvarUsuarioEndereco(GEUsuarioEnderecoAluno);
            #endregion

            #region salva o aluno com os dados do usuário e endereço
            ACAluno ACAluno = CadastroAlunoExtractor.ExtractACAluno(CadastroAlunoViewModel);
            ACAluno.CodigoUsuario = SEGUsuarioAluno.CodigoUsuario;
            _iACAlunoService.SalvarAluno(ACAluno);
            #endregion

            #region salva o telefone do aluno
            GETelefone GETelefoneAluno = CadastroAlunoExtractor.ExtractTelefoneAluno(CadastroAlunoViewModel);
            GETelefoneAluno.CodigoUsuario = SEGUsuarioAluno.CodigoUsuario;
            _iGETelefoneService.SalvarTelefone(GETelefoneAluno);
            #endregion

            #region Salva o usuário do responsável
            SEGUsuario SEGUsuarioResponsavel = null;

            if (!CadastroAlunoViewModel.AlunoÉOProprioResponsavel)
            {
                SEGUsuarioResponsavel = new SEGUsuario
                {
                    Login = CadastroAlunoViewModel.CPF,
                    NomeCompleto = CadastroAlunoViewModel.NomeCompleto
                };
                _iSEGUsuarioService.SalvarUsuario(SEGUsuarioResponsavel);
            }
            #endregion

            #region salva o endereço do responsável
            if (!CadastroAlunoViewModel.UsarEnderecoDoAluno)
            {
                GEEndereco GEEnderecoResponsavel = CadastroAlunoExtractor.ExtractGEEnderecoResponsavel(CadastroAlunoViewModel);
                _iGEEnderecoService.SalvarEndereco(GEEnderecoResponsavel);

            }
            #endregion

            #region salva o responsável
            ACResponsavel ACResponsavel = CadastroAlunoExtractor.ExtractACResponsavel(CadastroAlunoViewModel);
            ACResponsavel.CodigoUsuario = CadastroAlunoViewModel.AlunoÉOProprioResponsavel ? SEGUsuarioAluno.CodigoUsuario : SEGUsuarioResponsavel.CodigoUsuario;
            _iACResponsavelService.SalvarResponsavel(ACResponsavel);
            #endregion

            #region salva o aluno responsavel
            ACAlunoResponsavel ACAlunoResponsavel = new ACAlunoResponsavel
            {
                CodigoAluno = ACAluno.CodigoAluno,
                CodigoResponsavel = ACResponsavel.CodigoResponsavel,
                CodigoParentesco = CadastroAlunoViewModel.CodigoParentesco
            };
            _iACAlunoResponsavelService.SalvarAlunoReponsavel(ACAlunoResponsavel);
            #endregion

            #region salvar telefone do respossável
            if (!CadastroAlunoViewModel.AlunoÉOProprioResponsavel)
            {
                GETelefone GETelefoneresponsavel = CadastroAlunoExtractor.ExtractTelefoneAluno(CadastroAlunoViewModel);
                GETelefoneresponsavel.CodigoUsuario = SEGUsuarioResponsavel.CodigoUsuario;
                _iGETelefoneService.SalvarTelefone(GETelefoneresponsavel);
            }
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
