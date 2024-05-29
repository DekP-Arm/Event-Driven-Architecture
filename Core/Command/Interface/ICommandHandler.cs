
namespace EDA.Command.Interface
{
    public interface ICommandHandler<TCommand>
    {
        Task HandleAsync(TCommand command);
    }
}