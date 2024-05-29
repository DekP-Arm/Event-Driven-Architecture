using EDA.Entity;
using EDA.Infra.Interface;
using EDA.Command.Interface;
using EDA.Command;

namespace EDA.CommandHandle
{
    public class UpdateUserCommandHandler : ICommandHandler<UpdateUserCommand>
    {
        private readonly IUserRepository _userRepository;

        public UpdateUserCommandHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task HandleAsync(UpdateUserCommand command)
        {
            var user = new UserDbo
            {
                Username = command.Username,
                Password = command.Password
            };
            var UpdateUser =  await _userRepository.UpdateUserAsync(user);
        }
    }
}