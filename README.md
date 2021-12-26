# GoalVegan
GoalVegan é uma de marketplace focado em pessoas veganas, estou usando para fixação de conhecimentos


## Tecnologias

* .NET Core
* Entity Framework Core (SQL Server)
* Arquitetura Limpa com 
* Camadas de Responsabilidades com camadas Core, Application, Infrasctructure e API.
* Padrão de Projeto Repository para acesso da dados
* Padrão CQRS para para separar as responsabilidades de leitura e escrita de dados
* FluentValidations para validações dos commands
* Testes Unitários com XUnit e Moq

##Features
* CRUD de Buyers(Compradores) e Vendedores(Sellers), usuários do sistema, são usuários diferentes na API, cada um possui seu login especifíco
* CRUD de Produtos, que só pode ser feito pelo Seller
* Criação e leitura de pedidos, somente o Buyer consegue criar o pedido e fazer algumas atualizações, vendedores conseguem atualizar para Enviado, Faturado, e código de rastreio

## Camadas de responsabilidades

* Core: Contém os serviços de domínio, classes, repositórios, interfaces. As classes usam private set para reforçar as imutabilidades.
* Infrastructure: Contém as implementações do repositório e a classe DbContext.
* Application: Contém as implementações dos Commands, Queries e Validators, além dos, View Models e Input Models.
* API: Contém os Controllers, Injeção de Dependência, Swagger, SQL-Server DbContext
