# SISTEMA PARA UMA OFICINA 

> **Como funciona atualmente**

- Atualmente o cliente chega na oficina com o veiculo apresentando algum defeito.
- O cliente passa ao mecânico o que está ocorrendo com o veiculo.
- O mecanico faz uma analise rápida e caso a tenha outros veiculos na frente aguardando concerto.
- As informações sobre o proprietario do veiculo é mantida apenas pelo numero do telefone (Whatsapp).
- O Mecanico faz uma verificação mais detalhada no veiculo, verifica a causa do problema e passao ao cliente.

> **Informações sobre o problema**
- A possível causa do dano
- Peças que poderão ser compradas para concerto do dano
- Tipo de mão de obra que será utilizada
- Valores de peças e de mão de obra
- Valor total do concerto

**Todas as informações são registradas apenas por mensagens no whatsapp**

<p>Não existe nenhum documento com as informações de peças compradas, valores de peças, valores de mão de obra, descriminação do que foi realizado, descontos, forma de pagamento e etc.</p>
<p>Não há nenhum tipo de cadastro de clientes, veiculos, peças, serviços e etc.</p>
<hr>

# Proposta 
Criação de um sistema para gerenciar todo processo que hoje é feito manualmente na organização dos dados de clientes, veiculos e serviços realizados.

## Contextos
- Cliente
- Funcionário
- Veiculo
- Serviço
- Financeiro
- Relatórios
- Peças
- Estoque
  
## Funcionalidades

> **Cliente**
- Cadastrar
- Excluir
- Editar
- Pesquisar  
  
> **Funcionário**
- Cadastrar
- Excluir
- Editar
- Pesquisar    
  
> **Veiculo**
- Cadastrar
- Excluir
- Editar
- Pesquisar 

> **Orçamento/Serviço**
- Abrir Orçamento
- Fechar Orçamento
- Editar Orçamento
- Excluir Orçamento
- Pesquisar Orçamento
    - *Composição de um Orçamento*  
      - Dados do Cliente
      - Dados do Mecanico responsavel pelo concerto
      - Dados do veiculo
      - Informação do problema relatado
      - Informação das peças que poderão ser trocadas
      - informação de mão-de-obra
- Abrir OS
- Abrir OS por um Orçamento
- Fechar OS
- Editar OS
- Excluir OS
- Pesquisar OS
  - *Composição de uma Ordem de Serviço*  
    - Dados do Orçamento
    - Numero da OS
    - Inicio do concerto ( ao abrir a OS ) Data e Hora
    - Fim do concerto ( Envio de msg ao cliente ) Data e Hora
    - Status Reparo [ *Aguardando Autorização - Em reparo - Finalizado* ]
    - Status Financeiro [ *Aguardando Pagamento - Pago* ]

 > **Peça**
- Cadastrar
- Excluir
- Editar   

> **Estoque**
- Incluir Peça
- Excluir Peça
- Pesquisar Peça
       
> **Serviço**
- Cadastrar
- Excluir
- Editar
- Pesquisar

> **Financeiro**
-
> **Relatórios**
-