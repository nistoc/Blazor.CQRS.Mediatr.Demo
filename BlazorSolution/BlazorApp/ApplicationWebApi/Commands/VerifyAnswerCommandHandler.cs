using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace BlazorApp.ApplicationWebApi.Commands
{

    public class VerifyAnswerCommandHandler : IRequestHandler<VerifyAnswerCommand, Boolean>
    {
        public async Task<bool> Handle(VerifyAnswerCommand request, CancellationToken cancellationToken)
        {
            await Task.Delay(900);

            switch (request.Role)
            {
                case "chemist":
                    return request.Name == "Mendeleev";
                case "russian doll":
                    return request.Name == "Matreshka";
                case "philosopher":
                    return request.Name == "Dostoevskii";
            }

            return false;
        }
    }
}
