﻿namespace Agenda.Aplicacao;

public class AtualizarClienteDto
{
    public string Nome { get; set; }
    public string Email { get; set; }
    public DateTime DataNascimento { get; set; }
    public List<TelefoneDto> Telefones { get; set; }
    public List<DocumentoIdentificacaoDto> Documentos { get; set; }
    public EnderecoDto Endereco { get; set; }
}
