# Exercício 01: Análise de números

## O que você vai praticar

- Declarar e preencher um **`int[]`**
- Laços (`for`) para percorrer o array
- Cálculos: **soma**, **média**, **maior** e **menor** valor
- (Desafio extra) Contar quantos números são **pares** e quantos são **ímpares**

## Cenário

Você precisa de um programa que leia vários números inteiros, guarde em um array e mostre um resumo estatístico simples (útil para análise rápida de uma lista de valores).

## Enunciado

1. Peça ao usuário quantos números serão informados (**N**, inteiro positivo).
2. Crie um **`int[]`** com tamanho **N**.
3. Em um laço, leia cada número (validando com **`int.TryParse`** quando fizer sentido) e armazene no array.
4. Calcule e exiba:
   - **soma** de todos os elementos;
   - **média** (soma ÷ N);
   - **maior** valor;
   - **menor** valor.

## Desafio extra

- Conte quantos números são **pares** e quantos são **ímpares** e exiba esses totais.

## Exemplo de saída

```
Quantos números? 4
Número 1: 10
Número 2: 5
Número 3: 8
Número 4: 3
Soma: 26 | Média: 6,5 | Maior: 10 | Menor: 3
Pares: 2 | Ímpares: 2
```

## Dica

Inicialize `maior` e `menor` com o primeiro elemento do array depois de preenchê-lo, ou use `int.MinValue` / `int.MaxValue` com cuidado na lógica.

## Como executar

Crie um projeto console na pasta deste exercício (ou use um projeto existente) e execute:

```bash
dotnet run
```
