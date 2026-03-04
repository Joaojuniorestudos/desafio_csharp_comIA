# Exercício 3: Média escolar e operador ternário

## O que você vai praticar
- **Switch expression** (sintaxe `valor switch { condição => resultado, _ => padrão }`)
- **Operador ternário** (condição ? valorSeVerdadeiro : valorSeFalso)
- **int.TryParse** para validar notas
- Cenário real: boletim (média e situação) e status ativo/inativo

## Cenário
Calcular a média de duas notas, definir a situação (Aprovado / Recuperação / Reprovado) com switch expression e, em seguida, usar operador ternário para exibir se o aluno está "Ativo" ou "Inativo" na disciplina (por exemplo, considerado ativo se a média for >= 5).

## Enunciado

1. Peça **duas notas** (0 a 10) com `Console.ReadLine()`. Use **double.TryParse** em cada uma. Se alguma entrada for inválida, exiba "Nota inválida." e encerre ou peça de novo.

2. Calcule a **média**: (nota1 + nota2) / 2.

3. Use **switch expression** para definir a situação a partir da média:
   - média >= 7  → "Aprovado"
   - média >= 4  → "Em recuperação"
   - caso contrário (_) → "Reprovado"

   Exemplo: `string situacao = media switch { >= 7 => "Aprovado", >= 4 => "Em recuperação", _ => "Reprovado" };`

4. Use **operador ternário** para definir se o aluno está ativo na disciplina:
   - Se média >= 5, status = "Ativo", senão "Inativo".
   - Exemplo: `string status = media >= 5 ? "Ativo" : "Inativo";`

5. Exiba a média, a situação (Aprovado/Recuperação/Reprovado) e o status (Ativo/Inativo).

## Exemplo de saída
```
Digite a nota 1: 8
Digite a nota 2: 6
Média: 7,0 | Situação: Aprovado | Status na disciplina: Ativo
```

## Dica
O operador ternário é útil quando você só precisa escolher entre dois valores com base em uma condição. O switch expression é ideal quando há várias faixas (média) e um resultado para cada.
