using DotNet_WebAPI_CQRS.Models;
using MediatR;

namespace DotNet_WebAPI_CQRS.Queries
{
    public class GetAllGamesQuery : IRequest<IEnumerable<Game>>
    {
             
    }
}
