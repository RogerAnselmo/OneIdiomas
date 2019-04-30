using System.Collections.Generic;
using One.Application.Adapter;
using One.Application.Extractors;
using One.Application.Interfaces;
using One.Application.UoW;
using One.Application.ViewModels;
using One.Application.ViewModels.ACAlunoVM;
using One.Domain.Entities;
using One.Domain.Interfaces.Service;
using One.Domain.Validation;
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
        public ValidationResults SalvarAluno(CadastroAlunoViewModel cadastroAlunoViewModel)
        {
            BeginTransaction();

            #region Salva o usuário do aluno
            SEGUsuario SEGUsuarioAluno = _iSEGUsuarioService.SalvarUsuario(CadastroAlunoExtractor.ExtractSEGUsuarioAluno(cadastroAlunoViewModel));

            if (!SEGUsuarioAluno.ValidationResult.IsValid)
                return SEGUsuarioAluno.ValidationResult;
            #endregion

            #region salva o endereço do aluno
            GEEndereco GEEnderecoAluno = _iGEEnderecoService.SalvarEndereco(CadastroAlunoExtractor.ExtractGEEnderecoAluno(cadastroAlunoViewModel));

            if (!GEEnderecoAluno.ValidationResult.IsValid)
                return GEEnderecoAluno.ValidationResult;


            GEUsuarioEndereco GEUsuarioEnderecoAluno = new GEUsuarioEndereco
            {
                CodigoEndereco = GEEnderecoAluno.CodigoEndereco,
                CodigoUsuario = SEGUsuarioAluno.CodigoUsuario
            };

            GEUsuarioEnderecoAluno = _iGEEnderecoService.SalvarUsuarioEndereco(GEUsuarioEnderecoAluno);

            if (!GEUsuarioEnderecoAluno.ValidationResult.IsValid)
                return GEUsuarioEnderecoAluno.ValidationResult;
            #endregion

            #region salva o aluno com os dados do usuário e endereço
            ACAluno ACAluno = CadastroAlunoExtractor.ExtractACAluno(cadastroAlunoViewModel);
            ACAluno.CodigoUsuario = SEGUsuarioAluno.CodigoUsuario;
            ACAluno = _iACAlunoService.SalvarAluno(ACAluno);

            if (!ACAluno.ValidationResult.IsValid)
                return ACAluno.ValidationResult;

            #endregion

            #region salva o telefone do aluno
            GETelefone GETelefoneAluno = CadastroAlunoExtractor.ExtractTelefoneAluno(cadastroAlunoViewModel);
            GETelefoneAluno.CodigoUsuario = SEGUsuarioAluno.CodigoUsuario;
            GETelefoneAluno = _iGETelefoneService.SalvarTelefone(GETelefoneAluno);

            if (!GETelefoneAluno.ValidationResult.IsValid)
                return GETelefoneAluno.ValidationResult;

            #endregion

            #region Salva o usuário do responsável
            SEGUsuario SEGUsuarioResponsavel = null;

            if (!cadastroAlunoViewModel.AlunoÉOProprioResponsavel)
            {
                SEGUsuarioResponsavel = CadastroAlunoExtractor.ExtractSEGUsuarioResponsavel(cadastroAlunoViewModel);
                SEGUsuarioResponsavel = _iSEGUsuarioService.SalvarUsuario(SEGUsuarioResponsavel);

                if (!SEGUsuarioResponsavel.ValidationResult.IsValid)
                    return SEGUsuarioResponsavel.ValidationResult;
            }
            #endregion

            #region salva o endereço do responsável
            if (!cadastroAlunoViewModel.UsarEnderecoDoAluno)
            {
                GEEndereco GEEnderecoResponsavel = CadastroAlunoExtractor.ExtractGEEnderecoResponsavel(cadastroAlunoViewModel);
                GEEnderecoResponsavel = _iGEEnderecoService.SalvarEndereco(GEEnderecoResponsavel);

                if (!GEEnderecoResponsavel.ValidationResult.IsValid)
                    return GEEnderecoResponsavel.ValidationResult;
            }
            #endregion

            #region salva o responsável
            ACResponsavel ACResponsavel = CadastroAlunoExtractor.ExtractACResponsavel(cadastroAlunoViewModel);
            ACResponsavel.CodigoUsuario = cadastroAlunoViewModel.AlunoÉOProprioResponsavel ? SEGUsuarioAluno.CodigoUsuario : SEGUsuarioResponsavel.CodigoUsuario;
            _iACResponsavelService.SalvarResponsavel(ACResponsavel);
            #endregion

            #region salva o aluno responsavel
            ACAlunoResponsavel ACAlunoResponsavel = new ACAlunoResponsavel
            {
                CodigoAluno = ACAluno.CodigoAluno,
                CodigoResponsavel = ACResponsavel.CodigoResponsavel,
                CodigoParentesco = cadastroAlunoViewModel.CodigoParentesco
            };
            _iACAlunoResponsavelService.SalvarAlunoReponsavel(ACAlunoResponsavel);
            #endregion

            #region salvar telefone do respossável
            if (!cadastroAlunoViewModel.AlunoÉOProprioResponsavel)
            {
                GETelefone GETelefoneresponsavel = CadastroAlunoExtractor.ExtractTelefoneAluno(cadastroAlunoViewModel);
                GETelefoneresponsavel.CodigoUsuario = SEGUsuarioResponsavel.CodigoUsuario;
                _iGETelefoneService.SalvarTelefone(GETelefoneresponsavel);
            }
            #endregion

            SaveChange();
            Commit();

            return new ValidationResults(true, "Aluno salvo com sucesso!");
        }

        public void AlterarAluno(EditarAlunoViewModel editarAlunoViewModel)
        {
            BeginTransaction();

            SEGUsuario SEGUsuario = EditarAlunoExtractor.ExtractSEGUsuario(editarAlunoViewModel);
            ACAluno ACAluno = EditarAlunoExtractor.ExtractACAluno(editarAlunoViewModel);
            GEEndereco GEEndereco = EditarAlunoExtractor.ExtractEnderecoAluno(editarAlunoViewModel);

            _iACAlunoService.AlterarAluno(ACAluno);
            _iSEGUsuarioService.AlterarUsuario(SEGUsuario);
            _iGEEnderecoService.AlterarEndereco(GEEndereco);

            SaveChange();
            Commit();
        }

        public void ExcluirAluno(int id)
        {
            BeginTransaction();
            _iACAlunoService.ExcluirAluno(id);
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
