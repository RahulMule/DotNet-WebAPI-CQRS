using DotNet_WebAPI_CQRS.Commands;
using DotNet_WebAPI_CQRS.Models;
using DotNet_WebAPI_CQRS.Queries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DotNet_WebAPI_CQRS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GamesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public GamesController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<ActionResult> GetAllGames()
        {
            try
            {
                var query = new GetAllGamesQuery();
                var games = await _mediator.Send(query);
                if (games != null)
                {
                    return Ok(games);
                }
                return NotFound("No Games Found");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public async Task<ActionResult> AddGame(Game game)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var command = new AddGameCommand(game);
                    var resp = await _mediator.Send(command);
                    return Ok(resp);
                }
                return BadRequest(ModelState);
            }
            catch (Exception ex1)
            {
                return BadRequest(ex1.Message);
            }
        }
    }
}
