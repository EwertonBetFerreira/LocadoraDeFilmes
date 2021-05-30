========================================================================================
API e banco publicados na Azure, seguem abaixo as instruções para consumir a API (TODOS OS BODYS DAS CHAMADAS SÃO EM JSON): 

Get Lista de Filmes: https://locadoradefilmesapi.azure-api.net/v1/api/Filmes

========================================================================================

Post Cadastrar novo Filme: https://locadoradefilmesapi.azure-api.net/v1/api/Filmes Inserir o seguinte body na chamada:

{
  "nome": "string",
  "dataCriacao": "2021-05-30T22:28:53.088Z",
  "ativo": 0,
  "genero": "string"
}

========================================================================================

Delete registros: https://locadoradefilmesapi.azure-api.net/v1/api/Filmes/ Inserir o parâmetro ID (1 ou mais separados por virgula) no header da chamada

========================================================================================

Update Registro: https://locadoradefilmesapi.azure-api.net/v1/api/Filmes/ Inserir após a barra o ID do Filme e a seguinte estrutura de Body:

{
  "id": 0,
  "nome": "string",
  "dataCriacao": "2021-05-30T22:28:53.088Z",
  "ativo": 0,
  "genero": "string"
}

========================================================================================
