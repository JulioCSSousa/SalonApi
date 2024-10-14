API de Agendamento de Salão
Esta API permite o gerenciamento de agendamentos para um salão de beleza, permitindo criar, listar, atualizar e excluir agendamentos, além de gerenciar clientes. A API foi desenvolvida usando ASP.NET Core e Entity Framework e está preparada para integração com um frontend em React.

Índice
Tecnologias Utilizadas
Instalação
Configuração
Endpoints
Listar Agendamentos
Criar Agendamento
Atualizar Agendamento
Deletar Agendamento
Listar Clientes
Módulos Adicionais
Configuração de CORS
Licença
Tecnologias Utilizadas
ASP.NET Core 6
Entity Framework Core
SQL Server ou MySQL (Banco de Dados)
AutoMapper
React (para o frontend)
Instalação
Clone este repositório para sua máquina local:

bash
Copiar código
git clone https://github.com/seu-usuario/sua-api-agendamento-salao.git
cd sua-api-agendamento-salao
Instale as dependências necessárias:

bash
Copiar código
dotnet restore
Configure a string de conexão com o banco de dados em appsettings.json:

json
Copiar código
"ConnectionStrings": {
  "DefaultConnection": "Server=localhost;Database=SalonDB;User Id=seu-usuario;Password=sua-senha;"
}
Rode as migrações para criar o banco de dados:

bash
Copiar código
dotnet ef database update
Inicie o servidor:

bash
Copiar código
dotnet run
Acesse a API em http://localhost:5000.

Configuração
Alterar para HTTP
Para usar HTTP em vez de HTTPS no desenvolvimento, edite o arquivo launchSettings.json conforme abaixo:

json
Copiar código
"applicationUrl": "http://localhost:5000",
Comente ou remova a linha app.UseHttpsRedirection(); em Program.cs ou Startup.cs:

csharp
Copiar código
// app.UseHttpsRedirection();
Endpoints
Listar Agendamentos
GET /api/Appointments

Retorna a lista de todos os agendamentos.

Exemplo de Resposta:

json
Copiar código
[
  {
    "id": 1,
    "date": "2024-10-14T14:00:00",
    "client": {
      "name": "Maria Silva",
      "phoneNumber": "(11) 98765-4321"
    },
    "service": "Corte de Cabelo"
  },
  ...
]
Criar Agendamento
POST /api/Appointments

Cria um novo agendamento.

Body da Requisição:

json
Copiar código
{
  "date": "2024-10-15T15:00:00",
  "clientId": 1,
  "service": "Corte de Cabelo"
}
Exemplo de Resposta:

json
Copiar código
{
  "id": 2,
  "date": "2024-10-15T15:00:00",
  "client": {
    "name": "João Souza",
    "phoneNumber": "(11) 91234-5678"
  },
  "service": "Corte de Cabelo"
}
Atualizar Agendamento
PUT /api/Appointments/{id}

Atualiza os detalhes de um agendamento existente.

Body da Requisição:

json
Copiar código
{
  "date": "2024-10-16T16:00:00",
  "clientId": 2,
  "service": "Manicure"
}
Exemplo de Resposta:

json
Copiar código
{
  "id": 1,
  "date": "2024-10-16T16:00:00",
  "client": {
    "name": "João Souza",
    "phoneNumber": "(11) 91234-5678"
  },
  "service": "Manicure"
}
Deletar Agendamento
DELETE /api/Appointments/{id}

Exclui um agendamento específico com base no ID.

Exemplo de Resposta:

json
Copiar código
{
  "message": "Agendamento excluído com sucesso."
}
Listar Clientes
GET /api/Clients

Retorna uma lista de todos os clientes cadastrados no sistema.

Exemplo de Resposta:

json
Copiar código
[
  {
    "id": 1,
    "name": "Maria Silva",
    "phoneNumber": "(11) 98765-4321"
  },
  {
    "id": 2,
    "name": "João Souza",
    "phoneNumber": "(11) 91234-5678"
  }
]
Módulos Adicionais
AutoMapper: Usado para mapear entidades para DTOs.
Entity Framework Core: Usado para gerenciar o banco de dados e realizar as operações CRUD.
Configuração de CORS
Se o frontend React está recebendo erros de CORS, é necessário configurar a API para permitir requisições de origens específicas.

Adicione a configuração de CORS no Program.cs ou Startup.cs:

csharp
Copiar código
public void ConfigureServices(IServiceCollection services)
{
    services.AddCors(options =>
    {
        options.AddPolicy("AllowAll", builder =>
        {
            builder.AllowAnyOrigin()
                   .AllowAnyMethod()
                   .AllowAnyHeader();
        });
    });
    
    services.AddControllers();
}

public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
{
    app.UseCors("AllowAll");
    
    app.UseRouting();
    app.UseEndpoints(endpoints =>
    {
        endpoints.MapControllers();
    });
}
Licença
Este projeto está licenciado sob a Licença MIT. Veja o arquivo LICENSE para mais detalhes.
