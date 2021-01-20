# Dominando os Testes de Software

## Plataforma

[desenvolvedor.io](https://desenvolvedor.io/)

## Link para o curso

[Fundamentos de Arquitetura de Software](https://desenvolvedor.io/curso-online-dominando-os-testes-de-software)

## Instrutor

### Eduardo Pires

Eduardo Pires é fundador da plataforma desenvolvedor.io, arquiteto e desenvolvedor de software, palestrante e instrutor de treinamentos.

Foi reconhecido como Most Valuable Professional (MVP) pela Microsoft na competência de desenvolvimento de software de 2014 até 2020.

Este reconhecimento é um prêmio internacional conferido pela Microsoft aos profissionais de maior destaque no mercado, existem cerca de 3.500 MVPs no mundo e 110 MVPs no Brasil, sendo 40 deles na competência de desenvolvimento de software.

## Progresso do Curso

- [x] Apresentação (1:00)

### A importância de testar

- [x] Por que testar? (16:00)
- [x] Como testar? (14:00)
- [x] Regra 10 de Myers (9:00)
- [x] Mitos sobre os testes de software (16:00)
- [x] Tipos de testes mais comuns (20:00)
- [x] Teste os seus conhecimentos (2:00)
- [x] Teste os seus conhecimentos (3:00)

### Testes de Unidade

- [x] Objetivos (3:00)
- [x] Frameworks de testes (12:00)
- [ ] Padrões e Nomenclaturas (17:00)
- [ ] A importância do Mock (7:00)
- [ ] O básico sobre testes de unidade (26:00)
- [ ] Asserções (Assert) (19:00)
- [ ] Utilizando Traits (14:00)
- [ ] Utilizando Fixtures (14:00)
- [ ] Ordenação de testes (14:00)
- [ ] Gerando dados humanos (20:00)
- [ ] Realizando mock de objetos (20:00)
- [ ] Simulando retorno de métodos com Mock (19:00)
- [ ] Utilizando AutoMock (20:00)
- [ ] Utilizando Fluent Assertions (20:00)
- [ ] Escapando de testes (4:00)
- [ ] Mensagens de saída nos testes (3:00)
- [ ] Playlists de testes (6:00)
- [ ] Rodando os testes via linha de comando (7:00)
- [ ] Trabalhando com testes no Visual Studio Code (11:00)
- [ ] Analisando a cobertura de código dos testes (19:00)

### TDD - Test Driven Development

- [ ] Introdução (6:00)
- [ ] Por que utilizar TDD? (14:00)
- [ ] Comece com Baby Steps (22:00)
- [ ] Setup do projeto (13:00)
- [ ] Pedido - Adicionar Item - Parte 1 (16:00)
- [ ] Pedido - Adicionar Item - Parte 2 (17:00)
- [ ] Pedido - Adicionar Item - Parte 3 (23:00)
- [ ] Pedido - Adicionar Item - Parte 4 (12:00)
- [ ] Pedido - Atualizar Item (18:00)
- [ ] Pedido - Remover Item (8:00)
- [ ] Pedido - Aplicar Voucher - Parte 1 (19:00)
- [ ] Pedido - Aplicar Voucher - Parte 2 (21:00)
- [ ] Pedido - Aplicar Voucher - Parte 3 (16:00)
- [ ] Pedido - Adicionar Item Command (20:00)
- [ ] Pedido - Command Handler - Parte 1 (25:00)
- [ ] Pedido - Command Handler - Parte 2 (23:00)
- [ ] Pedido - Command Handler - Parte 3 (30:00)
- [ ] Refatorando Testes (10:00)
- [ ] Code Coverage - Considerações Finais (10:00)
- [ ] Teste os seus conhecimentos (5:00)
- [ ] Teste os seus conhecimentos (5:00)

### Testes de Integração

- [ ] Apresentação - Cenário de testes (10:00)
- [ ] Propósito dos testes de integração (6:00)
- [ ] Configurações necessárias (22:00)
- [ ] Registro do usuário - pt1 (23:00)
- [ ] Registro do usuário - pt2 (18:00)
- [ ] Registro do usuário - pt3 (20:00)
- [ ] Pedidos - Web - pt1 (25:00)
- [ ] Pedidos - Web - pt2 (15:00)
- [ ] Pedidos - API - pt1 (24:00)
- [ ] Pedidos - API - pt2 (21:00)

### BDD

- [ ] Sobre o que é? (10:00)
- [ ] User Stories (14:00)
- [ ] Ferramentas e configuração (9:00)
- [ ] Escrevendo user stories com SpecFlow (19:00)
- [ ] Gerando os testes de comportamento (28:00)

### Testes Automatizados

- [ ] Apresentação (14:00)
- [ ] Apresentando o Selenium (15:00)
- [ ] Configurando o Selenium da forma certa (17:00)
- [ ] Customizando o uso do Selenium (14:00)
- [ ] Automatizando a criação do WebDriver do Selenium (9:00)
- [ ] POM - Page Object Model (22:00)
- [ ] Automatizando a interface de cadastro de usuário (21:00)
- [ ] Automatizando a interface de cadastro e login (24:00)
- [ ] Automatizando a interface de carrinho de compras (38:00)
- [ ] Execução headless via comando e considerações finais (13:00)

### Testes de Carga

- [ ] Tipos de testes de carga (12:00)
- [ ] Ferramentas disponíveis no mercado (10:00)
- [ ] Índice de satisfação do usuário com APDEX (13:00)
- [ ] Introdução ao JMeter (32:00)
- [ ] Plano de testes completo com JMeter e BlazeMeter (35:00)
- [ ] Teste os seus conhecimentos (3:00)

### Encerramento

- [ ] Palavras Finais (8:00)

---
---
---

## **Anotações:**

---

## *A importância de testar*

---

### Por que testar?

Para garantir qualidade.

---

### Como testar?

Testes de Caixa-Preta e Caixa-Branca

#### **Caixa-Preta**

- Testers execute functional and regression tests via user interface
  - E.g. functional tests, regression tests, UI tests

#### **Caixa-Branca**

- Testers (or developers) look directly at code to find bugs and erros
  - E.g. unit tests, load tests

#### **Baixo Nível / Alto Nível**

![Baixo Nível / Alto Nível](images/a-importancia-de-testar/como-testar-baixo-nivel-alto-nivel.png)

#### **Quadrante Mágico do Teste Agil**

![quadrante-magico-do-teste-agil](images/a-importancia-de-testar/como-testar-quadrante-magico-do-teste-agil.png)

#### **Consequências de não testar**

- Muitos bugs e problemas de qualidade
- Falhas de codificação
- Possíveis atrasos na entrega
- Perda de confiança do cliente
- Desmotivação do time
- Aumento na rotatividade de pessoas
- Prejuízos financeiros
- Possíveis implicações legais

---

### Regra 10 de Myers

"O Custo da correção de defeitos é mais custoso quanto mais tarde o defeito é encontrado."

---

### Mitos sobre os testes de software

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

### Tipos de testes mais comuns

#### **Testes de Unidade**

Um teste de unidade é aquele que testa uma única unidade do sistema. Realiza o teste de maneira isolada, geralmente simulando as prováveis dependências que aquela unidade tem.

Em linguagens orientadas a objetos, é comum que a unidade seja uma classe.  
Quando precisamos escrever testes de unidade para a classe ex Pedido, essa bateria de testes testará o funionamento da classe Pedido, isolada, sem interações com outras classes.

#### **Testes de Integração**

Um teste de integração é aquele que testa a integração entre duas ou mais partes da sua aplicação.

Testes que você escreve para a sua classe PedidoService e PedidoRepository, por exemplo, onde seu teste vai até o banco de dados, é um teste de integração.

De fato você está testando a integração da sua aplicaçãop com suas diversas partes, por exemplo o banco de dados, uma camada de serviços externo.

Estes testes garantem algo que os testes de unidade não garantem, eles garantem que as unidades da sua aplicação estão se integrando conforme o esperado.

#### **Testes Automatizados**

O teste automatizado é um teste de sistema, podemos considerar como um teste de aceitação, funciona como um teste de caixa preta, já que os sistema é testado de ponta a ponta através das oprações executadas no sistema.

A automatização garante que todo o processo será executado da mesma maneira que fosse um usuário utilizando a aplicação.

Pode ser considerado um teste de aceitação, pois neste teste além de garantir o funcionamento ponta a ponta, podemos validar características do negócio e funcionalidades.

#### **Testes de carga**

O teste de carga (load test) consiste em testar as capacidades da aplicação, muitas vezes até seu limite, de forma que a aplicação não consiga mais responder. Pode ser também considerado como um teste de stress.

Existem alguns objetivos por trás do teste de carga:

- Testar a performance do código e componente em situações extremas. Descobrir possíveis gargalos.
- Testar como a aplicação irá se comportar com um determinado número de usuários simultâneos e garantir que irá atender a demanada.
- Testar um possível balanceamento de carga no servidor ou até mesmo a escala elástica na nuvem.

O teste de carga é muito importante em aplicações Web e em aplicações que é esperado um grande volume de requisições

---

## *Testes de Unidade*

---

### Objetivos

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

### Frameworks de Testes

#### **MSTest**

É da própria Microsoft  

#### Links

[docs.microsoft.com](https://docs.microsoft.com/en-us/dotnet/api/microsoft.visualstudio.testtools.unittesting?view=mstest-net-1.3.2)  
[GitHub](https://github.com/microsoft/testfx)

#### **NUnit**

Framework muito consagrado.  
É uma portabilidade do JUnit (Java)  

##### Links

[NUnit.org](https://nunit.org/)  
[GitHub](https://github.com/nunit)

#### **XUnit**

- Escrito pelos criadores do NUnit
- Compatível com Visual Studio
- Utilizado pelo time de desenvolvimento do .NET Core e ASP.NET
  - [Exemplo de uso pela própria Microsoft](https://github.com/dotnet/aspnetcore/blob/7a26d27e8b7f67a1ac80532e5872bfde6c28f952/src/Mvc/Mvc.Core/test/Filters/FilterProviderTest.cs)

##### Instalação do framework

```powershell
Install-Package xunit
```

##### Instalação para reconhecimento do Visual Studio

```powershell
Install-Package xunit.runner.visualstudio
```

##### Links

[xUnit.net](https://xunit.net/)  
[GitHub](https://github.com/xunit/xunit)  

##### *Obs.:*

*vamos utilizar o **XUnit***

---
---
---
