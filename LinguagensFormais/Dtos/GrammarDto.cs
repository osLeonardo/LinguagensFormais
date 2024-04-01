using System.ComponentModel;

namespace LinguagensFormais.Dtos
{
    public class Grammar
    {
        [Description("Não terminais")]
        public HashSet<string> N { get; set; }

        [Description("Terminais")]
        public HashSet<string> T { get; set; }

        [Description("Produções")]
        public Dictionary<string, List<string>> P { get; set; }
        
        [Description("Inicial")]
        public string S { get; set; }
    }
}