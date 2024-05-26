namespace Agenda.Infra;

public interface IRepositorio<T>
{
    Task<IList<T>> ObterTodos();
    Task<T?> ObterPorId(Guid id);
    Task Criar(T modelo);
    Task Atualizar(T modelo);
    Task Remover(Guid id);
}
