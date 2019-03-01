using One.Domain.Entities;
using One.Domain.Validation;
using One.Domain.Specifications.ACAvaliacaoSpecification;

namespace One.Domain.Validations.ACAvaliacaoValidation
{
    public class ACAvaliacaoConsistenteValidation : Validator<ACAvaliacao>
    {
        public ACAvaliacaoConsistenteValidation(ACAvaliacao ACAvaliacao)
        {
            var CodigoMatriculaDeveSerMaiorQueZero = new CodigoMatriculaDeveSerMaiorQueZero();
            var DataAvaliacaoDeveSerValida = new DataAvaliacaoDeveSerValida();
            var DescricaoDeveSerValida = new DescricaoDeveSerValida();
            var DescricaoDeveTerNoMaximo500Caracteres = new DescricaoDeveTerNoMaximo500Caracteres();
            var NotaDeveSerValida = new NotaDeveSerValida();
            var SituacaoDeveSerValida = new SituacaoDeveSerValida();
            var SituacaoDeveTerSomente1Caracter = new SituacaoDeveTerSomente1Caracter();
            var StatusDeveSerValido = new StatusDeveSerValido();
            var StatusDeveTerSomente1Caracter = new StatusDeveTerSomente1Caracter();

            base.Add("CodigoMatriculaDeveSerMaiorQueZero", new Rule<ACAvaliacao>(CodigoMatriculaDeveSerMaiorQueZero, "Código de matrícula da avaliação deve ser maior que Zero.", ACAvaliacao));
            base.Add("DataAvaliacaoDeveSerValida", new Rule<ACAvaliacao>(DataAvaliacaoDeveSerValida, "Data da avaliação deve ser válida.", ACAvaliacao));
            base.Add("DescricaoDeveSerValida", new Rule<ACAvaliacao>(DescricaoDeveSerValida, "Descrição da avaliação deve ser válida.", ACAvaliacao));
            base.Add("DescricaoDeveTerNoMaximo500Caracteres", new Rule<ACAvaliacao>(DescricaoDeveTerNoMaximo500Caracteres, "Descrição da avaliação deve ter no máximo 500 caracteres.", ACAvaliacao));
            base.Add("NotaDeveSerValida", new Rule<ACAvaliacao>(NotaDeveSerValida, "Descrição da avaliação deve ser válida.", ACAvaliacao));
            base.Add("SituacaoDeveSerValida", new Rule<ACAvaliacao>(SituacaoDeveSerValida, "Situação da avaliação deve ser válida.", ACAvaliacao));
            base.Add("SituacaoDeveTerSomente1Caracter", new Rule<ACAvaliacao>(SituacaoDeveTerSomente1Caracter, "Situação da avaliação deve ter somente 1 caracter.", ACAvaliacao));
            base.Add("StatusDeveSerValido", new Rule<ACAvaliacao>(StatusDeveSerValido, "Status da avaliação deve ser válido.", ACAvaliacao));
            base.Add("StatusDeveTerSomente1Caracter", new Rule<ACAvaliacao>(StatusDeveTerSomente1Caracter, "Status da avaliação deve ter somente 1 caracter.", ACAvaliacao));
        }
    }
}
