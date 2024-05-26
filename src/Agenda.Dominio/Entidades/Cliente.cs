namespace Agenda.Dominio;

public class Cliente
{
    public Guid Id { get; set; }
    public string Nome { get; set; }
    public string Email { get; set; }
    public DateTime DataNascimento { get; set; }
    public List<Telefone> Telefones { get; set; }
    public List<DocumentoIdentificacao> Documentos { get; set; }
    public Endereco Endereco { get; set; }
}
