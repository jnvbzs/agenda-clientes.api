using Agenda.Dominio;
using Microsoft.EntityFrameworkCore;

namespace Agenda.Infra;

public class RepositorioCliente : IRepositorioCliente
{
    private readonly ClienteContext _context;

    public RepositorioCliente(ClienteContext context)
    {
        _context = context;
    }

    public async Task Atualizar(Cliente cliente)
    {
        _context.Clientes.Update(cliente);
        await _context.SaveChangesAsync();
    }

    public async Task Criar(Cliente cliente)
    {
        await _context.Clientes.AddAsync(cliente);
        await _context.SaveChangesAsync();
    }

    public async Task<Cliente?> ObterPorId(Guid id)
    {
        return await _context.Clientes
            .Include(c => c.Telefones)
            .Include(c => c.Endereco)
            .Include(c => c.Documentos)
            .FirstOrDefaultAsync(c => c.Id == id);
    }

    public async Task<IList<Cliente>> ObterTodos()
    {
        return await _context.Clientes
            .Include(c => c.Telefones)
            .Include(c => c.Endereco)
            .Include(c => c.Documentos)
            .ToListAsync();
    }

    public async Task Remover(Guid id)
    {
        var cliente = await _context.Clientes.FindAsync(id);
        _context.Clientes.Remove(cliente);
        await _context.SaveChangesAsync();
    }
}
