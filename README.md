GSNet24

GSNet24 é uma API Web .NET Core projetada para gerenciar dispositivos eletrônicos. Ela utiliza o banco de dados Oracle e segue o padrão de repositório para facilitar a manutenção e a organização do código.

Pré-requisitos

- .NET SDK 6.0 ou superior
- Banco de Dados Oracle configurado
- Visual Studio 2019 ou superior (ou outro editor, como Visual Studio Code)

Instalação

1. Clone o repositório:
   git clone https://github.com/seuusuario/GSNet24.git
   cd GSNet24

2. Instale os pacotes necessários:
   dotnet restore

Configuração

Edite o arquivo appsettings.json com as configurações do banco de dados Oracle:

{
  "ConnectionStrings": {
    "OracleConnection": "Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=oracle.fiap.com.br)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=ORCL)));User Id=SEU_USUARIO;Password=SUA_SENHA;"
  },
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "AllowedHosts": "*"
}

Migrações de Banco de Dados

1. Adicione uma nova migração:
   dotnet ef migrations add InitialCreate

2. Atualize o banco de dados:
   dotnet ef database update

Executando a Aplicação

1. Inicie a aplicação:
   dotnet run

2. Acesse a API em:
   https://localhost:5001

Endpoints da API

GET /aparelho/List  
Retorna todos os aparelhos cadastrados.

POST /aparelho/Add  
Adiciona um novo aparelho. Exemplo de corpo da requisição:
{
  "NomeAparelho": "Smartphone",
  "TempoUso": 120
}

PUT /aparelho/Update  
Atualiza os dados de um aparelho. Exemplo de corpo da requisição:
{
  "AparelhoId": 1,
  "NomeAparelho": "Smartphone",
  "TempoUso": 150
}

DELETE /aparelho/Delete  
Exclui um aparelho pelo ID. Exemplo de uso:
?id=1
