using Agenda.Dominio;
using AutoMapper;

namespace Agenda.Aplicacao;

public class PerfilCliente : Profile
{
    public PerfilCliente()
    {
        CreateMap<ClienteDto, Cliente>().ReverseMap();
        CreateMap<CriarClienteDto, Cliente>().ReverseMap();
        CreateMap<AtualizarClienteDto, Cliente>().ForMember(dest => dest.Id, opt => opt.Ignore());
        CreateMap<TelefoneDto, Telefone>().ReverseMap();
        CreateMap<DocumentoIdentificacaoDto, DocumentoIdentificacao>().ReverseMap();
        CreateMap<EnderecoDTO, Endereco>().ReverseMap();
    }
}
