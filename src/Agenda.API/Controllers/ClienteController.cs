using Agenda.Aplicacao;
using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
[ApiController]
public class ClienteController : ControllerBase
{
    private readonly ServicoCliente _servicoCliente;

    public ClienteController(ServicoCliente servicoCliente)
    {
        _servicoCliente = servicoCliente;
    }

    [HttpPost]
    public async Task<IActionResult> Criar([FromBody] CriarClienteDto criarClienteDto)
    {
        await _servicoCliente.Criar(criarClienteDto);
        return Ok();
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Atualizar([FromRoute] Guid id, [FromBody] AtualizarClienteDto atualizarClienteDto)
    {
        await _servicoCliente.Atualizar(id, atualizarClienteDto);
        return Ok();
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> ObterPorId([FromRoute] Guid id)
    {
        var cliente = await _servicoCliente.ObterPorId(id);

        return Ok(cliente);
    }

    [HttpGet]
    public async Task<IActionResult> ObterTodos()
    {
        var clientes = await _servicoCliente.ObterTodos();
        return Ok(clientes);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Remover([FromRoute] Guid id)
    {
        await _servicoCliente.Remover(id);
        return Ok();
    }
}
