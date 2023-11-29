# CarCRUD-Mongo
Api de um CRUD simples de um sistema de carros em .NET 7 com conexão ao banco de dados mongodb 

## Database
Para utilizar a api baixe o [mongodb](https://www.mongodb.com/try/download/community) em seu local de trabalho,
após baixado mude a connection string no appsettings.json do projeto caso necessidade, após você deve criar uma database
no mongodb chamado `cardb` e dentro desta database criar as seguintes collections;
- carro
- marca
- modelo

depois de seguir estes passo basta apenas rodar o projeto
