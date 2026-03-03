# Exercício 3: Entrada do usuário e operador ??

## O que você vai praticar
- Leitura de entrada com `Console.ReadLine()`
- Uso do operador **??** (null-coalescing) para valor padrão quando nada for digitado
- Combinar variáveis, conversões e entrada/saída

## Enunciado

Crie um programa que:

1. Peça o **nome** do usuário com `Console.WriteLine("Digite seu nome: ");` e leia com `Console.ReadLine()`. Use o operador **??** para que, se a pessoa não digitar nada (Enter vazio), seja usado o texto "Visitante".

2. Peça a **idade** com `Console.WriteLine("Digite sua idade: ");` e leia com `Console.ReadLine() ?? "0"`. Converta o valor lido para `int` com `int.Parse()` e guarde em uma variável `int idade`.

3. Exiba na tela uma mensagem que una o nome e a idade, por exemplo: "Olá, [nome]! Você tem [idade] anos."

## Exemplo de execução
```
Digite seu nome:
Maria
Digite sua idade:
30
Olá, Maria! Você tem 30 anos.
```

Se a pessoa apertar Enter sem digitar o nome:
```
Digite seu nome:

Digite sua idade:
25
Olá, Visitante! Você tem 25 anos.
```

## Dica
- `Console.ReadLine()` pode retornar `null` se não houver entrada; por isso usamos `?? "valor padrão"`.
- Para juntar texto e número na mensagem final, use conversão: `idade.ToString()` ou `Convert.ToString(idade)`.
