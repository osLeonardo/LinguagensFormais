using System.ComponentModel;

namespace LinguagensFormais.Dtos
{
    public class DerivationStep
    {
        [Description("Não terminais")]
        public string NonTerminal { get; set; }

        [Description("Produções")]
        public string Production { get; set; }

        [Description("Sentença parcial")]
        public string PartialSentence { get; set; }
    }
}
