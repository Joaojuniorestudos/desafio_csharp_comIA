# Exercício 2: Menu de opções (caixa eletrônico)

## O que você vai praticar
- **switch** com **case** e **break** para múltiplas opções
- Tratamento de opção inválida (default)
- Cenário real: menu de operações como em caixa eletrônico ou sistema bancário

## Cenário
Simule um menu simples de caixa eletrônico. O usuário escolhe uma opção (1 a 4) e o programa exibe a ação correspondente.

## Enunciado

1. Exiba um menu com as opções:
   - 1 - Consultar saldo
   - 2 - Sacar
   - 3 - Depositar
   - 4 - Sair

2. Peça a opção com `Console.ReadLine()` e converta para **int** (pode usar `int.TryParse` para validar).

3. Use **switch** com **case 1**, **case 2**, **case 3**, **case 4** e **default**:
   - case 1: exiba "Saldo disponível: R$ 1.250,00" (valor fixo para simulação)
   - case 2: exiba "Opção Sacar selecionada. Informe o valor no terminal."
   - case 3: exiba "Opção Depositar selecionada. Informe o valor no terminal."
   - case 4: exiba "Obrigado por usar o caixa. Até logo!"
   - default: exiba "Opção inválida. Escolha entre 1 e 4."

4. Se usar **int.TryParse** e a entrada for inválida, trate no default ou com um if antes do switch.

## Exemplo de saída
```
1 - Consultar saldo
2 - Sacar
3 - Depositar
4 - Sair
Digite a opção: 1
Saldo disponível: R$ 1.250,00
```

## Dica
Você pode ler a opção como string e usar `int.TryParse(entrada, out int opcao)`. Se der falso, considere como opção inválida e caia no default do switch.
