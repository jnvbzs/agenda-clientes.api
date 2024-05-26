namespace Agenda.Dominio;

public class Telefone
{
    public Guid Id { get; set; }
    public string Numero { get; set; }
    public Guid ClienteId { get; set; }
    public Cliente Cliente { get; set; }
}
