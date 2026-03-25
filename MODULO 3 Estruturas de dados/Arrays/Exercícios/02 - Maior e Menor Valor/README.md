# Exercício 02: Maior e menor valor

## O que você vai praticar

- Preencher um **`int[]`** com valores digitados
- Encontrar o **maior** e o **menor** elemento
- Contar **quantas vezes** o maior e o menor aparecem no array
- (Desafios) Listar os **índices** onde maior/menor aparecem; **ordenar** uma cópia do array (ou o próprio, se preferir)

## Cenário

Em muitos relatórios você precisa saber não só qual é o pico e o vale de uma série de números, mas também se há empates e onde eles ocorrem.

## Enunciado

1. Peça quantos valores serão lidos e crie um **`int[]`** com esse tamanho.
2. Leia os valores e armazene no array.
3. Determine o **maior** e o **menor** valor.
4. Conte **quantas vezes** o maior aparece e **quantas vezes** o menor aparece (considere que podem ser iguais se todos os elementos forem iguais).

## Desafios

- Mostre os **índices** (posições no array) em que o maior e o menor aparecem.
- Crie uma **cópia** do array, **ordene** (por exemplo com `Array.Sort`) e exiba a versão ordenada para conferência.

## Exemplo de saída

```
Quantidade: 5
Valor 0: 7
Valor 1: 2
Valor 2: 7
Valor 3: 2
Valor 4: 9
Maior: 9 (aparece 1 vez) | Menor: 2 (aparece 2 vezes)
Índices do maior: 4 | Índices do menor: 1, 3
Ordenado: 2 2 7 7 9
```

## Dica

Para contar ocorrências, use um segundo laço comparando cada elemento com `maior` e com `menor`. Para índices, acumule em uma lista ou imprima dentro do laço quando `array[i] == maior`.

## Como executar

```bash
dotnet run
```
