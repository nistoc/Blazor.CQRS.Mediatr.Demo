using BlazorApp.ApplicationWebApi.Models;
using MediatR;

namespace BlazorApp.ApplicationWebApi.Queries
{
    public class GetSelectionsQuery : IRequest<SelectionsDto> { }
}
