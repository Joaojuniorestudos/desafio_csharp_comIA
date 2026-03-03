# Exercício 2: Conversões de tipo

## O que você vai praticar
- `Convert.ToString()` para converter número em texto
- `.ToString()` em variáveis
- `int.Parse()` para converter texto em número inteiro

## Enunciado

Crie um programa que:

1. Declare uma variável `int` chamada `anoNascimento` com o valor 1982 e uma variável `int` chamada `anoAtual` com o valor 2025.

2. Calcule a idade em uma variável `int` chamada `idade` (idade = anoAtual - anoNascimento).

3. Crie uma variável `string` chamada `mensagem` que una o texto "Idade calculada: " com o valor de `idade` usando **Convert.ToString(idade)**.

4. Crie outra variável `string` chamada `mensagem2` que una "Ano de nascimento: " com `anoNascimento` usando **anoNascimento.ToString()**.

5. Declare uma variável `string` com o valor "10". Use **int.Parse()** para converter esse texto em `int` e some com `idade`. Guarde o resultado em uma variável e exiba na tela.

6. Use `Console.WriteLine` para exibir `mensagem`, `mensagem2` e o resultado da soma.

## Exemplo de saída esperada
```
Idade calculada: 43
Ano de nascimento: 1982
Resultado da soma (idade + 10): 53
```

## Dica
`int.Parse("10")` retorna o número 10. Você pode fazer: `int valor = int.Parse("10");` e depois `idade + valor`.
