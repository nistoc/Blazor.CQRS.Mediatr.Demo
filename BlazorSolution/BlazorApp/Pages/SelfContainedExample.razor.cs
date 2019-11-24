using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorApp.Application.Commands;
using MediatR;
using Microsoft.AspNetCore.Components;

namespace BlazorApp.Pages
{

    /// <summary>
    /// Class SelfContainedExampleBase.
    /// Derives from the <see cref="ComponentBase" />
    /// </summary>
    /// <remarks>
    /// This class demonstrates one approach to using MediatR in a Blazor application.
    /// All the code(except the fictitious repository and possibly domain objects) is contained in this one file.
    /// Nested classes are used to hold the queries, commands, and model objects that 'could' be placed in separate files.
    /// One advantage of structuring the application this way, is all the code required for this feature is here.
    /// If this feature requires a modification, the chance of merge conflicts is near zero when the developer checks in.
    /// This code was presented by Jimmy Bogard at NDC 2018. In the presentation he was showing something similar in a MVC Razor page.
    /// Since Blazor pages are so similar to Razor pages, it made sense to try this.
    /// Dependency Injection handles all the magic of associating the query or command with it's handler.  Send Mediator it's request, and it's handled for you.
    /// </remarks>

    public class SelfContainedExampleBase : ComponentBase
    {
        [Inject]
        public IMediator Mediator { get; set; }

        public ViewModel Model { get; private set; }

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






        public class ViewModel
        {

            public IList<String> Names { get; }

            public IList<String> Roles { get; }

            public String SelectedName { get; set; }

            public String SelectedRole { get; set; }

            public ViewModel(IList<String> roles, IList<String> names)
            {
                this.Roles = roles;
                this.Names = names;
            }
        }

    }
}
