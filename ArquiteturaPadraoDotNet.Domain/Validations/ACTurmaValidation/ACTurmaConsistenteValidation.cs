using One.Domain.Entities;
using One.Domain.Specifications.ACTurmaSpecification;
using One.Domain.Validation;

namespace One.Domain.Validations.ACTurmaValidation
{
    public class ACTurmaConsistenteValidation : Validator<ACTurma>
    {

        public ACTurmaConsistenteValidation(ACTurma ACTurma)
        {
            var CodigoProfessorDeveSerMaiorQueZero = new CodigoProfessorDeveSerMaiorQueZero();
            var CodigoNivelDeveSerMaiorQueZero = new CodigoNivelDeveSerMaiorQueZero();
            var DataInicialDevSerValida = new DataInicialDevSerValida();
            var DataFinalDevSerValida = new DataFinalDevSerValida();
            var DataInicialDeveSerMenorQueDataFinal = new DataInicialDeveSerMenorQueDataFinal();

            base.Add("CodigoProfessorDeveSerMaiorQueZero", new Rule<ACTurma>(CodigoProfessorDeveSerMaiorQueZero, "código do professor deve ser maior que zero", ACTurma));
            base.Add("CodigoNivelDeveSerMaiorQueZero", new Rule<ACTurma>(CodigoNivelDeveSerMaiorQueZero, "código do nivel deve ser maior que zero", ACTurma));
            base.Add("DataInicialDeveSerMenorQueDataFinal", new Rule<ACTurma>(DataInicialDeveSerMenorQueDataFinal, "Data inicial deve ser menor que a adata final", ACTurma));
            base.Add("DataInicialDevSerValida", new Rule<ACTurma>(DataInicialDevSerValida, "data inicial deve ser válida", ACTurma));
            base.Add("DataFinalDevSerValida", new Rule<ACTurma>(DataFinalDevSerValida, "data final deve ser válida", ACTurma));
        }
        


    }
}
