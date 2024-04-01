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
                N = new HashSet<string> { "S", "A", "B", "C" },
                T = new HashSet<string> { "a", "b", "c" },
                P = new Dictionary<string, List<string>>
                {
                    { "S", new List<string> { "ABC" } },
                    { "A", new List<string> { "aA", "a" } },
                    { "B", new List<string> { "bB", "" } },
                    { "C", new List<string> { "cA" } }
                },
                S = "S"
            };
            
            examples["example 03"] = new Grammar
            {
                N = new HashSet<string> { "S", "A", "B" },
                T = new HashSet<string> { "0", "1" },
                P = new Dictionary<string, List<string>>
                {
                    { "S", new List<string> { "0B", "1A" } },
                    { "A", new List<string> { "0", "0S", "1AA" } },
                    { "B", new List<string> { "1", "1S", "0BB" } }
                },
                S = "S"
            };
            
            examples["example 04"] = new Grammar
            {
                N = new HashSet<string> { "S", "A", "B", "C" },
                T = new HashSet<string> { "a", "b", "c" },
                P = new Dictionary<string, List<string>>
                {
                    { "S", new List<string> { "aA" } },
                    { "A", new List<string> { "", "aB", "bC", "cC" } },
                    { "B", new List<string> { "aA" } },
                    { "C", new List<string> { "bC", "cC", "" } }
                },
                S = "S"
            };

            return examples;
        }
    }
}