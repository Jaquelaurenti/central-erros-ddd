# Aplicação com Arquitetura DDD

### Rodar
dotnet run --project CentralErrosDDD

### Configurar o banco de Dados
Dentro do CentralErrosDDD.Api > appsettings.json configurar a tag abaixo com seu banco de dados. <p>
 "SqlConnection": { <p>
    "SqlConnectionString": "Server=localhost\\SQLEXPRESS;Database=CentralErrosDDD;Trusted_Connection=True;" <p>
  }, <p>
   
### Rodar as migrations

Após configurar o banco de dados, executar o comando update-database dentro do Package Manager Console <p>
Projeto: CentralErrosDDD.Infrastructure <p>

### Swagger
https://localhost:{suaporta}/swagger
