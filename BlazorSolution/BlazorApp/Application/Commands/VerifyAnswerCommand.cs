using MediatR;
using System;

namespace BlazorApp.Application.Commands
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
