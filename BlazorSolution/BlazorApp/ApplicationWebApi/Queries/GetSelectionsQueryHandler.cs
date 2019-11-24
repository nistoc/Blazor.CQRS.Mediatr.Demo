using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using BlazorApp.ApplicationWebApi.Models;
using MediatR;

namespace BlazorApp.ApplicationWebApi.Queries
{

    public class GetSelectionsQueryHandler : IRequestHandler<GetSelectionsQuery, SelectionsDto>
    {
        public async Task<SelectionsDto> Handle(GetSelectionsQuery request, CancellationToken cancellationToken)
        {
            await Task.Delay(900);

            return new SelectionsDto
            {
                Names = new List<string> { "Dostoevskii", "Mendeleev", "Matreshka" },
                Roles = new List<string> { "chemist", "russian doll", "philosopher" }
            };
        }
    }
}
