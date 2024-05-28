# Agenda Clientes .NET

## Requisitos

Certifique-se de ter as seguintes dependências instaladas em sua máquina:

- [Docker](https://docs.docker.com/get-docker/)
- [.NET Core SDK](https://dotnet.microsoft.com/download)

## Executando

- Clone este repositório:

    ```bash
    git clone https://github.com/jnvbzs/agenda-clientes.api.git
    ```

- Navegue até o diretório do projeto:

    ```bash
    cd agenda-clientes.api
    ```

## Com docker

- Construa a imagem Docker:

    ```bash
    docker build -t agenda.api ./src/Agenda.API
    ```

- Suba o container com a imagem da api e um banco SQL:

    ```bash
    docker-compose up
    ```

## Localmente

- Inicie a api com a donet CLI

    ```bash
    dotnet run --project ./src/Agenda.API
    ```

Agora, você pode acessar a API em `http://localhost:5259`.

## Endpoints Disponíveis

- `GET /api/cliente`: Retorna uma lista de clientes.
- `GET /api/cliente/:id`: Retorna um cliente.
- `POST /api/cliente/`: Cria um cliente.
- `PUT /api/cliente/:id`: Atualiza um cliente.
- `DELETE /api/cliente/:id`: Deleta um cliente.
