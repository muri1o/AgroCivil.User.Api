using AgroCivil.Usuario.Domain.Commands.User.Request;
using AgroCivil.Usuario.Domain.Services.IUserService;
using AgroCivil.Usuario.Domain.Shared;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace AgroCivil.Usuario.Domain.Handlers.User
{
    public class GetUsersAsyncCommandHandler : IRequestHandler<GetUsersAsyncCommand, ResponseBaseModel>
    {
        private readonly IUserService _userService;
        public GetUsersAsyncCommandHandler(IUserService userService)
        {
            _userService = userService;
        }

        public async Task<ResponseBaseModel> Handle(GetUsersAsyncCommand request, CancellationToken cancellationToken)
        {
            var response = new GetUsersAsyncResponseCommand();

            var users = await _userService.GetUsers();

            response.Users = users;

            return response;
        }
    }
}