using Microsoft.AspNetCore.Mvc;
using Roulette.Controllers;

namespace Roulette.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CreationRoulette : ControllerBase
    {
        public static int ValorGlobal { get; set; }
        [HttpGet]
        public IActionResult Get()
        {
            RPRoulette rpCli = new RPRoulette();
            return Ok(rpCli.GetInformations());
        }

        [HttpPost("Open")]
        public IActionResult OpenRoulette(int id)
        {
            RPRoulette rpCli = new RPRoulette();
            ValorGlobal = id;
            var cliRet = rpCli.GetInfo(id);
            if (cliRet == null)
            {
                var nf = NotFound("Denegado");
                return nf;
            }

            return Ok("Exitosa");
        }

        [HttpPost("Add")]
        public IActionResult AddRoulette(Properties NewRoulette)
        {
            RPRoulette rpCli = new RPRoulette();
            rpCli.Add(NewRoulette);
            return AcceptedAtAction(nameof(AddRoulette), NewRoulette);
        }

        [HttpPost("Bet")]
        public IActionResult Bet(Bet NewRoulette)
        {
            RPRoulette rpCli = new RPRoulette();
            var cliRet = rpCli.GetInfo(ValorGlobal);
            if (cliRet == null)
            {
                return NotFound("No se encuentra activa la ruleta");
            }
            var Numero = rpCli.BetOn(NewRoulette);
            if (Numero == 1)
            {
                return Ok("Ganaste");
            }
            else
            {
                return Ok("Perdiste");
            }
        }
    }
}
