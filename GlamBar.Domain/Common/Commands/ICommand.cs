using MediatR;

namespace GlamBar.Domain.Common.Commands;

public interface ICommand<out TResult> : ICommand, IRequest<TResult>
{
}

public interface ICommand
{
}