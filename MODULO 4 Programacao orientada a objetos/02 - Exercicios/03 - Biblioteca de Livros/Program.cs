// =============================================================================
// EXERCÍCIO 03 — Biblioteca de livros (classes em arquivos separados)
// =============================================================================
//
// Objetivo: modelar entidades (Livro), um serviço que guarda coleções
// (Biblioteca) e um menu (MenuBiblioteca) só para entrada/saída no Console.
//
// Estrutura (já criada):
//   Livro.cs           — título, autor, ano
//   Biblioteca.cs      — adicionar, listar, buscar por título (parcial)
//   MenuBiblioteca.cs  — menu
//   Program.cs         — entrada
//
// Tarefas para o aluno:
// 1) Adicionar campo ou propriedade ISBN (string) em Livro e exibir na listagem.
// 2) Implementar em Biblioteca o método RemoverPorTitulo(string titulo) que
//    remove o primeiro livro cujo título seja igual (ignorando maiúsculas/minúsculas).
// 3) No menu, nova opção "Remover livro" que usa esse método.
//
// Desafio extra: classe Leitor com nome e lista de empréstimos (títulos).
// =============================================================================

MenuBiblioteca.Executar();
