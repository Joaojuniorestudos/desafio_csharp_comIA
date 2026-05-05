// =============================================================================
// EXERCÍCIO 02 — Conta bancária simples (classes em arquivos separados)
// =============================================================================
//
// Objetivo: encapsular regras (saldo, depósito, saque) em uma classe de domínio
// e separar a interface de console em outra classe.
//
// Estrutura (já criada):
//   ContaBancaria.cs — titular, saldo, Depositar, Sacar, Resumo
//   MenuConta.cs     — menu interativo
//   Program.cs       — início do programa
//
// Tarefas para o aluno:
// 1) Entender por que Sacar retorna bool em vez de apenas alterar o saldo.
// 2) Adicionar um limite de saque diário (ex.: no máximo 3 saques por execução
//    do programa) usando campos privados em ContaBancaria.
// 3) Adicionar propriedade NumeroDaConta (string) exibida no Resumo e pedida
//    no construtor ou em um método Configurar.
//
// Desafio extra: histórico de movimentações em uma List<string> com data/hora.
// =============================================================================

MenuConta.Executar();
