using Microsoft.EntityFrameworkCore;

namespace Agenda.Infra;

public class InicializadorDbContext(DbContext context) : IInicializadorDb
{
    public void Iniciar()
    {
        context.Database.EnsureCreated();
    }
}
