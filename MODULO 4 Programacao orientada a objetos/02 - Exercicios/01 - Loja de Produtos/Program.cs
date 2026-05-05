// =============================================================================
// EXERCÍCIO 01 — Loja de produtos (classes em arquivos separados)
// =============================================================================
//
// Objetivo: praticar modelagem com classes, responsabilidades e organização.
//
// Estrutura sugerida (já criada):
//   Produto.cs      — dados de um produto (nome, preço)
//   Loja.cs         — lista de produtos e operações (cadastrar, listar)
//   MenuLoja.cs     — interação com o Console (menus e leitura)
//   Program.cs      — ponto de entrada
//
// Tarefas para o aluno:
// 1) Ler e entender como Produto, Loja e MenuLoja se comunicam.
// 2) Adicionar na classe Produto uma propriedade ou campo "Código" (string)
//    e ajustar cadastro e listagem.
// 3) Em Loja, implementar um método RemoverPorNome(string nome) que remove
//    o primeiro produto com aquele nome (ou informar se não encontrou).
// 4) No menu, incluir opção "Remover produto" que chame esse método.
//
// Desafio extra: validar preço > 0 no cadastro e nome não vazio.
// =============================================================================

MenuLoja.Executar();
