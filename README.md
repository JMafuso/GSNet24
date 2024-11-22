GSNet24

GSNet24 é uma API Web .NET Core projetada inicialmente para armazenar e computar o tempo de uso de eletrônicos. Ela utiliza o banco de dados Oracle e segue o padrão de repositório para facilitar a manutenção e a organização do código.

Pré-requisitos

- .NET SDK 8.0
- Banco de Dados Oracle configurado
- Visual Studio 2019 ou superior (ou outro editor, como Visual Studio Code)

Instalação

1. Clone o repositório:
   git clone https://github.com/JMafuso/GSNet24.git
   cd GSNet24
   
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

Endpoints da API

GET /aparelho/List  
Retorna todos os aparelhos cadastrados.

POST /aparelho/Add  
Adiciona um novo aparelho. Exemplo de corpo da requisição:
{
  "NomeAparelho": "Microondas",
  "TempoUso": 12
}

PUT /aparelho/Update  
Atualiza os dados de um aparelho. Exemplo de corpo da requisição:
{
  "AparelhoId": 1,
  "NomeAparelho": "Microondas",
  "TempoUso": 13
}

DELETE /aparelho/Delete  
Exclui um aparelho pelo ID. Exemplo de uso:
?id=1
