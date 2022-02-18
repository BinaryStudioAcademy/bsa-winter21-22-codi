namespace Codi.Core.BLL.Exceptions;

public sealed class NotFoundException<T> : Exception
    where T : struct
{
    public NotFoundException(string name, T id)
        : base($"Entity {name} with id ({id}) was not found.")
    {
    }

    public NotFoundException(string name) : base($"Entity {name} was not found.") { }
}