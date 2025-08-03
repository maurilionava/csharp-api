**FUNDAMENTOOS DA WEB API**

**Roteamento, padrões e restrições**
- ControllerBase: fornece recursos para tratamento de requisições HTTP
- ApiController: atributo de regras de inferência para fonte de dados
- Route: atributo responsável pelo roteamento e templates de rota
  - mapear requisições, despachar aos endpoints, extrair valores, gerar urls para os endpoints

**Tipos de retorno**
- Tipo específico: complexo ou primitivo
- IActionResult: apropriado para quando é possível o retorno de diferentes tipos ActionResult
- ActionResult<T>: retorno de tipo específico(complexo ou primitivo) ou um derivado de IActionResult

**Métodos actions assíncronos**
- async, await, Task: implementação do método com assinatura async e retorno do tipo Task, e invocação do método com await
- A requisição especifica não ficará rápida em hipótese alguma, a vantagem é atender mais requisições e há perda de desempenho
- Utilizar quando há tarefas demoradas, aceso a banco de dados, longos processamentos

**Model binding**
- A vinculação de dados é um recurso para mapeamento automático dos dados recebidos a partir de uma requisição HTTP para um método Action de um controlador
  - Mapeamento dos dados recebidos a partir de: formulários, rotas e query strings
- Fonte de dados: FromForm, FromRoute, FromQuery, FromHeader, FromBody, FromServices
- Atributo: *FromServices*
    - injeção de dependência através da invocação do método
    
**Injeção de dependência**
- Implementação do princípio IoC ou inversão de controle onde a instância de um objeto é recebido através do construtor, delegando a responsabilidade do ciclo de vida de objeto para a aplicação, por exemplo para o container de inativos

**Data Annotations**
- Classes de atributos utilizados para validação de dados diretamente no modelo de domínio
- *Validação* realizada através do ModelState sendo automático em projetos Web API, é possível realizar a validação manual através do método TryValidateModel(model)
  - Pode ser personalizada através de artibutos customizados ou implementação da interface *IValidatableObject* no modelo

**Configuração**

**Middleware**

**Filtros**

**Logging** 

**Fluent API**

**DTO data transfer objects**

**Tratamento de erros**