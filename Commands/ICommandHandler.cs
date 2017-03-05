using System.Threading.Tasks;

namespace Warden.Messages.Commands
{
    public interface ICommandHandler<in T> where T : ICommand
    {
        Task HandleAsync(T command);
    }
}