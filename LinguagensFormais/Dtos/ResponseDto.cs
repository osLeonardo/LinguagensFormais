using System.ComponentModel;

namespace LinguagensFormais.Dtos
{
    public class Response
    {
        [Description("Sentença")]
        public string Sentence { get; set; }

        [Description("Passos da derivação")]
        public List<DerivationStep> DerivationSteps { get; set; }
    }
}
