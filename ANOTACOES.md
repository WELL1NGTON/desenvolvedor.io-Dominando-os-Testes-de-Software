# **Anotações:**

---

## *A importância de testar*

---

## Por que testar?

Para garantir qualidade.

---

## Como testar?

Testes de Caixa-Preta e Caixa-Branca

### **Caixa-Preta**

- Testers execute functional and regression tests via user interface
  - E.g. functional tests, regression tests, UI tests

### **Caixa-Branca**

- Testers (or developers) look directly at code to find bugs and erros
  - E.g. unit tests, load tests

### **Baixo Nível / Alto Nível**

![Baixo Nível / Alto Nível](images/a-importancia-de-testar/como-testar-baixo-nivel-alto-nivel.png)

### **Quadrante Mágico do Teste Agil**

![quadrante-magico-do-teste-agil](images/a-importancia-de-testar/como-testar-quadrante-magico-do-teste-agil.png)

### **Consequências de não testar**

- Muitos bugs e problemas de qualidade
- Falhas de codificação
- Possíveis atrasos na entrega
- Perda de confiança do cliente
- Desmotivação do time
- Aumento na rotatividade de pessoas
- Prejuízos financeiros
- Possíveis implicações legais

---

## Regra 10 de Myers

"O Custo da correção de defeitos é mais custoso quanto mais tarde o defeito é encontrado."

---

## Mitos sobre os testes de software

"Eu não tenho tempo de testar!"  
"Testar é escrever o dobro de código!"  
"Se fizer o código certinho não precisa testar"  
"Testar é papel do testador"  
"Que adianta eu testar se o resto da equipe não testa?"  
"Os testes garantem 100% de software livre de erros"  
"Se passou no teste é porque não tem bug"  
"Eu já terminei. Só falta testar"  
"Testes de unidade só funcionam se for com TDD"  
"Testar manualmente é mais produtivo"  
"Não consigo convencer meu gerente!"

---

## Tipos de testes mais comuns

### **Testes de Unidade**

Um teste de unidade é aquele que testa uma única unidade do sistema. Realiza o teste de maneira isolada, geralmente simulando as prováveis dependências que aquela unidade tem.

Em linguagens orientadas a objetos, é comum que a unidade seja uma classe.  
Quando precisamos escrever testes de unidade para a classe ex Pedido, essa bateria de testes testará o funionamento da classe Pedido, isolada, sem interações com outras classes.

### **Testes de Integração**

Um teste de integração é aquele que testa a integração entre duas ou mais partes da sua aplicação.

Testes que você escreve para a sua classe PedidoService e PedidoRepository, por exemplo, onde seu teste vai até o banco de dados, é um teste de integração.

De fato você está testando a integração da sua aplicaçãop com suas diversas partes, por exemplo o banco de dados, uma camada de serviços externo.

Estes testes garantem algo que os testes de unidade não garantem, eles garantem que as unidades da sua aplicação estão se integrando conforme o esperado.

### **Testes Automatizados**

O teste automatizado é um teste de sistema, podemos considerar como um teste de aceitação, funciona como um teste de caixa preta, já que os sistema é testado de ponta a ponta através das oprações executadas no sistema.

A automatização garante que todo o processo será executado da mesma maneira que fosse um usuário utilizando a aplicação.

Pode ser considerado um teste de aceitação, pois neste teste além de garantir o funcionamento ponta a ponta, podemos validar características do negócio e funcionalidades.

### **Testes de carga**

O teste de carga (load test) consiste em testar as capacidades da aplicação, muitas vezes até seu limite, de forma que a aplicação não consiga mais responder. Pode ser também considerado como um teste de stress.

Existem alguns objetivos por trás do teste de carga:

- Testar a performance do código e componente em situações extremas. Descobrir possíveis gargalos.
- Testar como a aplicação irá se comportar com um determinado número de usuários simultâneos e garantir que irá atender a demanada.
- Testar um possível balanceamento de carga no servidor ou até mesmo a escala elástica na nuvem.

O teste de carga é muito importante em aplicações Web e em aplicações que é esperado um grande volume de requisições

---

## *Testes de Unidade*

---

## Objetivos

- Frameworks
- Nomenclaturas
- Ferramentas
- Escritas de testes
- Features do framework de teste
- Execução no VS, VSCode, Command Line
- Mock
- AutoMock
- Fixture
- Geração de dados
- Fluent Assertions

---

## Frameworks de Testes

### **MSTest**

É da própria Microsoft  

### Links

[docs.microsoft.com](https://docs.microsoft.com/en-us/dotnet/api/microsoft.visualstudio.testtools.unittesting?view=mstest-net-1.3.2)  
[GitHub](https://github.com/microsoft/testfx)

### **NUnit**

Framework muito consagrado.  
É uma portabilidade do JUnit (Java)  

#### Links

[NUnit.org](https://nunit.org/)  
[GitHub](https://github.com/nunit)

### **XUnit**

- Escrito pelos criadores do NUnit
- Compatível com Visual Studio
- Utilizado pelo time de desenvolvimento do .NET Core e ASP.NET
  - [Exemplo de uso pela própria Microsoft](https://github.com/dotnet/aspnetcore/blob/7a26d27e8b7f67a1ac80532e5872bfde6c28f952/src/Mvc/Mvc.Core/test/Filters/FilterProviderTest.cs)

#### Instalação do framework

```powershell
PM> Install-Package xunit
```

#### Instalação para reconhecimento do Visual Studio

```powershell
PM> Install-Package xunit.runner.visualstudio
```

#### Links

[xUnit.net](https://xunit.net/)  
[GitHub](https://github.com/xunit/xunit)  

#### *Obs.:*

*vamos utilizar o **XUnit***

---

## Padrões e Nomenclaturas

### **AAA - Arrange, Act, Assert**

Organizar os testes:

```csharp
[Fact]
public async Task MiddlewareFilter_SetsMiddlewareFilterFeature_OnExecution()
{
    // Arrange
    Task requestDelegate(HttpContext context) => Task.FromResult(true);
    var middlewareFilter = new MiddlewareFilter(requestDelegate);
    var httpContext = new DefaultHttpContext();
    var resourceExecutingContext = GetResourceExecutingContext(httpContext);
    var resourceExecutionDelegate = GetResourceExecutionDelegate(httpContext);

    // Act
    await middlewareFilter.OnResourceExecutionAsync(resourceExecutingContext, resourceExecutionDelegate);

    // Assert
    var feature = resourceExecutingContext.HttpContext.Features.Get<IMiddlewareFilterFeature>();
    Assert.NotNull(feature);
    Assert.Same(resourceExecutingContext, feature.ResourceExecutingContext);
    Assert.Same(resourceExecutionDelegate, feature.ResourceExecutionDelegate);
}
```

### **Nomenclatura de Testes de Unidade**

#### *Exemplos de nomenclaturas*

```ObjetoEmTeste_MetodoComportamentoEmTeste_ComportamentoEsperado```:

- ```Pedido_AdicionarPedidoItem_DeveIncrementarUnidadesSeItemJaExiste```
- ```Estoque_RetirarItem_DeveEnviarEmailSeAbaixoDe10Unidades```

```MetodoEmTeste_EstadoEmTeste_ComportamentoEsperado```:

- ```AdicionarPedidoItem_ItemExisteCarrinho_DeveIncrementarUnidadeDoItem```
- ```RetirarItemEstoque_EstoqueAbaixoDe10Unidades_DeveEnviarEmailDeAviso```

Obs.: Pode "usar vários padrões"/"misturar padrões" que melhor se adquem a cada teste, desde que não use muitos padrões diferentes ou fuja dos padrões.

#### Exemplos Vida Real

- [AspNetCore - FilterProviderTest.cs](https://github.com/dotnet/aspnetcore/blob/7a26d27e8b7f67a1ac80532e5872bfde6c28f952/src/Mvc/Mvc.Core/test/Filters/FilterProviderTest.cs) <!-- ObjetoEmTeste_MetodoComportamentoEmTeste_ComportamentoEsperado -->
- [AspNetCore - ResponseCacheFilterExecutorTest.cs](https://github.com/dotnet/aspnetcore/blob/7a26d27e8b7f67a1ac80532e5872bfde6c28f952/src/Mvc/Mvc.Core/test/Filters/ResponseCacheFilterExecutorTest.cs) <!-- Estado Comportamento Invertido. (Mesmo padrão mas invertido) -->
- [AspNetCore - RequestSizeLimitFilterTest.cs](https://github.com/dotnet/aspnetcore/blob/7a26d27e8b7f67a1ac80532e5872bfde6c28f952/src/Mvc/Mvc.Core/test/Filters/RequestSizeLimitFilterTest.cs) <!-- Não foi utilizada nenhuma das nomenclaturas, mas está claro a escrita dos testes (porém teriasido melhor fazer de forma mais expressiva)  -->

---

## A importância do Mock

### O que é um Mock?

Objetos Mock, objetos simulados ou simplemente Mock (do inglês Mock object) são objetos que simulam o comportamento de objetos de forma controlada.

São normalmente criados para testar o comportamento de outros objesto. Em outras palavras, os objetos mock são objetos "falsos" que simulam o comportamento de uma classe ou objeto "real" para que possamos focar o teste na unidade a ser testada.

Uma vantagem do Mock é que o objeto simulado pode ser criado dinamicamente através de um framework de Mock e poupando o desenvolvedor ter que criar uma classe física para simular aquele objeto.

Uma classe física que simula o objeto costuma ser chamada de Fake, mas na teoria é um Mock, a diferença é que foi criada manualmente.

### MOQ

- Realize Mock com facilidade
- Compatível com Visual Studio
- Utilizado pelo time de desenvolvimento do .NET Core e ASP.NET

Instalação do framework

```powershell
PM> Install-Package Moq
```

#### Links

[Quickstart](https://github.com/Moq/moq4/wiki/Quickstart)  
[GitHub](https://github.com/moq/moq4)  

---

### Analisando a cobertura de código dos testes

[pacote coverlet.msbuild](https://www.nuget.org/packages/coverlet.msbuild)  
[Plugin Coverage Gutters para VSCode](https://marketplace.visualstudio.com/items?itemName=ryanluker.vscode-coverage-gutters)  
[Code Coverage no C# com VSCode](https://medium.com/@lorranpalmeira/code-coverage-no-c-com-vscode-cfa3cb6c89d0)  

---

## TDD - Test Driven Development

### OBSERVAÇÃO IMPORTANTE

Usei o seguinte regex para remover os DisplayNames com o vscode ```\(DisplayName\s*=\s*"[\w|\s||á]*"\)```

---

### Por que utilizar TDD?

![Modelo de Desenvolvimento "Tradicional"](./images/tdd-test-driven-development/tdd-modelo-desenvolvimento-tradicional.png)

![O Problema](images/tdd-test-driven-development/tdd-o-problema.png)

![O Problema 2](images/tdd-test-driven-development/tdd-o-problema2.png)

![O Problema 3](images/tdd-test-driven-development/tdd-o-problema3.png)

![Utilizando Testes Durante o Desenvolvimento](images/tdd-test-driven-development/tdd-utilizando-testes-durante-o-desenvolvimento.png)

#### As Três leis do TDD

1. Você **não pode escrever nenhum código até ter escrito um teste** que detecte uma possível falha.
2. Você **não pode escrever mais testes de unidade do que o suficiente** para detectar a falha - não compilar não é ter efeito.
3. Você **não pode escrever mais código od que o suficiente** para passar nos testes.

---

### Comece com Baby Steps

É indicado para desenvolvedores que estão iniciando na prática do TDD.

É utilizado quando não se tem muita confiança sobre código a ser escrito e testado.

Não existe uma prática exata sobre a utilização baby steps, a recomendação é fazer um processo por vez, identificar as necessidades, avaliar o cenário e continuar.

![Baby Steps](images/tdd-test-driven-development/baby-steps.png)

![Produtividade x Tempo](images/tdd-test-driven-development/baby-steps-produtividade-x-tempo.png)

#### Dicas para começar com TDD

- Pratique os baby steps e respeite as 3 leis do TDD
- Saiba exatamente o que precisa entregar antes de começar
- Não deixe para descobrir a regra de negócio durante a codificação
- Tenha uma lista de anotações ou uma documentação clara sempre a mão
- Minta! No "green" o teste só precisa passar, depois utilize Mocks
- Mantenha os testes simples
- Após a escrita de alguns testes, analise a possibilidade de reaproveitamento de objetos
- Saiba quando usar TDD, nem sempre é vantajoso

#### Teste Driven Design?

- O conceito de TDD pode confundir, não é sobre escrever testes e sim sobre escrever código com um bom design. (código escrito da forma certa é fácil de testar)
- Escrever testes depois do código também ajuda, mas pode ocasionar retrabalho caso seja necessário modificar um código para possibilitar o teste.

#### Leituras Indicadas

![Leituras Indicadas](images/tdd-test-driven-development/tdd-leituras-indicadas.png)

---

## BDD

---

### Sobre o que é?

#### Sobre o que é?

- Envolver as pessoas no processo através do "Desenvolvimento de fora para dentro" (Outside-in development).
- Escrever estórias para apresentar as necessidades de um usuário e explicar as funcionalidades da aplicação
- Desenvolver a aplicação guiada por cenários de testes dos comportamentos descritos nas estórias do usuário
- Escrever testes de integração ou automação para validar os comportamentos como uma bateria de testes de regressão

### BDD - Ciclo de desenvolvimento

![Behavior Drive Development](images/bdd/behavior-driven-development.png)

---

### User Stories

#### User Stories

![User Stories](images/bdd/user-stories.png)

![User Stories Example](images/bdd/user-stories-examplo.png)

#### Cenários

![User Stories Cenários](images/bdd/user-stories-cenario.png)

![User Stories Cenário Exemplo](images/bdd/user-stories-cenario-exemplo.png)

![User Stories Cenário Exemplo 02](images/bdd/user-stories-cenario-exemplo2.png)

Existem várias aplicações/suits de apoio ao desenvolvimento como por exemplo o [Visual Studio DevOps](https://azure.microsoft.com/pt-br/services/devops/), ou até mesmo o [GitHub](https://github.com/) colocando issues, ou pode escrever essas estórias em papéis.

#### Users Stories - Visual Studio

![Visual Studio](images/bdd/user-stories-visual-studio.png)

---

### Ferramentas e configuração

#### SpecFlow

[![SpecFlow](https://www.specflow.org/wp-content/uploads/2016/07/SF_Logo.png)](https://specflow.org/)

- Versão do Cucumber para .NET
- Utiliza o Gherkin Parser para transformar o texto em ações
- Compatível com todas as versões do VS atuais

Instalação do framework

```powershell
PM> Install-Package SpecFlow
```

Instalação para reconhecimento do Visual Studio com XUnit

```powershell
PM> Install-Package SpecFlow.xUnit
```

---

## Testes Automatizados

---

### Apresentação

- Utilização do Selenium
- Page Object Model
- Testes de aceitação / regressão com SpecFlow
- Boas práticas no design dos testes

### Apresentando o Selenium

[![Selenium](https://www.selenium.dev/images/selenium_logo_large.png)](https://www.selenium.dev/)

- Realiza a autoação de ações para browsers
- Utilizado para automatização de testes e Web Crawling
- Compatível com Visual Studio

Instalação do framework

```powershell
PM> Install-Package Selenium.WebDriver
```

Driver do Google Chrome para utilização do Selenium  
<https://chromedriver.chromium.org/downloads>

[selenium.dev](https://www.selenium.dev/)  
[GitHub](https://github.com/SeleniumHQ/selenium)

---

### POM - Page Object Model

- É um padrão de projeto descrito por Martin Fowler.
- Diz como criar um repositório de objetos com elementos contidos numa página Web. Sob este modelo, para cada página, deve haver uma classe correspondente.
- Benefícios
  - Reaproveitamento de código
  - Código mais limpo
  - Facilita na manutenção
  - Maior independência dos testes como uma bateria de testes de regressão

![POM - Page Object Model](images/testes-automatizados/pom-page-object-model.png)

---

## Testes de Carga

---

### Tipos de testes de carga

Quais são os tipos de testes disponíveis e quais os objetivos deles?

#### Teste de desempenho

Sua aplicação possui 5000 usuários. Será que ela é capaz de suportar 1/3 dos usuários simultaneamente?

#### Teste de carga

Quantas transações serão suportadas se o número de usuários aumentar em 50%?

#### Teste de Stress

Como a aplicação irá se comportar se um número não previsto de requisições for disparado simultaneamente?

---

### Ferramentas disponíveis no mercado

![Ferramentas](images/testes-de-carga/ferramentas.png)

[Azure Devops Load Testing - Interrompido](https://devblogs.microsoft.com/devops/cloud-based-load-testing-service-eol/)  
[Apache JMeter](https://jmeter.apache.org/)*  
[BlazeMeter](https://www.blazemeter.com/)*  
[Gatling](https://gatling.io/)  
[Artillery.io](https://artillery.io/)  
[AutoCannon](https://github.com/mcollina/autocannon)  
[West Wind WebSurge](https://websurge.west-wind.com/)  
[Locust](https://locust.io/)  

---

### Índice de satisfação do usuário com APDEX

#### Exemplo classificação

![Exemplo](images/testes-de-carga/classificacao-do-response-time-exemplo.png)

#### Fórmula do APDEX

![Fórmula do APDEX](images/testes-de-carga/formula-apdex.png)

#### APDEX Score

![APDEX Score](images/testes-de-carga/apdex-score.png)

---
---
---

## Pacotes / Softwares utilizados nos testes

[MOQ](https://github.com/moq/moq4)  
[Moq.AutoMocker](https://github.com/moq/Moq.AutoMocker)  
[XUnit](https://xunit.net/)  
[xunit.runner.visualstudio](https://github.com/xunit/visualstudio.xunit)  
[Fluent Assertions](https://fluentassertions.com/)  
[Bogus for .NET](https://github.com/bchavez/Bogus)  

[SpecFlow](https://specflow.org/)  
[cucumber](https://github.com/cucumber/cucumber)  
[Selenium](https://github.com/SeleniumHQ/selenium)  

---
---
---
