using LinguagensFormais.Dtos;
using System.Linq;

namespace LinguagensFormais.Services
{
    public static class RandomSentenceService
    {
        public static (string sentence, List<string> derivationSteps) GenerateRandomSentence(Grammar grammar)
        {
            var derivationSteps = new List<string>();
            var stack = new Stack<string>();
            stack.Push(grammar.S);

            while (stack.Contains(grammar.N.ToString()))
            {
                var symbol = stack.Pop();
                if (grammar.T.Contains(symbol)) // If symbol is terminal, add it to derivation steps
                {
                    derivationSteps.Add(symbol);
                }
                else if (grammar.N.Contains(symbol)) // If symbol is non-terminal, expand itx
                {
                    var productions = grammar.P[symbol];
                    var randomProduction = productions[new Random().Next(0, productions.Count)];

                    // Split the production into symbols and push them onto the stack in reverse order
                    foreach (var s in randomProduction.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Reverse())
                    {
                        stack.Push(s);
                    }

                    // Add the current production to the derivation steps
                    derivationSteps.Add($"{symbol}->{randomProduction}");
                }
            }

            // Filter out non-terminal symbols from the final sentence
            var sentence = string.Join("", derivationSteps
                .Where(step => !step.Contains("->")) // Filter out non-terminal productions
                .Select(step => step.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)) // Split the step into symbols
                .SelectMany(symbols => symbols) // Flatten the symbols into a single sequence
                .Where(symbol => grammar.T.Contains(symbol))); // Filter out non-terminal symbols

            return (sentence, derivationSteps.Where(step => !step.Contains("->")).ToList());
        }
    }
}