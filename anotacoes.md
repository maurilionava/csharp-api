**ASP.NET CORE WEB API**
- Pode-se criar web apis com ou sem controllers(minimal apis)
- Não se usa mais a classe *Startup.cs* a configuração dos serviços e request de pipeline é feita na classe *Program.cs*
- Classe *Program.cs* possui os seguintes recursos: *top level statements(não possui método main)* e *global usings(using implícitos)*
- **Arquivo de projeto:** informações sobre tipo do projeto, linguagem, dependências como bibliotecas e pacotes, etc.
- **launchSettings.json:** configurações referentes a execução do programa diferenciados de acordo com *profile*
- **appsettings.json:** configurações referentes a aplicação que permitem a alteração de informações do programa sem a necessidade de recompilação. connection strings, chaves de api, etc.
- **Controllers:** classes especiais que recebem e tratam as requisições dos usuários da aplicação
- **Endpoint:** URL do serviço que será acessado pelo cliente

**API (APPLICATION PROGRAMMING INTERFACE)** forma de permitir que diferentes serviços troquem mensagens sem que seja necessário o conhecimento da implementação de cada um. Uma interface de comunicação padronizada, documentada e protegida que não expõe detalhes da implementação do serviço
- Permite a integração entre sistemas, troca de informações, segurança, controle de acesso, tendem a ser fáceis de implementar
  
**WEB SERVICES** todo web service é uma API com tecnologia de comunicação via rede apoiado no XML e protocolo SOAP

**WEB API** evolução dos web services, conjunto de serviços expostas na WEB para integração de aplicações e clientes. *SOAP* ou *REST* através do protocolo HTTP

**PRTOCOLO SOAP (SIMPLE OBJECT ACCESS PROTOCOL)** baseado em *XML* e utilizado para troca de informações entre diferentes aplicações

**REST (REPRESENTATIONAL STATE TRANSFER PROTOCOL)** *estilo arquitetural* com restrições, princípios arquiteturais e seu acesso é baseado no protocolo HTTP (HYPERTEXT TRANSFER PROTOCOL)
- Deve possuir arquitetura cliente/servidor, recurso, representação, interação sem estado, mensagens padrão HTTP

**ASP.NET CORE** framework da *Microsoft* para criação de Web APIs aderentes ao estilo REST na plataforma *.NET Core (ambiente multiplataforma)*

**HTTPS - TLS(TRANSPORT LAYER SECURITY)** extensão segura do protocolo HTTP

**JSON (JAVASCRIPT OBJECT NOTATION** formato para transporte de dados entre aplicações

**NIVEIS DE MATURIDADE DE RICHARDSON** representa o nível de aplicação do padrão REST em determinada aplicação

**INJEÇÃO DE DEPENDÊNCIA(DI)** padrão utilizado para implementar a *inversão de controle (IoC)* e assim garantir um código menos acoplado. Evita inicializar objetos das quais determinada classe depende e passa a recebê-las como argumentos
  - Princípio:*IoC*, *DIP* 
  - Padrão: *DI* 
  - Framework: *IoC Container* 

**LIFETIME SERVICE** o tempo de vida dos serviços injetados via IoC Container pode afetar o desempenho do programa
- Transient: criada uma nova instância a cada nova solicitação. indicado para serviços leves e sem estado
- Scoped: criada apenas uma instância por requisição. indicado para serviços web
- Singleton: criada apenas uma instância para toda a aplicação

**HTTP (HYPERTEXT TRANSFER PROTOCOL)** verbos CRUD: GET(read), POST(create), PUT(update), DELETE e outros
```
POST /api/endpoint/ HTTP/1.1
Host: Microsoft.com
Cache-Control: no-cache
Accept-Language: pt, br

{
    Campo1: "valor",
    Campo2: "outro valor
}
```

```
HTTP/1.1 200 OK
Date: ***
Server: gws
Accept-Range: bytes
Content-length: 3456
***
<!doctype html><html>
***
```

cliente > socket > aplicação