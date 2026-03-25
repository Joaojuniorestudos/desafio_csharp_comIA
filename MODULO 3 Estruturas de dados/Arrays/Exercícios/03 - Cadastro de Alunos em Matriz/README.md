# Exercício 03: Cadastro de alunos em matriz

## O que você vai praticar

- Representar dados em **matriz** `string[,]` ou **`string[]` + `double[]`** (nome e nota)
- Laços para cadastrar e exibir dados
- Calcular **média** por aluno em um boletim simples
- (Desafios) Várias notas por aluno; **média da turma**

## Cenário

Você está montando um cadastro escolar mínimo: nomes de alunos e notas, com um boletim em texto no console.

## Enunciado

1. Defina quantos alunos serão cadastrados.
2. Use uma das abordagens:
   - **Matriz** `string[,]` com colunas por exemplo **nome** e **nota** (nota pode ser guardada como `string` e convertida, ou use duas estruturas paralelas: `string[] nomes` e `double[] notas`).
3. Para cada aluno, leia **nome** e **nota** (uma nota por aluno já basta para o exercício base).
4. Exiba um **boletim simples**: lista com nome e nota de cada um.

## Desafios

- Permitir **duas ou mais notas** por aluno e exibir a **média** de cada aluno.
- Calcular e exibir a **média geral da turma** (média das médias ou média de todas as notas, conforme o modelo que escolher — descreva no programa o que está fazendo).

## Exemplo de saída

```
Quantos alunos? 2
Aluno 1 - Nome: Ana
Aluno 1 - Nota: 8,5
Aluno 2 - Nome: Bruno
Aluno 2 - Nota: 7,0

--- Boletim ---
Ana    | 8,5
Bruno  | 7,0
```

## Dica

Se usar `string[,]`, lembre-se de converter nota com **`double.TryParse`**. Matriz retangular exige o mesmo “formato” em todas as linhas; para muitas notas por aluno, um **array de arrays** ou listas pode ficar mais natural nos desafios.

## Como executar

```bash
dotnet run
```
