using Agenda.Dominio;
using AutoMapper;

namespace Agenda.Aplicacao;

public class PerfilCliente : Profile
{
    public PerfilCliente()
    {
        CreateMap<ClienteDto, Cliente>().ReverseMap();
        CreateMap<CriarClienteDto, Cliente>().ReverseMap();
        CreateMap<AtualizarClienteDto, Cliente>().ReverseMap();
        CreateMap<TelefoneDto, Telefone>().ReverseMap();
        CreateMap<DocumentoIdentificacaoDto, DocumentoIdentificacao>().ReverseMap();
        CreateMap<EnderecoDTO, Endereco>().ReverseMap();
    }
}
