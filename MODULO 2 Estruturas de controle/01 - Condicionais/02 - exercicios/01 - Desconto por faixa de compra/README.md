# Exercício 1: Desconto por faixa de compra

## O que você vai praticar
- **if, else if e else** para várias condições
- **int.TryParse** (ou double.TryParse) para validar entrada do usuário
- Comparações numéricas no dia a dia (desconto em loja)

## Cenário
Uma loja oferece desconto progressivo conforme o valor da compra:
- Até R$ 100,00: sem desconto
- Acima de R$ 100,00 até R$ 500,00: 5% de desconto
- Acima de R$ 500,00: 10% de desconto

## Enunciado

1. Peça ao usuário o **valor da compra** com `Console.ReadLine()`.

2. Use **double.TryParse(entrada, out double valorCompra)** para validar. Se a entrada for inválida, exiba "Valor inválido. Digite um número." e não calcule nada. Se for válida, continue.

3. Com **if, else if e else**, calcule o valor do desconto e o valor final:
   - Se `valorCompra <= 100`: desconto 0%, valor final = valorCompra
   - Se `valorCompra <= 500`: desconto 5%, valor final = valorCompra - (valorCompra * 0.05)
   - Senão: desconto 10%, valor final = valorCompra - (valorCompra * 0.10)

4. Exiba uma mensagem informando o valor original, o percentual de desconto aplicado e o valor final a pagar.

## Exemplo de saída
```
Digite o valor da compra: 350
Valor original: R$ 350,00 | Desconto: 5% | Valor final: R$ 332,50
```

## Dica
Use variáveis para guardar `percentualDesconto` e `valorFinal` dentro de cada bloco if/else if/else, e depois exiba com `Console.WriteLine` (pode usar interpolação `$"..."`).
