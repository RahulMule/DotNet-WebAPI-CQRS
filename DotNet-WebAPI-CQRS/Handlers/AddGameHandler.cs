using DotNet_WebAPI_CQRS.Commands;
using DotNet_WebAPI_CQRS.Data;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace DotNet_WebAPI_CQRS.Handlers
{
    public class AddGameHandler : IRequestHandler<AddGameCommand, ActionResult>
    {

        private readonly GameContext _context;

        public AddGameHandler(GameContext context)
        {
            _context = context;
        }

        public async Task<ActionResult> Handle(AddGameCommand request, CancellationToken cancellationToken)
        {
            await _context.games.AddAsync(request.game);
            await _context.SaveChangesAsync();
            return new OkResult();
        }
    }
}
