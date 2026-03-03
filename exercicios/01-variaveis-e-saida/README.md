# Exercício 1: Variáveis e saída no console

## O que você vai praticar
- Declaração de variáveis **estáticas** (`string`, `int`)
- Declaração de variáveis **dinâmicas** (`var`)
- Saída de texto com `Console.WriteLine`

## Enunciado

Crie um programa que:

1. Declare **duas variáveis estáticas**: uma `string` chamada `cidade` com o valor "São Paulo" e uma `int` chamada `populacao` com o valor 12396372.

2. Declare **duas variáveis com `var`**: uma para armazenar o nome de um bairro (por exemplo "Pinheiros") e outra para armazenar o número do CEP (por exemplo 05422).

3. Use `Console.WriteLine` para exibir na tela:
   - A cidade e a população (em uma linha)
   - O bairro e o CEP (em outra linha)

## Exemplo de saída esperada
```
Cidade: São Paulo - População: 12396372
Bairro: Pinheiros - CEP: 05422
```

## Dica
Lembre-se: para juntar texto com números na mesma linha, você pode usar `+` ou converter o número com `Convert.ToString()` ou `.ToString()`.
