using EDA.Entity;
using EDA.Infra.Interface;
using EDA.Command.Interface;
using EDA.Command;

namespace EDA.CommandHandle
{
    public class CreateUserCommandHandler : ICommandHandler<CreateUserCommand>
    {
        private readonly IUserRepository _userRepository;

        public CreateUserCommandHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task HandleAsync(CreateUserCommand command)
        {
            var user = new UserDbo
            {
                Username = command.Username,
                Password = command.Password
            };
            var createUser =  await _userRepository.CreateUserAsync(user);
            
        }
    }
}