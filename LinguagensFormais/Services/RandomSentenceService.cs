using LinguagensFormais.Dtos;
using System.Text;

namespace LinguagensFormais.Services
{
    public static class RandomSentenceService
    {
        public static (string, List<DerivationStep>) GenerateRandomSentence(Grammar grammar)
        {
            var derivationSteps = new List<DerivationStep>();
            var sentence = DeriveSentence(grammar, grammar.S, derivationSteps, new StringBuilder());
            return (sentence, derivationSteps);
        }

        private static string DeriveSentence(Grammar grammar, string current, List<DerivationStep> steps, StringBuilder partialSentence)
        {
            if (!grammar.P.ContainsKey(current)) return current;

            var productions = grammar.P[current];
            var production = productions[new Random().Next(productions.Count)];

            if (partialSentence.Equals("")) partialSentence.Append(production);
            else partialSentence.Replace(current, production);

            steps.Add(new DerivationStep { NonTerminal = current, Production = production, PartialSentence = partialSentence.ToString() });

            var derivedSentence = new StringBuilder();
            foreach (var symbol in production)
            {
                if (grammar.N.Contains(symbol.ToString()))
                    derivedSentence.Append(DeriveSentence(grammar, symbol.ToString(), steps, partialSentence));

                else derivedSentence.Append(symbol);
            }

            return derivedSentence.ToString();
        }
    }
}