# Exercício 03 — Cadastro de Alunos em Matriz

## Cenário real

Você está montando um pequeno sistema para registrar alunos e suas notas em uma tabela (matriz) para depois exibir um boletim simples.

## Objetivo

Criar um programa em C# que:

1. Cadastre o **nome** e a **nota** de alguns alunos usando uma **matriz**.
2. Calcule a **média de cada aluno**.
3. Mostre um **boletim** no console com **nome** e **nota/média**.

## Dica

Em C#, uma matriz pode ser `string[,]` (por exemplo colunas para nome e cada nota, ou nome e valores que você converte com `double.TryParse`). Se cada aluno tiver **várias notas**, use a matriz ou linhas extras para guardar essas notas e então calcular a média antes de exibir o boletim.

## Como executar

```bash
dotnet run
```
