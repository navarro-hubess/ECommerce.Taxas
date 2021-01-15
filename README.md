# ECommerce.Taxas
- Projeto com API para fornecer ao projeto (https://github.com/navarro-hubess/ECommerce) a Taxa de Juros.
 

## Conceitos, Frameworks e tecnologias utilizadas:
- em ASP.NET Core, C#, Clean Code
- Documenta��o das Apis com Swagger
1. Utiliza��o de GIT com 2 Branchs 
  - Master e Homolog
- Inje��o de Depend�ncia
- Log usando Serilog 
(Projeto Ecommerce => https://github.com/navarro-hubess/ECommerce)
- Testes de Unidade e de Integra��o 
- Resili�ncia com Polly
 Foi adicionada uma pol�tica de Retry no projeto (ECommerce - https://github.com/navarro-hubess/ECommerce)
- Para o C�lculo do valorFinal de Juros foi usada a biblioteca https://www.nuget.org/packages/DecimalMath.DecimalEx/ para que fosse poss�vel manter a precis�o em decimal, j� que a biblioteca original Microsoft Math.Pow somente aceita double.

## Get Started
> Para executar localmente:
- Descompactar e abrir o projeto no Visual Studio (recomenda-se 2019).
- Executar o projeto (F5) e o mesmo abrir� na documenta��o da API com Swagger.
- Dentro do Swagger seguir o fluxo para teste da Api


