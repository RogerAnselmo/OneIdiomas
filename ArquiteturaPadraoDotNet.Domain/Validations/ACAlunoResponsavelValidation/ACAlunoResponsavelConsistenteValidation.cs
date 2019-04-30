using One.Domain.Entities;
using One.Domain.Validation;
using One.Domain.Specifications.ACAlunoResponsavelSpecification;

namespace One.Domain.Validations.ACAlunoResponsavelValidation
{
    public class ACAlunoResponsavelConsistenteValidation: Validator<ACAlunoResponsavel>
    {
        public ACAlunoResponsavelConsistenteValidation(ACAlunoResponsavel ACAlunoResponsavel)
        {
            var CodigoResponsavelDeveSerMaiorQueZero = new CodigoResponsavelDeveSerMaiorQueZero();
            var CodigoParentescoDeveSerMaiorQueZero = new CodigoParentescoDeveSerMaiorQueZero();
            var CodigoAlunoDeveSerMaiorQueZero = new CodigoAlunoDeveSerMaiorQueZero();

            base.Add("CodigoResponsavelDeveSerMaiorQueZero ", new Rule<ACAlunoResponsavel>(CodigoAlunoDeveSerMaiorQueZero, "Código do aluno deve ser maior que Zero.", ACAlunoResponsavel));
            base.Add("CodigoAlunoDeveSerMaiorQueZero ", new Rule<ACAlunoResponsavel>(CodigoResponsavelDeveSerMaiorQueZero, "Código do responsável deve ser maior que Zero.", ACAlunoResponsavel));
            base.Add("CodigoParentescoDeveSerMaiorQueZero", new Rule<ACAlunoResponsavel>(CodigoParentescoDeveSerMaiorQueZero, "Código do parentesco deve ser maior que Zero.", ACAlunoResponsavel));
        }
    }
}
