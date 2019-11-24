using System;
using MediatR;

namespace BlazorApp.ApplicationWebApi.Commands
{

    public class VerifyAnswerCommand : IRequest<Boolean>
    {

        public String Name { get; set; } = String.Empty;

        public String Role { get; set; } = String.Empty;

        public VerifyAnswerCommand()
        {
        }
    }
}
