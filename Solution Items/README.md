server=localhost;userid=developer;password123;database=desafioqsti


# Desafio
Este desafio tem por objetivo avaliar seus conhecimentos em C#.

## Sobre o sistema
Neste desafio deverá ser criado um sistema simples onde poderemos cadastrar as aplicações, em que cliente está instalado e em que versão.
Também será possível registrar um log de quando foi executada a aplicação.

Crie uma aplicação web usando Asp.Net Mvc ou WebApi em C#, onde terão as seguintes tabelas no MySql.


|  **Servico** |
| ------------ |
| Id  |
| Nome  |
| Descricao  |


|**Cliente**|
| ------------ |
|Id|
|Nome|


|**ServicoCliente**|
| ------------ |
|Id|
|IdServico|
|IdCliente|
|Versao|

**ExecucaoServico**
| ------------ |
|Id|
|IdServicoCliente|
|DataHora|


Crie algum tipo de autenticação para que somente usuários autenticados possam administrar esses dados.

Você está livre para criar mais tabelas, usar algum tipo de ORM, segurança com Jwt, ddd, angular, ionic e etc

Estarei avaliando sua criatividade e organização de código.


Adicione seu projeto no github e me envie por e-mail paulo@qsti.com.br

Boa sorte!
