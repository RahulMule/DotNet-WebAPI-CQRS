using DotNet_WebAPI_CQRS.Data;
using DotNet_WebAPI_CQRS.Models;
using DotNet_WebAPI_CQRS.Queries;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace DotNet_WebAPI_CQRS.Handlers
{
    public class GetAllGamesHandler : IRequestHandler<GetAllGamesQuery,IEnumerable<Game>>
    {
        private readonly GameContext _context;

        public GetAllGamesHandler(GameContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Game>> Handle(GetAllGamesQuery request, CancellationToken cancellationToken)
        {
            IEnumerable<Game> games = await _context.games.ToListAsync(cancellationToken);
            if(games.Any())
            {
                return games;
            }
            return null;

        }
    }
}
