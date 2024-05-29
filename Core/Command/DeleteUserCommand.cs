using EDA.Entity;
using EDA.Infra.Interface;
using EDA.Command.Interface;
using EDA.Command;

namespace EDA.CommandHandle
{
    public class DeleteUserCommandHandler : ICommandHandler<DeleteUserCommand>
    {
        private readonly IUserRepository _userRepository;

        public DeleteUserCommandHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task HandleAsync(DeleteUserCommand command)
        {
            var userToDelete = await _userRepository.GetUserByIdAsync(command.Id);
            if (userToDelete == null)
            {
                throw new Exception("User not found");
            }
            else{
                await _userRepository.DeleteUserAsync(userToDelete.UserId);
            }
        }
    }
}