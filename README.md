# CP4-DOTNET

## Visão Geral

Este projeto consiste em uma WebAPI desenvolvida em .NET com o objetivo de realizar a conversão da moeda Dólar Americano (USD) para Reais (BRL) utilizando o serviço da [ExchangeRate-API](https://www.exchangerate-api.com/). A API faz uma chamada ao endpoint do serviço de câmbio e retorna o valor do USD em BRL.

## Funcionalidades Principais

- **Implementação da Interface IConversionRate:** A interface IConversionRate foi implementada para lidar com a lógica de conversão de moeda, conforme especificado na [documentação oficial da API](https://www.exchangerate-api.com/docs/c-sharp-currency-api).
  
- **Implementação da Interface IExchangeController:** A interface IExchangeController foi implementada para expor o endpoint de conversão de moeda, permitindo que clientes possam solicitar a taxa de conversão de USD para BRL.

- **Chamada ao Endpoint Exchangerate-API:** A API faz a chamada ao endpoint `https://v6.exchangerate-api.com` seguindo as melhores práticas de desenvolvimento. A chamada é validada com base no retorno do método `IsSuccessStatusCode` para garantir que a solicitação foi bem-sucedida.

- **Documentação Pública:** O projeto possui uma documentação pública detalhada disponível em uma Wiki no Azure DevOps, abordando os principais aspectos da solução, como arquitetura, detalhes de implementação, e exemplos de uso.

- **Swagger:** A WebAPI inclui um Swagger bem formatado e detalhado, que descreve os endpoints disponíveis e como interagir com eles.

## Estrutura do Projeto

- **Controllers/ExchangeController.cs:** Controlador responsável pelo endpoint `/api/exchange`. Faz a chamada ao serviço de câmbio e retorna a conversão de USD para BRL.
  
- **Services/ConversionRateService.cs:** Serviço que implementa a interface IConversionRate, responsável pela lógica de comunicação com a API de câmbio.

- **Interfaces/IConversionRate.cs:** Interface que define o contrato para o serviço de conversão de moeda.

- **Interfaces/IExchangeController.cs:** Interface que define o contrato para o controlador responsável pela conversão.

- **Startup.cs:** Configuração da WebAPI, incluindo injeção de dependências e configuração do Swagger.

## Endpoints Disponíveis

### GET /api/exchange
Retorna o valor da taxa de câmbio de USD para BRL.

**Exemplo de Requisição:**
```
GET http://localhost:5232/api/exchange
```

**Exemplo de Resposta:**
```json
{
  "base_currency": "USD",
  "target_currency": "BRL",
  "exchange_rate": 5.25
}
```

### Swagger
O Swagger pode ser acessado em:
```
http://localhost:5232/swagger
```

Este documento oferece uma interface visual para explorar os endpoints e testar a API diretamente do navegador.

## Guia de Execução

### Pré-requisitos

- [.NET SDK](https://dotnet.microsoft.com/download)

### Execução da API

1. Clone o repositório do projeto.
2. No terminal, navegue até o diretório do projeto e execute o comando:
   ```
   dotnet run
   ```
3. Acesse o endpoint principal da API em:
   ```
   http://localhost:5232/api/exchange
   ```
4. Para visualizar a documentação interativa (Swagger), acesse:
   ```
   http://localhost:5232/swagger
   ```

## Considerações Finais

Este projeto foi desenvolvido seguindo as melhores práticas de desenvolvimento em .NET, garantindo uma solução escalável e de fácil manutenção. A documentação pública e o Swagger fornecem uma interface amigável para desenvolvedores e usuários finais explorarem e integrarem-se com a API.
