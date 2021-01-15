# ECommerce.Taxas
Projeto em ASP.NET Core.

##Conceitos, Frameworks e tecnologias utilizadas:
> Documentação das Apis com Swagger
> Injeção de Dependência
> Log usando Serilog 
> Testes de Unidade e de Integração (Projeto Ecommerce => https://github.com/navarro-hubess/ECommerce)
> Para o Cálculo do valorFinal de Juros foi usada a biblioteca https://www.nuget.org/packages/DecimalMath.DecimalEx/ para que fosse possível manter a precisão em decimal, já que a biblioteca original Microsoft Math.Pow somente aceita double.
> Resiliência com Polly
>> Foi adicionada uma política de Retry no projeto (ECommerce - https://github.com/navarro-hubess/ECommerce)

## Get Started
>Para executar localmente:
>>Descompactar e abrir o projeto no Visual Studio (recomenda-se 2019).
>>Executar o projeto (F5) e o mesmo abrirá na documentação da API com Swagger.
>>Dentro do Swagger seguir o fluxo para teste da Api


