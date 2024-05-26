namespace Agenda.Aplicacao;

public enum TipoDocumentoDto
{
    RG, CPF
}

public class DocumentoIdentificacaoDto
{
    public TipoDocumentoDto Tipo { get; set; }
    public string Numero { get; set; }
}
