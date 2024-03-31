using LinguagensFormais.Dtos;
using LinguagensFormais.Services;
using Microsoft.AspNetCore.Mvc;

namespace LinguagensFormais.Controllers
{
    public class GrammarController : ControllerBase
    {
        [HttpGet("examples")]
        public IActionResult GetGrammerExamples()
        {
            return Ok(ExamplesService.GetExamples());
        }

        [HttpPost("generate-or-derive")]
        public IActionResult GenerateOrDeriveSentence([FromBody] Grammar grammar)
        {
            var (sentence, derivationSteps) = RandomSentenceService.GenerateRandomSentence(grammar);
            return Ok(new { sentence, derivationSteps });
        }
    }
}
