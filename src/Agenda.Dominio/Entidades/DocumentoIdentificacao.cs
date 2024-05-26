namespace Agenda.Dominio;

public enum TipoDocumento 
{
    CPF, RG
}

public class DocumentoIdentificacao
{
    public Guid Id { get; set; }
    public TipoDocumento Tipo { get; set; }
    public string Numero { get; set; }
    public Guid ClienteId { get; set; }
    public Cliente Cliente { get; set; }
}
