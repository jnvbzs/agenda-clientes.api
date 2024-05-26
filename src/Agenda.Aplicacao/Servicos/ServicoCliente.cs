using Agenda.Dominio;
using Agenda.Infra;
using AutoMapper;

namespace Agenda.Aplicacao;

public class ServicoCliente
{
    private readonly IRepositorioCliente _repositorioCliente;
    private readonly IMapper _mapper;

    public ServicoCliente(IRepositorioCliente repositorioCliente, IMapper mapper)
    {
        _repositorioCliente = repositorioCliente;
        _mapper = mapper;
    }

    public async Task Criar(CriarClienteDto criarClienteDtoclienteDto)
    {
        var cliente = _mapper.Map<Cliente>(criarClienteDtoclienteDto);
        await _repositorioCliente.Criar(cliente);
    }

    public async Task Atualizar(Guid id, AtualizarClienteDto atualizarClienteDto)
    {
        var cliente = await _repositorioCliente.ObterPorId(id);

        if (cliente != null)
        {
            _mapper.Map(atualizarClienteDto, cliente);
            await _repositorioCliente.Atualizar(cliente);
        }
    }

    public async Task<ClienteDto> ObterPorId(Guid id)
    {
        var cliente = await _repositorioCliente.ObterPorId(id);
        return _mapper.Map<ClienteDto>(cliente);
    }

    public async Task<IEnumerable<ClienteDto>> ObterTodos()
    {
        var clientes = await _repositorioCliente.ObterTodos();
        return _mapper.Map<IList<ClienteDto>>(clientes);
    }

    public async Task Remover(Guid id)
    {
        var cliente = await _repositorioCliente.ObterPorId(id);

        if (cliente != null)
        {
            await _repositorioCliente.Remover(id);
        }
    }
}
