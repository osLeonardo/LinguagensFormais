using LinguagensFormais.Dtos;

namespace LinguagensFormais.Services
{
    public class ExamplesService
    {
        public static Dictionary<string, Grammar> GetExamples()
        {
            var examples = new Dictionary<string, Grammar>();

            examples["example 01"] = new Grammar
            {
                N = new HashSet<string> { "S", "A" },
                T = new HashSet<string> { "0", "1", "2" },
                P = new Dictionary<string, List<string>>
                {
                    { "S", new List<string> { "0A", "1S", "2S" } },
                    { "A", new List<string> { "0A", "1S", "2S", "" } }
                },
                S = "S"
            };
            
            examples["example 02"] = new Grammar
            {
                N = new HashSet<string> { },
                T = new HashSet<string> { },
                P = new Dictionary<string, List<string>>
                { },
                S = ""
            };

            return examples;
        }
    }
}