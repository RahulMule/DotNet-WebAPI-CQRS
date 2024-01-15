using DotNet_WebAPI_CQRS.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace DotNet_WebAPI_CQRS.Commands
{
    public class AddGameCommand : IRequest<ActionResult>
    {
        public Game game { get; set; }

        public AddGameCommand(Game game)
        {
            this.game = game;
        }
    }
}
