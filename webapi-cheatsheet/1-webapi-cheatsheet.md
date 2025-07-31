1. criar projeto web api
   ```dotnet new webapi --use-controllers -o DemoApi```  
2. instalar e configurar o swagger
   1. instalar pacote
      ```dotnet add package NSwag.AspNetCore```
   2. alterar classe *Program.cs*
      ```
         app.UseSwaggerUi(options =>
            {
               options.DocumentPath = "/openapi/v1.json";
            });
      ```
3. instalar os pacotes do *Entity Framework* e do provedor de banco de dados
      ```
         dotnet add package Pomelo.EntityFrameworkCore.MySql
         dotnet add package Microsoft.EntityFrameworkCore.Design

         dotnet tool install --global dotnet-ef #EF Core Tools
         dotnet tool update --global dotnet-ef
         dotnet-ef
      ``` 
4. criar modelos de domínio anêmicos (sem comportamento) e definir relacionamentos quando aplicável
   - caso haja referência cíclica entre modelos, corrigir com o código abaixo. incluso o código para ignorar valores padrões:
      ```
      builder.Services.AddControllers().AddJsonOptions(
         options => {
            options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
            options.JsonSerializerOptions.DefaultIgnoreCondition = JsonIgnoreCondition.<condicao>
         }
      );
      ```
5. criar classe de contexto com referência a *DbContext* e definir referência objeto-relacional com *DbSet*
   - uma instância da classe de contexto representa uma sessão com o banco de dados
   - é responsável pelo mapeamento entre classes e tabelas
6. definir string de conexão e registrar o contexto como um serviço no container de inativos
   *jsonsettings.json*
   ```
      "ConnectionStrings":{
         "DefaultConnection":"Server=localhost;Database=devdb;Uid=root;Pwd:1234"
      },
   ```
   *Program.cs*
   ```
      string sqlConnectionString = builder.Configuration.GetConnectionString("DefaultConnection");

      builder.Services.AddDbContext<AppDbContext>(options =>
         options.UseMySql(sqlConnectionString, ServerVersion.AutoDetect(sqlConnectionString)));
   ```
7.  criar, ajustar (*data annotations*) e atualizar a base de dados a partir da *migration*
   - para criação ou atualização do banco de dados e armazenamento do estado atual das entidades
   ```
      dotnet ef migrations add MigracaoInicial #criação do arquivo de script para alteração do bd
      dotnet ef migrations remove MigracaoInicial #desfazer a migração determinada
      dotnet ef database update #aplicação do script gerado
   ```
   *package manager console*
   ```
      add-migration MigracaoInicial #criação do arquivo de script para alteração do bd
      remove-migration 'MigracaoInicial #desfazer a migração determinada
      update-database #aplicação do script gerado
   ```
8. popular tabelas de dados
9. criar controllers definindo os *endpoints* ou métodos *Action* para crealizar as operações de CRUD
   **OTIMIZAÇÃO DE DESEMPENHO EM CONSULTAS**
   - não rastrear o resultado da consulta: ```.AsNoTracking().ToList();```
   - não retornar todos os registros de uma vez: ```.Take(10).ToList();```
   - sempre aplicar filtro: ```_context.Classe.Where().ToList();```
10. tratar erros com bloco try-catch-finally


*https://www.connectionstrings.com*