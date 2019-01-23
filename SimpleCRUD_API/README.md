# Simple CRUD API

 - API simples que realiza CRUD de Funcionários, conforme solicitado pelo teste.
 - Para subir a API basta abrir o projeto (SimpleCRUD_API.sln) no Microsoft Visual Studio e compilar.
 - E enviar requisicoes para as URLs da API: http://localhost:53156/

# Rotas

(GET) funcionarios/list - Retorna todos os registro inseridos
(GET) funcionarios/show/id – Retorna o registro referente ao id especificado
(POST) funcionarios/create - Criar um novo registro de funcionário a partir do post
 - Parametros da url:
 - nome
 - sobrenome
 - idade
 - funcao

(POST) funcionarios/destroy/id – Excluí o registro referente ao id especificado no post

(POST) funcionarios/update – Atualiza o registro conforme os dados do post referente ao id especificado.
 - Parametros opcionais da url:
 - nome
 - sobrenome
 - idade
 - funcao
