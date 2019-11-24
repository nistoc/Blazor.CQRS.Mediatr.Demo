using System.Threading.Tasks;
using BlazorApp.ApplicationWebApi.Commands;
using BlazorApp.ApplicationWebApi.Models;
using BlazorApp.ApplicationWebApi.Queries;
using MediatR;
using Microsoft.AspNetCore.Components;

namespace BlazorApp.Pages
{

    /// <summary>
    /// Class WebApiStyleExampleBase.
    /// Derives from the <see cref="ComponentBase" />
    /// </summary>
    /// <remarks>
    /// This class demonstrates one approach to using MediatR in a Blazor application.
    /// This approach is very similar to using MediatR in a Web API app, where the two below methods would each be controller routes.
    /// Notice the 'Application' folder that contains the commands, models, and queries.
    /// </remarks>
    public class WebApiStyleExampleBase: ComponentBase
    {
        [Inject]
        public IMediator Mediator { get; set; }

        public ViewModel Model { get; set; }

        public string Result { get; set; }

        public async Task VerifySelections()
        {
            var result = await Mediator.Send(new VerifyAnswerCommand
            {
                Name = Model.SelectedName,
                Role = Model.SelectedRole
            });

            Result = result ? $"Outstanding, {Model.SelectedName}'s role is {Model.SelectedRole}" : $"Sorry give it another try";
        }


        protected override async Task OnInitializedAsync()
        {
            var selections = await Mediator.Send(new GetSelectionsQuery());
            Model = new ViewModel(selections.Roles, selections.Names);
        }
    }
}
