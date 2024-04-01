using LinguagensFormais.Dtos;
using System.Text;

namespace LinguagensFormais.Services
{
    public static class RandomSentenceService
    {
        public static (string, List<DerivationStep>) GenerateRandomSentence(Grammar grammar)
        {
            var derivationSteps = new List<DerivationStep>();
            var sentence = DeriveSentence(grammar, grammar.S, derivationSteps, "");
            return (sentence, derivationSteps);
        }

        private static string DeriveSentence(Grammar grammar, string current, List<DerivationStep> steps, string partialSentence)
        {
            if (!grammar.P.ContainsKey(current))
                return current;

            var productions = grammar.P[current];
            var production = productions[new Random().Next(productions.Count)];

            if (partialSentence == "")
                steps.Add(new DerivationStep { NonTerminal = current, Production = production, PartialSentence = production });

            else steps.Add(new DerivationStep { NonTerminal = current, Production = production, PartialSentence = partialSentence.Replace(current, production) });

            var derivedSentence = new StringBuilder();
            foreach (var symbol in production)
            {
                if (grammar.N.Contains(symbol.ToString()))
                    derivedSentence.Append(DeriveSentence(grammar, symbol.ToString(), steps, partialSentence + production));

                else derivedSentence.Append(symbol);
            }

            return derivedSentence.ToString();
        }
    }
}