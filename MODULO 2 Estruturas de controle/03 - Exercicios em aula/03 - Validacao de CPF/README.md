# Exercício 03: Validação de CPF

## Cenário real

Você está desenvolvendo um sistema que precisa validar CPFs informados pelos usuários antes de permitir um cadastro.

## Objetivo

Criar um programa em C# que:

- Leia um CPF informado pelo usuário (apenas números).
- Remova qualquer caractere de formatação (pontos e traço), se você quiser aceitar "000.000.000-00".
- Verifique se tem exatamente 11 dígitos e se não são todos iguais (ex.: "00000000000", "11111111111" são inválidos).
- Calcule os dois dígitos verificadores usando laços e operadores aritméticos.
- Informe se o CPF é válido ou inválido.

## Exemplos para teste

- CPF válido: `529.982.247-25` (ou `52998224725`)
- CPF inválido: `123.456.789-00` (ou `12345678900`)
