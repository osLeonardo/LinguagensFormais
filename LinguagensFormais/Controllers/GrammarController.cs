using LinguagensFormais.Dtos;
using LinguagensFormais.Services;
using Microsoft.AspNetCore.Mvc;

namespace LinguagensFormais.Controllers
{
    public class GrammarController : ControllerBase
    {
        [HttpGet("examples")]
        [Produces("application/json", Type = typeof(Grammar))]
        public IActionResult GetGrammerExamples()
        {
            return Ok(ExamplesService.GetExamples());
        }

        [HttpPost("generate")]
        [Produces("application/json", Type = typeof(Response))]
        public IActionResult GenerateRandomSentence([FromBody] Grammar grammar)
        {
            var (sentence, derivationSteps) = RandomSentenceService.GenerateRandomSentence(grammar);
            return Ok(new { sentence, derivationSteps });
        }
    }
}