GSNet24
GSNet24 é um projeto de API Web .NET Core projetado para gerenciar dispositivos eletrônicos. Ele utiliza Oracle como seu sistema de gerenciamento de banco de dados e segue o padrão de repositório para código limpo e de fácil manutenção.

Índice
Pré-requisitos

Instalação

Configuração

Migrações de Banco de Dados

Executando a Aplicação

Endpoints da API

Licença

Pré-requisitos
.NET SDK 6.0 ou superior

Banco de Dados Oracle

Visual Studio 2019 ou superior

Instalação
Clone o repositório:

bash
git clone https://github.com/seuusuario/GSNet24.git
cd GSNet24
Instale os pacotes necessários:

bash
dotnet restore
Configuração
Abra appsettings.json e configure sua conexão com o banco de dados Oracle:

json
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
Adicione uma nova migração:

bash
dotnet ef migrations add InitialCreate
Atualize o banco de dados:

bash
dotnet ef database update
Executando a Aplicação
Compile e execute a aplicação:

bash
dotnet run
A aplicação será iniciada e você poderá acessar os endpoints da API.

Endpoints da API
AparelhoController
GET /aparelho/List - Recupera uma lista de todos os aparelhos.

POST /aparelho/Add - Adiciona um novo aparelho.

Exemplo de corpo da requisição:

json
{
  "NomeAparelho": "Smartphone",
  "TempoUso": 120
}
PUT /aparelho/Update - Atualiza um aparelho existente.

Exemplo de corpo da requisição:

json
{
  "AparelhoId": 1,
  "NomeAparelho": "Smartphone",
  "TempoUso": 150
}
DELETE /aparelho/Delete - Exclui um aparelho pelo ID.

Exemplo de parâmetro de consulta: ?id=1
