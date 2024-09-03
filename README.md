
# CP4-DOTNET

## Visão Geral

Este projeto consiste em uma WebAPI desenvolvida em .NET com o objetivo de realizar a conversão da moeda Dólar Americano (USD) para Reais (BRL) utilizando o serviço da [ExchangeRate-API](https://www.exchangerate-api.com/). A API faz uma chamada ao endpoint do serviço de câmbio e retorna o valor do USD em BRL.

## Funcionalidades Principais

- **Implementação da Interface IConversionRate:** A interface `IConversionRate` foi implementada para lidar com a lógica de conversão de moeda. Ela possui a propriedade `BRL`, que é utilizada para armazenar a taxa de câmbio do BRL.

- **Implementação da Interface IExchangeController:** A interface `IExchangeController` foi implementada para expor o endpoint de conversão de moeda, permitindo que clientes possam solicitar a taxa de conversão de USD para BRL.

- **Chamada ao Endpoint Exchangerate-API:** A API faz a chamada ao endpoint `https://v6.exchangerate-api.com` seguindo as melhores práticas de desenvolvimento. A chamada é validada com base no retorno do método `IsSuccessStatusCode` para garantir que a solicitação foi bem-sucedida.

- **Swagger:** A WebAPI inclui um Swagger bem formatado e detalhado, que descreve os endpoints disponíveis e fornece uma interface visual para explorar e testar a API diretamente do navegador.

## Estrutura do Projeto

- **Controllers/ExchangeController.cs:** Controlador responsável pelo endpoint `/api/exchange`. Faz a chamada ao serviço de câmbio e retorna a conversão de USD para BRL.

- **Interfaces/IConversionRate.cs:** Interface que define o contrato para o serviço de conversão de moeda.

- **Interfaces/IExchangeController.cs:** Interface que define o contrato para o controlador responsável pela conversão.

- **Program.cs:** Configuração da WebAPI, incluindo injeção de dependências e configuração do Swagger.

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
  "CurrencyPair": "USD/BRL",
  "Rate": 5.25,
  "Date": "2024-09-03T00:00:00Z"
}
```

### Swagger
O Swagger pode ser acessado em:
```
http://localhost:5232/swagger
```

O Swagger fornece uma interface visual para explorar e testar a API diretamente do navegador.

## Guia de Execução

### Pré-requisitos

- [.NET SDK](https://dotnet.microsoft.com/download)

### Configuração e Execução

1. **Clone o Repositório:** Clone o repositório GitHub para sua máquina local:
   ```
   git clone https://github.com/LuccaRaphael/CP4-DOTNET.git
   ```
   
2. **Restaure as Dependências:** Navegue até o diretório do projeto e restaure as dependências do .NET:
   ```
   dotnet restore
   ```

3. **Execute a API:** Utilize o comando `dotnet run` para iniciar a aplicação:
   ```
   dotnet run
   ```

4. **Acesse o Endpoint:** Após a aplicação ser iniciada, acesse o endpoint para obter a taxa de câmbio:
   ```
   http://localhost:5232/api/exchange
   ```

5. **Documentação via Swagger:** Explore a documentação da API através do Swagger:
   ```
   http://localhost:5232/swagger
   ```

## Considerações Finais

Este projeto foi desenvolvido seguindo as melhores práticas de desenvolvimento, para a entrega do Checkpoint 4 da matéria de ADVANCED BUSINESS DEVELOPMENT WITH .NET.
